namespace POKEDEX.UI
{
    partial class Pokedex_moves_list
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
            this.movesviewGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.atras_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movesviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // movesviewGrid
            // 
            this.movesviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movesviewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.movesviewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.movesviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movesviewGrid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.movesviewGrid.Location = new System.Drawing.Point(12, 56);
            this.movesviewGrid.MultiSelect = false;
            this.movesviewGrid.Name = "movesviewGrid";
            this.movesviewGrid.ReadOnly = true;
            this.movesviewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.movesviewGrid.RowTemplate.Height = 25;
            this.movesviewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movesviewGrid.Size = new System.Drawing.Size(621, 346);
            this.movesviewGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ataques que el pokemon puede aprender:";
            // 
            // atras_but
            // 
            this.atras_but.Location = new System.Drawing.Point(558, 27);
            this.atras_but.Name = "atras_but";
            this.atras_but.Size = new System.Drawing.Size(75, 23);
            this.atras_but.TabIndex = 2;
            this.atras_but.Text = "Atras";
            this.atras_but.UseVisualStyleBackColor = true;
            this.atras_but.Click += new System.EventHandler(this.atras_but_Click);
            // 
            // Pokedex_moves_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 415);
            this.Controls.Add(this.atras_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movesviewGrid);
            this.Name = "Pokedex_moves_list";
            this.Text = "Pokedex_moves_list";
            this.Load += new System.EventHandler(this.Pokedex_moves_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movesviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView movesviewGrid;
        private Label label1;
        private Button atras_but;
    }
}