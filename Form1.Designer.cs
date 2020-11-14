namespace Zigbee_V1._0
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucMenu = new HZH_Controls.Controls.UCMenu();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSplit = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.iconBtnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconBtnMaximize = new FontAwesome.Sharp.IconButton();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconBtnSerial = new FontAwesome.Sharp.IconButton();
            this.iconBtnExit = new FontAwesome.Sharp.IconButton();
            this.iconBtnUserControl = new FontAwesome.Sharp.IconButton();
            this.iconBtnQRCode = new FontAwesome.Sharp.IconButton();
            this.iconBtnData = new FontAwesome.Sharp.IconButton();
            this.iconBtnViewer = new FontAwesome.Sharp.IconButton();
            this.iconBtnZigbee = new FontAwesome.Sharp.IconButton();
            this.ucSplitLine_H1 = new HZH_Controls.Controls.UCSplitLine_H();
            this.ucSplitLine_V1 = new HZH_Controls.Controls.UCSplitLine_V();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenu
            // 
            this.ucMenu.AutoScroll = true;
            this.ucMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.ucMenu.ChildrenItemStyles = null;
            this.ucMenu.ChildrenItemType = typeof(HZH_Controls.Controls.UCMenuChildrenItem);
            this.ucMenu.DataSource = null;
            this.ucMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMenu.IsShowFirstItem = true;
            this.ucMenu.Location = new System.Drawing.Point(0, 0);
            this.ucMenu.MenuStyle = HZH_Controls.Controls.MenuStyle.Fill;
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.ParentItemStyles = null;
            this.ucMenu.ParentItemType = typeof(HZH_Controls.Controls.UCMenuParentItem);
            this.ucMenu.Size = new System.Drawing.Size(204, 739);
            this.ucMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(204, 167);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = global::Zigbee_V1._0.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSplit
            // 
            this.labelSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSplit.Location = new System.Drawing.Point(12, 660);
            this.labelSplit.Name = "labelSplit";
            this.labelSplit.Size = new System.Drawing.Size(181, 1);
            this.labelSplit.TabIndex = 8;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panelTitle.Controls.Add(this.iconBtnMinimize);
            this.panelTitle.Controls.Add(this.iconBtnMaximize);
            this.panelTitle.Controls.Add(this.iconBtnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(204, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1210, 47);
            this.panelTitle.TabIndex = 10;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // iconBtnMinimize
            // 
            this.iconBtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMinimize.FlatAppearance.BorderSize = 0;
            this.iconBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnMinimize.IconSize = 32;
            this.iconBtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnMinimize.Location = new System.Drawing.Point(1085, 9);
            this.iconBtnMinimize.Name = "iconBtnMinimize";
            this.iconBtnMinimize.Rotation = 0D;
            this.iconBtnMinimize.Size = new System.Drawing.Size(32, 32);
            this.iconBtnMinimize.TabIndex = 11;
            this.iconBtnMinimize.UseVisualStyleBackColor = true;
            this.iconBtnMinimize.Click += new System.EventHandler(this.iconBtnMinimize_Click);
            // 
            // iconBtnMaximize
            // 
            this.iconBtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMaximize.FlatAppearance.BorderSize = 0;
            this.iconBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnMaximize.IconSize = 32;
            this.iconBtnMaximize.Location = new System.Drawing.Point(1123, 9);
            this.iconBtnMaximize.Name = "iconBtnMaximize";
            this.iconBtnMaximize.Rotation = 0D;
            this.iconBtnMaximize.Size = new System.Drawing.Size(32, 32);
            this.iconBtnMaximize.TabIndex = 12;
            this.iconBtnMaximize.UseVisualStyleBackColor = true;
            this.iconBtnMaximize.Click += new System.EventHandler(this.iconBtnMaximize_Click);
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnClose.IconSize = 32;
            this.iconBtnClose.Location = new System.Drawing.Point(1161, 9);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(32, 32);
            this.iconBtnClose.TabIndex = 1;
            this.iconBtnClose.UseVisualStyleBackColor = true;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(204, 47);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1210, 692);
            this.panelDesktop.TabIndex = 12;
            // 
            // iconBtnSerial
            // 
            this.iconBtnSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnSerial.FlatAppearance.BorderSize = 0;
            this.iconBtnSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSerial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSerial.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSerial.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconBtnSerial.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSerial.IconSize = 32;
            this.iconBtnSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSerial.Location = new System.Drawing.Point(0, 239);
            this.iconBtnSerial.Name = "iconBtnSerial";
            this.iconBtnSerial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnSerial.Rotation = 0D;
            this.iconBtnSerial.Size = new System.Drawing.Size(204, 60);
            this.iconBtnSerial.TabIndex = 11;
            this.iconBtnSerial.Text = "串口设置";
            this.iconBtnSerial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSerial.UseVisualStyleBackColor = false;
            this.iconBtnSerial.Click += new System.EventHandler(this.iconBtnSerial_Click);
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnExit.FlatAppearance.BorderSize = 0;
            this.iconBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconBtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconSize = 32;
            this.iconBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExit.Location = new System.Drawing.Point(0, 679);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnExit.Rotation = 0D;
            this.iconBtnExit.Size = new System.Drawing.Size(204, 60);
            this.iconBtnExit.TabIndex = 9;
            this.iconBtnExit.Text = "退出";
            this.iconBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExit.UseVisualStyleBackColor = false;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            // 
            // iconBtnUserControl
            // 
            this.iconBtnUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnUserControl.FlatAppearance.BorderSize = 0;
            this.iconBtnUserControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUserControl.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnUserControl.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnUserControl.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconBtnUserControl.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnUserControl.IconSize = 32;
            this.iconBtnUserControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUserControl.Location = new System.Drawing.Point(0, 503);
            this.iconBtnUserControl.Name = "iconBtnUserControl";
            this.iconBtnUserControl.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnUserControl.Rotation = 0D;
            this.iconBtnUserControl.Size = new System.Drawing.Size(204, 60);
            this.iconBtnUserControl.TabIndex = 6;
            this.iconBtnUserControl.Text = "用户管理";
            this.iconBtnUserControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUserControl.UseVisualStyleBackColor = false;
            this.iconBtnUserControl.Click += new System.EventHandler(this.iconBtnUserControl_Click);
            // 
            // iconBtnQRCode
            // 
            this.iconBtnQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnQRCode.FlatAppearance.BorderSize = 0;
            this.iconBtnQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQRCode.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnQRCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnQRCode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconBtnQRCode.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnQRCode.IconSize = 32;
            this.iconBtnQRCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQRCode.Location = new System.Drawing.Point(0, 437);
            this.iconBtnQRCode.Name = "iconBtnQRCode";
            this.iconBtnQRCode.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnQRCode.Rotation = 0D;
            this.iconBtnQRCode.Size = new System.Drawing.Size(204, 60);
            this.iconBtnQRCode.TabIndex = 5;
            this.iconBtnQRCode.Text = "二维码导出";
            this.iconBtnQRCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQRCode.UseVisualStyleBackColor = false;
            this.iconBtnQRCode.Click += new System.EventHandler(this.iconBtnQRCode_Click);
            // 
            // iconBtnData
            // 
            this.iconBtnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnData.FlatAppearance.BorderSize = 0;
            this.iconBtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnData.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnData.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.iconBtnData.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnData.IconSize = 32;
            this.iconBtnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnData.Location = new System.Drawing.Point(0, 371);
            this.iconBtnData.Name = "iconBtnData";
            this.iconBtnData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnData.Rotation = 0D;
            this.iconBtnData.Size = new System.Drawing.Size(204, 60);
            this.iconBtnData.TabIndex = 4;
            this.iconBtnData.Text = "病人资料";
            this.iconBtnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnData.UseVisualStyleBackColor = false;
            this.iconBtnData.Click += new System.EventHandler(this.iconBtnData_Click);
            // 
            // iconBtnViewer
            // 
            this.iconBtnViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnViewer.FlatAppearance.BorderSize = 0;
            this.iconBtnViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnViewer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnViewer.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnViewer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconBtnViewer.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnViewer.IconSize = 32;
            this.iconBtnViewer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnViewer.Location = new System.Drawing.Point(0, 305);
            this.iconBtnViewer.Name = "iconBtnViewer";
            this.iconBtnViewer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnViewer.Rotation = 0D;
            this.iconBtnViewer.Size = new System.Drawing.Size(204, 60);
            this.iconBtnViewer.TabIndex = 3;
            this.iconBtnViewer.Text = "实时监测";
            this.iconBtnViewer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnViewer.UseVisualStyleBackColor = false;
            this.iconBtnViewer.Click += new System.EventHandler(this.iconBtnViewer_Click);
            // 
            // iconBtnZigbee
            // 
            this.iconBtnZigbee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconBtnZigbee.FlatAppearance.BorderSize = 0;
            this.iconBtnZigbee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnZigbee.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnZigbee.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnZigbee.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.iconBtnZigbee.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnZigbee.IconSize = 32;
            this.iconBtnZigbee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnZigbee.Location = new System.Drawing.Point(0, 173);
            this.iconBtnZigbee.Name = "iconBtnZigbee";
            this.iconBtnZigbee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnZigbee.Rotation = 0D;
            this.iconBtnZigbee.Size = new System.Drawing.Size(204, 60);
            this.iconBtnZigbee.TabIndex = 2;
            this.iconBtnZigbee.Text = "Zigbee连接";
            this.iconBtnZigbee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnZigbee.UseVisualStyleBackColor = false;
            this.iconBtnZigbee.Click += new System.EventHandler(this.iconBtnZigbee_Click);
            // 
            // ucSplitLine_H1
            // 
            this.ucSplitLine_H1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H1.Location = new System.Drawing.Point(204, 47);
            this.ucSplitLine_H1.Name = "ucSplitLine_H1";
            this.ucSplitLine_H1.Size = new System.Drawing.Size(1210, 1);
            this.ucSplitLine_H1.TabIndex = 0;
            this.ucSplitLine_H1.TabStop = false;
            // 
            // ucSplitLine_V1
            // 
            this.ucSplitLine_V1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_V1.Location = new System.Drawing.Point(204, 47);
            this.ucSplitLine_V1.Name = "ucSplitLine_V1";
            this.ucSplitLine_V1.Size = new System.Drawing.Size(1, 692);
            this.ucSplitLine_V1.TabIndex = 13;
            this.ucSplitLine_V1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 739);
            this.ControlBox = false;
            this.Controls.Add(this.ucSplitLine_V1);
            this.Controls.Add(this.ucSplitLine_H1);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.iconBtnSerial);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.iconBtnExit);
            this.Controls.Add(this.labelSplit);
            this.Controls.Add(this.iconBtnUserControl);
            this.Controls.Add(this.iconBtnQRCode);
            this.Controls.Add(this.iconBtnData);
            this.Controls.Add(this.iconBtnViewer);
            this.Controls.Add(this.iconBtnZigbee);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.ucMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCMenu ucMenu;
        private FontAwesome.Sharp.IconButton iconBtnZigbee;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconBtnViewer;
        private FontAwesome.Sharp.IconButton iconBtnData;
        private FontAwesome.Sharp.IconButton iconBtnQRCode;
        private FontAwesome.Sharp.IconButton iconBtnUserControl;
        private System.Windows.Forms.Label labelSplit;
        private FontAwesome.Sharp.IconButton iconBtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private FontAwesome.Sharp.IconButton iconBtnMinimize;
        private FontAwesome.Sharp.IconButton iconBtnMaximize;
        private FontAwesome.Sharp.IconButton iconBtnSerial;
        private System.Windows.Forms.Panel panelDesktop;
        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H1;
        private HZH_Controls.Controls.UCSplitLine_V ucSplitLine_V1;
    }
}

