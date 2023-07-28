using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskScrollBar20230705_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 120;
            textBox1.Location = new Point(textBox1.Location.X, vScrollBar1.Value + 10);

            textBox1.Text = $"{textBox1.Location.X} : {textBox1.Location.Y} || " +
                $"{textBox1.Location.X + textBox1.Width} : {textBox1.Location.Y + textBox1.Height}";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 340;
            textBox1.Location = new Point(hScrollBar1.Value + 10, textBox1.Location.Y);

            textBox1.Text = $"{textBox1.Location.X} : {textBox1.Location.Y} || " +
                $"{textBox1.Location.X+textBox1.Width} : {textBox1.Location.Y+textBox1.Height}";
        }
    }
}
