#pragma warning disable IDE1006
#pragma warning disable IDE0028

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strength_Calculator
{
    public partial class Form1 : Form
    {
        bool flag = false;
        List<TextBox> inputs = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

            //tab 1
            List<Item> shearings = new List<Item>();
            shearings.Add(new Item() { Text = "Yksileikkeinen", Value = 1 });
            shearings.Add(new Item() { Text = "Kaksileikkeinen", Value = 2 });
            screwShearing.DataSource = shearings;
            screwShearing.DisplayMember = "Text";
            screwShearing.ValueMember = "Value";

            List<Item> classes = new List<Item>();
            classes.Add(new Item() { Text = "8.8", Value = 800 });
            classes.Add(new Item() { Text = "10.9", Value = 1000 });
            screwClass.DataSource = classes;
            screwClass.DisplayMember = "Text";
            screwClass.ValueMember = "Value";

            List<Item> sizes = new List<Item>();
            sizes.Add(new Item() { Text = "M12", Value = 12 });
            sizes.Add(new Item() { Text = "M16", Value = 16 });
            sizes.Add(new Item() { Text = "M20", Value = 20 });
            sizes.Add(new Item() { Text = "M22", Value = 22 });
            sizes.Add(new Item() { Text = "M24", Value = 24 });
            sizes.Add(new Item() { Text = "M27", Value = 27 });
            sizes.Add(new Item() { Text = "M30", Value = 30 });
            sizes.Add(new Item() { Text = "M36", Value = 36 });
            screwSize.DataSource = sizes;
            screwSize.DisplayMember = "Text";
            screwSize.ValueMember = "Value";

            List<Item> threadings = new List<Item>();
            threadings.Add(new Item() { Text = "Osakierteinen", Value = 0 });
            threadings.Add(new Item() { Text = "Täyskierteinen", Value = 1 });
            screwThreading.DataSource = threadings;
            screwThreading.DisplayMember = "Text";
            screwThreading.ValueMember = "Value";

            List<Item> count = new List<Item>();
            count.Add(new Item() { Text = "1x2 (2)", Value = 2 });
            count.Add(new Item() { Text = "2x2 (4)", Value = 4 });
            screwAmount.DataSource = count;
            screwAmount.DisplayMember = "Text";
            screwAmount.ValueMember = "Value";



            //tab 2
            List<Item> jointShearings = new List<Item>();
            jointShearings.Add(new Item() { Text = "Yksileikkeinen", Value = 1 });
            jointShearings.Add(new Item() { Text = "Kaksileikkeinen", Value = 2 });
            shearing.DataSource = jointShearings;
            shearing.DisplayMember = "Text";
            shearing.ValueMember = "Value";

            List<Item> screwCounts = new List<Item>();
            screwCounts.Add(new Item() { Text = "1x2 (2)", Value = 2 });
            screwCounts.Add(new Item() { Text = "2x2 (4)", Value = 4 });
            screwAmount1.DataSource = screwCounts;
            screwAmount1.DisplayMember = "Text";
            screwAmount1.ValueMember = "Value";

            List<Item> screwSizes = new List<Item>();
            screwSizes.Add(new Item() { Text = "M12", Value = 13 });
            screwSizes.Add(new Item() { Text = "M16", Value = 18 });
            screwSizes.Add(new Item() { Text = "M20", Value = 22 });
            screwSizes.Add(new Item() { Text = "M22", Value = 24 });
            screwSizes.Add(new Item() { Text = "M24", Value = 26 });
            screwSizes.Add(new Item() { Text = "M27", Value = 30 });
            screwSizes.Add(new Item() { Text = "M30", Value = 33 });
            screwSizes.Add(new Item() { Text = "M36", Value = 39 });
            screwSize1.DataSource = screwSizes;
            screwSize1.DisplayMember = "Text";
            screwSize1.ValueMember = "Value";

            List<Item> beams = new List<Item>();
            beams.Add(new Item() { Text = "HEA120", Value = 1 });
            beams.Add(new Item() { Text = "HEA180", Value = 2 });
            beams.Add(new Item() { Text = "HEA320", Value = 3 });
            beams.Add(new Item() { Text = "HEA700", Value = 4 });
            beam.DataSource = beams;
            beam.DisplayMember = "Text";
            beam.ValueMember = "Value";

            List<Item> beamMaterials = new List<Item>();
            beamMaterials.Add(new Item() { Text = "S235", Value = 235 });
            beamMaterials.Add(new Item() { Text = "S355", Value = 355 });
            beamMaterial.DataSource = beamMaterials;
            beamMaterial.DisplayMember = "Text";
            beamMaterial.ValueMember = "Value";

            List<Item> plateMaterials = new List<Item>();
            plateMaterials.Add(new Item() { Text = "S235", Value = 235 });
            plateMaterials.Add(new Item() { Text = "S355", Value = 355 });
            plateMaterial.DataSource = plateMaterials;
            plateMaterial.DisplayMember = "Text";
            plateMaterial.ValueMember = "Value";

            List<Item> plateThicknesses = new List<Item>();
            plateThicknesses.Add(new Item() { Text = "10mm", Value = 10 });
            plateThicknesses.Add(new Item() { Text = "12mm", Value = 12 });
            plateThicknesses.Add(new Item() { Text = "15mm", Value = 15 });
            plateThicknesses.Add(new Item() { Text = "20mm", Value = 20 });
            plateThicknesses.Add(new Item() { Text = "25mm", Value = 25 });
            plateThicknesses.Add(new Item() { Text = "30mm", Value = 30 });
            plateThickness.DataSource = plateThicknesses;
            plateThickness.DisplayMember = "Text";
            plateThickness.ValueMember = "Value";

            inputs.Add(e1);
            inputs.Add(e2);
            inputs.Add(p1);
            inputs.Add(p2);


            flag = true;
            Calculate();
        }

        void Calculate()
        {
            if (!flag)
                return;

            float result = CuttingStrength.Calculate(
                int.Parse(screwThreading.SelectedValue.ToString()),
                int.Parse(screwClass.SelectedValue.ToString()),
                int.Parse(screwSize.SelectedValue.ToString()),
                int.Parse(screwShearing.SelectedValue.ToString()),
                int.Parse(screwAmount.SelectedValue.ToString()));

            resultBoxK.Text = (result / 1000).ToString();
            formula.Text = CuttingStrength.formula;
        }

        void CalculateBlock()
        {
            if (!flag)
                return;

            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i].Text == null || inputs[i].Text == "")
                {
                    inputs[i].BackColor = Color.FromArgb(255, 225, 225);
                }
                else
                    inputs[i].BackColor = Color.White;
            }

            if (e1.Text == null || e1.Text == "" || e2.Text == null || e2.Text == "" || p1.Text == null || p1.Text == "" || p2.Text == null || p2.Text == "")
            {
                return;
            }

            float result = BlockShearingStrength.Calculate(
                int.Parse(plateMaterial.SelectedValue.ToString()),
                int.Parse(beamMaterial.SelectedValue.ToString()),
                int.Parse(screwAmount1.SelectedValue.ToString()),
                float.Parse(e1.Text.ToString()),
                float.Parse(e2.Text.ToString()),
                float.Parse(p1.Text.ToString()),
                float.Parse(p2.Text.ToString()),
                int.Parse(beam.SelectedValue.ToString()),
                int.Parse(plateThickness.SelectedValue.ToString()),
                int.Parse(screwSize1.SelectedValue.ToString()),
                int.Parse(shearing.SelectedValue.ToString()));

            result01.Text = (result / 1000).ToString();
            blockFormula.Text = BlockShearingStrength.formula;
            if (result >= 0)
                negWarn.Visible = false;
            else
                negWarn.Visible = true;
        }

        private void shearing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void screwClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void screwSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void screwThreading_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void screwAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void screwShearing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void shearing_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void screwAmount1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void screwSize1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void beam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void beamMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void plateThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void plateMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void e1_TextChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void e2_TextChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            CalculateBlock();
        }

        private void alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTop.Checked)
                TopMost = true;
            else
                TopMost = false;
        }
    }

    public class Item
    {
        public Item() { }

        public int Value { set; get; }
        public string Text { set; get; }
    }
}
