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
            PopulateMovesBox();
            PopulateTrainersBox();
            PopulatePokemonBox();
            PopulateTrainersLocationBox();
            PopulateTrainerPokemonBox1();
            PopulateTrainerPokemonBox2();
            PopulateTrainerPokemonBox3();
            PopulateTrainerPokemonBox4();
            PopulateTrainerPokemonBox5();
            PopulateTrainerPokemonBox6();
        }

        private void PopulateResults()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Trainers JOIN TrainerPokemon ON TrainerPokemon.TrainerID = Trainers.TrainerID JOIN Pokemon ON Pokemon.PokedexNumber = TrainerPokemon.PokemonID WHERE 1 = 1";

                if (MenuLocation.SelectedItem != null)
                {
                    query += $" AND Trainers.LocationID = '{MenuLocation.SelectedItem}'";
                }
                
                if (MenuType.SelectedItem != null)
                {
                    query += $" AND Pokemon.PrimaryTypeID = {MenuType.SelectedItem} OR Pokemon.SecondaryTypeID = {MenuType.SelectedItem}";
                }
                
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable TrainerTable = new DataTable();
                    adapter.Fill(TrainerTable);

                    ResultsBox.DisplayMember = "TrainerName";
                    ResultsBox.ValueMember = "Id";
                    ResultsBox.DataSource = TrainerTable;
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
                    MenuLocation.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainersBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Trainers WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable TrainersTable = new DataTable();
                    adapter.Fill(TrainersTable);

                    MenuTrainers.DisplayMember = "TrainerName";
                    MenuTrainers.ValueMember = "Id";
                    MenuTrainers.DataSource = TrainersTable;
                    MenuTrainers.SelectedIndex = -1;
                }
            }
        }

        private void PopulatePokemonBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    MenuPokemon.DisplayMember = "PokemonName";
                    MenuPokemon.ValueMember = "Id";
                    MenuPokemon.DataSource = PokemonTable;
                    MenuPokemon.SelectedIndex = -1;
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
                    MenuType.SelectedIndex = -1;
                }
            }
        }

        private void PopulateMovesBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Moves WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable MovesTable = new DataTable();
                    adapter.Fill(MovesTable);

                    MenuMove.DisplayMember = "MoveName";
                    MenuMove.ValueMember = "Id";
                    MenuMove.DataSource = MovesTable;
                    MenuMove.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainersLocationBox()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Locations WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable LocationTable = new DataTable();
                    adapter.Fill(LocationTable);

                    TrainerLocation.DisplayMember = "LocationName";
                    TrainerLocation.ValueMember = "Id";
                    TrainerLocation.DataSource = LocationTable;
                    TrainerLocation.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox1()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon1.DisplayMember = "PokemonName";
                    TrainerPokemon1.ValueMember = "Id";
                    TrainerPokemon1.DataSource = PokemonTable;
                    TrainerPokemon1.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox2()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon2.DisplayMember = "PokemonName";
                    TrainerPokemon2.ValueMember = "Id";
                    TrainerPokemon2.DataSource = PokemonTable;
                    TrainerPokemon2.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox3()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon3.DisplayMember = "PokemonName";
                    TrainerPokemon3.ValueMember = "Id";
                    TrainerPokemon3.DataSource = PokemonTable;
                    TrainerPokemon3.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox4()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon4.DisplayMember = "PokemonName";
                    TrainerPokemon4.ValueMember = "Id";
                    TrainerPokemon4.DataSource = PokemonTable;
                    TrainerPokemon4.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox5()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon5.DisplayMember = "PokemonName";
                    TrainerPokemon5.ValueMember = "Id";
                    TrainerPokemon5.DataSource = PokemonTable;
                    TrainerPokemon5.SelectedIndex = -1;
                }
            }
        }

        private void PopulateTrainerPokemonBox6()
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Pokemon WHERE 1 = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataTable PokemonTable = new DataTable();
                    adapter.Fill(PokemonTable);

                    TrainerPokemon6.DisplayMember = "PokemonName";
                    TrainerPokemon6.ValueMember = "Id";
                    TrainerPokemon6.DataSource = PokemonTable;
                    TrainerPokemon6.SelectedIndex = -1;
                }
            }
        }

        private void TrainerPokemon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon1.SelectedIndex == -1)
            {
                TPM11.Enabled = false;
                TPM12.Enabled = false;
                TPM13.Enabled = false;
                TPM14.Enabled = false;
            }
            else
            {
                TPM11.Enabled = true;
                TPM12.Enabled = true;
                TPM13.Enabled = true;
                TPM14.Enabled = true;
            }
        }

        private void TrainerPokemon2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon2.SelectedIndex == -1)
            {
                TPM21.Enabled = false;
                TPM22.Enabled = false;
                TPM23.Enabled = false;
                TPM24.Enabled = false;
            }
            else
            {
                TPM21.Enabled = true;
                TPM22.Enabled = true;
                TPM23.Enabled = true;
                TPM24.Enabled = true;
            }
        }

        private void TrainerPokemon3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon1.SelectedIndex == -1)
            {
                TPM31.Enabled = false;
                TPM32.Enabled = false;
                TPM33.Enabled = false;
                TPM34.Enabled = false;
            }
            else
            {
                TPM31.Enabled = true;
                TPM32.Enabled = true;
                TPM33.Enabled = true;
                TPM34.Enabled = true;
            }
        }

        private void TrainerPokemon4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon1.SelectedIndex == -1)
            {
                TPM41.Enabled = false;
                TPM42.Enabled = false;
                TPM43.Enabled = false;
                TPM44.Enabled = false;
            }
            else
            {
                TPM41.Enabled = true;
                TPM42.Enabled = true;
                TPM43.Enabled = true;
                TPM44.Enabled = true;
            }
        }

        private void TrainerPokemon5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon1.SelectedIndex == -1)
            {
                TPM51.Enabled = false;
                TPM52.Enabled = false;
                TPM53.Enabled = false;
                TPM54.Enabled = false;
            }
            else
            {
                TPM51.Enabled = true;
                TPM52.Enabled = true;
                TPM53.Enabled = true;
                TPM54.Enabled = true;
            }
        }

        private void TrainerPokemon6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerPokemon1.SelectedIndex == -1)
            {
                TPM61.Enabled = false;
                TPM62.Enabled = false;
                TPM63.Enabled = false;
                TPM64.Enabled = false;
            }
            else
            {
                TPM61.Enabled = true;
                TPM62.Enabled = true;
                TPM63.Enabled = true;
                TPM64.Enabled = true;
            }
        }

        private void TrainerName_TextChanged(object sender, EventArgs e)
        {
            if (TrainerName.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
