using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Zigbee_V1._0
{
    public partial class MainWindow : Form
    {
        //fields
        private IconButton currentBtn;              //当前点击的按钮
        private Panel leftBorderBtn;                //左部高亮
        private Control currentUserControl;              //当前按钮的子按钮
        //窗体拖动
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Constructor
        public MainWindow()             //初始化
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.Controls.Add(leftBorderBtn);             //加入到菜单栏中

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors                //颜色结构体
        {
            public static Color basicColor = Color.FromArgb(255, 77, 59);
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }



        private void ActivateButton(object senderBtn,Color color)         //激活按钮
        {
            if(senderBtn!=null)
            {
                DisableButton();                //先把按钮设成未激活状态
                //设置button属性
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255,255,255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //设置panel属性
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()                //设置按钮未激活时的状态
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(40, 43, 51);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        
        private void AddControl(Control control)          //打开子窗体
        {
            
            currentUserControl = control;
            this.panelDesktop.Controls.Add(control);
        }


        private void iconBtnZigbee_Click(object sender, EventArgs e)            //鼠标点击事件
        {
            ActivateButton(sender, RGBColors.basicColor);                       //首先激活当前的按钮
        }

        private void iconBtnViewer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconBtnData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconBtnQRCode_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconBtnUserControl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconBtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)      //拖动效果
        {
            ReleaseCapture();               //拖动
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconBtnSerial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.basicColor);
            
        }
    }
}
