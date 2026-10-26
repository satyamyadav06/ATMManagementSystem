namespace ATM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNo.Text.Trim();
            string pin = txtPIN.Text.Trim();

            if (accountNumber == "" || pin == "")
            {
                MessageBox.Show("Please enter account number and PIN.");
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT AccountHolder
                             FROM Accounts
                             WHERE AccountNumber = @AccountNumber
                             AND PIN = @PIN";

                    using (var command = new Microsoft.Data.SqlClient.SqlCommand(
                        query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        command.Parameters.AddWithValue("@PIN", pin);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("Login successful! Welcome, " + result);

                            // Open your existing dashboard form here.
                            FrmDashboard dashboard = new FrmDashboard(accountNumber);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid account number or PIN.");
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

