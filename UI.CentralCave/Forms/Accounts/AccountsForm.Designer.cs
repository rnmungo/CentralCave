
namespace UI.CentralCave.Forms.Accounts
{
    partial class AccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCBUSA = new System.Windows.Forms.Label();
            this.lbCUIT = new System.Windows.Forms.Label();
            this.lbCBUW = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSeeSavingAccount = new System.Windows.Forms.Button();
            this.btnSeeWallet = new System.Windows.Forms.Button();
            this.btnDepositARS = new System.Windows.Forms.Button();
            this.btnDepositBTC = new System.Windows.Forms.Button();
            this.btnTransferBTC = new System.Windows.Forms.Button();
            this.btnTransferARS = new System.Windows.Forms.Button();
            this.btnBuyBTC = new System.Windows.Forms.Button();
            this.btnBuyARS = new System.Windows.Forms.Button();
            this.tbARS = new System.Windows.Forms.NumericUpDown();
            this.tbBTC = new System.Windows.Forms.NumericUpDown();
            this.lbSaldoARS = new System.Windows.Forms.Label();
            this.lbSaldoBTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbARS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovements
            // 
            this.dgvMovements.AllowUserToAddRows = false;
            this.dgvMovements.AllowUserToDeleteRows = false;
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedAt,
            this.Reason,
            this.IdTransaction,
            this.Amount});
            this.dgvMovements.Location = new System.Drawing.Point(15, 242);
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.ReadOnly = true;
            this.dgvMovements.Size = new System.Drawing.Size(515, 190);
            this.dgvMovements.TabIndex = 0;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Fecha";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 120;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Motivo";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // IdTransaction
            // 
            this.IdTransaction.HeaderText = "Nr. Operación";
            this.IdTransaction.Name = "IdTransaction";
            this.IdTransaction.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Monto";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Últimos movimientos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cuentas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Caja de ahorro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCBUSA
            // 
            this.lbCBUSA.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCBUSA.Location = new System.Drawing.Point(13, 61);
            this.lbCBUSA.Name = "lbCBUSA";
            this.lbCBUSA.Size = new System.Drawing.Size(180, 21);
            this.lbCBUSA.TabIndex = 10;
            this.lbCBUSA.Text = "CBU:";
            this.lbCBUSA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCUIT
            // 
            this.lbCUIT.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUIT.Location = new System.Drawing.Point(13, 82);
            this.lbCUIT.Name = "lbCUIT";
            this.lbCUIT.Size = new System.Drawing.Size(139, 21);
            this.lbCUIT.TabIndex = 11;
            this.lbCUIT.Text = "CUIT:";
            this.lbCUIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCBUW
            // 
            this.lbCBUW.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCBUW.Location = new System.Drawing.Point(274, 61);
            this.lbCBUW.Name = "lbCBUW";
            this.lbCBUW.Size = new System.Drawing.Size(172, 21);
            this.lbCBUW.TabIndex = 13;
            this.lbCBUW.Text = "CBU:";
            this.lbCBUW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Billetera virtual (BTC)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "(ARS)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "(BTC)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeeSavingAccount
            // 
            this.btnSeeSavingAccount.BackColor = System.Drawing.Color.Indigo;
            this.btnSeeSavingAccount.FlatAppearance.BorderSize = 0;
            this.btnSeeSavingAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeSavingAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeeSavingAccount.Location = new System.Drawing.Point(148, 37);
            this.btnSeeSavingAccount.Name = "btnSeeSavingAccount";
            this.btnSeeSavingAccount.Size = new System.Drawing.Size(119, 23);
            this.btnSeeSavingAccount.TabIndex = 16;
            this.btnSeeSavingAccount.Text = "VER MOVIMIENTOS";
            this.btnSeeSavingAccount.UseVisualStyleBackColor = false;
            this.btnSeeSavingAccount.Click += new System.EventHandler(this.btnSeeSavingAccount_Click);
            // 
            // btnSeeWallet
            // 
            this.btnSeeWallet.BackColor = System.Drawing.Color.Indigo;
            this.btnSeeWallet.FlatAppearance.BorderSize = 0;
            this.btnSeeWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeWallet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeeWallet.Location = new System.Drawing.Point(406, 35);
            this.btnSeeWallet.Name = "btnSeeWallet";
            this.btnSeeWallet.Size = new System.Drawing.Size(119, 23);
            this.btnSeeWallet.TabIndex = 17;
            this.btnSeeWallet.Text = "VER MOVIMIENTOS";
            this.btnSeeWallet.UseVisualStyleBackColor = false;
            this.btnSeeWallet.Click += new System.EventHandler(this.btnSeeWallet_Click);
            // 
            // btnDepositARS
            // 
            this.btnDepositARS.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDepositARS.FlatAppearance.BorderSize = 0;
            this.btnDepositARS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositARS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepositARS.Location = new System.Drawing.Point(15, 123);
            this.btnDepositARS.Name = "btnDepositARS";
            this.btnDepositARS.Size = new System.Drawing.Size(119, 23);
            this.btnDepositARS.TabIndex = 18;
            this.btnDepositARS.Text = "DEPOSITAR (ARS)";
            this.btnDepositARS.UseVisualStyleBackColor = false;
            this.btnDepositARS.Click += new System.EventHandler(this.btnDepositARS_Click);
            // 
            // btnDepositBTC
            // 
            this.btnDepositBTC.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDepositBTC.FlatAppearance.BorderSize = 0;
            this.btnDepositBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositBTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepositBTC.Location = new System.Drawing.Point(277, 123);
            this.btnDepositBTC.Name = "btnDepositBTC";
            this.btnDepositBTC.Size = new System.Drawing.Size(119, 23);
            this.btnDepositBTC.TabIndex = 19;
            this.btnDepositBTC.Text = "DEPOSITAR (BTC)";
            this.btnDepositBTC.UseVisualStyleBackColor = false;
            this.btnDepositBTC.Click += new System.EventHandler(this.btnDepositBTC_Click);
            // 
            // btnTransferBTC
            // 
            this.btnTransferBTC.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTransferBTC.FlatAppearance.BorderSize = 0;
            this.btnTransferBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferBTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransferBTC.Location = new System.Drawing.Point(406, 123);
            this.btnTransferBTC.Name = "btnTransferBTC";
            this.btnTransferBTC.Size = new System.Drawing.Size(119, 23);
            this.btnTransferBTC.TabIndex = 20;
            this.btnTransferBTC.Text = "TRANSFERIR";
            this.btnTransferBTC.UseVisualStyleBackColor = false;
            this.btnTransferBTC.Click += new System.EventHandler(this.btnTransferBTC_Click);
            // 
            // btnTransferARS
            // 
            this.btnTransferARS.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTransferARS.FlatAppearance.BorderSize = 0;
            this.btnTransferARS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferARS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransferARS.Location = new System.Drawing.Point(140, 123);
            this.btnTransferARS.Name = "btnTransferARS";
            this.btnTransferARS.Size = new System.Drawing.Size(119, 23);
            this.btnTransferARS.TabIndex = 21;
            this.btnTransferARS.Text = "TRANSFERIR";
            this.btnTransferARS.UseVisualStyleBackColor = false;
            this.btnTransferARS.Click += new System.EventHandler(this.btnTransferARS_Click);
            // 
            // btnBuyBTC
            // 
            this.btnBuyBTC.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBuyBTC.FlatAppearance.BorderSize = 0;
            this.btnBuyBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyBTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyBTC.Location = new System.Drawing.Point(15, 152);
            this.btnBuyBTC.Name = "btnBuyBTC";
            this.btnBuyBTC.Size = new System.Drawing.Size(119, 23);
            this.btnBuyBTC.TabIndex = 22;
            this.btnBuyBTC.Text = "COMPRAR BTC";
            this.btnBuyBTC.UseVisualStyleBackColor = false;
            this.btnBuyBTC.Click += new System.EventHandler(this.btnBuyBTC_Click);
            // 
            // btnBuyARS
            // 
            this.btnBuyARS.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBuyARS.FlatAppearance.BorderSize = 0;
            this.btnBuyARS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyARS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyARS.Location = new System.Drawing.Point(277, 152);
            this.btnBuyARS.Name = "btnBuyARS";
            this.btnBuyARS.Size = new System.Drawing.Size(119, 23);
            this.btnBuyARS.TabIndex = 23;
            this.btnBuyARS.Text = "COMPRAR ARS";
            this.btnBuyARS.UseVisualStyleBackColor = false;
            this.btnBuyARS.Click += new System.EventHandler(this.btnBuyARS_Click);
            // 
            // tbARS
            // 
            this.tbARS.DecimalPlaces = 2;
            this.tbARS.Location = new System.Drawing.Point(16, 185);
            this.tbARS.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbARS.Name = "tbARS";
            this.tbARS.Size = new System.Drawing.Size(147, 20);
            this.tbARS.TabIndex = 24;
            // 
            // tbBTC
            // 
            this.tbBTC.DecimalPlaces = 9;
            this.tbBTC.Location = new System.Drawing.Point(277, 185);
            this.tbBTC.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbBTC.Name = "tbBTC";
            this.tbBTC.Size = new System.Drawing.Size(147, 20);
            this.tbBTC.TabIndex = 25;
            // 
            // lbSaldoARS
            // 
            this.lbSaldoARS.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoARS.Location = new System.Drawing.Point(12, 102);
            this.lbSaldoARS.Name = "lbSaldoARS";
            this.lbSaldoARS.Size = new System.Drawing.Size(40, 21);
            this.lbSaldoARS.TabIndex = 26;
            this.lbSaldoARS.Text = "Saldo:";
            this.lbSaldoARS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSaldoBTC
            // 
            this.lbSaldoBTC.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoBTC.Location = new System.Drawing.Point(274, 83);
            this.lbSaldoBTC.Name = "lbSaldoBTC";
            this.lbSaldoBTC.Size = new System.Drawing.Size(40, 21);
            this.lbSaldoBTC.TabIndex = 27;
            this.lbSaldoBTC.Text = "Saldo:";
            this.lbSaldoBTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(544, 440);
            this.Controls.Add(this.lbSaldoBTC);
            this.Controls.Add(this.lbSaldoARS);
            this.Controls.Add(this.tbBTC);
            this.Controls.Add(this.tbARS);
            this.Controls.Add(this.btnBuyARS);
            this.Controls.Add(this.btnBuyBTC);
            this.Controls.Add(this.btnTransferARS);
            this.Controls.Add(this.btnTransferBTC);
            this.Controls.Add(this.btnDepositBTC);
            this.Controls.Add(this.btnDepositARS);
            this.Controls.Add(this.btnSeeWallet);
            this.Controls.Add(this.btnSeeSavingAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbCBUW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCUIT);
            this.Controls.Add(this.lbCBUSA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMovements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbARS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCBUSA;
        private System.Windows.Forms.Label lbCUIT;
        private System.Windows.Forms.Label lbCBUW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSeeSavingAccount;
        private System.Windows.Forms.Button btnSeeWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnDepositARS;
        private System.Windows.Forms.Button btnDepositBTC;
        private System.Windows.Forms.Button btnTransferBTC;
        private System.Windows.Forms.Button btnTransferARS;
        private System.Windows.Forms.Button btnBuyBTC;
        private System.Windows.Forms.Button btnBuyARS;
        private System.Windows.Forms.NumericUpDown tbARS;
        private System.Windows.Forms.NumericUpDown tbBTC;
        private System.Windows.Forms.Label lbSaldoARS;
        private System.Windows.Forms.Label lbSaldoBTC;
    }
}