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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.resultBoxK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.beam = new System.Windows.Forms.ComboBox();
            this.shearing = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.screwAmount1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.e2 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.e1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.beamMaterial = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.plateMaterial = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.plateThickness = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
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
            this.screwClass.Location = new System.Drawing.Point(168, 64);
            this.screwClass.Name = "screwClass";
            this.screwClass.Size = new System.Drawing.Size(104, 21);
            this.screwClass.TabIndex = 3;
            this.screwClass.SelectedIndexChanged += new System.EventHandler(this.screwClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruuvien lujuusluokka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
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
            this.screwSize.Location = new System.Drawing.Point(168, 91);
            this.screwSize.Name = "screwSize";
            this.screwSize.Size = new System.Drawing.Size(104, 21);
            this.screwSize.TabIndex = 6;
            this.screwSize.SelectedIndexChanged += new System.EventHandler(this.screwSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
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
            this.screwThreading.Location = new System.Drawing.Point(168, 118);
            this.screwThreading.Name = "screwThreading";
            this.screwThreading.Size = new System.Drawing.Size(104, 21);
            this.screwThreading.TabIndex = 8;
            this.screwThreading.SelectedIndexChanged += new System.EventHandler(this.screwThreading_SelectedIndexChanged);
            // 
            // screwAmount
            // 
            this.screwAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwAmount.FormattingEnabled = true;
            this.screwAmount.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.screwAmount.Location = new System.Drawing.Point(168, 145);
            this.screwAmount.Name = "screwAmount";
            this.screwAmount.Size = new System.Drawing.Size(104, 21);
            this.screwAmount.TabIndex = 9;
            this.screwAmount.SelectedIndexChanged += new System.EventHandler(this.screwAmount_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruuvien määrä:";
            // 
            // screwShearing
            // 
            this.screwShearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwShearing.FormattingEnabled = true;
            this.screwShearing.Location = new System.Drawing.Point(168, 37);
            this.screwShearing.Name = "screwShearing";
            this.screwShearing.Size = new System.Drawing.Size(104, 21);
            this.screwShearing.TabIndex = 11;
            this.screwShearing.SelectedIndexChanged += new System.EventHandler(this.screwShearing_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBox.Location = new System.Drawing.Point(168, 197);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(60, 20);
            this.resultBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Leikkauskestävyys:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "N";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Location = new System.Drawing.Point(64, 251);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(41, 13);
            this.formula.TabIndex = 15;
            this.formula.Text = "Kaava:";
            // 
            // resultBoxK
            // 
            this.resultBoxK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBoxK.Location = new System.Drawing.Point(168, 221);
            this.resultBoxK.Name = "resultBoxK";
            this.resultBoxK.ReadOnly = true;
            this.resultBoxK.Size = new System.Drawing.Size(60, 20);
            this.resultBoxK.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "kN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 427);
            this.tabControl1.TabIndex = 18;
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
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.screwThreading);
            this.tabPage1.Controls.Add(this.resultBox);
            this.tabPage1.Controls.Add(this.screwAmount);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(496, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ruuvin leikkauskestävyys";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Controls.Add(this.p2);
            this.tabPage2.Controls.Add(this.e2);
            this.tabPage2.Controls.Add(this.p1);
            this.tabPage2.Controls.Add(this.e1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(496, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palamurtumiskestävyys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // beam
            // 
            this.beam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beam.FormattingEnabled = true;
            this.beam.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.beam.Location = new System.Drawing.Point(168, 159);
            this.beam.Name = "beam";
            this.beam.Size = new System.Drawing.Size(104, 21);
            this.beam.TabIndex = 16;
            // 
            // shearing
            // 
            this.shearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shearing.FormattingEnabled = true;
            this.shearing.Location = new System.Drawing.Point(168, 105);
            this.shearing.Name = "shearing";
            this.shearing.Size = new System.Drawing.Size(104, 21);
            this.shearing.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Leikkeisyys:";
            // 
            // screwAmount1
            // 
            this.screwAmount1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwAmount1.FormattingEnabled = true;
            this.screwAmount1.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.screwAmount1.Location = new System.Drawing.Point(168, 132);
            this.screwAmount1.Name = "screwAmount1";
            this.screwAmount1.Size = new System.Drawing.Size(104, 21);
            this.screwAmount1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ruuvien määrä:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "p2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "p1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "e2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "e1";
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(248, 65);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(35, 20);
            this.p2.TabIndex = 6;
            // 
            // e2
            // 
            this.e2.Location = new System.Drawing.Point(168, 65);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(35, 20);
            this.e2.TabIndex = 5;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(248, 39);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(35, 20);
            this.p1.TabIndex = 4;
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(168, 39);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(35, 20);
            this.e1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Palkki:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Palkin materiaali:";
            // 
            // beamMaterial
            // 
            this.beamMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beamMaterial.FormattingEnabled = true;
            this.beamMaterial.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.beamMaterial.Location = new System.Drawing.Point(168, 186);
            this.beamMaterial.Name = "beamMaterial";
            this.beamMaterial.Size = new System.Drawing.Size(104, 21);
            this.beamMaterial.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Levyn materiaali:";
            // 
            // plateMaterial
            // 
            this.plateMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateMaterial.FormattingEnabled = true;
            this.plateMaterial.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.plateMaterial.Location = new System.Drawing.Point(168, 213);
            this.plateMaterial.Name = "plateMaterial";
            this.plateMaterial.Size = new System.Drawing.Size(104, 21);
            this.plateMaterial.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Levyn paksuus:";
            // 
            // plateThickness
            // 
            this.plateThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateThickness.FormattingEnabled = true;
            this.plateThickness.Items.AddRange(new object[] {
            "2x2 (4)",
            "1x2 (2)"});
            this.plateThickness.Location = new System.Drawing.Point(168, 240);
            this.plateThickness.Name = "plateThickness";
            this.plateThickness.Size = new System.Drawing.Size(104, 21);
            this.plateThickness.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 446);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kestävyyslaskuri";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox e2;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox e1;
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
    }
}

