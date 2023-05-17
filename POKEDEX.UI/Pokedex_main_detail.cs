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
        POKEMONBE pokemonbe = new POKEMONBE();
        POKEMONBC pokemonbc = new POKEMONBC();
        public int Usuario { get; set; }
       
        public Pokedex_main_detail()
        {
            InitializeComponent();
        }

        private void Pokedex_main_detail_Load(object sender, EventArgs e)
        {
            
            pokemonbe = pokemonbc.PokemonObtener(Usuario);
            pokename_label.Text = pokemonbe.NAME;

            tipo_label.Text     = "Tipo 1: "        +  pokemonbe.TYPEs1;

           
            tipo2_label.Text     = "Tipo 2: " + pokemonbe.TYPEs2;
            

            hp_label.Text       = "HP: "            +  pokemonbe.HP;
            attack_label.Text   = "Attack: "          + pokemonbe.ATTACK;
            defense_label.Text  = "Defense: "       +  pokemonbe.DEFENSE;
            spd_atk_label.Text  = "Speed attack: "  +  pokemonbe.SPEED_ATTACK;
            spd_def_label.Text  = "Speed defense: " +  pokemonbe.SPEED_DEFENSE;
            speed_label.Text    = "Speed: "         +  pokemonbe.SPEED;

            pokemonimage.ImageLocation = pokemonbe.IMAGE_DIR;
        }

        private void atras_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atc_but_Click(object sender, EventArgs e)
        {
            Pokedex_moves_list frmMoves = new Pokedex_moves_list();
            frmMoves.Codigo1 = pokemonbe.TYPE1;
            if(pokemonbe.TYPE2.HasValue)
            {
                frmMoves.Codigo2 = pokemonbe.TYPE2.GetValueOrDefault();
            }
      
            frmMoves.ShowDialog();
        }

        private void editar_but_Click(object sender, EventArgs e)
        {
            Pokedex_mante poke = new Pokedex_mante();
            poke.Userid = pokemonbe.POKEMONID;
            poke.ShowDialog();
        }
    }
}
