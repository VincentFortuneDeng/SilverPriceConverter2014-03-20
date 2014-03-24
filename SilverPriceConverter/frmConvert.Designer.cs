namespace SilverPriceConverter
{
    partial class frmConvert
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvert));
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRMB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.notIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUSD = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.microChart1 = new DevComponents.DotNetBar.MicroChart();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.cmsNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackgroundImage = global::SilverPriceConverter.Properties.Resources.exchange;
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(242, 15);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(48, 36);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(35, 24);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(50, 21);
            this.txtExchangeRate.TabIndex = 1;
            this.txtExchangeRate.Text = "6.1300";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "美元/盎司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "汇率";
            // 
            // txtRMB
            // 
            this.txtRMB.BackColor = System.Drawing.SystemColors.Window;
            this.txtRMB.Location = new System.Drawing.Point(323, 24);
            this.txtRMB.Name = "txtRMB";
            this.txtRMB.ReadOnly = true;
            this.txtRMB.Size = new System.Drawing.Size(50, 21);
            this.txtRMB.TabIndex = 1;
            this.txtRMB.Text = "4300";
            this.txtRMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "人民币/千克";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "离线";
            // 
            // notIcon
            // 
            this.notIcon.ContextMenuStrip = this.cmsNotice;
            this.notIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notIcon.Icon")));
            this.notIcon.Text = "SilverPriceExchange";
            this.notIcon.Visible = true;
            this.notIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notIcon_MouseClick);
            // 
            // cmsNotice
            // 
            this.cmsNotice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.cmsNotice.Name = "cmsNotice";
            this.cmsNotice.ShowImageMargin = false;
            this.cmsNotice.Size = new System.Drawing.Size(105, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.显示ToolStripMenuItem.Text = "显示/隐藏";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtUSD
            // 
            this.txtUSD.DecimalPlaces = 2;
            this.txtUSD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtUSD.Location = new System.Drawing.Point(161, 25);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(50, 21);
            this.txtUSD.TabIndex = 4;
            this.txtUSD.Value = new decimal(new int[] {
            209,
            0,
            0,
            65536});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(11, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(199, 179);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(239, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(199, 179);
            this.textBox2.TabIndex = 6;
            // 
            // microChart1
            // 
            // 
            // 
            // 
            this.microChart1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.microChart1.Location = new System.Drawing.Point(22, 289);
            this.microChart1.Name = "microChart1";
            this.microChart1.Size = new System.Drawing.Size(404, 64);
            this.microChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.microChart1.TabIndex = 8;
            this.microChart1.Text = "microChart1";
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Checked = true;
            this.cbxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAuto.Location = new System.Drawing.Point(91, 29);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(48, 16);
            this.cbxAuto.TabIndex = 9;
            this.cbxAuto.Text = "自动";
            this.cbxAuto.UseVisualStyleBackColor = true;
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 379);
            this.Controls.Add(this.cbxAuto);
            this.Controls.Add(this.microChart1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRMB);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.btnConvert);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SilverPriceExchange";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConvert_FormClosing);
            this.Resize += new System.EventHandler(this.frmConvert_Resize);
            this.cmsNotice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NotifyIcon notIcon;
        private System.Windows.Forms.NumericUpDown txtUSD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevComponents.DotNetBar.MicroChart microChart1;
        private System.Windows.Forms.ContextMenuStrip cmsNotice;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbxAuto;
    }
}

