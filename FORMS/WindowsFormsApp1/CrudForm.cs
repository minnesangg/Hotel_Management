using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CrudForm : Form
    {
        private SqlConnection connection;

        public CrudForm()
        {
            InitializeComponent();

            string connectionString = "Data Source=(local); Initial Catalog=HotelManagment; Integrated Security=True";
            connection = new SqlConnection(connectionString);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            LoadData("SELECT * FROM Reservations");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Reservations");
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
                    dataGridView1.DataSource = table;
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
                if (string.IsNullOrEmpty(txtCome.Text) || string.IsNullOrEmpty(txtGuestID.Text) ||
                    string.IsNullOrEmpty(txtLeave.Text) || string.IsNullOrEmpty(txtReservName.Text) ||
                    string.IsNullOrEmpty(txtReservID.Text))
                {
                    MessageBox.Show("Усі поля повинні бути заповнені.");
                    return;
                }
                string insertQuery = @"
                    INSERT INTO Reservations (Come, GuestID, Leave, ReservationID, ReservName)
                    VALUES (@Come, @GuestID, @Leave, @ReservationID, @ReservName)";
                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@Come", txtCome.Text);
                command.Parameters.AddWithValue("@GuestID", Convert.ToInt32(txtGuestID.Text)); 
                command.Parameters.AddWithValue("@Leave", txtLeave.Text);
                command.Parameters.AddWithValue("@ReservationID", Convert.ToInt32(txtReservID.Text)); 
                command.Parameters.AddWithValue("@ReservName", txtReservName.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Резервація успішно додана.");
                LoadData("SELECT * FROM Reservations");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання: " + ex.Message);
                connection.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtReservID.Text))
                {
                    MessageBox.Show("Будь ласка, введіть ID резервації для видалення.");
                    return;
                }

                string deleteQuery = "DELETE FROM Reservations WHERE ReservationID = @id";
                SqlCommand command = new SqlCommand(deleteQuery, connection);

                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtReservID.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Резервація успішно видалена.");
                LoadData("SELECT * FROM Reservations");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення: " + ex.Message);
                connection.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCome.Text) || string.IsNullOrEmpty(txtGuestID.Text) ||
                    string.IsNullOrEmpty(txtLeave.Text) || string.IsNullOrEmpty(txtReservName.Text) ||
                    string.IsNullOrEmpty(txtReservID.Text))
                {
                    MessageBox.Show("Усі поля повинні бути заповнені.");
                    return;
                }

                string updateQuery = @"
                    UPDATE Reservations 
                    SET Come = @Come, GuestID = @GuestID, Leave = @Leave, ReservName = @ReservName
                    WHERE ReservationID = @ReservationID";
                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@Come", txtCome.Text);
                command.Parameters.AddWithValue("@GuestID", Convert.ToInt32(txtGuestID.Text)); 
                command.Parameters.AddWithValue("@Leave", txtLeave.Text);
                command.Parameters.AddWithValue("@ReservName", txtReservName.Text);
                command.Parameters.AddWithValue("@ReservationID", Convert.ToInt32(txtReservID.Text)); 

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Резервація успішно оновлена.");
                LoadData("SELECT * FROM Reservations");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення: " + ex.Message);
                connection.Close();
            }
        }

     
    }
}
