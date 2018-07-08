namespace ILP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.negThresh = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.testTab = new System.Windows.Forms.TabControl();
            this.posTab = new System.Windows.Forms.TabPage();
            this.pos = new System.Windows.Forms.ListBox();
            this.negTab = new System.Windows.Forms.TabPage();
            this.negLB = new System.Windows.Forms.ListBox();
            this.bkTab = new System.Windows.Forms.TabPage();
            this.bkLB = new System.Windows.Forms.ListBox();
            this.trainData = new System.Windows.Forms.TabPage();
            this.trainGrid = new System.Windows.Forms.DataGridView();
            this.testdata = new System.Windows.Forms.TabPage();
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accuracyValLBL = new System.Windows.Forms.Label();
            this.accuracyLBL = new System.Windows.Forms.Label();
            this.fmeasureLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TryCnt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.percLbl = new System.Windows.Forms.Label();
            this.perc_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Step3UD = new System.Windows.Forms.NumericUpDown();
            this.DRLbl = new System.Windows.Forms.Label();
            this.drtextLbl = new System.Windows.Forms.Label();
            this.trainUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.predicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.negThresh)).BeginInit();
            this.testTab.SuspendLayout();
            this.posTab.SuspendLayout();
            this.negTab.SuspendLayout();
            this.bkTab.SuspendLayout();
            this.trainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainGrid)).BeginInit();
            this.testdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step3UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predicateBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Negative Threshold:";
            // 
            // negThresh
            // 
            this.negThresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negThresh.Location = new System.Drawing.Point(939, 33);
            this.negThresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.negThresh.Name = "negThresh";
            this.negThresh.Size = new System.Drawing.Size(96, 38);
            this.negThresh.TabIndex = 13;
            this.negThresh.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.negThresh.ValueChanged += new System.EventHandler(this.negThresh_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "FileName.txt";
            // 
            // testTab
            // 
            this.testTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.testTab.Controls.Add(this.posTab);
            this.testTab.Controls.Add(this.negTab);
            this.testTab.Controls.Add(this.bkTab);
            this.testTab.Controls.Add(this.trainData);
            this.testTab.Controls.Add(this.testdata);
            this.testTab.Location = new System.Drawing.Point(22, 285);
            this.testTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.testTab.Name = "testTab";
            this.testTab.SelectedIndex = 0;
            this.testTab.Size = new System.Drawing.Size(1237, 771);
            this.testTab.TabIndex = 16;
            // 
            // posTab
            // 
            this.posTab.Controls.Add(this.pos);
            this.posTab.Location = new System.Drawing.Point(10, 48);
            this.posTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.posTab.Name = "posTab";
            this.posTab.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.posTab.Size = new System.Drawing.Size(1217, 713);
            this.posTab.TabIndex = 0;
            this.posTab.Text = "Positive Examples";
            this.posTab.UseVisualStyleBackColor = true;
            this.posTab.Click += new System.EventHandler(this.posTab_Click);
            // 
            // pos
            // 
            this.pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos.FormattingEnabled = true;
            this.pos.ItemHeight = 31;
            this.pos.Location = new System.Drawing.Point(5, 6);
            this.pos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(1207, 701);
            this.pos.TabIndex = 0;
            this.pos.SelectedIndexChanged += new System.EventHandler(this.pos_SelectedIndexChanged);
            // 
            // negTab
            // 
            this.negTab.Controls.Add(this.negLB);
            this.negTab.Location = new System.Drawing.Point(10, 48);
            this.negTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.negTab.Name = "negTab";
            this.negTab.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.negTab.Size = new System.Drawing.Size(1217, 713);
            this.negTab.TabIndex = 1;
            this.negTab.Text = "Negative Examples";
            this.negTab.UseVisualStyleBackColor = true;
            // 
            // negLB
            // 
            this.negLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.negLB.FormattingEnabled = true;
            this.negLB.ItemHeight = 31;
            this.negLB.Location = new System.Drawing.Point(5, 6);
            this.negLB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.negLB.Name = "negLB";
            this.negLB.Size = new System.Drawing.Size(1207, 701);
            this.negLB.TabIndex = 1;
            this.negLB.SelectedIndexChanged += new System.EventHandler(this.negLB_SelectedIndexChanged);
            // 
            // bkTab
            // 
            this.bkTab.Controls.Add(this.bkLB);
            this.bkTab.Location = new System.Drawing.Point(10, 48);
            this.bkTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bkTab.Name = "bkTab";
            this.bkTab.Size = new System.Drawing.Size(1217, 713);
            this.bkTab.TabIndex = 2;
            this.bkTab.Text = "Background Knowledge";
            this.bkTab.UseVisualStyleBackColor = true;
            // 
            // bkLB
            // 
            this.bkLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bkLB.FormattingEnabled = true;
            this.bkLB.ItemHeight = 31;
            this.bkLB.Location = new System.Drawing.Point(0, 0);
            this.bkLB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bkLB.Name = "bkLB";
            this.bkLB.Size = new System.Drawing.Size(1217, 713);
            this.bkLB.TabIndex = 2;
            this.bkLB.SelectedIndexChanged += new System.EventHandler(this.bkLB_SelectedIndexChanged);
            // 
            // trainData
            // 
            this.trainData.Controls.Add(this.trainGrid);
            this.trainData.Location = new System.Drawing.Point(10, 48);
            this.trainData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trainData.Name = "trainData";
            this.trainData.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trainData.Size = new System.Drawing.Size(1217, 713);
            this.trainData.TabIndex = 3;
            this.trainData.Text = "Train Data";
            this.trainData.UseVisualStyleBackColor = true;
            // 
            // trainGrid
            // 
            this.trainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainGrid.Location = new System.Drawing.Point(5, 6);
            this.trainGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trainGrid.Name = "trainGrid";
            this.trainGrid.RowTemplate.Height = 24;
            this.trainGrid.Size = new System.Drawing.Size(1207, 701);
            this.trainGrid.TabIndex = 0;
            // 
            // testdata
            // 
            this.testdata.Controls.Add(this.testGrid);
            this.testdata.Location = new System.Drawing.Point(10, 48);
            this.testdata.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.testdata.Name = "testdata";
            this.testdata.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.testdata.Size = new System.Drawing.Size(1217, 713);
            this.testdata.TabIndex = 4;
            this.testdata.Text = "Test Data";
            this.testdata.UseVisualStyleBackColor = true;
            // 
            // testGrid
            // 
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testGrid.Location = new System.Drawing.Point(5, 6);
            this.testGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.testGrid.Name = "testGrid";
            this.testGrid.RowTemplate.Height = 24;
            this.testGrid.Size = new System.Drawing.Size(1207, 701);
            this.testGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.accuracyValLBL);
            this.panel1.Controls.Add(this.accuracyLBL);
            this.panel1.Controls.Add(this.fmeasureLbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TryCnt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.modeCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.percLbl);
            this.panel1.Controls.Add(this.perc_lbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Step3UD);
            this.panel1.Controls.Add(this.DRLbl);
            this.panel1.Controls.Add(this.drtextLbl);
            this.panel1.Controls.Add(this.trainUD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.negThresh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2903, 213);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // accuracyValLBL
            // 
            this.accuracyValLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyValLBL.AutoSize = true;
            this.accuracyValLBL.Location = new System.Drawing.Point(2470, 112);
            this.accuracyValLBL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.accuracyValLBL.Name = "accuracyValLBL";
            this.accuracyValLBL.Size = new System.Drawing.Size(54, 32);
            this.accuracyValLBL.TabIndex = 43;
            this.accuracyValLBL.Text = "NA";
            // 
            // accuracyLBL
            // 
            this.accuracyLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyLBL.AutoSize = true;
            this.accuracyLBL.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.accuracyLBL.Location = new System.Drawing.Point(2256, 104);
            this.accuracyLBL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.accuracyLBL.Name = "accuracyLBL";
            this.accuracyLBL.Size = new System.Drawing.Size(155, 39);
            this.accuracyLBL.TabIndex = 42;
            this.accuracyLBL.Text = "Accuracy:";
            // 
            // fmeasureLbl
            // 
            this.fmeasureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fmeasureLbl.AutoSize = true;
            this.fmeasureLbl.Location = new System.Drawing.Point(2471, 46);
            this.fmeasureLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fmeasureLbl.Name = "fmeasureLbl";
            this.fmeasureLbl.Size = new System.Drawing.Size(54, 32);
            this.fmeasureLbl.TabIndex = 20;
            this.fmeasureLbl.Text = "NA";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label9.Location = new System.Drawing.Point(2256, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 39);
            this.label9.TabIndex = 19;
            this.label9.Text = "F-Measure:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TryCnt
            // 
            this.TryCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TryCnt.Location = new System.Drawing.Point(939, 100);
            this.TryCnt.Margin = new System.Windows.Forms.Padding(5);
            this.TryCnt.Name = "TryCnt";
            this.TryCnt.Size = new System.Drawing.Size(96, 38);
            this.TryCnt.TabIndex = 39;
            this.TryCnt.Text = "5";
            this.TryCnt.TextChanged += new System.EventHandler(this.TryCnt_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "Try Count:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1303, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Time (milisecond):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1559, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // modeCB
            // 
            this.modeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeCB.FormattingEnabled = true;
            this.modeCB.Items.AddRange(new object[] {
            "All Predicates",
            "Random",
            "Predicate with Maximum Score",
            "Less Constants "});
            this.modeCB.Location = new System.Drawing.Point(1289, 17);
            this.modeCB.Margin = new System.Windows.Forms.Padding(5);
            this.modeCB.Name = "modeCB";
            this.modeCB.Size = new System.Drawing.Size(424, 39);
            this.modeCB.TabIndex = 33;
            this.modeCB.Visible = false;
            this.modeCB.SelectedIndexChanged += new System.EventHandler(this.modeCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1185, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mode:";
            this.label4.Visible = false;
            // 
            // percLbl
            // 
            this.percLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percLbl.AutoSize = true;
            this.percLbl.Location = new System.Drawing.Point(1979, 112);
            this.percLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.percLbl.Name = "percLbl";
            this.percLbl.Size = new System.Drawing.Size(54, 32);
            this.percLbl.TabIndex = 31;
            this.percLbl.Text = "NA";
            // 
            // perc_lbl
            // 
            this.perc_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perc_lbl.AutoSize = true;
            this.perc_lbl.Location = new System.Drawing.Point(1801, 111);
            this.perc_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.perc_lbl.Name = "perc_lbl";
            this.perc_lbl.Size = new System.Drawing.Size(141, 32);
            this.perc_lbl.TabIndex = 30;
            this.perc_lbl.Text = "Precision:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "# of Steps:";
            // 
            // Step3UD
            // 
            this.Step3UD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step3UD.Location = new System.Drawing.Point(337, 101);
            this.Step3UD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Step3UD.Name = "Step3UD";
            this.Step3UD.Size = new System.Drawing.Size(121, 38);
            this.Step3UD.TabIndex = 25;
            this.Step3UD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Step3UD.ValueChanged += new System.EventHandler(this.Step3UD_ValueChanged);
            // 
            // DRLbl
            // 
            this.DRLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DRLbl.AutoSize = true;
            this.DRLbl.Location = new System.Drawing.Point(1979, 43);
            this.DRLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DRLbl.Name = "DRLbl";
            this.DRLbl.Size = new System.Drawing.Size(54, 32);
            this.DRLbl.TabIndex = 22;
            this.DRLbl.Text = "NA";
            // 
            // drtextLbl
            // 
            this.drtextLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drtextLbl.AutoSize = true;
            this.drtextLbl.Location = new System.Drawing.Point(1801, 42);
            this.drtextLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.drtextLbl.Name = "drtextLbl";
            this.drtextLbl.Size = new System.Drawing.Size(103, 32);
            this.drtextLbl.TabIndex = 21;
            this.drtextLbl.Text = "Recall:";
            // 
            // trainUD
            // 
            this.trainUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainUD.Location = new System.Drawing.Point(337, 34);
            this.trainUD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trainUD.Name = "trainUD";
            this.trainUD.Size = new System.Drawing.Size(121, 38);
            this.trainUD.TabIndex = 18;
            this.trainUD.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.trainUD.ValueChanged += new System.EventHandler(this.trainUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "% of Train Examples:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1289, 333);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1579, 723);
            this.dataGridView1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.pruneToolStripMenuItem,
            this.colorizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2903, 49);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.fileToolStripMenuItem.Text = "Open";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(120, 45);
            this.runToolStripMenuItem.Text = "Induce";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // pruneToolStripMenuItem
            // 
            this.pruneToolStripMenuItem.Name = "pruneToolStripMenuItem";
            this.pruneToolStripMenuItem.Size = new System.Drawing.Size(107, 45);
            this.pruneToolStripMenuItem.Text = "Prune";
            this.pruneToolStripMenuItem.Click += new System.EventHandler(this.pruneToolStripMenuItem_Click);
            // 
            // colorizeToolStripMenuItem
            // 
            this.colorizeToolStripMenuItem.Name = "colorizeToolStripMenuItem";
            this.colorizeToolStripMenuItem.Size = new System.Drawing.Size(238, 45);
            this.colorizeToolStripMenuItem.Text = "Results Filtering";
            this.colorizeToolStripMenuItem.Click += new System.EventHandler(this.colorizeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2903, 1082);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.testTab);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = " YAD ILP Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.negThresh)).EndInit();
            this.testTab.ResumeLayout(false);
            this.posTab.ResumeLayout(false);
            this.negTab.ResumeLayout(false);
            this.bkTab.ResumeLayout(false);
            this.trainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainGrid)).EndInit();
            this.testdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step3UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predicateBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown negThresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl testTab;
        private System.Windows.Forms.TabPage posTab;
        private System.Windows.Forms.TabPage negTab;
        private System.Windows.Forms.ListBox negLB;
        private System.Windows.Forms.ListBox pos;
        private System.Windows.Forms.TabPage bkTab;
        private System.Windows.Forms.ListBox bkLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource predicateBindingSource;
        private System.Windows.Forms.NumericUpDown trainUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DRLbl;
        private System.Windows.Forms.Label drtextLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Step3UD;
        private System.Windows.Forms.TabPage trainData;
        private System.Windows.Forms.DataGridView trainGrid;
        private System.Windows.Forms.TabPage testdata;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.Label percLbl;
        private System.Windows.Forms.Label perc_lbl;
        private System.Windows.Forms.ComboBox modeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TryCnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fmeasureLbl;
        private System.Windows.Forms.Label accuracyValLBL;
        private System.Windows.Forms.Label accuracyLBL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorizeToolStripMenuItem;
    }
}

