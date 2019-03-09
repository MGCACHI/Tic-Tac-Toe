using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        List<Button> text = new List<Button>();
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by ARchil :D");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";
                turn = false;
            }
            else
            {
                b.Text = "O";
                turn = true;
            }
            b.Enabled = false;

            turn_count++;
             
            checker();
        }
        //Checker
        private void checker()
        {
            text.Add(A1);
            text.Add(A2);
            text.Add(A3);
            text.Add(B1);
            text.Add(B2);
            text.Add(B3);
            text.Add(C1);
            text.Add(C2);
            text.Add(C3);
            bool winner = false;
            //Horizontal
            foreach (Button item in text)
            {
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                {
                    B1.Text = null;
                    B2.Text = null;
                    B3.Text = null;
                    C1.Text = null;
                    C2.Text = null;
                    C3.Text = null;

                    winner = true;
                    if((item.Text=="X"||item.Text=="O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                {
                    A1.Text = null;
                    A2.Text = null;
                    A3.Text = null;
                    C1.Text = null;
                    C2.Text = null;
                    C3.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                {
                    A1.Text = null;
                    A2.Text = null;
                    A3.Text = null;
                    B1.Text = null;
                    B2.Text = null;
                    B3.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                //Vertical
                if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                {
                    A2.Text = null;
                    B2.Text = null;
                    C2.Text = null;
                    A3.Text = null;
                    B3.Text = null;
                    C3.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                {
                    A1.Text = null;
                    B1.Text = null;
                    C1.Text = null;
                    A3.Text = null;
                    B3.Text = null;
                    C3.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                {
                    A1.Text = null;
                    B1.Text = null;
                    C1.Text = null;
                    A2.Text = null;
                    B2.Text = null;
                    C2.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                //Diagonal
                if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                {
                    A2.Text = null;
                    A3.Text = null;
                    B3.Text = null;
                    B1.Text = null;
                    C1.Text = null;
                    C2.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
                else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                {
                    A1.Text = null;
                    A2.Text = null;
                    B1.Text = null;
                    B3.Text = null;
                    C3.Text = null;
                    C2.Text = null;

                    winner = true;
                    if ((item.Text == "X" || item.Text == "O") && (!item.Enabled))
                    {
                        item.BackColor = Color.LightBlue;
                        item.ForeColor = Color.Red;
                    }
                }
            }
            if (winner)
            {
                Disabledbuttons();

                string win = "";
                if(turn)
                {
                    win = "O";
                    
                }
                else
                {
                    win = "X";
                    
                }
                MessageBox.Show("wins" + "----" + win);
            }
            else if(turn_count==9)
            {
                MessageBox.Show("Draw");  
            }
        }

        //Disabledbuttons
        private void Disabledbuttons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    A1.Text = null;
                    A2.Text = null;
                    A3.Text = null;
                    B1.Text = null;
                    B2.Text = null;
                    B3.Text = null;
                    C1.Text = null;
                    C2.Text = null;
                    C3.Text = null;

                    b.BackColor = Color.Gainsboro;
                }
            }
            catch { }
            
        }
        //hover
        private void Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
                b.ForeColor = Color.Blue;
            } 
            else
            {
                b.Text = "O";
                b.ForeColor = Color.Red;
            }
        }

        private void Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                b.Text = null;
            }
        }
        //hover
    }
}
