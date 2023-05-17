namespace POKEDEX.UI
{
    partial class Pokedex_main_detail
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
            this.pokemonimage = new System.Windows.Forms.PictureBox();
            this.pokename_label = new System.Windows.Forms.Label();
            this.tipo_label = new System.Windows.Forms.Label();
            this.tipo2_label = new System.Windows.Forms.Label();
            this.hp_label = new System.Windows.Forms.Label();
            this.attack_label = new System.Windows.Forms.Label();
            this.defense_label = new System.Windows.Forms.Label();
            this.spd_atk_label = new System.Windows.Forms.Label();
            this.spd_def_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.editar_but = new System.Windows.Forms.Button();
            this.atras_but = new System.Windows.Forms.Button();
            this.atc_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonimage)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonimage
            // 
            this.pokemonimage.ImageLocation = "";
            this.pokemonimage.Location = new System.Drawing.Point(12, 55);
            this.pokemonimage.Name = "pokemonimage";
            this.pokemonimage.Size = new System.Drawing.Size(240, 246);
            this.pokemonimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemonimage.TabIndex = 0;
            this.pokemonimage.TabStop = false;
            // 
            // pokename_label
            // 
            this.pokename_label.AutoSize = true;
            this.pokename_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokename_label.Location = new System.Drawing.Point(8, 9);
            this.pokename_label.Name = "pokename_label";
            this.pokename_label.Size = new System.Drawing.Size(244, 37);
            this.pokename_label.TabIndex = 1;
            this.pokename_label.Text = "POKEMON_NAME";
            // 
            // tipo_label
            // 
            this.tipo_label.AutoSize = true;
            this.tipo_label.Location = new System.Drawing.Point(287, 58);
            this.tipo_label.Name = "tipo_label";
            this.tipo_label.Size = new System.Drawing.Size(33, 15);
            this.tipo_label.TabIndex = 2;
            this.tipo_label.Text = "Tipo:";
            // 
            // tipo2_label
            // 
            this.tipo2_label.AutoSize = true;
            this.tipo2_label.Location = new System.Drawing.Point(517, 55);
            this.tipo2_label.Name = "tipo2_label";
            this.tipo2_label.Size = new System.Drawing.Size(39, 15);
            this.tipo2_label.TabIndex = 3;
            this.tipo2_label.Text = "Tipo2:";
            // 
            // hp_label
            // 
            this.hp_label.AutoSize = true;
            this.hp_label.Location = new System.Drawing.Point(287, 103);
            this.hp_label.Name = "hp_label";
            this.hp_label.Size = new System.Drawing.Size(26, 15);
            this.hp_label.TabIndex = 4;
            this.hp_label.Text = "HP:";
            // 
            // attack_label
            // 
            this.attack_label.AutoSize = true;
            this.attack_label.Location = new System.Drawing.Point(517, 103);
            this.attack_label.Name = "attack_label";
            this.attack_label.Size = new System.Drawing.Size(44, 15);
            this.attack_label.TabIndex = 5;
            this.attack_label.Text = "Attack:";
            // 
            // defense_label
            // 
            this.defense_label.AutoSize = true;
            this.defense_label.Location = new System.Drawing.Point(287, 145);
            this.defense_label.Name = "defense_label";
            this.defense_label.Size = new System.Drawing.Size(52, 15);
            this.defense_label.TabIndex = 6;
            this.defense_label.Text = "Defense:";
            // 
            // spd_atk_label
            // 
            this.spd_atk_label.AutoSize = true;
            this.spd_atk_label.Location = new System.Drawing.Point(517, 145);
            this.spd_atk_label.Name = "spd_atk_label";
            this.spd_atk_label.Size = new System.Drawing.Size(77, 15);
            this.spd_atk_label.TabIndex = 7;
            this.spd_atk_label.Text = "Speed attack:";
            // 
            // spd_def_label
            // 
            this.spd_def_label.AutoSize = true;
            this.spd_def_label.Location = new System.Drawing.Point(287, 186);
            this.spd_def_label.Name = "spd_def_label";
            this.spd_def_label.Size = new System.Drawing.Size(86, 15);
            this.spd_def_label.TabIndex = 8;
            this.spd_def_label.Text = "Speed defense:";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(517, 186);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(42, 15);
            this.speed_label.TabIndex = 9;
            this.speed_label.Text = "Speed:";
            // 
            // editar_but
            // 
            this.editar_but.Location = new System.Drawing.Point(287, 270);
            this.editar_but.Name = "editar_but";
            this.editar_but.Size = new System.Drawing.Size(75, 23);
            this.editar_but.TabIndex = 10;
            this.editar_but.Text = "Editar";
            this.editar_but.UseVisualStyleBackColor = true;
            this.editar_but.Click += new System.EventHandler(this.editar_but_Click);
            // 
            // atras_but
            // 
            this.atras_but.Location = new System.Drawing.Point(517, 270);
            this.atras_but.Name = "atras_but";
            this.atras_but.Size = new System.Drawing.Size(75, 23);
            this.atras_but.TabIndex = 11;
            this.atras_but.Text = "Atras";
            this.atras_but.UseVisualStyleBackColor = true;
            this.atras_but.Click += new System.EventHandler(this.atras_but_Click);
            // 
            // atc_but
            // 
            this.atc_but.Location = new System.Drawing.Point(258, 23);
            this.atc_but.Name = "atc_but";
            this.atc_but.Size = new System.Drawing.Size(128, 23);
            this.atc_but.TabIndex = 12;
            this.atc_but.Text = "Ataques disponibles";
            this.atc_but.UseVisualStyleBackColor = true;
            this.atc_but.Click += new System.EventHandler(this.atc_but_Click);
            // 
            // Pokedex_main_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 324);
            this.Controls.Add(this.atc_but);
            this.Controls.Add(this.atras_but);
            this.Controls.Add(this.editar_but);
            this.Controls.Add(this.speed_label);
            this.Controls.Add(this.spd_def_label);
            this.Controls.Add(this.spd_atk_label);
            this.Controls.Add(this.defense_label);
            this.Controls.Add(this.attack_label);
            this.Controls.Add(this.hp_label);
            this.Controls.Add(this.tipo2_label);
            this.Controls.Add(this.tipo_label);
            this.Controls.Add(this.pokename_label);
            this.Controls.Add(this.pokemonimage);
            this.Name = "Pokedex_main_detail";
            this.Text = "Pokedex_main_detail";
            this.Load += new System.EventHandler(this.Pokedex_main_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pokemonimage;
        private Label pokename_label;
        private Label tipo_label;
        private Label tipo2_label;
        private Label hp_label;
        private Label attack_label;
        private Label defense_label;
        private Label spd_atk_label;
        private Label spd_def_label;
        private Label speed_label;
        private Button editar_but;
        private Button atras_but;
        private Button atc_but;
    }
}