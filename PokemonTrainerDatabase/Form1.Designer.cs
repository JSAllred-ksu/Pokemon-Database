namespace PokemonTrainerDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.MenuLocation = new System.Windows.Forms.ComboBox();
            this.labelTrainer = new System.Windows.Forms.Label();
            this.MenuTrainers = new System.Windows.Forms.ComboBox();
            this.labelPokemon = new System.Windows.Forms.Label();
            this.MenuPokemon = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.MenuType = new System.Windows.Forms.ComboBox();
            this.labelMoves = new System.Windows.Forms.Label();
            this.MenuMove = new System.Windows.Forms.ComboBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.TLabelLocation = new System.Windows.Forms.Label();
            this.TLabelName = new System.Windows.Forms.Label();
            this.TLabelPokemon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainerPokemon1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TPM11 = new System.Windows.Forms.ComboBox();
            this.TPM14 = new System.Windows.Forms.ComboBox();
            this.TPM13 = new System.Windows.Forms.ComboBox();
            this.TPM12 = new System.Windows.Forms.ComboBox();
            this.TPM22 = new System.Windows.Forms.ComboBox();
            this.TPM23 = new System.Windows.Forms.ComboBox();
            this.TPM24 = new System.Windows.Forms.ComboBox();
            this.TPM21 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrainerPokemon2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TPM32 = new System.Windows.Forms.ComboBox();
            this.TPM33 = new System.Windows.Forms.ComboBox();
            this.TPM34 = new System.Windows.Forms.ComboBox();
            this.TPM31 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TrainerPokemon3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TPM42 = new System.Windows.Forms.ComboBox();
            this.TPM43 = new System.Windows.Forms.ComboBox();
            this.TPM44 = new System.Windows.Forms.ComboBox();
            this.TPM41 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TrainerPokemon4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TPM52 = new System.Windows.Forms.ComboBox();
            this.TPM53 = new System.Windows.Forms.ComboBox();
            this.TPM54 = new System.Windows.Forms.ComboBox();
            this.TPM51 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TrainerPokemon5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TPM62 = new System.Windows.Forms.ComboBox();
            this.TPM63 = new System.Windows.Forms.ComboBox();
            this.TPM64 = new System.Windows.Forms.ComboBox();
            this.TPM61 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TrainerPokemon6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TrainerName = new System.Windows.Forms.TextBox();
            this.TrainerLocation = new System.Windows.Forms.ComboBox();
            this.AddTrainerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 9);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(47, 13);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Filter on:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 39);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location";
            // 
            // MenuLocation
            // 
            this.MenuLocation.FormattingEnabled = true;
            this.MenuLocation.Location = new System.Drawing.Point(75, 36);
            this.MenuLocation.Name = "MenuLocation";
            this.MenuLocation.Size = new System.Drawing.Size(121, 21);
            this.MenuLocation.TabIndex = 2;
            this.MenuLocation.SelectedIndexChanged += new System.EventHandler(this.MenuLocation_SelectedIndexChanged);
            // 
            // labelTrainer
            // 
            this.labelTrainer.AutoSize = true;
            this.labelTrainer.Location = new System.Drawing.Point(12, 80);
            this.labelTrainer.Name = "labelTrainer";
            this.labelTrainer.Size = new System.Drawing.Size(40, 13);
            this.labelTrainer.TabIndex = 3;
            this.labelTrainer.Text = "Trainer";
            // 
            // MenuTrainers
            // 
            this.MenuTrainers.FormattingEnabled = true;
            this.MenuTrainers.Location = new System.Drawing.Point(75, 80);
            this.MenuTrainers.Name = "MenuTrainers";
            this.MenuTrainers.Size = new System.Drawing.Size(121, 21);
            this.MenuTrainers.TabIndex = 4;
            this.MenuTrainers.SelectedIndexChanged += new System.EventHandler(this.MenuTrainers_SelectedIndexChanged);
            // 
            // labelPokemon
            // 
            this.labelPokemon.AutoSize = true;
            this.labelPokemon.Location = new System.Drawing.Point(12, 124);
            this.labelPokemon.Name = "labelPokemon";
            this.labelPokemon.Size = new System.Drawing.Size(52, 13);
            this.labelPokemon.TabIndex = 5;
            this.labelPokemon.Text = "Pokemon";
            // 
            // MenuPokemon
            // 
            this.MenuPokemon.FormattingEnabled = true;
            this.MenuPokemon.Location = new System.Drawing.Point(75, 124);
            this.MenuPokemon.Name = "MenuPokemon";
            this.MenuPokemon.Size = new System.Drawing.Size(121, 21);
            this.MenuPokemon.TabIndex = 6;
            this.MenuPokemon.SelectedIndexChanged += new System.EventHandler(this.MenuPokemon_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 166);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Type";
            // 
            // MenuType
            // 
            this.MenuType.FormattingEnabled = true;
            this.MenuType.Location = new System.Drawing.Point(75, 166);
            this.MenuType.Name = "MenuType";
            this.MenuType.Size = new System.Drawing.Size(121, 21);
            this.MenuType.TabIndex = 8;
            this.MenuType.SelectedIndexChanged += new System.EventHandler(this.MenuType_SelectedIndexChanged);
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Location = new System.Drawing.Point(12, 209);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(34, 13);
            this.labelMoves.TabIndex = 9;
            this.labelMoves.Text = "Move";
            // 
            // MenuMove
            // 
            this.MenuMove.FormattingEnabled = true;
            this.MenuMove.Location = new System.Drawing.Point(75, 209);
            this.MenuMove.Name = "MenuMove";
            this.MenuMove.Size = new System.Drawing.Size(121, 21);
            this.MenuMove.TabIndex = 10;
            this.MenuMove.SelectedIndexChanged += new System.EventHandler(this.MenuMove_SelectedIndexChanged);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 255);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 11;
            this.labelResults.Text = "Results:";
            // 
            // ResultsBox
            // 
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.Items.AddRange(new object[] {
            "",
            "",
            ""});
            this.ResultsBox.Location = new System.Drawing.Point(75, 255);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ScrollAlwaysVisible = true;
            this.ResultsBox.Size = new System.Drawing.Size(236, 186);
            this.ResultsBox.TabIndex = 12;
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(422, 9);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(82, 13);
            this.labelMake.TabIndex = 13;
            this.labelMake.Text = "Make a Trainer:";
            // 
            // TLabelLocation
            // 
            this.TLabelLocation.AutoSize = true;
            this.TLabelLocation.Location = new System.Drawing.Point(422, 39);
            this.TLabelLocation.Name = "TLabelLocation";
            this.TLabelLocation.Size = new System.Drawing.Size(48, 13);
            this.TLabelLocation.TabIndex = 14;
            this.TLabelLocation.Text = "Location";
            // 
            // TLabelName
            // 
            this.TLabelName.AutoSize = true;
            this.TLabelName.Location = new System.Drawing.Point(422, 80);
            this.TLabelName.Name = "TLabelName";
            this.TLabelName.Size = new System.Drawing.Size(35, 13);
            this.TLabelName.TabIndex = 15;
            this.TLabelName.Text = "Name";
            // 
            // TLabelPokemon
            // 
            this.TLabelPokemon.AutoSize = true;
            this.TLabelPokemon.Location = new System.Drawing.Point(422, 124);
            this.TLabelPokemon.Name = "TLabelPokemon";
            this.TLabelPokemon.Size = new System.Drawing.Size(52, 13);
            this.TLabelPokemon.TabIndex = 16;
            this.TLabelPokemon.Text = "Pokemon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pokemon 1:";
            // 
            // TrainerPokemon1
            // 
            this.TrainerPokemon1.FormattingEnabled = true;
            this.TrainerPokemon1.Location = new System.Drawing.Point(492, 163);
            this.TrainerPokemon1.Name = "TrainerPokemon1";
            this.TrainerPokemon1.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon1.TabIndex = 18;
            this.TrainerPokemon1.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Moves:";
            // 
            // TPM11
            // 
            this.TPM11.Enabled = false;
            this.TPM11.FormattingEnabled = true;
            this.TPM11.Location = new System.Drawing.Point(492, 203);
            this.TPM11.Name = "TPM11";
            this.TPM11.Size = new System.Drawing.Size(121, 21);
            this.TPM11.TabIndex = 20;
            // 
            // TPM14
            // 
            this.TPM14.Enabled = false;
            this.TPM14.FormattingEnabled = true;
            this.TPM14.Location = new System.Drawing.Point(619, 230);
            this.TPM14.Name = "TPM14";
            this.TPM14.Size = new System.Drawing.Size(121, 21);
            this.TPM14.TabIndex = 21;
            // 
            // TPM13
            // 
            this.TPM13.Enabled = false;
            this.TPM13.FormattingEnabled = true;
            this.TPM13.Location = new System.Drawing.Point(492, 230);
            this.TPM13.Name = "TPM13";
            this.TPM13.Size = new System.Drawing.Size(121, 21);
            this.TPM13.TabIndex = 22;
            // 
            // TPM12
            // 
            this.TPM12.Enabled = false;
            this.TPM12.FormattingEnabled = true;
            this.TPM12.Location = new System.Drawing.Point(619, 203);
            this.TPM12.Name = "TPM12";
            this.TPM12.Size = new System.Drawing.Size(121, 21);
            this.TPM12.TabIndex = 23;
            // 
            // TPM22
            // 
            this.TPM22.Enabled = false;
            this.TPM22.FormattingEnabled = true;
            this.TPM22.Location = new System.Drawing.Point(619, 297);
            this.TPM22.Name = "TPM22";
            this.TPM22.Size = new System.Drawing.Size(121, 21);
            this.TPM22.TabIndex = 30;
            // 
            // TPM23
            // 
            this.TPM23.Enabled = false;
            this.TPM23.FormattingEnabled = true;
            this.TPM23.Location = new System.Drawing.Point(492, 324);
            this.TPM23.Name = "TPM23";
            this.TPM23.Size = new System.Drawing.Size(121, 21);
            this.TPM23.TabIndex = 29;
            // 
            // TPM24
            // 
            this.TPM24.Enabled = false;
            this.TPM24.FormattingEnabled = true;
            this.TPM24.Location = new System.Drawing.Point(619, 324);
            this.TPM24.Name = "TPM24";
            this.TPM24.Size = new System.Drawing.Size(121, 21);
            this.TPM24.TabIndex = 28;
            // 
            // TPM21
            // 
            this.TPM21.Enabled = false;
            this.TPM21.FormattingEnabled = true;
            this.TPM21.Location = new System.Drawing.Point(492, 297);
            this.TPM21.Name = "TPM21";
            this.TPM21.Size = new System.Drawing.Size(121, 21);
            this.TPM21.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Moves:";
            // 
            // TrainerPokemon2
            // 
            this.TrainerPokemon2.FormattingEnabled = true;
            this.TrainerPokemon2.Location = new System.Drawing.Point(492, 257);
            this.TrainerPokemon2.Name = "TrainerPokemon2";
            this.TrainerPokemon2.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon2.TabIndex = 25;
            this.TrainerPokemon2.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pokemon 2:";
            // 
            // TPM32
            // 
            this.TPM32.Enabled = false;
            this.TPM32.FormattingEnabled = true;
            this.TPM32.Location = new System.Drawing.Point(619, 391);
            this.TPM32.Name = "TPM32";
            this.TPM32.Size = new System.Drawing.Size(121, 21);
            this.TPM32.TabIndex = 37;
            // 
            // TPM33
            // 
            this.TPM33.Enabled = false;
            this.TPM33.FormattingEnabled = true;
            this.TPM33.Location = new System.Drawing.Point(492, 418);
            this.TPM33.Name = "TPM33";
            this.TPM33.Size = new System.Drawing.Size(121, 21);
            this.TPM33.TabIndex = 36;
            // 
            // TPM34
            // 
            this.TPM34.Enabled = false;
            this.TPM34.FormattingEnabled = true;
            this.TPM34.Location = new System.Drawing.Point(619, 418);
            this.TPM34.Name = "TPM34";
            this.TPM34.Size = new System.Drawing.Size(121, 21);
            this.TPM34.TabIndex = 35;
            // 
            // TPM31
            // 
            this.TPM31.Enabled = false;
            this.TPM31.FormattingEnabled = true;
            this.TPM31.Location = new System.Drawing.Point(492, 391);
            this.TPM31.Name = "TPM31";
            this.TPM31.Size = new System.Drawing.Size(121, 21);
            this.TPM31.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Moves:";
            // 
            // TrainerPokemon3
            // 
            this.TrainerPokemon3.FormattingEnabled = true;
            this.TrainerPokemon3.Location = new System.Drawing.Point(492, 351);
            this.TrainerPokemon3.Name = "TrainerPokemon3";
            this.TrainerPokemon3.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon3.TabIndex = 32;
            this.TrainerPokemon3.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Pokemon 3:";
            // 
            // TPM42
            // 
            this.TPM42.Enabled = false;
            this.TPM42.FormattingEnabled = true;
            this.TPM42.Location = new System.Drawing.Point(945, 203);
            this.TPM42.Name = "TPM42";
            this.TPM42.Size = new System.Drawing.Size(121, 21);
            this.TPM42.TabIndex = 44;
            // 
            // TPM43
            // 
            this.TPM43.Enabled = false;
            this.TPM43.FormattingEnabled = true;
            this.TPM43.Location = new System.Drawing.Point(818, 230);
            this.TPM43.Name = "TPM43";
            this.TPM43.Size = new System.Drawing.Size(121, 21);
            this.TPM43.TabIndex = 43;
            // 
            // TPM44
            // 
            this.TPM44.Enabled = false;
            this.TPM44.FormattingEnabled = true;
            this.TPM44.Location = new System.Drawing.Point(945, 230);
            this.TPM44.Name = "TPM44";
            this.TPM44.Size = new System.Drawing.Size(121, 21);
            this.TPM44.TabIndex = 42;
            // 
            // TPM41
            // 
            this.TPM41.Enabled = false;
            this.TPM41.FormattingEnabled = true;
            this.TPM41.Location = new System.Drawing.Point(818, 203);
            this.TPM41.Name = "TPM41";
            this.TPM41.Size = new System.Drawing.Size(121, 21);
            this.TPM41.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Moves:";
            // 
            // TrainerPokemon4
            // 
            this.TrainerPokemon4.FormattingEnabled = true;
            this.TrainerPokemon4.Location = new System.Drawing.Point(818, 163);
            this.TrainerPokemon4.Name = "TrainerPokemon4";
            this.TrainerPokemon4.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon4.TabIndex = 39;
            this.TrainerPokemon4.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Pokemon 4:";
            // 
            // TPM52
            // 
            this.TPM52.Enabled = false;
            this.TPM52.FormattingEnabled = true;
            this.TPM52.Location = new System.Drawing.Point(945, 297);
            this.TPM52.Name = "TPM52";
            this.TPM52.Size = new System.Drawing.Size(121, 21);
            this.TPM52.TabIndex = 51;
            // 
            // TPM53
            // 
            this.TPM53.Enabled = false;
            this.TPM53.FormattingEnabled = true;
            this.TPM53.Location = new System.Drawing.Point(818, 324);
            this.TPM53.Name = "TPM53";
            this.TPM53.Size = new System.Drawing.Size(121, 21);
            this.TPM53.TabIndex = 50;
            // 
            // TPM54
            // 
            this.TPM54.Enabled = false;
            this.TPM54.FormattingEnabled = true;
            this.TPM54.Location = new System.Drawing.Point(945, 324);
            this.TPM54.Name = "TPM54";
            this.TPM54.Size = new System.Drawing.Size(121, 21);
            this.TPM54.TabIndex = 49;
            // 
            // TPM51
            // 
            this.TPM51.Enabled = false;
            this.TPM51.FormattingEnabled = true;
            this.TPM51.Location = new System.Drawing.Point(818, 297);
            this.TPM51.Name = "TPM51";
            this.TPM51.Size = new System.Drawing.Size(121, 21);
            this.TPM51.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Moves:";
            // 
            // TrainerPokemon5
            // 
            this.TrainerPokemon5.FormattingEnabled = true;
            this.TrainerPokemon5.Location = new System.Drawing.Point(818, 257);
            this.TrainerPokemon5.Name = "TrainerPokemon5";
            this.TrainerPokemon5.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon5.TabIndex = 46;
            this.TrainerPokemon5.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon5_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Pokemon 5:";
            // 
            // TPM62
            // 
            this.TPM62.Enabled = false;
            this.TPM62.FormattingEnabled = true;
            this.TPM62.Location = new System.Drawing.Point(945, 396);
            this.TPM62.Name = "TPM62";
            this.TPM62.Size = new System.Drawing.Size(121, 21);
            this.TPM62.TabIndex = 58;
            // 
            // TPM63
            // 
            this.TPM63.Enabled = false;
            this.TPM63.FormattingEnabled = true;
            this.TPM63.Location = new System.Drawing.Point(818, 423);
            this.TPM63.Name = "TPM63";
            this.TPM63.Size = new System.Drawing.Size(121, 21);
            this.TPM63.TabIndex = 57;
            // 
            // TPM64
            // 
            this.TPM64.Enabled = false;
            this.TPM64.FormattingEnabled = true;
            this.TPM64.Location = new System.Drawing.Point(945, 423);
            this.TPM64.Name = "TPM64";
            this.TPM64.Size = new System.Drawing.Size(121, 21);
            this.TPM64.TabIndex = 56;
            // 
            // TPM61
            // 
            this.TPM61.Enabled = false;
            this.TPM61.FormattingEnabled = true;
            this.TPM61.Location = new System.Drawing.Point(818, 396);
            this.TPM61.Name = "TPM61";
            this.TPM61.Size = new System.Drawing.Size(121, 21);
            this.TPM61.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Moves:";
            // 
            // TrainerPokemon6
            // 
            this.TrainerPokemon6.FormattingEnabled = true;
            this.TrainerPokemon6.Location = new System.Drawing.Point(818, 356);
            this.TrainerPokemon6.Name = "TrainerPokemon6";
            this.TrainerPokemon6.Size = new System.Drawing.Size(121, 21);
            this.TrainerPokemon6.TabIndex = 53;
            this.TrainerPokemon6.SelectedIndexChanged += new System.EventHandler(this.TrainerPokemon6_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(748, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Pokemon 6:";
            // 
            // TrainerName
            // 
            this.TrainerName.Location = new System.Drawing.Point(492, 80);
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.Size = new System.Drawing.Size(100, 20);
            this.TrainerName.TabIndex = 59;
            this.TrainerName.TextChanged += new System.EventHandler(this.TrainerName_TextChanged);
            // 
            // TrainerLocation
            // 
            this.TrainerLocation.FormattingEnabled = true;
            this.TrainerLocation.Location = new System.Drawing.Point(492, 36);
            this.TrainerLocation.Name = "TrainerLocation";
            this.TrainerLocation.Size = new System.Drawing.Size(121, 21);
            this.TrainerLocation.TabIndex = 60;
            // 
            // AddTrainerButton
            // 
            this.AddTrainerButton.Enabled = false;
            this.AddTrainerButton.Location = new System.Drawing.Point(737, 29);
            this.AddTrainerButton.Name = "AddTrainerButton";
            this.AddTrainerButton.Size = new System.Drawing.Size(325, 64);
            this.AddTrainerButton.TabIndex = 61;
            this.AddTrainerButton.Text = "Add your Trainer!";
            this.AddTrainerButton.UseVisualStyleBackColor = true;
            this.AddTrainerButton.Click += new System.EventHandler(this.AddTrainerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.AddTrainerButton);
            this.Controls.Add(this.TrainerLocation);
            this.Controls.Add(this.TrainerName);
            this.Controls.Add(this.TPM62);
            this.Controls.Add(this.TPM63);
            this.Controls.Add(this.TPM64);
            this.Controls.Add(this.TPM61);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TrainerPokemon6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TPM52);
            this.Controls.Add(this.TPM53);
            this.Controls.Add(this.TPM54);
            this.Controls.Add(this.TPM51);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TrainerPokemon5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TPM42);
            this.Controls.Add(this.TPM43);
            this.Controls.Add(this.TPM44);
            this.Controls.Add(this.TPM41);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrainerPokemon4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TPM32);
            this.Controls.Add(this.TPM33);
            this.Controls.Add(this.TPM34);
            this.Controls.Add(this.TPM31);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrainerPokemon3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TPM22);
            this.Controls.Add(this.TPM23);
            this.Controls.Add(this.TPM24);
            this.Controls.Add(this.TPM21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrainerPokemon2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TPM12);
            this.Controls.Add(this.TPM13);
            this.Controls.Add(this.TPM14);
            this.Controls.Add(this.TPM11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrainerPokemon1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLabelPokemon);
            this.Controls.Add(this.TLabelName);
            this.Controls.Add(this.TLabelLocation);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.MenuMove);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.MenuType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.MenuPokemon);
            this.Controls.Add(this.labelPokemon);
            this.Controls.Add(this.MenuTrainers);
            this.Controls.Add(this.labelTrainer);
            this.Controls.Add(this.MenuLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox MenuLocation;
        private System.Windows.Forms.Label labelTrainer;
        private System.Windows.Forms.ComboBox MenuTrainers;
        private System.Windows.Forms.Label labelPokemon;
        private System.Windows.Forms.ComboBox MenuPokemon;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox MenuType;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.ComboBox MenuMove;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ListBox ResultsBox;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label TLabelLocation;
        private System.Windows.Forms.Label TLabelName;
        private System.Windows.Forms.Label TLabelPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TrainerPokemon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TPM11;
        private System.Windows.Forms.ComboBox TPM14;
        private System.Windows.Forms.ComboBox TPM13;
        private System.Windows.Forms.ComboBox TPM12;
        private System.Windows.Forms.ComboBox TPM22;
        private System.Windows.Forms.ComboBox TPM23;
        private System.Windows.Forms.ComboBox TPM24;
        private System.Windows.Forms.ComboBox TPM21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TrainerPokemon2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TPM32;
        private System.Windows.Forms.ComboBox TPM33;
        private System.Windows.Forms.ComboBox TPM34;
        private System.Windows.Forms.ComboBox TPM31;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TrainerPokemon3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TPM42;
        private System.Windows.Forms.ComboBox TPM43;
        private System.Windows.Forms.ComboBox TPM44;
        private System.Windows.Forms.ComboBox TPM41;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TrainerPokemon4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TPM52;
        private System.Windows.Forms.ComboBox TPM53;
        private System.Windows.Forms.ComboBox TPM54;
        private System.Windows.Forms.ComboBox TPM51;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TrainerPokemon5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TPM62;
        private System.Windows.Forms.ComboBox TPM63;
        private System.Windows.Forms.ComboBox TPM64;
        private System.Windows.Forms.ComboBox TPM61;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox TrainerPokemon6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TrainerName;
        private System.Windows.Forms.ComboBox TrainerLocation;
        private System.Windows.Forms.Button AddTrainerButton;
    }
}

