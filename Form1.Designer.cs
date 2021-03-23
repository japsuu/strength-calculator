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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 66);
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
            this.screwClass.Location = new System.Drawing.Point(222, 90);
            this.screwClass.Name = "screwClass";
            this.screwClass.Size = new System.Drawing.Size(60, 21);
            this.screwClass.TabIndex = 3;
            this.screwClass.SelectedIndexChanged += new System.EventHandler(this.screwClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruuvien kestävyysluokka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 120);
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
            this.screwSize.Location = new System.Drawing.Point(222, 117);
            this.screwSize.Name = "screwSize";
            this.screwSize.Size = new System.Drawing.Size(60, 21);
            this.screwSize.TabIndex = 6;
            this.screwSize.SelectedIndexChanged += new System.EventHandler(this.screwSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 147);
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
            this.screwThreading.Location = new System.Drawing.Point(222, 144);
            this.screwThreading.Name = "screwThreading";
            this.screwThreading.Size = new System.Drawing.Size(60, 21);
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
            this.screwAmount.Location = new System.Drawing.Point(222, 171);
            this.screwAmount.Name = "screwAmount";
            this.screwAmount.Size = new System.Drawing.Size(60, 21);
            this.screwAmount.TabIndex = 9;
            this.screwAmount.SelectedIndexChanged += new System.EventHandler(this.screwAmount_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruuvien määrä:";
            // 
            // shearing
            // 
            this.shearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shearing.FormattingEnabled = true;
            this.shearing.Items.AddRange(new object[] {
            "1",
            "2"});
            this.shearing.Location = new System.Drawing.Point(222, 63);
            this.shearing.Name = "shearing";
            this.shearing.Size = new System.Drawing.Size(60, 21);
            this.shearing.TabIndex = 11;
            this.shearing.SelectedIndexChanged += new System.EventHandler(this.shearing_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(222, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kestävyys:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "N/mm²";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shearing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.screwAmount);
            this.Controls.Add(this.screwThreading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.screwSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.screwClass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox shearing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

