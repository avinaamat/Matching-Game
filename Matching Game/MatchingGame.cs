﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matching_Game
{
    public partial class MatchingGame : Form
    {
        Label first = null;
        Label second = null;

        Random r = new Random();
        List<string> myIcons = new List<string>();/*
            {"a","a","b","b","c","c","d","d","e","e","f","f","g","g","h","h","i","i" };
        */
        
        private void AssignIcons()
        {
            //assign symnols smarter with a for loop
            for(char i = 'a'; i <= 'r'; i++)
            {
                myIcons.Add(i.ToString());
                myIcons.Add(i.ToString());
            }
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label l = control as Label;
                int ran = r.Next(myIcons.Count);
                l.Text = myIcons[ran];
                l.ForeColor = l.BackColor; // hide the image
                myIcons.RemoveAt(ran);
            }
        }

        private void label_click (object sender, EventArgs e)
        {
            // if the timer is running ignore any clicks
            if (timer1.Enabled == true)
                return;

            Label l = sender as Label;

            if (l.ForeColor == Color.Black) // the user clicked an exposed image - ignore      
                return;

            if (first == null)
            {
                l.ForeColor = Color.Black;  // expose the image
                first = l;  // assign sender to global first label var
                return;
            }

            // if the code gets this far this is second click
            second = l;
            second.ForeColor = Color.Black;

            CheckForWin();

            if (first.Text == second.Text)
            {
                first = null;
                second = null;
                return;
            }
            else
                timer1.Start();
        }

        public MatchingGame(string myString)
        {
            InitializeComponent();
            label1.Text = myString;
            AssignIcons();
            progressBar1.Value = 180;
            label18.Text = "180";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            first.ForeColor = first.BackColor;
            first = null;
            second.ForeColor = second.BackColor;
            second = null;
        }

        private void CheckForWin()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
                if (c.ForeColor == c.BackColor) return;
            timer2.Stop();
            MessageBox.Show("Way to go. You matched them all.", "Congrats");
            Application.OpenForms["UserProfile"].Close();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 1;
                label18.Text = progressBar1.Value.ToString();

                if (progressBar1.Value == 0)
                {
                    MessageBox.Show("Sorry but time has expired.", "Sorry");
                    Application.OpenForms["UserProfile"].Close();
                }
            }
        }

        //need to specify this command since first form stays open and when hitting X button program won't end
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /* if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
                 MessageBox.Show("Closed by calling Close()");
             else
                 MessageBox.Show("Closed by X or Alt+F4");*/
            Application.OpenForms["UserProfile"].Close();
        }
    }
}
