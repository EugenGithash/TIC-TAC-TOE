using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
      
        private bool jucator1 = true;
        private int[,] tabla = new int[3, 3];
        const int x = 1;
        const int o = 2;

        public Form1()
        {
            InitializeComponent();
            rr();
            jucator1 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[0, 0] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[0, 0] = o;
            }

            verificareCastigator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[0, 1] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[0, 1] = o;
            }
            verificareCastigator();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[0, 2] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[0, 2] = o;
            }
            verificareCastigator();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[1, 0] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[1, 0] = o;
            }
            verificareCastigator();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[1, 1] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[1, 1] = o;
            }
            verificareCastigator();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[1, 2] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[1, 2] = o;
            }
            verificareCastigator();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[2, 0] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[2, 0] = o;
            }
            verificareCastigator();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[2, 1] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[2, 1] = o;
            }
            verificareCastigator();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                jucator1 = false;
                ((Button)sender).Text = "X";
                tabla[2, 2] = x;
            }
            else
            {
                jucator1 = true;
                ((Button)sender).Text = "O";
                tabla[2, 2] = o;
            }
            verificareCastigator();
        }
        
        private void verificareCastigator()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(tabla[i, 0]) == Convert.ToInt32(tabla[i, 1]) &&
                    Convert.ToInt32(tabla[i, 1]) == Convert.ToInt32(tabla[i, 2]) &&
                    Convert.ToInt32(tabla[i, 1]) != 0)
                {
                    
                    afisareCastigator(tabla[i, 0]);
                    return;
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(tabla[0, i]) == Convert.ToInt32(tabla[1, i]) &&
                    Convert.ToInt32(tabla[1, i]) == Convert.ToInt32(tabla[2, i]) &&
                    Convert.ToInt32(tabla[2, i]) != 0)
                {
                    
                    afisareCastigator(tabla[1, i]);
                    return;
                }
            }

            if (Convert.ToInt32(tabla[0, 0]) == Convert.ToInt32(tabla[1, 1]) &&
                Convert.ToInt32(tabla[1, 1]) == Convert.ToInt32(tabla[2, 2]) &&
                Convert.ToInt32(tabla[2, 2]) != 0)
            {
                
                afisareCastigator(tabla[1, 1]);
                return;
            }
            else if (Convert.ToInt32(tabla[0, 2]) == Convert.ToInt32(tabla[1, 1]) &&
              Convert.ToInt32(tabla[1, 1]) == Convert.ToInt32(tabla[2, 0]) &&
              Convert.ToInt32(tabla[2, 0]) != 0)
            {
                
                afisareCastigator(tabla[1, 1]);
                return;
            }

            
            bool ok = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (tabla[i, j] == 0)
                        ok = false;
            if (ok)
            {
                MessageBox.Show("Egalitate");
                rr();
            }
        }

        private void afisareCastigator(int val)
        {
            if (val == x)
            {
                MessageBox.Show("Jucatorul 1 a castigat!");
                int player1_score = Convert.ToInt32(label6.Text);
                ++player1_score;
                label6.Text = player1_score.ToString();
            }
            else
            {
                MessageBox.Show("Jucatorul 2 a castigat!");
                int player2_score = Convert.ToInt32(label7.Text);
                ++player2_score;
                label7.Text = player2_score.ToString();
            }

            rr();
        }

        private void rr()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    tabla[i, j] = 0;

            clear();
            jucator1 = true;
        }

        private void clear()
        {
        
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jucator1 == true)
            {
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.Black;  
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
