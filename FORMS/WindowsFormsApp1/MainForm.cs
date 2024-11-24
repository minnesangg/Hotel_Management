using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click); // резервация
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);// добавление гостя
        }
       
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            var crudForm = new CrudForm();
            crudForm.ShowDialog(); 
        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            var addGuestForm = new AddGuestForm();
            addGuestForm.ShowDialog(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog(); // Показуємо форму пошуку
        }

        //private void btnExport_Click(object sender, EventArgs e)
        //{
        //    var exportForm = new ExportForm();
        //    exportForm.ShowDialog(); // Показуємо форму експорту
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
