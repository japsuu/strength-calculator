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
            this.shearing = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.resultBoxK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.screwClass.TabIndex = 3;
            this.screwClass.SelectedIndexChanged += new System.EventHandler(this.screwClass_SelectedIndexChanged);
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
            this.screwSize.TabIndex = 6;
            this.screwSize.SelectedIndexChanged += new System.EventHandler(this.screwSize_SelectedIndexChanged);
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
            this.screwAmount.Location = new System.Drawing.Point(224, 178);
            this.screwAmount.Margin = new System.Windows.Forms.Padding(4);
            this.screwAmount.Name = "screwAmount";
            this.screwAmount.Size = new System.Drawing.Size(137, 24);
            this.screwAmount.TabIndex = 9;
            this.screwAmount.SelectedIndexChanged += new System.EventHandler(this.screwAmount_SelectedIndexChanged);
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
            // shearing
            // 
            this.shearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shearing.FormattingEnabled = true;
            this.shearing.Location = new System.Drawing.Point(224, 49);
            this.shearing.Margin = new System.Windows.Forms.Padding(4);
            this.shearing.Name = "shearing";
            this.shearing.Size = new System.Drawing.Size(137, 24);
            this.shearing.TabIndex = 11;
            this.shearing.SelectedIndexChanged += new System.EventHandler(this.shearing_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBox.Location = new System.Drawing.Point(224, 242);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(79, 22);
            this.resultBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Leikkauskestävyys:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "N";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Location = new System.Drawing.Point(86, 309);
            this.formula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(52, 17);
            this.formula.TabIndex = 15;
            this.formula.Text = "Kaava:";
            // 
            // resultBoxK
            // 
            this.resultBoxK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBoxK.Location = new System.Drawing.Point(224, 272);
            this.resultBoxK.Margin = new System.Windows.Forms.Padding(4);
            this.resultBoxK.Name = "resultBoxK";
            this.resultBoxK.ReadOnly = true;
            this.resultBoxK.Size = new System.Drawing.Size(79, 22);
            this.resultBoxK.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 275);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 525);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.shearing);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ruuvin leikkauskestävyys";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palamurtumiskestävyys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 549);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ComboBox shearing;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.TextBox resultBoxK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

