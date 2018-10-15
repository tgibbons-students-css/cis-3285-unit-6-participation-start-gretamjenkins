namespace AccountsFormsApp
{
    partial class Form1
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.newAcctLbl = new System.Windows.Forms.Label();
            this.newAcctTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.currentAcctLbl = new System.Windows.Forms.Label();
            this.currentAcctsList = new System.Windows.Forms.ListBox();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.balanceTxt = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.withdrawalTxt = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.titleLbl.Location = new System.Drawing.Point(12, 23);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(526, 44);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Wells Fargo Acccount Creator";
            // 
            // newAcctLbl
            // 
            this.newAcctLbl.AutoSize = true;
            this.newAcctLbl.Location = new System.Drawing.Point(27, 87);
            this.newAcctLbl.Name = "newAcctLbl";
            this.newAcctLbl.Size = new System.Drawing.Size(206, 25);
            this.newAcctLbl.TabIndex = 1;
            this.newAcctLbl.Text = "New Account Name:";
            // 
            // newAcctTxt
            // 
            this.newAcctTxt.Location = new System.Drawing.Point(240, 87);
            this.newAcctTxt.Name = "newAcctTxt";
            this.newAcctTxt.Size = new System.Drawing.Size(162, 31);
            this.newAcctTxt.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(240, 142);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(162, 47);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Account";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // currentAcctLbl
            // 
            this.currentAcctLbl.AutoSize = true;
            this.currentAcctLbl.Location = new System.Drawing.Point(42, 226);
            this.currentAcctLbl.Name = "currentAcctLbl";
            this.currentAcctLbl.Size = new System.Drawing.Size(184, 25);
            this.currentAcctLbl.TabIndex = 4;
            this.currentAcctLbl.Text = "Current Accounts:";
            // 
            // currentAcctsList
            // 
            this.currentAcctsList.FormattingEnabled = true;
            this.currentAcctsList.ItemHeight = 25;
            this.currentAcctsList.Location = new System.Drawing.Point(47, 267);
            this.currentAcctsList.Name = "currentAcctsList";
            this.currentAcctsList.Size = new System.Drawing.Size(355, 154);
            this.currentAcctsList.TabIndex = 5;
            this.currentAcctsList.SelectedIndexChanged += new System.EventHandler(this.currentAcctsList_SelectedIndexChanged);
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(470, 87);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(186, 25);
            this.balanceLbl.TabIndex = 6;
            this.balanceLbl.Text = "Account Balance: ";
            // 
            // balanceTxt
            // 
            this.balanceTxt.Location = new System.Drawing.Point(662, 84);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.ReadOnly = true;
            this.balanceTxt.Size = new System.Drawing.Size(112, 31);
            this.balanceTxt.TabIndex = 7;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(470, 226);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(85, 25);
            this.amountLbl.TabIndex = 8;
            this.amountLbl.Text = "Amount";
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(475, 267);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(141, 31);
            this.depositTxt.TabIndex = 9;
            // 
            // withdrawalTxt
            // 
            this.withdrawalTxt.Location = new System.Drawing.Point(475, 320);
            this.withdrawalTxt.Name = "withdrawalTxt";
            this.withdrawalTxt.Size = new System.Drawing.Size(141, 31);
            this.withdrawalTxt.TabIndex = 10;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(640, 261);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(150, 42);
            this.depositBtn.TabIndex = 11;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.Location = new System.Drawing.Point(640, 312);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(150, 46);
            this.withdrawalBtn.TabIndex = 12;
            this.withdrawalBtn.Text = "Withdrawal";
            this.withdrawalBtn.UseVisualStyleBackColor = true;
            this.withdrawalBtn.Click += new System.EventHandler(this.withdrawalBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.withdrawalBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.withdrawalTxt);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.balanceTxt);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.currentAcctsList);
            this.Controls.Add(this.currentAcctLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.newAcctTxt);
            this.Controls.Add(this.newAcctLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Wells Fargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label newAcctLbl;
        private System.Windows.Forms.TextBox newAcctTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label currentAcctLbl;
        private System.Windows.Forms.ListBox currentAcctsList;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.TextBox balanceTxt;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.TextBox withdrawalTxt;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawalBtn;
    }
}

