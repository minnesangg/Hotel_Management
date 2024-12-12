using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace HotelManagment
{
    public partial class ExportForm : Form
    {
        private readonly string connectionString = "Data Source=(local); Initial Catalog=HotelManagment; Integrated Security=True";

        public ExportForm()
        {
            InitializeComponent();

            LoadTables();
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ReadOnly = true;

            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;
            btnExportToWord.Click += BtnExportToWord_Click;
        }

        private void LoadTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable schemaTable = connection.GetSchema("Tables");

                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableType = row["TABLE_TYPE"].ToString();
                    string tableName = row["TABLE_NAME"].ToString();

                    if (tableType == "BASE TABLE" && !tableName.StartsWith("sys"))
                    {
                        comboBoxTables.Items.Add(tableName);
                    }
                }
            }
        }

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTables.SelectedIndex == -1) return;

            string selectedTable = comboBoxTables.SelectedItem.ToString();
            txtTableDescription.Text = $"Вы выбрали таблицу '{selectedTable}'.";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {selectedTable}";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                connection.Open();
                da.Fill(dt);
                dataGridViewData.DataSource = dt;

                txtTableDescription.AppendText($"\r\nСтрок в таблице: {dt.Rows.Count}.");
            }
        }

        private void BtnExportToWord_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTable = comboBoxTables.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedTable))
                {
                    MessageBox.Show("Выберите таблицу для экспорта.");
                    return;
                }

                Word.Application wordApp = new Word.Application();
                string templatePath = Application.StartupPath + "\\Hotel1.docx";

                if (!System.IO.File.Exists(templatePath))
                {
                    MessageBox.Show("Файл Hotel.docx не найден!");
                    return;
                }

                Word.Document doc = wordApp.Documents.Open(templatePath);
                doc.Activate();

                switch (selectedTable)
                {
                    case "Reservations":
                        ExportReservations(doc);
                        break;
                    case "Guests":
                        ExportGuests(doc);
                        break;
                    case "Rooms":
                        ExportRooms(doc);
                        break;
                    case "RoomTypes":
                        ExportRoomTypes(doc);
                        break;
                    case "Guests_Archive":
                        ExportGuestArchive(doc);
                        break;
                    case "Accomodation":
                        ExportAccomodation(doc);
                        break;
                    default:
                        MessageBox.Show("Экспорт для данной таблицы не реализован.");
                        break;
                }

                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте: {ex.Message}");
            }
        }

        private void ExportReservations(Word.Document doc)
        {
            try
            {
                DataTable reservationsTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ReservationID, ReservName, Come, Leave, GuestID, Number FROM Reservations;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(reservationsTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (reservationsTable.Rows.Count > 0)
                {
                    DataRow row = reservationsTable.Rows[0];
                    if (bookmarks.Exists("ReservationID"))
                        bookmarks["ReservationID"].Range.Text = row["ReservationID"].ToString();
                    if (bookmarks.Exists("ReservName"))
                        bookmarks["ReservName"].Range.Text = row["ReservName"].ToString();
                    if (bookmarks.Exists("Come"))
                        bookmarks["Come"].Range.Text = DateTime.Parse(row["Come"].ToString()).ToShortDateString();
                    if (bookmarks.Exists("Leave"))
                        bookmarks["Leave"].Range.Text = DateTime.Parse(row["Leave"].ToString()).ToShortDateString();
                    if (bookmarks.Exists("GuestID"))
                        bookmarks["GuestID"].Range.Text = row["GuestID"].ToString();
                    if (bookmarks.Exists("ReservNumber"))
                        bookmarks["ReservNumber"].Range.Text = row["Number"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица Reservations не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы Reservations: {ex.Message}");
            }
        }

        private void ExportGuests(Word.Document doc)
        {
            try
            {
                DataTable guestsTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    GuestID, Name, Date, Address, Town, Aim, Passport, 
                    PassportDate, Region, Work, Year, Money, Cash, 
                    Receipt, DepartureDate, Comment, Registrar 
                FROM Guests;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(guestsTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (guestsTable.Rows.Count > 0)
                {
                    DataRow row = guestsTable.Rows[0];

                    if (bookmarks.Exists("GuestID1"))
                        bookmarks["GuestID1"].Range.Text = row["GuestID"].ToString();
                    if (bookmarks.Exists("Name"))
                        bookmarks["Name"].Range.Text = row["Name"].ToString();
                    if (bookmarks.Exists("Date"))
                        bookmarks["Date"].Range.Text = DateTime.Parse(row["Date"].ToString()).ToShortDateString();
                    if (bookmarks.Exists("Address"))
                        bookmarks["Address"].Range.Text = row["Address"].ToString();
                    if (bookmarks.Exists("Town"))
                        bookmarks["Town"].Range.Text = row["Town"].ToString();
                    if (bookmarks.Exists("Aim"))
                        bookmarks["Aim"].Range.Text = row["Aim"].ToString();
                    if (bookmarks.Exists("Passport"))
                        bookmarks["Passport"].Range.Text = row["Passport"].ToString();
                    if (bookmarks.Exists("PassportDate"))
                        bookmarks["PassportDate"].Range.Text = DateTime.Parse(row["PassportDate"].ToString()).ToShortDateString();
                    if (bookmarks.Exists("Region"))
                        bookmarks["Region"].Range.Text = row["Region"].ToString();
                    if (bookmarks.Exists("Work"))
                        bookmarks["Work"].Range.Text = row["Work"].ToString();
                    if (bookmarks.Exists("Year"))
                        bookmarks["Year"].Range.Text = row["Year"].ToString();
                    if (bookmarks.Exists("Money"))
                        bookmarks["Money"].Range.Text = row["Money"].ToString();
                    if (bookmarks.Exists("Cash"))
                        bookmarks["Cash"].Range.Text = row["Cash"].ToString();
                    if (bookmarks.Exists("Receipt"))
                        bookmarks["Receipt"].Range.Text = row["Receipt"].ToString();
                    if (bookmarks.Exists("DepartureDate"))
                        bookmarks["DepartureDate"].Range.Text = DateTime.Parse(row["DepartureDate"].ToString()).ToShortDateString();
                    if (bookmarks.Exists("Comment"))
                        bookmarks["Comment"].Range.Text = row["Comment"].ToString();
                    if (bookmarks.Exists("Registrar"))
                        bookmarks["Registrar"].Range.Text = row["Registrar"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица Guests не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы Guests: {ex.Message}");
            }
        }
        private void ExportRooms(Word.Document doc)
        {
            try
            {
                DataTable roomsTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    Number, Rooms, Storey, TV, Fridge, Bed, Type, 
                    Balcony 
                FROM Rooms;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(roomsTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (roomsTable.Rows.Count > 0)
                {
                    DataRow row = roomsTable.Rows[0];

                    if (bookmarks.Exists("Number"))
                        bookmarks["Number"].Range.Text = row["Number"].ToString();
                    if (bookmarks.Exists("Rooms"))
                        bookmarks["Rooms"].Range.Text = row["Rooms"].ToString();
                    if (bookmarks.Exists("Storey"))
                        bookmarks["Storey"].Range.Text = row["Storey"].ToString();
                    if (bookmarks.Exists("TV"))
                        bookmarks["TV"].Range.Text = row["TV"].ToString();
                    if (bookmarks.Exists("Fridge"))
                        bookmarks["Fridge"].Range.Text = row["Fridge"].ToString();
                    if (bookmarks.Exists("Bed"))
                        bookmarks["Bed"].Range.Text = row["Bed"].ToString();
                    if (bookmarks.Exists("Type"))
                        bookmarks["Type"].Range.Text = row["Type"].ToString();
                    if (bookmarks.Exists("Balcony"))
                        bookmarks["Balcony"].Range.Text = row["Balcony"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица Rooms не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы Rooms: {ex.Message}");
            }
        }
        private void ExportRoomTypes(Word.Document doc)
        {
            try
            {
                DataTable roomTypesTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    Type, TypeName 
                FROM RoomTypes;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(roomTypesTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (roomTypesTable.Rows.Count > 0)
                {
                    DataRow row = roomTypesTable.Rows[0];

                    if (bookmarks.Exists("Type"))
                        bookmarks["Type"].Range.Text = row["Type"].ToString();
                    if (bookmarks.Exists("TypeName"))
                        bookmarks["TypeName"].Range.Text = row["TypeName"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица RoomTypes не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы RoomTypes: {ex.Message}");
            }
        }

        private void ExportGuestArchive(Word.Document doc)
        {
            try
            {
                DataTable guestsArchiveTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    GuestID, Name, Money, StayEnded
                FROM Guests_Archive;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(guestsArchiveTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (guestsArchiveTable.Rows.Count > 0)
                {
                    DataRow row = guestsArchiveTable.Rows[0];

                    if (bookmarks.Exists("GuestID2"))
                        bookmarks["GuestID2"].Range.Text = row["GuestID"].ToString();
                    if (bookmarks.Exists("Name1"))
                        bookmarks["Name1"].Range.Text = row["Name"].ToString();
                    if (bookmarks.Exists("Money1"))
                        bookmarks["Money1"].Range.Text = row["Money"].ToString();
                    if (bookmarks.Exists("StayEnded"))
                        bookmarks["StayEnded"].Range.Text = row["StayEnded"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица GuestsArchive не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы GuestsArchive: {ex.Message}");
            }
        }
        private void ExportAccomodation(Word.Document doc)
        {
            try
            {
                DataTable guestsArchiveTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    GuestID, Number, Date, StayEnded
                FROM Accomodation;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(guestsArchiveTable);
                }

                Word.Bookmarks bookmarks = doc.Bookmarks;

                if (guestsArchiveTable.Rows.Count > 0)
                {
                    DataRow row = guestsArchiveTable.Rows[0];

                    if (bookmarks.Exists("GuestID3"))
                        bookmarks["GuestID3"].Range.Text = row["GuestID"].ToString();
                    if (bookmarks.Exists("Number3"))
                        bookmarks["Number3"].Range.Text = row["Number"].ToString();
                    if (bookmarks.Exists("Date1"))
                        bookmarks["Date1"].Range.Text = row["Date"].ToString();
                    if (bookmarks.Exists("End1"))
                        bookmarks["End1"].Range.Text = row["StayEnded"].ToString();
                }
                else
                {
                    MessageBox.Show("Таблица Accomodation не содержит данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте таблицы Accomodation: {ex.Message}");
            }
        }
    }
}
