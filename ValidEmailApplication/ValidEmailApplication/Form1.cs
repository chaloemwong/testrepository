using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidEmailApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IsEmailValid(email.Text));
        }
        public string IsEmailValid(string email)
        {
            string pattern = //"^([*]{1}$|([0-9a-zA-Z]*([-.\\w]*[0-9a-zA-Z]*[-\\w])[@]([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9}[,]?)+$)";
            "^([*]{1}$|([0-9a-zA-Z]*([-.\\w]*[0-9a-zA-Z]*[-\\w])[@]([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})([,][0-9a-zA-Z]*([-.\\w]*[0-9a-zA-Z]*[-\\w])[@]([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})*$)";
                   //"^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z]*[-\\w])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(email, pattern))
                return "Success";
            else
               return "Fail";
        }
    }
}
