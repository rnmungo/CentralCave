using System;
using System.ComponentModel;
using System.Windows.Forms;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Contracts;
using BLL.CentralCave.Services;
using Domain.CentralCave;
using SL.CentralCave.Services;

namespace UI.CentralCave
{
    public partial class MainForm : Form
    {
        private User _user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _user = UserService.Current.Login(tbName.Text, tbPassword.Text);
                tbName.ReadOnly = true;
                tbPassword.ReadOnly = true;
                btnLogin.Enabled = false;
            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show(LanguageManager.Current.Translate(ex.Message));
            }
        }
    }
}
