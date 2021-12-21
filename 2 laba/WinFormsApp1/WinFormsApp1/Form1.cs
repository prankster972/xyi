using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstNum.KeyDown -= FirstNum_KeyDown;
            FirstNum.Validating += FirstNum_Validating;
            SecondNum.Validating += FirstNum_Validating;
        }       

        private void FirstNum_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox FirstNum = sender as MaskedTextBox;
            if (FirstNum.Text.Equals(""))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                string message = "Вы не ввели число.";
                MessageBox.Show(message);
                Debug.WriteLine(message);
            }
        }

        public void FirstNum_KeyDown(object sender, KeyEventArgs e)
        {
            FirstNum.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        public void button1_Click(object sender, System.EventArgs e)
        {
            var PL1 = UInt32.MinValue;
            MinU.Text = PL1.ToString();
            var PL2 = Byte.MinValue;
            MB.Text = PL2.ToString();
            var PL3 = Int32.MinValue;
            MinI.Text = PL3.ToString();

            var PH1 = UInt32.MaxValue;
            MaxU.Text = PH1.ToString();
            var PH2 = Byte.MaxValue;
            MaxB.Text = PH2.ToString();
            var PH3 = Int32.MaxValue;
            MaxI.Text = PH3.ToString();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string check = "TP_ISTbd_lw03";
            //string xyi = "";

            if (FirstNum.Text == FirstNum.Text.IndexOf(check, 0, 13).ToString())
            {
                MinB.LinkColor = Color.Blue;
            }

            else
            {
                AnsL.Text = "dolbaeb";
            }
            
            int First;
            int Second;
            string Symb = SymbOper.Text;
            try
            {
                First = System.Convert.ToInt32(FirstNum.Text);
                Second = System.Convert.ToInt32(SecondNum.Text);
                
            }
            catch (Exception ex)
            {
                string message = "Кажется вы ввели какое-то число неверно. Попытка исправить ситуацию...";
                MessageBox.Show(message, "Обработка исключения класса " + ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNum.Text = FirstNum.Text.Replace(" ", "");
                SecondNum.Text = SecondNum.Text.Replace(" ", "");
                First = int.Parse(FirstNum.Text);
                Second = System.Convert.ToInt32(SecondNum.Text);
                Debug.WriteLine(message);
            }
            
            

            switch (Symb)
                {
                case "+":

                    AnsL.Text = "res" + (First + Second); break;

                case "-":                  
    
                    AnsL.Text = "res" + (First - Second); break;

                case "*":

                    AnsL.Text = "res" + (First * Second); break;

                case "/":

                    AnsL.Text = "res" + (First / Second); break;

                case "&":

                    int Mx = Math.Max(First, Second);
                    AnsL.Text = (Mx.ToString().PadLeft(Mx.ToString().Length + 2, '&')); break;

                case "!":
                    int Mm = Math.Min(First, Second);
                    AnsL.Text = (Mm.ToString().PadLeft(Mm.ToString().Length + 1, '!')); break;
       
            }
        }


        private void FirstNum_Leave(object sender, System.EventArgs e)
        {
            FirstNum.Focus();
            FirstNum.ForeColor = Color.Red;
        }

        public void button2_Click(object sender, System.EventArgs e)
        {
            var PD1 = Double.MinValue;
            DMT.Text = PD1.ToString();
            var PD2 = Double.MaxValue;
            D_M.Text = PD2.ToString();           
        }
    }
}