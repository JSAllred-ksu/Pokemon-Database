using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PokemonTrainerDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection Connection;
        string ConnectionString;

        public Form1()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["PokemonTrainerDatabase.Properties.Settings.PokemonTrainerDatabaseTablesConnectionString"].ConnectionString;
            PopulateResults();
        }

        private void PopulateResults()
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pokemon", Connection))
            {
                DataTable PokemonTable = new DataTable();
                adapter.Fill(PokemonTable);

                ResultsBox.DisplayMember = "PokemonName";
                ResultsBox.ValueMember = "Id";
                ResultsBox.DataSource = PokemonTable;
            }
        }
    }
}
