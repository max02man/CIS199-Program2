//Alaa Hawsawi 
//CIS199-01  
//Date:10-27-2014
//This program will tell you when you register day and time by enter the first letter of your last name and what year they are
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class program2 : Form
    {

        public program2()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            char firstletter;
            char.TryParse(firstletter_textBox.Text, out firstletter);
           
            firstletter=char.ToUpper(firstletter);
            //time and date for senior
            if (SENIOR_radioButton.Checked)
            {
                result_label.Text = "FRIDAY, NOV 7";

                if (firstletter >= 'A' && firstletter <= 'D')
                {
                    result_label.Text += " at 10:00am";
                }
                else if (firstletter >= 'E' && firstletter <= 'I')
                {
                    result_label.Text += " at 11:30am";
                }
                else if (firstletter >= 'J' && firstletter <= 'O')
                {
                    result_label.Text += " at 2:00pm";
                }
                else if (firstletter >= 'P' && firstletter <= 'R')
                {
                    result_label.Text += " at 4:00pm";
                }
                else if (firstletter >= 'S' && firstletter <= 'Z')
                {
                    result_label.Text += " at 8:30am";
                }
            }
                //time and date for junior

            else if (JUNIOR_radioButton.Checked)
            {
                result_label.Text = "MONDAY, NOV 10 ";
                if (firstletter >= 'A' && firstletter <= 'D')
                {
                    result_label.Text += " at 10:00am";
                }
                else if (firstletter >= 'E' && firstletter <= 'I')
                {
                    result_label.Text += " at 11:30am";
                }
                else if (firstletter >= 'J' && firstletter <= 'O')
                {
                    result_label.Text += " at 2:00pm";
                }
                else if (firstletter >= 'P' && firstletter <= 'R')
                {
                    result_label.Text += " at 4:00pm";
                }
                else if (firstletter >= 'S' && firstletter <= 'Z')
                {
                    result_label.Text += " at 8:30am";
                }
            }
                //date for sophomore
            else if (SOPHOMORE_radioButton.Checked)
            {
                result_label.Text = "TUESDAY, NOV ";
                if (firstletter >= 'E' && firstletter <= 'R')                
                 result_label.Text += "12 ";                
                else 
                 result_label.Text += "11 ";
            }
            //date for freachman
            else
            {
                result_label.Text = "THURSDAY, NOV ";
              if (firstletter >= 'E' && firstletter <= 'R')                
                 result_label.Text += "13 ";                
                else 
                 result_label.Text += "14 ";            
            }
                //time freachman and saphmore
                if (firstletter >= 'S' && firstletter <= 'T')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 8:30am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 8:30am";
                }
                else if (firstletter >= 'U' && firstletter <= 'V')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 10:00am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 10:00am";
                }
                else if (firstletter >= 'W' && firstletter <= 'Z')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 11:30am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 11:30am";
                }
                else if (firstletter >= 'A' && firstletter <= 'B')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 2:00pm";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 2:00pm";
                }
                else if (firstletter >= 'C' && firstletter <= 'D')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 4:00pm";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 4:00pm";
                }
                else if (firstletter >= 'E' && firstletter <= 'F')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 8:30am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 8:30am";
                }
                else if (firstletter >= 'G' && firstletter <= 'I')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += " at 10:00am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 10:00am";
                }
                else if (firstletter >= 'J' && firstletter <= 'L')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 11:30am";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 11:30am";
                }
                else if (firstletter >= 'M' && firstletter <= 'O')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 2:00pm";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 2:00pm";
                }
                else if (firstletter >= 'P' && firstletter <= 'R')
                {
                    if (FRESHMAN_radioButton.Checked)
                        result_label.Text += "at 4:00pm";
                    else if (SOPHOMORE_radioButton.Checked)
                        result_label.Text += "at 4:00pm";
                }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


                           
    

