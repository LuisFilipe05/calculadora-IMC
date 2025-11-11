using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_imc_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNumber(object sender, EventArgs e)
        {
            if ((sender as Button).Text == ",")
            {
                if (txtPeso.BackColor == Color.Red)
                {
                    if (!txtPeso.Text.Contains(","))
                    {
                        txtPeso.Text += (sender as Button).Text;
                    }
                }

                if (txtPeso.BackColor == Color.Red)
                {
                    if (!txtPeso.Text.Contains(","))
                    {
                        txtP            eso.Text += (sender as Button).Text;
                    }
                }
            }
            else
            {
                if (txtPeso.BackColor == Color.Red)
                {
                    txtPeso.Text += ((Button)sender).Text;



                }
                else if (txtAltura.BackColor == Color.Red)
                {
                    txtAltura.Text += ((Button)sender).Text;
                }
            }
        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;   
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;  
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            { 
                txtPeso.ResetText();
            }
            if (txtAltura.BackColor == Color.Red)
            { 
                txtAltura.ResetText();
            }

        }
    }
}
