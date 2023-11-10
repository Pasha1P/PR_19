using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void tabPage1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void groupBox2_Enter(object sender, EventArgs e)
        { }

        private void label2_Click_1(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        { }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        { }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        { }

        private void label1_Click_1(object sender, EventArgs e)
        { }

        private void label2_Click_2(object sender, EventArgs e)
        { }

        private void ____оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxA, "Введите число!");
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxB, "Введите число!");
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxC, "Введите число!");
        }

        private void textBoxRez_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxRez, "Сюда будет выведен результат");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, Y;
                double v1, v2, v3, v4, v5, v6, v7, v8;
                a = double.Parse(textBoxA.Text);
                b = double.Parse(textBoxB.Text);
                c = double.Parse(textBoxC.Text);
                v1 = b * c * c * c;
                v1 = Math.Sqrt(Math.Sqrt(v1));            //расчет корня корня
                v2 = a * a * b * c;
                v2 = Math.Sqrt(Math.Sqrt(v2));            //расчет корня корня
                v3 = Math.Sqrt(a);                        //расчет корня для деления
                v4 = Math.Sqrt(c);                        //расчет корня для деления
                v5 = b * c;
                v5 = Math.Sqrt(Math.Sqrt(v5));            //расчет корня
                double temp = v3 + v4;
                double temp1 = Math.Sqrt(v5);
                if ((temp == 0) ||(temp1 == 0))
                    throw new DivideByZeroException("Ошибка. Исключение деления на ноль.");
                else
                {
                    v5 = ((v1 + v2) / (v3 + v4)) + v5;
                    v5 = v5 * v5;
                    v6 = b * c;
                    v7 = v5 - v6 + 12;
                    v8 = Math.Sqrt(v6);                       //расчет корня
                    v8 -= 3;                                  //сахар
                    Y = v7 / v8;
                    Y = Math.Round(Y, 3);
                    textBoxRez.Text = Y.ToString();
                }
            }
            catch (DivideByZeroException)
            {
                errors("Ошибка. Исключение деления на ноль.");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                errors("Исключение аргумента вне диапазона. Ошибка: " + aoore.Message);
            }
            catch (OperationCanceledException oce)
            {
                errors("Исключение отмены операции. Ошибка: " + oce.Message);
            }
            catch (FormatException fe)
            {
                errors("Исключение формата. Ошибка: " + fe.Message);
            }
            catch (Exception ex)
            {
                errors("Что то пошло не так. Ошибка: " + ex.Message);
            }
        }
        private void errors(String W)
        {
            MessageBox.Show(W, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxRez.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxRez.Clear();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
