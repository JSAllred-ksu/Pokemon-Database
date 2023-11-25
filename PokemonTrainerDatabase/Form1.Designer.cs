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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.TLabelLocation = new System.Windows.Forms.Label();
            this.TLabelName = new System.Windows.Forms.Label();
            this.TLabelPokemon = new System.Windows.Forms.Label();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLabelPokemon);
            this.Controls.Add(this.TLabelName);
            this.Controls.Add(this.TLabelLocation);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ListBox ResultsBox;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label TLabelLocation;
        private System.Windows.Forms.Label TLabelName;
        private System.Windows.Forms.Label TLabelPokemon;
    }
}

