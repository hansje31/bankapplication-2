using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool loginEnabled1;
        bool loginEnabled2;
        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            loginEnabled1 = txtAccountNumber.Text != "";
            CheckButton();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            loginEnabled2 = txtPassword.Text != "";
            CheckButton();
        }
        private void CheckButton()
        {
            btnLogin.Enabled = loginEnabled1 && loginEnabled2;
        }
    }
}
