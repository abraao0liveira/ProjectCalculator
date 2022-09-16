using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; // Implementar o CultureInfo.
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class Form1 : Form
    {
        decimal value01 = 0, value02 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        #region Numbers
        private void button16_Click(object sender, EventArgs e) // Tecla 0.
        {
            txtResult.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e) // Tecla 1.
        {
            txtResult.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e) // Tecla 2.
        {
            txtResult.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e) // Tecla 3.
        {
            txtResult.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e) // Tecla 4.
        {
            txtResult.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e) // Tecla 5.
        {
            txtResult.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e) // Tecla 6.
        {
            txtResult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e) //Tecla 7.
        {
            txtResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e) // Tecla 8.
        {
            txtResult.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e) // Tecla 9.
        {
            txtResult.Text += "9";
        }
        #endregion

        #region Actions
        private void button4_Click(object sender, EventArgs e) // Adição.
        {
            if (txtResult.Text != "")
            {
                value01 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture); // Converter o valor da váriavel, de decimal para string.
                txtResult.Text = ""; // Texto vazio para receber algo.
                operation = "Sum"; // Somar.
                lblOp.Text = "+"; // Aparecer na tela o sinal de +.
            }
            else
            {
                MessageBox.Show("Informe um valor.");
            }
        }
        private void button9_Click(object sender, EventArgs e) // Subtração.
        {
            if (txtResult.Text != "")
            {
                value01 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "Decrease"; // Diminuir.
                lblOp.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor.");
            }
        }
        private void button14_Click(object sender, EventArgs e) // Mutiplicação.
        {
            if (txtResult.Text != "")
            {
                value01 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "Multiply"; // Mutiplicar.
                lblOp.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor.");
            }
        }
        private void button18_Click(object sender, EventArgs e) // Divisão.
        {
            if (txtResult.Text != "")
            {
                value01 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "Share"; // Dividir.
                lblOp.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor.");
            }
        }
        #endregion

        #region Keys
        private void button15_Click(object sender, EventArgs e) // Tecla "=".
        {
            value02 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

            switch (operation)
            {
                case "Sum":
                    txtResult.Text = Convert.ToString(value01 + value02); // Soma e depois converte decimal para string.
                    break;
                case "Decrease":
                    txtResult.Text = Convert.ToString(value01 - value02); // Diminui depois converte decimal para string.
                    break;
                case "Multiply":
                    txtResult.Text = Convert.ToString(value01 * value02); // Multiplica depois converte decimal para string.
                    break;
                case "Share":
                    txtResult.Text = Convert.ToString(value01 / value02); // Divide depois converte ddecimal para string.\
                    break;
            }
        }
        private void button5_Click(object sender, EventArgs e) // Tecla CE.
        {
            txtResult.Text = ""; // Limpa o campo.
        }

        private void button10_Click(object sender, EventArgs e) // Tecla C.
        {
            txtResult.Text = "";
            lblOp.Text = ""; // Limpa a label.
            value01 = 0;
            value02 = 0;
        }

        private void button17_Click(object sender, EventArgs e) // Tecla ".".
        {
            txtResult.Text += ".";
        }
        #endregion
    }
}
