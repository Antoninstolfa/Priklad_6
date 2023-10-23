using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad6
{
    public partial class Form1 : Form
    {
        TextBox textbox1;
        FontDialog fontdialog1;
        ColorDialog colordialog1;
        NumericUpDown numericUpDown1;
        NumericUpDown numericUpDown2;
        Label label1;
        Label label2;
        Button Uloz;
        Button Zrus;
        Button popredi;
        Button pozadi;
        Button font;
        ComboBox combicko;
        Color fore = Color.Black;
        Color back = Color.White;
        Font pismo = null;
        public Form1()
        {
            InitializeComponent();
        }

        Form form2 = new Form();
        private void button1_Click(object sender, EventArgs e)
        {
            textbox1 = new TextBox();
            textbox1.Location = new Point(20, 10);
            textbox1.Size = new Size(120,20);
            textbox1.Text = "Text tlačítka";

            fontdialog1 = new FontDialog();

            colordialog1 = new ColorDialog();

            numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(20, 40);
            numericUpDown1.Size = new Size(50, 20);
            numericUpDown1.Minimum = 50;
            numericUpDown1.Maximum = 1000;

            numericUpDown2 = new NumericUpDown();
            numericUpDown2.Location = new Point(20, 70);
            numericUpDown2.Size = new Size(50, 20);
            numericUpDown2.Minimum = 50;
            numericUpDown2.Maximum = 1000;

            label1 = new Label();
            label1.Location = new Point(5, 40);
            label1.Size = new Size(15, 20);
            label1.Text = "x:";

            label2 = new Label();
            label2.Location = new Point(5, 70);
            label2.Size = new Size(15,20);
            label2.Text = "y:";

            popredi = new Button();
            popredi.Location = new Point(20, 100);
            popredi.Size = new Size(70, 20);
            popredi.Text = "Barva textu";
            popredi.Click += popredi_Click;

            pozadi = new Button();
            pozadi.Location = new Point(100, 100);
            pozadi.Size = new Size(70, 20);
            pozadi.Text = "Barva pozadí";
            pozadi.Click += pozadi_Click;

            font = new Button();
            font.Location = new Point(70,130);
            font.Size = new Size(70,20);
            font.Text = "Font";
            font.Click += font_Click;

            string[] moznosti = new string[9] { "TopLeft", "TopCenter", "TopRight", "MiddleLeft", "MiddleCenter", "MiddleRight", "BottomLeft", "BottomCenter", "BottomRight" };

            combicko = new ComboBox();
            combicko.Location = new Point(80, 40);
            combicko.Size = new Size(70, 20);
            combicko.Text = "*-Vyberte-*";
            combicko.Items.AddRange(moznosti);

            Uloz = new Button();
            Uloz.Location = new Point(20, 160);
            Uloz.Size = new Size(70, 20);
            Uloz.Text = "Ulož";
            Uloz.Click += Uloz_Click;

            Zrus = new Button();
            Zrus.Location = new Point(20, 190);
            Zrus.Size = new Size(70, 20);
            Zrus.Text = "Zrušit";
            Zrus.Click += Zrus_Click;

            form2.Controls.Add(textbox1);
            form2.Controls.Add(numericUpDown1);
            form2.Controls.Add(numericUpDown2);
            form2.Controls.Add(label1);
            form2.Controls.Add(label2);
            form2.Controls.Add(popredi);
            form2.Controls.Add(pozadi);
            form2.Controls.Add(font);
            form2.Controls.Add(Uloz);
            form2.Controls.Add(Zrus);
            form2.Controls.Add(combicko);

            if (form2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void popredi_Click(object sender, EventArgs e)
        {
            if(colordialog1.ShowDialog() == DialogResult.OK)
            {
                fore = colorDialog1.Color;
            }
        }

        private void pozadi_Click(object sender, EventArgs e)
        {

            if (colordialog1.ShowDialog() == DialogResult.OK)
            {
                back = colorDialog1.Color;
            }
        }

        private void font_Click(object obj, EventArgs e)
        {
            if(fontdialog1.ShowDialog() == DialogResult.OK)
            {
                pismo = fontdialog1.Font;
            }
        }

        private void Uloz_Click(object sender, EventArgs e)
        {
            button1.Text = textbox1.Text;
            button1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            button1.ForeColor = fore;
            button1.BackColor = back;
            button1.Font = pismo;
            switch(combicko.Text)
            {
                case "TopLeft":
                    {
                        button1.TextAlign = ContentAlignment.TopLeft;
                        break;
                    }
                case "TopCenter":
                    {
                        button1.TextAlign = ContentAlignment.TopCenter;
                        break;
                    }
                case "TopRight":
                    {
                        button1.TextAlign = ContentAlignment.TopRight;
                        break;
                    }
                case "MiddleLeft":
                    {
                        button1.TextAlign = ContentAlignment.MiddleLeft;
                        break;
                    }
                case "MiddleCenter":
                    {
                        button1.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    }
                case "MiddleRight":
                    {
                        button1.TextAlign = ContentAlignment.MiddleRight;
                        break;
                    }
                case "BottomLeft":
                    {
                        button1.TextAlign = ContentAlignment.BottomLeft;
                        break;
                    }
                case "BottomCenter":
                    {
                        button1.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    }
                case "BottomRight":
                    {
                        button1.TextAlign = ContentAlignment.BottomRight;
                        break;
                    }

            }
        }
        private void Zrus_Click(object sender, EventArgs e)
        {
            form2.Close();
        }
    }
}
