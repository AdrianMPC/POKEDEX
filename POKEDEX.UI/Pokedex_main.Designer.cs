namespace POKEDEX.UI
{
    partial class Pokedex_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataPokemon = new System.Windows.Forms.DataGridView();
            this.Agregar_but = new System.Windows.Forms.Button();
            this.Detail_but = new System.Windows.Forms.Button();
            this.Elim_but = new System.Windows.Forms.Button();
            this.act_but = new System.Windows.Forms.Button();
            this.tipos_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "POKEDEX";
            // 
            // dataPokemon
            // 
            this.dataPokemon.Location = new System.Drawing.Point(41, 62);
            this.dataPokemon.MultiSelect = false;
            this.dataPokemon.Name = "dataPokemon";
            this.dataPokemon.ReadOnly = true;
            this.dataPokemon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPokemon.Size = new System.Drawing.Size(1035, 275);
            this.dataPokemon.TabIndex = 0;
            // 
            // Agregar_but
            // 
            this.Agregar_but.Location = new System.Drawing.Point(41, 357);
            this.Agregar_but.Name = "Agregar_but";
            this.Agregar_but.Size = new System.Drawing.Size(75, 23);
            this.Agregar_but.TabIndex = 1;
            this.Agregar_but.Text = "Agregar";
            this.Agregar_but.UseVisualStyleBackColor = true;
            this.Agregar_but.Click += new System.EventHandler(this.Agregar_but_Click);
            // 
            // Detail_but
            // 
            this.Detail_but.Location = new System.Drawing.Point(137, 357);
            this.Detail_but.Name = "Detail_but";
            this.Detail_but.Size = new System.Drawing.Size(75, 23);
            this.Detail_but.TabIndex = 2;
            this.Detail_but.Text = "Detalle";
            this.Detail_but.UseVisualStyleBackColor = true;
            this.Detail_but.Click += new System.EventHandler(this.Detail_but_Click);
            // 
            // Elim_but
            // 
            this.Elim_but.Location = new System.Drawing.Point(232, 357);
            this.Elim_but.Name = "Elim_but";
            this.Elim_but.Size = new System.Drawing.Size(75, 23);
            this.Elim_but.TabIndex = 3;
            this.Elim_but.Text = "Eliminar";
            this.Elim_but.UseVisualStyleBackColor = true;
            this.Elim_but.Click += new System.EventHandler(this.Elim_but_Click);
            // 
            // act_but
            // 
            this.act_but.Location = new System.Drawing.Point(137, 21);
            this.act_but.Name = "act_but";
            this.act_but.Size = new System.Drawing.Size(75, 23);
            this.act_but.TabIndex = 4;
            this.act_but.Text = "Actualizar";
            this.act_but.UseVisualStyleBackColor = true;
            this.act_but.Click += new System.EventHandler(this.act_but_Click);
            // 
            // tipos_but
            // 
            this.tipos_but.Location = new System.Drawing.Point(848, 21);
            this.tipos_but.Name = "tipos_but";
            this.tipos_but.Size = new System.Drawing.Size(228, 23);
            this.tipos_but.TabIndex = 5;
            this.tipos_but.Text = "Listar tipos";
            this.tipos_but.UseVisualStyleBackColor = true;
            this.tipos_but.Click += new System.EventHandler(this.tipos_but_Click);
            // 
            // Pokedex_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 394);
            this.Controls.Add(this.tipos_but);
            this.Controls.Add(this.act_but);
            this.Controls.Add(this.Elim_but);
            this.Controls.Add(this.Detail_but);
            this.Controls.Add(this.Agregar_but);
            this.Controls.Add(this.dataPokemon);
            this.Controls.Add(this.label1);
            this.Name = "Pokedex_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pokedex_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataPokemon;
        private Button Agregar_but;
        private Button Detail_but;
        private Button Elim_but;
        private Button act_but;
        private Button tipos_but;
    }
}