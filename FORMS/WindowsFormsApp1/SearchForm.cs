using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagment
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
            txtDepartment.TextChanged += txtDepartment_TextChanged; 
            listBox1.DoubleClick += listBox1_DoubleClick; 
            LoadData(); 
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDepartment.Text))
                {
                    listBox1.DataSource = null;
                    return;
                }

                string query = "SELECT ReservName FROM reservations WHERE ReservName LIKE @namePart ORDER BY ReservName";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@namePart", txtDepartment.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtReservations.Clear(); 
                    da.Fill(dtReservations); 
                }

                if (dtReservations.Rows.Count > 0)
                {
                    bsReservations.DataSource = dtReservations;
                    listBox1.DataSource = bsReservations;
                    listBox1.DisplayMember = "ReservName"; 
                }
                else
                {
                    listBox1.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    DataRowView dr = (DataRowView)listBox1.SelectedItem;
                    string selectedReservName = dr["ReservName"].ToString();

                    string query = "SELECT * FROM reservations WHERE ReservName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedReservName);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

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

        private void LoadData()
        {
            try
            {

                string query = "SELECT * FROM reservations";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
    }
}
