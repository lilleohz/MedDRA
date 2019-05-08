namespace MedDRASearch
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imglTreeview = new System.Windows.Forms.ImageList(this.components);
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblConfig = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tvResults = new MedDRASearch.shlTreeView(this.components);
            this.tcResultOption = new System.Windows.Forms.TabControl();
            this.tpHLGT = new System.Windows.Forms.TabPage();
            this.tpHLT = new System.Windows.Forms.TabPage();
            this.tpPT = new System.Windows.Forms.TabPage();
            this.tpLLT = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.llbClear = new System.Windows.Forms.LinkLabel();
            this.lvSOC = new MedDRASearch.shlListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHistroy = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbLLT = new System.Windows.Forms.CheckBox();
            this.cbPT = new System.Windows.Forms.CheckBox();
            this.cbHLT = new System.Windows.Forms.CheckBox();
            this.cbHGLT = new System.Windows.Forms.CheckBox();
            this.cbSOC = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMedDra = new MedDRASearch.shlTreeView(this.components);
            this.menuPop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyCode = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tcResultOption.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuPop.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglTreeview
            // 
            this.imglTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglTreeview.ImageStream")));
            this.imglTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imglTreeview.Images.SetKeyName(0, "soc");
            this.imglTreeview.Images.SetKeyName(1, "hlgt");
            this.imglTreeview.Images.SetKeyName(2, "hlt");
            this.imglTreeview.Images.SetKeyName(3, "pt");
            this.imglTreeview.Images.SetKeyName(4, "llt");
            this.imglTreeview.Images.SetKeyName(5, "dra");
            this.imglTreeview.Images.SetKeyName(6, "results");
            this.imglTreeview.Images.SetKeyName(7, "search");
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(218, 2);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 28);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "数据载入";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Visible = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(253, 96);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 12);
            this.lblLevel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLoadData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 35);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblConfig);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(81, 33);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MedDRASearch.Properties.Resources.config;
            this.pictureBox3.Location = new System.Drawing.Point(17, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfig.Location = new System.Drawing.Point(41, 8);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(37, 19);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.TabStop = true;
            this.lblConfig.Text = "设置";
            this.lblConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConfig_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MedDRASearch.Properties.Resources.捕获;
            this.pictureBox2.Location = new System.Drawing.Point(93, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedDRASearch.Properties.Resources.ich_logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 4);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 668);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 33);
            this.panel3.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1283, 33);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "MedDRA术语集查询工具     版本号：0.1.0416   作者：沈宏良";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(294, 28);
            this.toolStripStatusLabel1.Text = "MedDRA术语集查询工具     版本号：0.1.0416";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(980, 629);
            this.panel6.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.tvResults);
            this.panel8.Controls.Add(this.tcResultOption);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 213);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(980, 416);
            this.panel8.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tvResults
            // 
            this.tvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResults.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvResults.Enabled = false;
            this.tvResults.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvResults.HideSelection = false;
            this.tvResults.ImageIndex = 0;
            this.tvResults.ImageList = this.imglTreeview;
            this.tvResults.Location = new System.Drawing.Point(0, 84);
            this.tvResults.Margin = new System.Windows.Forms.Padding(2);
            this.tvResults.Name = "tvResults";
            this.tvResults.SelectedImageIndex = 0;
            this.tvResults.Size = new System.Drawing.Size(980, 332);
            this.tvResults.TabIndex = 2;
            this.tvResults.DoubleClick += new System.EventHandler(this.tvResults_DoubleClick);
            this.tvResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvResults_MouseDown);
            this.tvResults.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvResults_MouseUp);
            // 
            // tcResultOption
            // 
            this.tcResultOption.Controls.Add(this.tpHLGT);
            this.tcResultOption.Controls.Add(this.tpHLT);
            this.tcResultOption.Controls.Add(this.tpPT);
            this.tcResultOption.Controls.Add(this.tpLLT);
            this.tcResultOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcResultOption.Enabled = false;
            this.tcResultOption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcResultOption.Location = new System.Drawing.Point(0, 53);
            this.tcResultOption.Margin = new System.Windows.Forms.Padding(2);
            this.tcResultOption.Name = "tcResultOption";
            this.tcResultOption.SelectedIndex = 0;
            this.tcResultOption.Size = new System.Drawing.Size(980, 31);
            this.tcResultOption.TabIndex = 1;
            this.tcResultOption.SelectedIndexChanged += new System.EventHandler(this.tcResultOption_SelectedIndexChanged);
            // 
            // tpHLGT
            // 
            this.tpHLGT.Location = new System.Drawing.Point(4, 29);
            this.tpHLGT.Margin = new System.Windows.Forms.Padding(2);
            this.tpHLGT.Name = "tpHLGT";
            this.tpHLGT.Padding = new System.Windows.Forms.Padding(2);
            this.tpHLGT.Size = new System.Drawing.Size(972, 0);
            this.tpHLGT.TabIndex = 0;
            this.tpHLGT.Text = "HLGT";
            this.tpHLGT.UseVisualStyleBackColor = true;
            // 
            // tpHLT
            // 
            this.tpHLT.Location = new System.Drawing.Point(4, 29);
            this.tpHLT.Margin = new System.Windows.Forms.Padding(2);
            this.tpHLT.Name = "tpHLT";
            this.tpHLT.Padding = new System.Windows.Forms.Padding(2);
            this.tpHLT.Size = new System.Drawing.Size(972, 0);
            this.tpHLT.TabIndex = 1;
            this.tpHLT.Text = "HLT";
            this.tpHLT.UseVisualStyleBackColor = true;
            // 
            // tpPT
            // 
            this.tpPT.Location = new System.Drawing.Point(4, 29);
            this.tpPT.Margin = new System.Windows.Forms.Padding(2);
            this.tpPT.Name = "tpPT";
            this.tpPT.Padding = new System.Windows.Forms.Padding(2);
            this.tpPT.Size = new System.Drawing.Size(972, 0);
            this.tpPT.TabIndex = 2;
            this.tpPT.Text = "PT";
            this.tpPT.UseVisualStyleBackColor = true;
            // 
            // tpLLT
            // 
            this.tpLLT.Location = new System.Drawing.Point(4, 29);
            this.tpLLT.Margin = new System.Windows.Forms.Padding(2);
            this.tpLLT.Name = "tpLLT";
            this.tpLLT.Padding = new System.Windows.Forms.Padding(2);
            this.tpLLT.Size = new System.Drawing.Size(972, 0);
            this.tpLLT.TabIndex = 3;
            this.tpLLT.Text = "LLT";
            this.tpLLT.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblDetails);
            this.panel9.Controls.Add(this.lblResults);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(980, 53);
            this.panel9.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetails.Location = new System.Drawing.Point(18, 28);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(51, 19);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "内容：";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults.Location = new System.Drawing.Point(18, 8);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(107, 19);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "查询返回结果：";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(980, 213);
            this.panel7.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.llbClear);
            this.groupBox3.Controls.Add(this.lvSOC);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(395, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(344, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择SOCs查询（默认为全部）";
            // 
            // llbClear
            // 
            this.llbClear.AutoSize = true;
            this.llbClear.Location = new System.Drawing.Point(12, 173);
            this.llbClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbClear.Name = "llbClear";
            this.llbClear.Size = new System.Drawing.Size(65, 19);
            this.llbClear.TabIndex = 1;
            this.llbClear.TabStop = true;
            this.llbClear.Text = "清除选择";
            this.llbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClear_LinkClicked);
            // 
            // lvSOC
            // 
            this.lvSOC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvSOC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSOC.FullRowSelect = true;
            this.lvSOC.GridLines = true;
            this.lvSOC.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSOC.HideSelection = false;
            this.lvSOC.Location = new System.Drawing.Point(12, 26);
            this.lvSOC.Margin = new System.Windows.Forms.Padding(2);
            this.lvSOC.Name = "lvSOC";
            this.lvSOC.OwnerDraw = true;
            this.lvSOC.Size = new System.Drawing.Size(329, 145);
            this.lvSOC.TabIndex = 0;
            this.lvSOC.UseCompatibleStateImageBehavior = false;
            this.lvSOC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SOC";
            this.columnHeader1.Width = 436;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHistroy);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(743, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(281, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询历史";
            // 
            // lbHistroy
            // 
            this.lbHistroy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHistroy.FormattingEnabled = true;
            this.lbHistroy.ItemHeight = 20;
            this.lbHistroy.Location = new System.Drawing.Point(14, 29);
            this.lbHistroy.Margin = new System.Windows.Forms.Padding(2);
            this.lbHistroy.Name = "lbHistroy";
            this.lbHistroy.Size = new System.Drawing.Size(253, 144);
            this.lbHistroy.TabIndex = 1;
            this.lbHistroy.DoubleClick += new System.EventHandler(this.lbHistroy_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.cbLLT);
            this.groupBox1.Controls.Add(this.cbPT);
            this.groupBox1.Controls.Add(this.cbHLT);
            this.groupBox1.Controls.Add(this.cbHGLT);
            this.groupBox1.Controls.Add(this.cbSOC);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(349, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询设置";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(180, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.ImageIndex = 7;
            this.btnSearch.ImageList = this.imglTreeview;
            this.btnSearch.Location = new System.Drawing.Point(53, 130);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "搜索词";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSearch.Location = new System.Drawing.Point(67, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // cbLLT
            // 
            this.cbLLT.AutoSize = true;
            this.cbLLT.Checked = true;
            this.cbLLT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLLT.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLLT.Location = new System.Drawing.Point(283, 29);
            this.cbLLT.Margin = new System.Windows.Forms.Padding(2);
            this.cbLLT.Name = "cbLLT";
            this.cbLLT.Size = new System.Drawing.Size(50, 24);
            this.cbLLT.TabIndex = 4;
            this.cbLLT.Text = "LLT";
            this.cbLLT.UseVisualStyleBackColor = true;
            this.cbLLT.CheckedChanged += new System.EventHandler(this.cbLLT_CheckedChanged);
            // 
            // cbPT
            // 
            this.cbPT.AutoSize = true;
            this.cbPT.Checked = true;
            this.cbPT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPT.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPT.Location = new System.Drawing.Point(222, 29);
            this.cbPT.Margin = new System.Windows.Forms.Padding(2);
            this.cbPT.Name = "cbPT";
            this.cbPT.Size = new System.Drawing.Size(45, 24);
            this.cbPT.TabIndex = 3;
            this.cbPT.Text = "PT";
            this.cbPT.UseVisualStyleBackColor = true;
            this.cbPT.CheckedChanged += new System.EventHandler(this.cbPT_CheckedChanged);
            // 
            // cbHLT
            // 
            this.cbHLT.AutoSize = true;
            this.cbHLT.Checked = true;
            this.cbHLT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHLT.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHLT.Location = new System.Drawing.Point(155, 29);
            this.cbHLT.Margin = new System.Windows.Forms.Padding(2);
            this.cbHLT.Name = "cbHLT";
            this.cbHLT.Size = new System.Drawing.Size(54, 24);
            this.cbHLT.TabIndex = 2;
            this.cbHLT.Text = "HLT";
            this.cbHLT.UseVisualStyleBackColor = true;
            this.cbHLT.CheckedChanged += new System.EventHandler(this.cbHLT_CheckedChanged);
            // 
            // cbHGLT
            // 
            this.cbHGLT.AutoSize = true;
            this.cbHGLT.Checked = true;
            this.cbHGLT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHGLT.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHGLT.Location = new System.Drawing.Point(81, 29);
            this.cbHGLT.Margin = new System.Windows.Forms.Padding(2);
            this.cbHGLT.Name = "cbHGLT";
            this.cbHGLT.Size = new System.Drawing.Size(64, 24);
            this.cbHGLT.TabIndex = 1;
            this.cbHGLT.Text = "HLGT";
            this.cbHGLT.UseVisualStyleBackColor = true;
            this.cbHGLT.CheckedChanged += new System.EventHandler(this.cbHGLT_CheckedChanged);
            // 
            // cbSOC
            // 
            this.cbSOC.AutoSize = true;
            this.cbSOC.Checked = true;
            this.cbSOC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSOC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSOC.Location = new System.Drawing.Point(14, 29);
            this.cbSOC.Margin = new System.Windows.Forms.Padding(2);
            this.cbSOC.Name = "cbSOC";
            this.cbSOC.Size = new System.Drawing.Size(56, 24);
            this.cbSOC.TabIndex = 0;
            this.cbSOC.Text = "SOC";
            this.cbSOC.UseVisualStyleBackColor = true;
            this.cbSOC.CheckedChanged += new System.EventHandler(this.cbSOC_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvMedDra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 629);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 9;
            // 
            // tvMedDra
            // 
            this.tvMedDra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMedDra.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvMedDra.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMedDra.HideSelection = false;
            this.tvMedDra.ImageIndex = 0;
            this.tvMedDra.ImageList = this.imglTreeview;
            this.tvMedDra.Location = new System.Drawing.Point(0, 0);
            this.tvMedDra.Margin = new System.Windows.Forms.Padding(2);
            this.tvMedDra.Name = "tvMedDra";
            this.tvMedDra.SelectedImageIndex = 5;
            this.tvMedDra.Size = new System.Drawing.Size(299, 629);
            this.tvMedDra.TabIndex = 0;
            this.tvMedDra.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvMedDra_BeforeSelect);
            this.tvMedDra.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMedDra_AfterSelect);
            this.tvMedDra.DoubleClick += new System.EventHandler(this.tvMedDra_DoubleClick);
            // 
            // menuPop
            // 
            this.menuPop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLocation,
            this.toolStripMenuItem1,
            this.mnuCopyCode});
            this.menuPop.Name = "menuPop";
            this.menuPop.Size = new System.Drawing.Size(161, 54);
            // 
            // mnuLocation
            // 
            this.mnuLocation.Name = "mnuLocation";
            this.mnuLocation.Size = new System.Drawing.Size(160, 22);
            this.mnuLocation.Text = "在主目录中显示";
            this.mnuLocation.Click += new System.EventHandler(this.mnuLocation_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuCopyCode
            // 
            this.mnuCopyCode.Name = "mnuCopyCode";
            this.mnuCopyCode.Size = new System.Drawing.Size(160, 22);
            this.mnuCopyCode.Text = "复制名称和编码";
            this.mnuCopyCode.Click += new System.EventHandler(this.mnuCopyCode_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 701);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedDRA 数据查询";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tcResultOption.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuPop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shlTreeView tvMedDra;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ImageList imglTreeview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbHistroy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbLLT;
        private System.Windows.Forms.CheckBox cbPT;
        private System.Windows.Forms.CheckBox cbHLT;
        private System.Windows.Forms.CheckBox cbHGLT;
        private System.Windows.Forms.CheckBox cbSOC;
        private shlTreeView tvResults;
        private System.Windows.Forms.TabControl tcResultOption;
        private System.Windows.Forms.TabPage tpHLGT;
        private System.Windows.Forms.TabPage tpHLT;
        private System.Windows.Forms.TabPage tpPT;
        private System.Windows.Forms.TabPage tpLLT;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip menuPop;
        private System.Windows.Forms.ToolStripMenuItem mnuLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private shlListView lvSOC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.LinkLabel llbClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lblConfig;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

