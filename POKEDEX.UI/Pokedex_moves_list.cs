using POKEDEX.BL.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POKEDEX.UI
{
    public partial class Pokedex_moves_list : Form
    {
        public int Codigo1 { get; set; }
        public int Codigo2 { get; set; }
        public Pokedex_moves_list()
        {
            InitializeComponent();
            Codigo2 = -1;
        }

        private void Pokedex_moves_list_Load(object sender, EventArgs e)
        {
            MOVESBC movesobj = new MOVESBC();
            movesviewGrid.DataSource = movesobj.MovimientosListar(Codigo1, Codigo2);
            movesviewGrid.Columns["MOVES_ID"].Visible = false;
            movesviewGrid.Columns["TYPES_ID"].Visible = false;
        }

        private void atras_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
