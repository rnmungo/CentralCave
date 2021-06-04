using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Services;
using Domain.CentralCave;

namespace UI.CentralCave.Forms.Accounts
{
    public partial class TransferForm : Form
    {
        private readonly Account _account;
        public TransferForm(Account account)
        {
            this._account = account;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCBU.Text))
            {
                MessageBox.Show("you must enter a CBU");
                return;
            }

            try
            {
                Account destination = AccountService.Current.GetByCBU(long.Parse(tbCBU.Text));
                AccountService.Current.Transfer(_account, destination, tbAmount.Value);
                MessageBox.Show("the transfer was successful");
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("enter only numbers");
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
