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
            this.notIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.txtUSD = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRMB = new System.Windows.Forms.TextBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.chartExchangeRate = new DevComponents.DotNetBar.MicroChart();
            this.gridExchangeRate = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.chartGoldETF = new DevComponents.DotNetBar.MicroChart();
            this.GridGoldETF = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.ETF = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.chartSilverETF = new DevComponents.DotNetBar.MicroChart();
            this.gridSiverETF = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.cmsNotice.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.SuspendLayout();
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
            this.cmsNotice.Size = new System.Drawing.Size(103, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.显示ToolStripMenuItem.Text = "显示/隐藏";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbxAuto);
            this.groupPanel1.Controls.Add(this.txtUSD);
            this.groupPanel1.Controls.Add(this.lblDate);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.txtRMB);
            this.groupPanel1.Controls.Add(this.txtExchangeRate);
            this.groupPanel1.Controls.Add(this.btnConvert);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(452, 100);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 13;
            this.groupPanel1.Text = "换算";
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.BackColor = System.Drawing.Color.Transparent;
            this.cbxAuto.Checked = true;
            this.cbxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAuto.ForeColor = System.Drawing.Color.Black;
            this.cbxAuto.Location = new System.Drawing.Point(88, 33);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(48, 16);
            this.cbxAuto.TabIndex = 18;
            this.cbxAuto.Text = "自动";
            this.cbxAuto.UseVisualStyleBackColor = false;
            // 
            // txtUSD
            // 
            this.txtUSD.BackColor = System.Drawing.Color.White;
            this.txtUSD.DecimalPlaces = 2;
            this.txtUSD.ForeColor = System.Drawing.Color.Black;
            this.txtUSD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtUSD.Location = new System.Drawing.Point(158, 29);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(50, 21);
            this.txtUSD.TabIndex = 17;
            this.txtUSD.Value = new decimal(new int[] {
            209,
            0,
            0,
            65536});
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(32, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "离线";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "人民币/千克";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "汇率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(158, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "美元/盎司";
            // 
            // txtRMB
            // 
            this.txtRMB.BackColor = System.Drawing.Color.White;
            this.txtRMB.ForeColor = System.Drawing.Color.Black;
            this.txtRMB.Location = new System.Drawing.Point(320, 28);
            this.txtRMB.Name = "txtRMB";
            this.txtRMB.ReadOnly = true;
            this.txtRMB.Size = new System.Drawing.Size(50, 21);
            this.txtRMB.TabIndex = 11;
            this.txtRMB.Text = "4300";
            this.txtRMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.BackColor = System.Drawing.Color.White;
            this.txtExchangeRate.ForeColor = System.Drawing.Color.Black;
            this.txtExchangeRate.Location = new System.Drawing.Point(32, 28);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(50, 21);
            this.txtExchangeRate.TabIndex = 12;
            this.txtExchangeRate.Text = "6.1300";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.White;
            this.btnConvert.BackgroundImage = global::SilverPriceConverter.Properties.Resources.exchange;
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(239, 19);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(48, 36);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(0, 100);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(452, 279);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 14;
            this.superTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.MultiLineFit;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem2,
            this.superTabItem1,
            this.ETF,
            this.superTabItem3});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.Text = "汇率";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.txtHistory);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(452, 253);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.Color.White;
            this.txtHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHistory.ForeColor = System.Drawing.Color.Black;
            this.txtHistory.Location = new System.Drawing.Point(0, 0);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(452, 253);
            this.txtHistory.TabIndex = 7;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "查询历史";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.chartExchangeRate);
            this.superTabControlPanel1.Controls.Add(this.gridExchangeRate);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(452, 253);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // chartExchangeRate
            // 
            this.chartExchangeRate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chartExchangeRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chartExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartExchangeRate.ForeColor = System.Drawing.Color.Black;
            this.chartExchangeRate.Location = new System.Drawing.Point(0, 151);
            this.chartExchangeRate.Name = "chartExchangeRate";
            this.chartExchangeRate.Size = new System.Drawing.Size(452, 102);
            this.chartExchangeRate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chartExchangeRate.TabIndex = 12;
            this.chartExchangeRate.Text = "microChart1";
            // 
            // gridExchangeRate
            // 
            this.gridExchangeRate.BackColor = System.Drawing.Color.White;
            this.gridExchangeRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridExchangeRate.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridExchangeRate.ForeColor = System.Drawing.Color.Black;
            this.gridExchangeRate.Location = new System.Drawing.Point(0, 0);
            this.gridExchangeRate.Name = "gridExchangeRate";
            this.gridExchangeRate.Size = new System.Drawing.Size(452, 151);
            this.gridExchangeRate.TabIndex = 11;
            this.gridExchangeRate.Text = "superGridControl3";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "汇率变化";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.chartGoldETF);
            this.superTabControlPanel3.Controls.Add(this.GridGoldETF);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(452, 253);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.ETF;
            // 
            // chartGoldETF
            // 
            this.chartGoldETF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chartGoldETF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chartGoldETF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGoldETF.ForeColor = System.Drawing.Color.Black;
            this.chartGoldETF.Location = new System.Drawing.Point(0, 151);
            this.chartGoldETF.Name = "chartGoldETF";
            this.chartGoldETF.Size = new System.Drawing.Size(452, 102);
            this.chartGoldETF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chartGoldETF.TabIndex = 10;
            this.chartGoldETF.Text = "microChart2";
            // 
            // GridGoldETF
            // 
            this.GridGoldETF.BackColor = System.Drawing.Color.White;
            this.GridGoldETF.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridGoldETF.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.GridGoldETF.ForeColor = System.Drawing.Color.Black;
            this.GridGoldETF.Location = new System.Drawing.Point(0, 0);
            this.GridGoldETF.Name = "GridGoldETF";
            this.GridGoldETF.Size = new System.Drawing.Size(452, 151);
            this.GridGoldETF.TabIndex = 0;
            this.GridGoldETF.Text = "superGridControl1";
            // 
            // ETF
            // 
            this.ETF.AttachedControl = this.superTabControlPanel3;
            this.ETF.GlobalItem = false;
            this.ETF.Name = "ETF";
            this.ETF.Text = "Gold ETF";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.chartSilverETF);
            this.superTabControlPanel4.Controls.Add(this.gridSiverETF);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(452, 253);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.superTabItem3;
            // 
            // chartSilverETF
            // 
            this.chartSilverETF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chartSilverETF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chartSilverETF.ForeColor = System.Drawing.Color.Black;
            this.chartSilverETF.Location = new System.Drawing.Point(0, 151);
            this.chartSilverETF.Name = "chartSilverETF";
            this.chartSilverETF.Size = new System.Drawing.Size(452, 102);
            this.chartSilverETF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chartSilverETF.TabIndex = 12;
            this.chartSilverETF.Text = "microChart3";
            // 
            // gridSiverETF
            // 
            this.gridSiverETF.BackColor = System.Drawing.Color.White;
            this.gridSiverETF.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridSiverETF.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridSiverETF.ForeColor = System.Drawing.Color.Black;
            this.gridSiverETF.Location = new System.Drawing.Point(0, 0);
            this.gridSiverETF.Name = "gridSiverETF";
            this.gridSiverETF.Size = new System.Drawing.Size(452, 151);
            this.gridSiverETF.TabIndex = 11;
            this.gridSiverETF.Text = "superGridControl2";
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel4;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Silver ETF";
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 379);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.groupPanel1);
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
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notIcon;
        private System.Windows.Forms.ContextMenuStrip cmsNotice;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.NumericUpDown txtUSD;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRMB;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Button btnConvert;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.MicroChart chartExchangeRate;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridExchangeRate;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.MicroChart chartGoldETF;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl GridGoldETF;
        private DevComponents.DotNetBar.SuperTabItem ETF;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private System.Windows.Forms.TextBox txtHistory;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.MicroChart chartSilverETF;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridSiverETF;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
    }
}

