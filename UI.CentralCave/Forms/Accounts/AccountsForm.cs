using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Services;
using Domain.CentralCave;

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
            dgvMovements.Rows.Clear();
            foreach (Movement movement in movements)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvMovements);
                fila.Cells[0].Value = movement.CreatedAt.ToShortDateString();
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
            decimal saldoARS = AccountService.Current.GetSaldo(_user.SavingAccount);
            decimal saldoBTC = AccountService.Current.GetSaldo(_user.Wallet);
            lbSaldoARS.Text = $"Saldo: {string.Format("{0:C}", saldoARS)}";
            lbSaldoBTC.Text = $"Saldo: {string.Format("{0:C}", saldoBTC)}";
        }

        private void btnDepositARS_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.Deposit(_user.SavingAccount, tbARS.Value);
                MessageBox.Show("the deposit was successful");
                LoadAccountsData();
                tbARS.Value = 0;
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransferARS_Click(object sender, EventArgs e)
        {
            TransferForm form = new TransferForm(_user.SavingAccount);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAccountsData();
            }
        }

        private void btnBuyBTC_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.ConvertTo(_user.SavingAccount, _user.Wallet, tbARS.Value);
                MessageBox.Show("the purchase was successful");
                LoadAccountsData();
                tbARS.Value = 0;
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDepositBTC_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.Deposit(_user.Wallet, tbBTC.Value);
                MessageBox.Show("the deposit was successful");
                LoadAccountsData();
                tbBTC.Value = 0;
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransferBTC_Click(object sender, EventArgs e)
        {
            TransferForm form = new TransferForm(_user.Wallet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAccountsData();
            }
        }

        private void btnBuyARS_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService.Current.ConvertTo(_user.Wallet, _user.SavingAccount, tbBTC.Value);
                MessageBox.Show("the purchase was successful");
                LoadAccountsData();
                tbBTC.Value = 0;
            }
            catch (InvalidTransactionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
