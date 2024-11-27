using Microsoft.VisualBasic.Devices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagment
{
    public partial class AddGuestForm : Form
    {
        private SqlConnection connection;

        public AddGuestForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=(local); Initial Catalog=HotelManagment; Integrated Security=True";
            connection = new SqlConnection(connectionString);
            this.btnAddGuest.Click += new System.EventHandler(this.AddButton_Click);
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.ReadOnly = true;
            LoadData("SELECT * FROM Guests");
        }

        private void LoadData(string query)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dgvGuests.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Немає даних для відображення.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAim.Text) ||
                    string.IsNullOrEmpty(checkBoxCash.Text) || string.IsNullOrEmpty(txtComment.Text) ||
                    string.IsNullOrEmpty(txtDate.Text) || string.IsNullOrEmpty(txtDepartureDate.Text) ||
                    string.IsNullOrEmpty(txtGuestID.Text) || string.IsNullOrEmpty(txtMoney.Text) ||
                    string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassport.Text) ||
                    string.IsNullOrEmpty(txtReceipt.Text) || string.IsNullOrEmpty(txtRegion.Text) ||
                    string.IsNullOrEmpty(txtRegistrar.Text) || string.IsNullOrEmpty(txtTown.Text) ||
                    string.IsNullOrEmpty(txtWork.Text) || string.IsNullOrEmpty(txtYear.Text))
                {
                    MessageBox.Show("Усі поля повинні бути заповнені.");
                    return;
                }
                string insertQuery = @"
                    INSERT INTO Guests (Address, Aim, Cash, Comment, Date, DepartureDate, GuestID, Money, Name, 
                        Passport, PassportDate, Receipt, Region, Registrar, Town, Work, Year)
                    VALUES (@Address, @Aim, @Cash, @Comment, @Date, @DepartureDate, @GuestID, @Money, @Name, 
                        @Passport, @PassportDate, @Receipt, @Region, @Registrar, @Town, @Work, @Year)";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@Aim", txtAim.Text);
                command.Parameters.AddWithValue("@Cash", checkBoxCash.Checked);
                command.Parameters.AddWithValue("@Comment", txtComment.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(txtDate.Text));
                command.Parameters.AddWithValue("@DepartureDate", DateTime.Parse(txtDepartureDate.Text));
                command.Parameters.AddWithValue("@GuestID", Convert.ToInt32(txtGuestID.Text));
                command.Parameters.AddWithValue("@Money", Convert.ToDecimal(txtMoney.Text));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Passport", txtPassport.Text);
                command.Parameters.AddWithValue("@PassportDate", DateTime.Parse(txtPassportDate.Text));
                command.Parameters.AddWithValue("@Receipt", txtReceipt.Text);
                command.Parameters.AddWithValue("@Region", txtRegion.Text);
                command.Parameters.AddWithValue("@Registrar", txtRegistrar.Text);
                command.Parameters.AddWithValue("@Town", txtTown.Text);
                command.Parameters.AddWithValue("@Work", txtWork.Text);
                command.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Гість успішно доданий.");
                LoadData("SELECT * FROM Guests");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання гостя: " + ex.Message);
                connection.Close();
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGuests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Виберіть рядок для оновлення.");
                    return;
                }

                DateTime date, departureDate, passportDate;

                if (!DateTime.TryParse(txtDate.Text, out date) ||
                    !DateTime.TryParse(txtDepartureDate.Text, out departureDate) ||
                    !DateTime.TryParse(txtPassportDate.Text, out passportDate))
                {
                    MessageBox.Show("Невірний формат дати.");
                    return;
                }

                string updateQuery = @"
            UPDATE Guests SET Address = @Address, Aim = @Aim, Cash = @Cash, Comment = @Comment,
            Date = @Date, DepartureDate = @DepartureDate, Money = @Money, Name = @Name,
            Passport = @Passport, PassportDate = @PassportDate, Receipt = @Receipt, Region = @Region,
            Registrar = @Registrar, Town = @Town, Work = @Work, Year = @Year
            WHERE GuestID = @GuestID";

                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@Aim", txtAim.Text);
                command.Parameters.AddWithValue("@Cash", checkBoxCash.Checked);
                command.Parameters.AddWithValue("@Comment", txtComment.Text);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@DepartureDate", departureDate);
                command.Parameters.AddWithValue("@Money", Convert.ToDecimal(txtMoney.Text));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Passport", txtPassport.Text);
                command.Parameters.AddWithValue("@PassportDate", passportDate);
                command.Parameters.AddWithValue("@Receipt", txtReceipt.Text);
                command.Parameters.AddWithValue("@Region", txtRegion.Text);
                command.Parameters.AddWithValue("@Registrar", txtRegistrar.Text);
                command.Parameters.AddWithValue("@Town", txtTown.Text);
                command.Parameters.AddWithValue("@Work", txtWork.Text);
                command.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));
                command.Parameters.AddWithValue("@GuestID", Convert.ToInt32(dgvGuests.SelectedRows[0].Cells["GuestID"].Value)); // Используем выбранный ID

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Дані успішно оновлені.");
                LoadData("SELECT * FROM Guests");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення даних: " + ex.Message);
                connection.Close();
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGuests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Виберіть рядок для видалення.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Ви дійсно хочете видалити цього гостя?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Guests WHERE GuestID = @GuestID";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@GuestID", Convert.ToInt32(dgvGuests.SelectedRows[0].Cells["GuestID"].Value));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Гість успішно видалений.");
                    LoadData("SELECT * FROM Guests");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення даних: " + ex.Message);
                connection.Close();
            }
        }

    }
}
