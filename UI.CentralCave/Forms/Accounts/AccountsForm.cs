using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Services;
using BLL.CentralCave.BusinessExceptions;
using Domain.CentralCave;
using SL.CentralCave.Services;

namespace UI.CentralCave.Forms.Accounts
{
    public partial class AccountsForm : Form
    {
        private readonly User _user;
        public AccountsForm(User user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void btnSeeSavingAccount_Click(object sender, EventArgs e)
        {
            List<Movement> movements = AccountService.Current.GetMovements(_user.SavingAccount);
            BindTable(movements);
        }

        private void btnSeeWallet_Click(object sender, EventArgs e)
        {
            List<Movement> movements = AccountService.Current.GetMovements(_user.Wallet);
            BindTable(movements);
        }

        private void BindTable(List<Movement> movements)
        {
            foreach (Movement movement in movements)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvMovements);
                fila.Cells[0].Value = movement.CreatedAt.ToLongDateString();
                fila.Cells[1].Value = movement.Reason.ToString();
                fila.Cells[2].Value = movement.IdTransaction.ToString();
                fila.Cells[3].Value = movement.Amount.ToString();
                dgvMovements.Rows.Add(fila);
            }
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            LoadAccountsData();
        }

        private void LoadAccountsData()
        {
            lbCBUSA.Text = $"CBU: {_user.SavingAccount.CBU}";
            lbCBUW.Text = $"CBU: {_user.Wallet.CBU}";
            lbCUIT.Text = $"CUIT: {_user.CUIT}";
            lbSaldoARS.Text = $"Saldo: {string.Format("{0:C}", AccountService.Current.GetSaldo(_user.SavingAccount))}";
            lbSaldoBTC.Text = $"Saldo: {string.Format("{0:C}", AccountService.Current.GetSaldo(_user.Wallet))}";
        }

        private void btnDepositARS_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.Deposit(_user.SavingAccount, tbARS.Value);
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(LanguageManager.Current.Translate(ex.Message));
            }
        }

        private void btnTransferARS_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyBTC_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositBTC_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.Deposit(_user.Wallet, tbBTC.Value);
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(LanguageManager.Current.Translate(ex.Message));
            }
        }

        private void btnTransferBTC_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyARS_Click(object sender, EventArgs e)
        {

        }
    }
}
