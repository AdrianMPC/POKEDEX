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
            // Pokedex_main_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}