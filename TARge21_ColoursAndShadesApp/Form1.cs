using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARge21_ColoursAndShadesApp
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TARge21_ColoursAndShadesApp.Properties.Settings.ColoursConnectionString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateColoursTable();
        }

        private void PopulateColoursTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColour", connection))
            {
                DataTable colourTable = new DataTable();
                adapter.Fill(colourTable);

                listPrimaryColour.DisplayMember = "PrimaryColourName";
                listPrimaryColour.ValueMember = "Id";
                listPrimaryColour.DataSource = colourTable;
            }
        }

        private void listPrimaryColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColourShades();
        }

        private void PopulateColourShades()
        {
            string query = "SELECT Shades.ColourName FROM PrimaryColour INNER JOIN Shades ON Shades.PrimaryColourId = PrimaryColour.Id WHERE PrimaryColour.Id = @PrimaryColourId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryColourId", listPrimaryColour.SelectedValue);
                DataTable colourNameTable = new DataTable();
                adapter.Fill(colourNameTable);

                listShades.DisplayMember = "ColourName";
                listShades.ValueMember = "Id";
                listShades.DataSource = colourNameTable;
            }
        }
    }
}
