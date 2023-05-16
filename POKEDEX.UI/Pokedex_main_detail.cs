using POKEDEX.BL.BE;
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
    public partial class Pokedex_main_detail : Form
    {
        public int Usuario { get; set; }
       
        public Pokedex_main_detail()
        {
            InitializeComponent();
        }

        private void Pokedex_main_detail_Load(object sender, EventArgs e)
        {
            POKEMONBE pokemonbe = new POKEMONBE();
            POKEMONBC pokemonbc = new POKEMONBC();
            pokemonbe = pokemonbc.PokemonObtener(Usuario);
            pokename_label.Text = pokemonbe.NAME;
            pokemonimage.ImageLocation = pokemonbe.IMAGE_DIR;
        }

        
    }
}
