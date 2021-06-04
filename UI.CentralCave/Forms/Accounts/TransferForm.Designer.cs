
namespace UI.CentralCave.Forms.Accounts
{
    partial class TransferForm
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCBU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransfer.Location = new System.Drawing.Point(54, 191);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(119, 23);
            this.btnTransfer.TabIndex = 22;
            this.btnTransfer.Text = "TRANSFERIR";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(179, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "CBU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.DecimalPlaces = 9;
            this.tbAmount.Location = new System.Drawing.Point(54, 121);
            this.tbAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(244, 22);
            this.tbAmount.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Monto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCBU
            // 
            this.tbCBU.Location = new System.Drawing.Point(54, 54);
            this.tbCBU.Name = "tbCBU";
            this.tbCBU.Size = new System.Drawing.Size(244, 22);
            this.tbCBU.TabIndex = 29;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(360, 233);
            this.Controls.Add(this.tbCBU);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTransfer);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCBU;
    }
}