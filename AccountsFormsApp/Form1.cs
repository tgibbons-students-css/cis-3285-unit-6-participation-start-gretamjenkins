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
        // Creates the ability to use the account services file
        IAccountServices acctServices = new AccountService();

        public Form1()
        {
            InitializeComponent();
        }

        // Adds a new account to the list only if the account name is not
        // null or empty. Called when the user clicks add account
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newAcctTxt.Text))
            {
                string acctName = newAcctTxt.Text;
                currentAcctsList.Items.Add(acctName);

                acctServices.CreateAccount(acctName, AccountType.Silver);

                newAcctTxt.ResetText();
            }
        }

        // Changes the balace text when the user selected an account from the list
        private void currentAcctsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBalanceText();
        }

        // Enables the user to make a deposit into their account. Called when the 
        // deposit button is clicked. Updates the balance to reflect the change. 
        private void depositBtn_Click(object sender, EventArgs e)
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal depositAmount = decimal.Parse(depositTxt.Text);

            acctServices.Deposit(selectedAcct, depositAmount);

            depositTxt.ResetText();
            updateBalanceText();
        }

        private void withdrawalBtn_Click(object sender, EventArgs e)
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal withdrawalAmount = decimal.Parse(withdrawalTxt.Text);

            acctServices.Withdrawal(selectedAcct, withdrawalAmount);

            withdrawalTxt.ResetText();
            updateBalanceText();
        }

        // updates the amount displayed balance text box
        private void updateBalanceText()
        {
            string selectedAcct = currentAcctsList.SelectedItem.ToString();
            decimal bal = acctServices.GetAccountBalance(selectedAcct);

            balanceTxt.Text = bal.ToString();
        }
    }
}
