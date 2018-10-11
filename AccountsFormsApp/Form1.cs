using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Domain;

namespace AccountsFormsApp
{
    public partial class Form1 : Form
    {

        IAccountServices acctServices = new AccountService();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string acctName = newAcctTxt.Text;
            currentAcctsList.Items.Add(acctName);

            acctServices.CreateAccount(acctName, AccountType.Silver);

            newAcctTxt.ResetText();
        }

        private void currentAcctsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBalanceLabel();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal depositAmount = decimal.Parse(depositTxt.Text);

            acctServices.Deposit(selectedAcct, depositAmount);

            depositTxt.ResetText();
            updateBalanceLabel();
        }

        private void withdrawalBtn_Click(object sender, EventArgs e)
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal withdrawalAmount = decimal.Parse(withdrawalTxt.Text);

            acctServices.Withdrawal(selectedAcct, withdrawalAmount);

            withdrawalTxt.ResetText();
            updateBalanceLabel();
        }

        private void updateBalanceLabel()
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal bal = acctServices.GetAccountBalance(selectedAcct);

            balanceTxt.Text = bal.ToString();
        }
    }
}
