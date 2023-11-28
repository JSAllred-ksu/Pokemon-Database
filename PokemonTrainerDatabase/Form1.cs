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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM11.DisplayMember = "MoveName";
                        TPM11.ValueMember = "Id";
                        TPM11.DataSource = PokemonTable1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM12.DisplayMember = "MoveName";
                        TPM12.ValueMember = "Id";
                        TPM12.DataSource = PokemonTable2;
                        TPM12.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM13.DisplayMember = "MoveName";
                        TPM13.ValueMember = "Id";
                        TPM13.DataSource = PokemonTable3;
                        TPM13.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM14.DisplayMember = "MoveName";
                        TPM14.ValueMember = "Id";
                        TPM14.DataSource = PokemonTable4;
                        TPM14.SelectedIndex = -1;
                    }
                }
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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM21.DisplayMember = "MoveName";
                        TPM21.ValueMember = "Id";
                        TPM21.DataSource = PokemonTable1;
                        TPM21.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM22.DisplayMember = "MoveName";
                        TPM22.ValueMember = "Id";
                        TPM22.DataSource = PokemonTable2;
                        TPM22.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM23.DisplayMember = "MoveName";
                        TPM23.ValueMember = "Id";
                        TPM23.DataSource = PokemonTable3;
                        TPM23.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM24.DisplayMember = "MoveName";
                        TPM24.ValueMember = "Id";
                        TPM24.DataSource = PokemonTable4;
                        TPM24.SelectedIndex = -1;
                    }
                }
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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM31.DisplayMember = "MoveName";
                        TPM31.ValueMember = "Id";
                        TPM31.DataSource = PokemonTable1;
                        TPM31.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM32.DisplayMember = "MoveName";
                        TPM32.ValueMember = "Id";
                        TPM32.DataSource = PokemonTable2;
                        TPM32.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM33.DisplayMember = "MoveName";
                        TPM33.ValueMember = "Id";
                        TPM33.DataSource = PokemonTable3;
                        TPM33.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM34.DisplayMember = "MoveName";
                        TPM34.ValueMember = "Id";
                        TPM34.DataSource = PokemonTable4;
                        TPM34.SelectedIndex = -1;
                    }
                }
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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM41.DisplayMember = "MoveName";
                        TPM41.ValueMember = "Id";
                        TPM41.DataSource = PokemonTable1;
                        TPM41.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM42.DisplayMember = "MoveName";
                        TPM42.ValueMember = "Id";
                        TPM42.DataSource = PokemonTable2;
                        TPM42.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM43.DisplayMember = "MoveName";
                        TPM43.ValueMember = "Id";
                        TPM43.DataSource = PokemonTable3;
                        TPM43.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM44.DisplayMember = "MoveName";
                        TPM44.ValueMember = "Id";
                        TPM44.DataSource = PokemonTable4;
                        TPM44.SelectedIndex = -1;
                    }
                }
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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM51.DisplayMember = "MoveName";
                        TPM51.ValueMember = "Id";
                        TPM51.DataSource = PokemonTable1;
                        TPM51.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM52.DisplayMember = "MoveName";
                        TPM52.ValueMember = "Id";
                        TPM52.DataSource = PokemonTable2;
                        TPM52.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM53.DisplayMember = "MoveName";
                        TPM53.ValueMember = "Id";
                        TPM53.DataSource = PokemonTable3;
                        TPM53.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM54.DisplayMember = "MoveName";
                        TPM54.ValueMember = "Id";
                        TPM54.DataSource = PokemonTable4;
                        TPM54.SelectedIndex = -1;
                    }
                }
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
                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable1 = new DataTable();
                        adapter.Fill(PokemonTable1);

                        TPM61.DisplayMember = "MoveName";
                        TPM61.ValueMember = "Id";
                        TPM61.DataSource = PokemonTable1;
                        TPM61.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable2 = new DataTable();
                        adapter.Fill(PokemonTable2);

                        TPM62.DisplayMember = "MoveName";
                        TPM62.ValueMember = "Id";
                        TPM62.DataSource = PokemonTable2;
                        TPM62.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable3 = new DataTable();
                        adapter.Fill(PokemonTable3);

                        TPM63.DisplayMember = "MoveName";
                        TPM63.ValueMember = "Id";
                        TPM63.DataSource = PokemonTable3;
                        TPM63.SelectedIndex = -1;
                    }
                }

                using (Connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Moves JOIN LearnableMoves ON LearnableMoves.MoveID = Moves.MoveID JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID WHERE 1 = 1";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                    {
                        DataTable PokemonTable4 = new DataTable();
                        adapter.Fill(PokemonTable4);

                        TPM64.DisplayMember = "MoveName";
                        TPM64.ValueMember = "Id";
                        TPM64.DataSource = PokemonTable4;
                        TPM64.SelectedIndex = -1;
                    }
                }
            }
        }

        private void TrainerName_TextChanged(object sender, EventArgs e)
        {
            if (TrainerName.Text != "")
            {
                AddTrainerButton.Enabled = true;
            }
            else
            {
                AddTrainerButton.Enabled = false;
            }
        }

        private void MenuLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Trainers WHERE 1 = 1";

                if (MenuLocation.SelectedIndex != -1)
                {
                    query += $" AND Trainers.LocationID = '{MenuLocation.SelectedIndex + 1}'";
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

        private void MenuTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Trainers WHERE 1 = 1";

                if (MenuTrainers.SelectedIndex != -1)
                {
                    query += $" AND Trainers.TrainerID = '{MenuTrainers.SelectedIndex + 2}'";
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

        private void MenuPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM TrainerPokemon Join Trainers ON Trainers.TrainerID = TrainerPokemon.TrainerID WHERE 1 = 1";

                if (MenuPokemon.SelectedIndex != -1)
                {
                    query += $" AND TrainerPokemon.PokemonID = '{MenuPokemon.SelectedIndex + 1}'";
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

        private void MenuType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Type JOIN Pokemon ON Pokemon.PrimaryTypeID = Type.TypeID OR Pokemon.SecondaryTypeID = Type.TypeID JOIN TrainerPokemon ON TrainerPokemon.PokemonID = Pokemon.PokedexNumber JOIN Trainers ON Trainers.TrainerID = TrainerPokemon.TrainerID WHERE 1 = 1";

                if (MenuType.SelectedIndex != -1)
                {
                    query += $" AND Type.TypeID = '{MenuType.SelectedIndex + 1}'";
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

        private void MenuMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM LearnableMoves JOIN Pokemon ON Pokemon.PokedexNumber = LearnableMoves.PokemonID JOIN TrainerPokemon ON TrainerPokemon.PokemonID = Pokemon.PokedexNumber JOIN Trainers ON Trainers.TrainerID = TrainerPokemon.TrainerID WHERE 1 = 1";

                if (MenuMove.SelectedIndex != -1)
                {
                    query += $" AND LearnableMoves.MoveID = '{MenuMove.SelectedIndex + 1}'";
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

        private void AddTrainerButton_Click(object sender, EventArgs e)
        {

        }
    }
}