using System;
using System.Windows.Forms;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Services;
using Domain.CentralCave;
using UI.CentralCave.Forms.Accounts;

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
                DisableFields();
                ClearLoginInfo();
                AccountsForm form = new AccountsForm(_user) { TopLevel = false, TopMost = true };
                rightPanel.Controls.Add(form);
                form.Show();
            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisableFields()
        {
            tbName.ReadOnly = true;
            tbPassword.ReadOnly = true;
            btnLogin.Visible = false;
            btnLogout.Visible = true;
        }

        private void EnableFields()
        {
            tbName.ReadOnly = false;
            tbPassword.ReadOnly = false;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
        }

        private void ClearLoginInfo()
        {
            tbName.Text = "";
            tbPassword.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            rightPanel.Controls.Clear();
            EnableFields();
        }
    }
}
