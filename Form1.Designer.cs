namespace Strength_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.screwClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.screwSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.screwThreading = new System.Windows.Forms.ComboBox();
            this.screwAmount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.screwShearing = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.resultBoxK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.p2 = new System.Windows.Forms.NumericUpDown();
            this.p1 = new System.Windows.Forms.NumericUpDown();
            this.e2 = new System.Windows.Forms.NumericUpDown();
            this.e1 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.result01 = new System.Windows.Forms.TextBox();
            this.negWarn = new System.Windows.Forms.Label();
            this.blockFormula = new System.Windows.Forms.Label();
            this.screwSize1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.plateThickness = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.plateMaterial = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.beamMaterial = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.beam = new System.Windows.Forms.ComboBox();
            this.shearing = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.screwAmount1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leikkeisyys:";
            // 
            // screwClass
            // 
            this.screwClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwClass.FormattingEnabled = true;
            this.screwClass.Items.AddRange(new object[] {
            "8.8",
            "10.9"});
            this.screwClass.Location = new System.Drawing.Point(224, 79);
            this.screwClass.Margin = new System.Windows.Forms.Padding(4);
            this.screwClass.Name = "screwClass";
            this.screwClass.Size = new System.Drawing.Size(137, 24);
            this.screwClass.TabIndex = 2;
            this.screwClass.SelectedIndexChanged += new System.EventHandler(this.CalculateListener);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruuvien lujuusluokka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ruuvien koko:";
            // 
            // screwSize
            // 
            this.screwSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwSize.FormattingEnabled = true;
            this.screwSize.Items.AddRange(new object[] {
            "M12",
            "M16",
            "M20",
            "M22",
            "M24",
            "M27",
            "M30",
            "M36"});
            this.screwSize.Location = new System.Drawing.Point(224, 112);
            this.screwSize.Margin = new System.Windows.Forms.Padding(4);
            this.screwSize.Name = "screwSize";
            this.screwSize.Size = new System.Drawing.Size(137, 24);
            this.screwSize.TabIndex = 3;
            this.screwSize.SelectedIndexChanged += new System.EventHandler(this.CalculateListener);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kierteisyys:";
            // 
            // screwThreading
            // 
            this.screwThreading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwThreading.FormattingEnabled = true;
            this.screwThreading.Items.AddRange(new object[] {
            "Osa",
            "Täys"});
            this.screwThreading.Location = new System.Drawing.Point(224, 145);
            this.screwThreading.Margin = new System.Windows.Forms.Padding(4);
            this.screwThreading.Name = "screwThreading";
            this.screwThreading.Size = new System.Drawing.Size(137, 24);
            this.screwThreading.TabIndex = 4;
            this.screwThreading.SelectedIndexChanged += new System.EventHandler(this.CalculateListener);
            // 
            // screwAmount
            // 
            this.screwAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwAmount.FormattingEnabled = true;
            this.screwAmount.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.screwAmount.Location = new System.Drawing.Point(224, 178);
            this.screwAmount.Margin = new System.Windows.Forms.Padding(4);
            this.screwAmount.Name = "screwAmount";
            this.screwAmount.Size = new System.Drawing.Size(137, 24);
            this.screwAmount.TabIndex = 5;
            this.screwAmount.SelectedIndexChanged += new System.EventHandler(this.CalculateListener);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruuvien määrä:";
            // 
            // screwShearing
            // 
            this.screwShearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwShearing.FormattingEnabled = true;
            this.screwShearing.Location = new System.Drawing.Point(224, 46);
            this.screwShearing.Margin = new System.Windows.Forms.Padding(4);
            this.screwShearing.Name = "screwShearing";
            this.screwShearing.Size = new System.Drawing.Size(137, 24);
            this.screwShearing.TabIndex = 1;
            this.screwShearing.SelectedIndexChanged += new System.EventHandler(this.CalculateListener);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Leikkauskestävyys:";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Location = new System.Drawing.Point(85, 309);
            this.formula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(52, 17);
            this.formula.TabIndex = 15;
            this.formula.Text = "Kaava:";
            // 
            // resultBoxK
            // 
            this.resultBoxK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBoxK.Location = new System.Drawing.Point(224, 255);
            this.resultBoxK.Margin = new System.Windows.Forms.Padding(4);
            this.resultBoxK.Name = "resultBoxK";
            this.resultBoxK.ReadOnly = true;
            this.resultBoxK.Size = new System.Drawing.Size(79, 22);
            this.resultBoxK.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "kN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 526);
            this.tabControl1.TabIndex = 101;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.screwShearing);
            this.tabPage1.Controls.Add(this.screwClass);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.resultBoxK);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.formula);
            this.tabPage1.Controls.Add(this.screwSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.screwThreading);
            this.tabPage1.Controls.Add(this.screwAmount);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(511, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ruuvin leikkauskestävyys";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.p2);
            this.tabPage2.Controls.Add(this.p1);
            this.tabPage2.Controls.Add(this.e2);
            this.tabPage2.Controls.Add(this.e1);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.result01);
            this.tabPage2.Controls.Add(this.negWarn);
            this.tabPage2.Controls.Add(this.blockFormula);
            this.tabPage2.Controls.Add(this.screwSize1);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.plateThickness);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.plateMaterial);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.beamMaterial);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.beam);
            this.tabPage2.Controls.Add(this.shearing);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.screwAmount1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(511, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palamurtumiskestävyys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(223, 78);
            this.p2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(65, 22);
            this.p2.TabIndex = 3;
            this.p2.ValueChanged += new System.EventHandler(this.CalculateBlockListener);
            this.p2.Enter += new System.EventHandler(this.p2_Enter);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(116, 78);
            this.p1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(65, 22);
            this.p1.TabIndex = 2;
            this.p1.ValueChanged += new System.EventHandler(this.CalculateBlockListener);
            this.p1.Enter += new System.EventHandler(this.p1_Enter);
            // 
            // e2
            // 
            this.e2.Location = new System.Drawing.Point(223, 46);
            this.e2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(65, 22);
            this.e2.TabIndex = 1;
            this.e2.ValueChanged += new System.EventHandler(this.CalculateBlockListener);
            this.e2.Enter += new System.EventHandler(this.e2_Enter);
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(116, 46);
            this.e1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(65, 22);
            this.e1.TabIndex = 0;
            this.e1.ValueChanged += new System.EventHandler(this.CalculateBlockListener);
            this.e1.Enter += new System.EventHandler(this.e1_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(312, 382);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "kN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 382);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 17);
            this.label20.TabIndex = 32;
            this.label20.Text = "Palamurtumiskestävyys:";
            // 
            // result01
            // 
            this.result01.Location = new System.Drawing.Point(224, 378);
            this.result01.Margin = new System.Windows.Forms.Padding(4);
            this.result01.Name = "result01";
            this.result01.ReadOnly = true;
            this.result01.Size = new System.Drawing.Size(79, 22);
            this.result01.TabIndex = 11;
            // 
            // negWarn
            // 
            this.negWarn.AutoSize = true;
            this.negWarn.ForeColor = System.Drawing.Color.Red;
            this.negWarn.Location = new System.Drawing.Point(4, 475);
            this.negWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.negWarn.Name = "negWarn";
            this.negWarn.Size = new System.Drawing.Size(442, 17);
            this.negWarn.TabIndex = 31;
            this.negWarn.Text = "Ulostulo on negatiivinen! Varmista, että kaikki syöttöarvot ovat oikein.";
            this.negWarn.Visible = false;
            // 
            // blockFormula
            // 
            this.blockFormula.AutoSize = true;
            this.blockFormula.Location = new System.Drawing.Point(40, 419);
            this.blockFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blockFormula.Name = "blockFormula";
            this.blockFormula.Size = new System.Drawing.Size(0, 17);
            this.blockFormula.TabIndex = 30;
            // 
            // screwSize1
            // 
            this.screwSize1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwSize1.FormattingEnabled = true;
            this.screwSize1.Location = new System.Drawing.Point(224, 194);
            this.screwSize1.Margin = new System.Windows.Forms.Padding(4);
            this.screwSize1.Name = "screwSize1";
            this.screwSize1.Size = new System.Drawing.Size(137, 24);
            this.screwSize1.TabIndex = 6;
            this.screwSize1.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 198);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 17);
            this.label19.TabIndex = 25;
            this.label19.Text = "Ruuvien koko:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 298);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Levyn paksuus:";
            // 
            // plateThickness
            // 
            this.plateThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateThickness.FormattingEnabled = true;
            this.plateThickness.Location = new System.Drawing.Point(224, 294);
            this.plateThickness.Margin = new System.Windows.Forms.Padding(4);
            this.plateThickness.Name = "plateThickness";
            this.plateThickness.Size = new System.Drawing.Size(137, 24);
            this.plateThickness.TabIndex = 9;
            this.plateThickness.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 331);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Levyn materiaali:";
            // 
            // plateMaterial
            // 
            this.plateMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateMaterial.FormattingEnabled = true;
            this.plateMaterial.Location = new System.Drawing.Point(224, 327);
            this.plateMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.plateMaterial.Name = "plateMaterial";
            this.plateMaterial.Size = new System.Drawing.Size(137, 24);
            this.plateMaterial.TabIndex = 10;
            this.plateMaterial.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 265);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Palkin materiaali:";
            // 
            // beamMaterial
            // 
            this.beamMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beamMaterial.FormattingEnabled = true;
            this.beamMaterial.Location = new System.Drawing.Point(224, 261);
            this.beamMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.beamMaterial.Name = "beamMaterial";
            this.beamMaterial.Size = new System.Drawing.Size(137, 24);
            this.beamMaterial.TabIndex = 8;
            this.beamMaterial.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 231);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Palkki:";
            // 
            // beam
            // 
            this.beam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beam.FormattingEnabled = true;
            this.beam.Location = new System.Drawing.Point(224, 228);
            this.beam.Margin = new System.Windows.Forms.Padding(4);
            this.beam.Name = "beam";
            this.beam.Size = new System.Drawing.Size(137, 24);
            this.beam.TabIndex = 7;
            this.beam.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // shearing
            // 
            this.shearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shearing.FormattingEnabled = true;
            this.shearing.Location = new System.Drawing.Point(224, 129);
            this.shearing.Margin = new System.Windows.Forms.Padding(4);
            this.shearing.Name = "shearing";
            this.shearing.Size = new System.Drawing.Size(137, 24);
            this.shearing.TabIndex = 4;
            this.shearing.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Leikkeisyys:";
            // 
            // screwAmount1
            // 
            this.screwAmount1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwAmount1.FormattingEnabled = true;
            this.screwAmount1.Location = new System.Drawing.Point(224, 161);
            this.screwAmount1.Margin = new System.Windows.Forms.Padding(4);
            this.screwAmount1.Name = "screwAmount1";
            this.screwAmount1.Size = new System.Drawing.Size(137, 24);
            this.screwAmount1.TabIndex = 5;
            this.screwAmount1.SelectedIndexChanged += new System.EventHandler(this.CalculateBlockListener);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ruuvien määrä:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "p2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "p1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "e2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "e1:";
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.AutoSize = true;
            this.alwaysOnTop.Location = new System.Drawing.Point(372, 10);
            this.alwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(159, 21);
            this.alwaysOnTop.TabIndex = 102;
            this.alwaysOnTop.Text = "Aina päällimmäisenä";
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.OnTopListener);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "Copyright © Jasper Honkasalo, Henri Koivuranta 2021";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(369, 548);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(97, 17);
            this.githubLinkLabel.TabIndex = 104;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "Link to source";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkListener);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 574);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alwaysOnTop);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kestävyyslaskuri";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox screwClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox screwSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox screwThreading;
        private System.Windows.Forms.ComboBox screwAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox screwShearing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.TextBox resultBoxK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox beam;
        private System.Windows.Forms.ComboBox shearing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox screwAmount1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox plateThickness;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox plateMaterial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox beamMaterial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox screwSize1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label blockFormula;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.Label negWarn;
        private System.Windows.Forms.TextBox result01;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.NumericUpDown e1;
        private System.Windows.Forms.NumericUpDown p2;
        private System.Windows.Forms.NumericUpDown p1;
        private System.Windows.Forms.NumericUpDown e2;
    }
}

