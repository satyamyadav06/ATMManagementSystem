using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class FrmDashboard : Form
    {
        private string loggedInAccount;

        public FrmDashboard(string accountNumber)
        {
            InitializeComponent();
            loggedInAccount = accountNumber;
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT Balance
                             FROM Accounts
                             WHERE AccountNumber = @AccountNumber";

                    using (var command =
                        new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@AccountNumber", loggedInAccount);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            decimal balance = Convert.ToDecimal(result);

                            MessageBox.Show(
                                "Available Balance: ₹" + balance.ToString("N2"),
                                "Account Balance");
                        }
                        else
                        {
                            MessageBox.Show("Account not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
