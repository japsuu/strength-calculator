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
        public Form1()
        {
            InitializeComponent();

            List<Item> shearings = new List<Item>();
            shearings.Add(new Item() { Text = "Yksileikkeinen", Value = 1 });
            shearings.Add(new Item() { Text = "Kaksileikkeinen", Value = 2 });
            shearing.DataSource = shearings;
            shearing.DisplayMember = "Text";
            shearing.ValueMember = "Value";

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

            flag = true;
            Calculate();
        }

        void Calculate()
        {
            if (!flag)
                return;

            string result = CuttingStrength.Calculate(
                int.Parse(screwThreading.SelectedValue.ToString()),
                int.Parse(screwClass.SelectedValue.ToString()),
                int.Parse(screwSize.SelectedValue.ToString()),
                int.Parse(shearing.SelectedValue.ToString()),
                int.Parse(screwAmount.SelectedValue.ToString()));

            resultBox.Text = result;
            formula.Text = CuttingStrength.formula;
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
    }

    public class Item
    {
        public Item() { }

        public int Value { set; get; }
        public string Text { set; get; }
    }
}
