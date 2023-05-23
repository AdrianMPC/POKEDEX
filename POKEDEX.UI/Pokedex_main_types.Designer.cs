namespace POKEDEX.UI
{
    partial class Pokedex_main_types
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertar_but = new System.Windows.Forms.Button();
            this.edit_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atras_but = new System.Windows.Forms.Button();
            this.act_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(318, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertar_but
            // 
            this.insertar_but.Location = new System.Drawing.Point(12, 426);
            this.insertar_but.Name = "insertar_but";
            this.insertar_but.Size = new System.Drawing.Size(75, 23);
            this.insertar_but.TabIndex = 1;
            this.insertar_but.Text = "Insertar";
            this.insertar_but.UseVisualStyleBackColor = true;
            this.insertar_but.Click += new System.EventHandler(this.insertar_but_Click);
            // 
            // edit_but
            // 
            this.edit_but.Location = new System.Drawing.Point(93, 426);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(75, 23);
            this.edit_but.TabIndex = 2;
            this.edit_but.Text = "Editar";
            this.edit_but.UseVisualStyleBackColor = true;
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipos";
            // 
            // atras_but
            // 
            this.atras_but.Location = new System.Drawing.Point(255, 426);
            this.atras_but.Name = "atras_but";
            this.atras_but.Size = new System.Drawing.Size(75, 23);
            this.atras_but.TabIndex = 5;
            this.atras_but.Text = "Atras";
            this.atras_but.UseVisualStyleBackColor = true;
            this.atras_but.Click += new System.EventHandler(this.atras_but_Click);
            // 
            // act_but
            // 
            this.act_but.Location = new System.Drawing.Point(255, 28);
            this.act_but.Name = "act_but";
            this.act_but.Size = new System.Drawing.Size(75, 23);
            this.act_but.TabIndex = 6;
            this.act_but.Text = "Actualizar";
            this.act_but.UseVisualStyleBackColor = true;
            this.act_but.Click += new System.EventHandler(this.act_but_Click);
            // 
            // Pokedex_main_types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 459);
            this.Controls.Add(this.act_but);
            this.Controls.Add(this.atras_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_but);
            this.Controls.Add(this.insertar_but);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pokedex_main_types";
            this.Text = "Pokedex_main_types";
            this.Load += new System.EventHandler(this.Pokedex_main_types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button insertar_but;
        private Button edit_but;
        private Button button1;
        private Label label1;
        private Button atras_but;
        private Button act_but;
    }
}