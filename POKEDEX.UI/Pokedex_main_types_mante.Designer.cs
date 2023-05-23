namespace POKEDEX.UI
{
    partial class Pokedex_main_types_mante
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
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_text = new System.Windows.Forms.TextBox();
            this.aceptar_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statebox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(1, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(294, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "SI_VES_ESTO_ALGO_SALIO_MAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(39, 48);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(100, 23);
            this.id_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // nombre_text
            // 
            this.nombre_text.Location = new System.Drawing.Point(72, 90);
            this.nombre_text.Name = "nombre_text";
            this.nombre_text.Size = new System.Drawing.Size(208, 23);
            this.nombre_text.TabIndex = 4;
            // 
            // aceptar_but
            // 
            this.aceptar_but.Location = new System.Drawing.Point(12, 164);
            this.aceptar_but.Name = "aceptar_but";
            this.aceptar_but.Size = new System.Drawing.Size(75, 23);
            this.aceptar_but.TabIndex = 5;
            this.aceptar_but.Text = "Aceptar";
            this.aceptar_but.UseVisualStyleBackColor = true;
            this.aceptar_but.Click += new System.EventHandler(this.aceptar_but_Click);
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(208, 164);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(75, 23);
            this.back_but.TabIndex = 6;
            this.back_but.Text = "Atras";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // statebox
            // 
            this.statebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statebox.FormattingEnabled = true;
            this.statebox.Items.AddRange(new object[] {
            "ACT",
            "ELI"});
            this.statebox.Location = new System.Drawing.Point(72, 126);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(121, 23);
            this.statebox.TabIndex = 8;
            // 
            // Pokedex_main_types_mante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 199);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.aceptar_but);
            this.Controls.Add(this.nombre_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Name = "Pokedex_main_types_mante";
            this.Text = "Pokedex_main_types_mante";
            this.Load += new System.EventHandler(this.Pokedex_main_types_mante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Label label1;
        private TextBox id_text;
        private Label label2;
        private TextBox nombre_text;
        private Button aceptar_but;
        private Button back_but;
        private Label label3;
        private ComboBox statebox;
    }
}