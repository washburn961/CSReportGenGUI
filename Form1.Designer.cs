namespace ReportGenGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            ctaEditorListBox = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            partNumberTextBox = new TextBox();
            partNumberLabel = new Label();
            oCcomboBox = new ComboBox();
            productNameTextBox = new TextBox();
            orderTextBox = new TextBox();
            orderLabel = new Label();
            productNameLabel = new Label();
            customerTextBox = new TextBox();
            customerLabel = new Label();
            ocLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            instantaneousErrorListBox = new ListBox();
            tabPage5 = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            compositeErrorListBox = new ListBox();
            tabPage6 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            excitationCurveListBox = new ListBox();
            tabPage7 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            securityFactorListBox = new ListBox();
            tabPage8 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            resistanceTextBox = new TextBox();
            resistanceLabel = new Label();
            temperatureLabel = new Label();
            temperatureTextBox = new TextBox();
            rctTemperatureLabel = new Label();
            rctTemperatureTextBox = new TextBox();
            rctLabel = new Label();
            rctTextBox = new TextBox();
            resistanceListBox = new ListBox();
            toolStrip1 = new ToolStrip();
            ctaToolStripButton = new ToolStripButton();
            ac1ToolStripButton = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabPage5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabPage6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPage7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tabPage8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 702);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1024, 740);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1016, 712);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CT Analyzer Editor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel2.Controls.Add(ctaEditorListBox, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1007, 703);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ctaEditorListBox
            // 
            ctaEditorListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ctaEditorListBox.FormattingEnabled = true;
            ctaEditorListBox.ItemHeight = 15;
            ctaEditorListBox.Location = new Point(3, 3);
            ctaEditorListBox.Name = "ctaEditorListBox";
            tableLayoutPanel2.SetRowSpan(ctaEditorListBox, 2);
            ctaEditorListBox.Size = new Size(238, 694);
            ctaEditorListBox.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Location = new Point(247, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 26;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(757, 697);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(129, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 27);
            label5.TabIndex = 1;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(partNumberTextBox);
            tabPage2.Controls.Add(partNumberLabel);
            tabPage2.Controls.Add(oCcomboBox);
            tabPage2.Controls.Add(productNameTextBox);
            tabPage2.Controls.Add(orderTextBox);
            tabPage2.Controls.Add(orderLabel);
            tabPage2.Controls.Add(productNameLabel);
            tabPage2.Controls.Add(customerTextBox);
            tabPage2.Controls.Add(customerLabel);
            tabPage2.Controls.Add(ocLabel);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1016, 712);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reports";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // partNumberTextBox
            // 
            partNumberTextBox.Location = new Point(762, 14);
            partNumberTextBox.Name = "partNumberTextBox";
            partNumberTextBox.Size = new Size(100, 23);
            partNumberTextBox.TabIndex = 12;
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Location = new Point(681, 17);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new Size(75, 15);
            partNumberLabel.TabIndex = 11;
            partNumberLabel.Text = "Part Number";
            // 
            // oCcomboBox
            // 
            oCcomboBox.FormattingEnabled = true;
            oCcomboBox.Location = new Point(38, 14);
            oCcomboBox.Name = "oCcomboBox";
            oCcomboBox.Size = new Size(121, 23);
            oCcomboBox.TabIndex = 10;
            oCcomboBox.SelectedIndexChanged += oCcomboBox_SelectedIndexChanged;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(255, 14);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(100, 23);
            productNameTextBox.TabIndex = 9;
            // 
            // orderTextBox
            // 
            orderTextBox.Location = new Point(575, 14);
            orderTextBox.Name = "orderTextBox";
            orderTextBox.Size = new Size(100, 23);
            orderTextBox.TabIndex = 7;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Location = new Point(532, 17);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(37, 15);
            orderLabel.TabIndex = 6;
            orderLabel.Text = "Order";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(165, 17);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(84, 15);
            productNameLabel.TabIndex = 8;
            productNameLabel.Text = "Product Name";
            // 
            // customerTextBox
            // 
            customerTextBox.Location = new Point(426, 14);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(100, 23);
            customerTextBox.TabIndex = 5;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(361, 17);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(59, 15);
            customerLabel.TabIndex = 4;
            customerLabel.Text = "Customer";
            // 
            // ocLabel
            // 
            ocLabel.AutoSize = true;
            ocLabel.Location = new Point(8, 17);
            ocLabel.Name = "ocLabel";
            ocLabel.Size = new Size(24, 15);
            ocLabel.TabIndex = 2;
            ocLabel.Text = "OC";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel3.Location = new Point(6, 45);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1004, 661);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.SetColumnSpan(tabControl2, 2);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tableLayoutPanel3.SetRowSpan(tabControl2, 2);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(998, 655);
            tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(990, 627);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Instantaneous Error";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel5.Controls.Add(instantaneousErrorListBox, 0, 0);
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(978, 615);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // instantaneousErrorListBox
            // 
            instantaneousErrorListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            instantaneousErrorListBox.FormattingEnabled = true;
            instantaneousErrorListBox.ItemHeight = 15;
            instantaneousErrorListBox.Location = new Point(3, 3);
            instantaneousErrorListBox.Name = "instantaneousErrorListBox";
            tableLayoutPanel5.SetRowSpan(instantaneousErrorListBox, 2);
            instantaneousErrorListBox.Size = new Size(231, 604);
            instantaneousErrorListBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tableLayoutPanel6);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(990, 627);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Composite Error";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel6.Controls.Add(compositeErrorListBox, 0, 0);
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(978, 615);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // compositeErrorListBox
            // 
            compositeErrorListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            compositeErrorListBox.FormattingEnabled = true;
            compositeErrorListBox.ItemHeight = 15;
            compositeErrorListBox.Location = new Point(3, 3);
            compositeErrorListBox.Name = "compositeErrorListBox";
            tableLayoutPanel6.SetRowSpan(compositeErrorListBox, 2);
            compositeErrorListBox.Size = new Size(231, 604);
            compositeErrorListBox.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(tableLayoutPanel7);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(990, 627);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Excitation Curve";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel7.Controls.Add(excitationCurveListBox, 0, 0);
            tableLayoutPanel7.Location = new Point(6, 6);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(978, 615);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // excitationCurveListBox
            // 
            excitationCurveListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            excitationCurveListBox.FormattingEnabled = true;
            excitationCurveListBox.ItemHeight = 15;
            excitationCurveListBox.Location = new Point(3, 3);
            excitationCurveListBox.Name = "excitationCurveListBox";
            tableLayoutPanel7.SetRowSpan(excitationCurveListBox, 2);
            excitationCurveListBox.Size = new Size(231, 604);
            excitationCurveListBox.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(tableLayoutPanel8);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(990, 627);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "Security Factor";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel8.Controls.Add(securityFactorListBox, 0, 0);
            tableLayoutPanel8.Location = new Point(6, 6);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(978, 615);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // securityFactorListBox
            // 
            securityFactorListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            securityFactorListBox.FormattingEnabled = true;
            securityFactorListBox.ItemHeight = 15;
            securityFactorListBox.Location = new Point(3, 3);
            securityFactorListBox.Name = "securityFactorListBox";
            tableLayoutPanel8.SetRowSpan(securityFactorListBox, 2);
            securityFactorListBox.Size = new Size(231, 604);
            securityFactorListBox.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(tableLayoutPanel9);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(990, 627);
            tabPage8.TabIndex = 4;
            tabPage8.Text = "Resistance";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel9.Controls.Add(resistanceListBox, 0, 0);
            tableLayoutPanel9.Location = new Point(6, 6);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel9.Size = new Size(978, 615);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 6;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel10.Controls.Add(resistanceTextBox, 3, 0);
            tableLayoutPanel10.Controls.Add(resistanceLabel, 2, 0);
            tableLayoutPanel10.Controls.Add(temperatureLabel, 0, 0);
            tableLayoutPanel10.Controls.Add(temperatureTextBox, 1, 0);
            tableLayoutPanel10.Controls.Add(rctTemperatureLabel, 0, 1);
            tableLayoutPanel10.Controls.Add(rctTemperatureTextBox, 1, 1);
            tableLayoutPanel10.Controls.Add(rctLabel, 2, 1);
            tableLayoutPanel10.Controls.Add(rctTextBox, 3, 1);
            tableLayoutPanel10.Location = new Point(240, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 24;
            tableLayoutPanel9.SetRowSpan(tableLayoutPanel10, 2);
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle());
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(735, 609);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // resistanceTextBox
            // 
            resistanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resistanceTextBox.Location = new Point(369, 3);
            resistanceTextBox.Name = "resistanceTextBox";
            resistanceTextBox.Size = new Size(116, 23);
            resistanceTextBox.TabIndex = 3;
            // 
            // resistanceLabel
            // 
            resistanceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resistanceLabel.AutoSize = true;
            resistanceLabel.Location = new Point(247, 0);
            resistanceLabel.Name = "resistanceLabel";
            resistanceLabel.Size = new Size(116, 26);
            resistanceLabel.TabIndex = 2;
            resistanceLabel.Text = "Resistance (Ω)";
            resistanceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // temperatureLabel
            // 
            temperatureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(3, 0);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(116, 26);
            temperatureLabel.TabIndex = 6;
            temperatureLabel.Text = "Temperature (ºC)";
            temperatureLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            temperatureTextBox.Location = new Point(125, 3);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(116, 23);
            temperatureTextBox.TabIndex = 7;
            // 
            // rctTemperatureLabel
            // 
            rctTemperatureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rctTemperatureLabel.AutoSize = true;
            rctTemperatureLabel.Location = new Point(3, 26);
            rctTemperatureLabel.Name = "rctTemperatureLabel";
            rctTemperatureLabel.Size = new Size(116, 26);
            rctTemperatureLabel.TabIndex = 8;
            rctTemperatureLabel.Text = "RCT Temp. (ºC)";
            rctTemperatureLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rctTemperatureTextBox
            // 
            rctTemperatureTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rctTemperatureTextBox.Location = new Point(125, 29);
            rctTemperatureTextBox.Name = "rctTemperatureTextBox";
            rctTemperatureTextBox.Size = new Size(116, 23);
            rctTemperatureTextBox.TabIndex = 9;
            // 
            // rctLabel
            // 
            rctLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rctLabel.AutoSize = true;
            rctLabel.Location = new Point(247, 26);
            rctLabel.Name = "rctLabel";
            rctLabel.Size = new Size(116, 26);
            rctLabel.TabIndex = 4;
            rctLabel.Text = "RCT (Ω)";
            rctLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rctTextBox
            // 
            rctTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rctTextBox.Location = new Point(369, 29);
            rctTextBox.Name = "rctTextBox";
            rctTextBox.Size = new Size(116, 23);
            rctTextBox.TabIndex = 5;
            // 
            // resistanceListBox
            // 
            resistanceListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resistanceListBox.FormattingEnabled = true;
            resistanceListBox.ItemHeight = 15;
            resistanceListBox.Location = new Point(3, 3);
            resistanceListBox.Name = "resistanceListBox";
            tableLayoutPanel9.SetRowSpan(resistanceListBox, 2);
            resistanceListBox.Size = new Size(231, 604);
            resistanceListBox.TabIndex = 0;
            resistanceListBox.SelectedIndexChanged += resistanceListBoxSelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { ctaToolStripButton, ac1ToolStripButton, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1024, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ctaToolStripButton
            // 
            ctaToolStripButton.Image = (Image)resources.GetObject("ctaToolStripButton.Image");
            ctaToolStripButton.ImageTransparentColor = Color.Magenta;
            ctaToolStripButton.Name = "ctaToolStripButton";
            ctaToolStripButton.Size = new Size(114, 22);
            ctaToolStripButton.Text = "Import CTA XML";
            ctaToolStripButton.Click += ctaToolStripButton_Click;
            // 
            // ac1ToolStripButton
            // 
            ac1ToolStripButton.Image = (Image)resources.GetObject("ac1ToolStripButton.Image");
            ac1ToolStripButton.ImageTransparentColor = Color.Magenta;
            ac1ToolStripButton.Name = "ac1ToolStripButton";
            ac1ToolStripButton.Size = new Size(115, 22);
            ac1ToolStripButton.Text = "Import AC1 XML";
            ac1ToolStripButton.Click += ac1ToolStripButton_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(84, 22);
            toolStripButton3.Text = "Export one";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(83, 22);
            toolStripButton4.Text = "Export this";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(76, 22);
            toolStripButton5.Text = "Export all";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStrip toolStrip1;
        private ListBox ctaEditorListBox;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TableLayoutPanel tableLayoutPanel5;
        private ListBox instantaneousErrorListBox;
        private TableLayoutPanel tableLayoutPanel6;
        private ListBox compositeErrorListBox;
        private TableLayoutPanel tableLayoutPanel7;
        private ListBox excitationCurveListBox;
        private TableLayoutPanel tableLayoutPanel8;
        private ListBox securityFactorListBox;
        private TableLayoutPanel tableLayoutPanel9;
        private ListBox resistanceListBox;
        private ToolStripButton ctaToolStripButton;
        private ToolStripButton ac1ToolStripButton;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private Label ocLabel;
        private TextBox productNameTextBox;
        private TextBox orderTextBox;
        private Label orderLabel;
        private Label productNameLabel;
        private TextBox customerTextBox;
        private Label customerLabel;
        private ComboBox oCcomboBox;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel10;
        private Label resistanceLabel;
        private TextBox resistanceTextBox;
        private TextBox partNumberTextBox;
        private Label partNumberLabel;
        private Label rctLabel;
        private TextBox rctTextBox;
        private Label temperatureLabel;
        private TextBox temperatureTextBox;
        private Label rctTemperatureLabel;
        private TextBox rctTemperatureTextBox;
    }
}