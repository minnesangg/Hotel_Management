using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchForm : Form
    {
        const string connectionString = "Data Source=(local);Initial Catalog=HotelManagment;Integrated Security=True";
        private SqlConnection cnn = new SqlConnection(connectionString);
        private DataTable dtReservations = new DataTable();
        private BindingSource bsReservations = new BindingSource();

        public SearchForm()
        {
            InitializeComponent();
            txtDepartment.TextChanged += txtDepartment_TextChanged; // Оставляем txtDepartment как есть
            listBox1.DoubleClick += listBox1_DoubleClick; // Подписка на событие двойного клика
            LoadData(); // Загружаем все данные при инициализации формы
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Если поле поиска пустое, очищаем список
                if (string.IsNullOrEmpty(txtDepartment.Text))
                {
                    listBox1.DataSource = null;
                    return;
                }

                // Формируем SQL-запрос для поиска по имени резервирования (ReservName)
                string query = "SELECT ReservName FROM reservations WHERE ReservName LIKE @namePart ORDER BY ReservName";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@namePart", txtDepartment.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtReservations.Clear(); // Очищаем старые данные
                    da.Fill(dtReservations); // Заполняем DataTable с результатами поиска
                }

                // Если есть результаты, показываем их в ListBox
                if (dtReservations.Rows.Count > 0)
                {
                    bsReservations.DataSource = dtReservations;
                    listBox1.DataSource = bsReservations;
                    listBox1.DisplayMember = "ReservName"; // Отображаем только имя резервирования
                }
                else
                {
                    listBox1.DataSource = null; // Если нет данных, очищаем ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Обработка события двойного клика по элементу в ListBox
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    // Получаем выбранное имя резервирования
                    DataRowView dr = (DataRowView)listBox1.SelectedItem;
                    string selectedReservName = dr["ReservName"].ToString(); // Получаем имя из выбранной строки

                    // Запрос для получения всех данных по выбранному резервированию
                    string query = "SELECT * FROM reservations WHERE ReservName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedReservName);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Отображаем все данные по выбранному резервированию в DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка отображения данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите резерв.");
            }
        }

        // Функция для загрузки всех данных из таблицы reservations
        private void LoadData()
        {
            try
            {
                // Загружаем все данные из таблицы reservations для отображения в dataGridView1
                string query = "SELECT * FROM reservations";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; // Загружаем все данные в DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
}
