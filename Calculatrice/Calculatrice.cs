using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        double total = 1;
        String calcul = "";
        String value = "";
        String btn_value;
        String last_operand = "*";
        bool b_total = false;

        public Calculatrice()
        {
            InitializeComponent();
        }




        /// NUMBERS
        /// 
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_0.Text);
        }        

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_1.Text);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_2.Text);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_3.Text);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_4.Text);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_5.Text);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_6.Text);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_7.Text);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_8.Text);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeNumber(); }
            AddValue(btn_9.Text);
        }
        /// END NUMBERS
        /// 
        /// CALCUL
        private void Compute()
        {
            switch (last_operand)
            {
                case "/":
                    if (Double.Parse(value) != 0) { total = total / Double.Parse(value); }
                    break;
                case "*":
                    total = total * Double.Parse(value);
                    break;
                case "-":
                    total = total - Double.Parse(value);
                    break;
                case "+":
                    total = total + Double.Parse(value);
                    break;
            }
            value = "";
        }

        private void AddValue(String t_value)
        {
            calcul = calcul + t_value;
            value = value + t_value;
            txt_display.Text = calcul;
        }

        private void ResetComputeNumber()
        {
            calcul = "";
            value = "";
            last_operand = "*";
            total = 1;
            b_total = false;
            txt_display.Text = "";
        }

        /// OPERAND
        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeOperand(); }
            btn_value = btn_divide.Text;
            calcul = calcul + btn_value;
            txt_display.Text = calcul;
            Compute();
            last_operand = "/";
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeOperand(); }
            btn_value = btn_multiply.Text;
            calcul = calcul + btn_value;
            txt_display.Text = calcul;
            Compute();
            last_operand = "*";
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeOperand(); }
            btn_value = btn_substract.Text;
            calcul = calcul + btn_value; 
            txt_display.Text = calcul;
            Compute();
            last_operand = "-";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (b_total) { ResetComputeOperand(); }
            btn_value = btn_add.Text;
            calcul = calcul + btn_value;
            txt_display.Text = calcul;
            Compute();
            last_operand = "+";
        }
        /// END OPERAND
        /// 
        private void ResetComputeOperand()
        {
            calcul = total.ToString();
            value = "0";
            last_operand = "1";
            b_total = false;
            txt_display.Text = calcul;
        }
        /// 
        /// TRUCS BIZARRES
        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (!b_total) { AddValue(btn_decimal.Text); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteLastCharacter();
        }

        private void btn_opposed_Click(object sender, EventArgs e)
        {
            // TO DO
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            DeleteLastCharacter();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            ResetComputeNumber();
        }

        // FUNCTION
        private void DeleteLastCharacter()
        {
            if (calcul.Length > 0)
            { 
                if (' '.Equals(calcul.ElementAt(calcul.Length - 1)))
                {
                    calcul = calcul.Remove(calcul.Length - 3, 3);
                }
                else
                {
                    calcul = calcul.Remove(calcul.Length - 1, 1);
                    if (value.Length > 0) { value = value.Remove(value.Length - 1, 1); }
                }
                txt_display.Text = calcul;
                if (calcul.Length == 0) { ResetComputeNumber(); }
            }
        }
        /// 
        /// TOTAL
        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!b_total)
            {
                Compute();
                txt_display.AppendText("\n");
                txt_display.AppendText(total.ToString());
                b_total = true;
            }
        }
    }
}
