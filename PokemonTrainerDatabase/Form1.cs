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
using System.Reflection;
using System.Collections;

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
            PopulateLocationBox();
            PopulateTypeBox();
        }

        private void PopulateResults()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                if (MenuLocation.SelectedItem != null)
                {
                    query += $" AND Pokemon.Region = '{MenuLocation.SelectedItem}'";
                }

                if (MenuType.SelectedItem != null)
                {
                    query += $" AND Pokemon.PrimaryTypeID = {MenuType.SelectedItem} OR Pokemon.SecondaryTypeID = {MenuType.SelectedItem}";
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    ResultsBox.DisplayMember = "PokemonName";
                    ResultsBox.ValueMember = "Id";
                    ResultsBox.DataSource = PokemonTable;
                }
            }
        }

        private void PopulateLocationBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Locations WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable LocationsTable = new DataTable();
                    adapter.Fill(LocationsTable);

                    MenuLocation.DisplayMember = "LocationName";
                    MenuLocation.ValueMember = "Id";
                    MenuLocation.DataSource = LocationsTable;
                }
            }
        }

        private void PopulateTypeBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Type WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable TypeTable = new DataTable();
                    adapter.Fill(TypeTable);

                    MenuType.DisplayMember = "Name";
                    MenuType.ValueMember = "Id";
                    MenuType.DataSource = TypeTable;
                }
            }
        }
    }
}
