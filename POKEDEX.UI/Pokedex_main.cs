using POKEDEX.BL.BC;
using POKEDEX.BL.BE;
using System.Windows.Forms;

namespace POKEDEX.UI
{
    public partial class Pokedex_main : Form
    {
        public Pokedex_main()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            POKEMONBC pokemonbc = new POKEMONBC();

            dataPokemon.DataSource = pokemonbc.PokemonListar(); ;
            dataPokemon.Columns["IMAGE_DIR"].Visible = false;
            dataPokemon.Columns["STATE"].Visible = false;
            dataPokemon.Columns["TYPE1"].Visible = false;
            dataPokemon.Columns["TYPE2"].Visible = false;
        }
        private void Pokedex_main_Load(object sender, EventArgs e)
        {
            POKEMONBC pokemonbc = new POKEMONBC();

            dataPokemon.DataSource = pokemonbc.PokemonListar(); ;
            dataPokemon.Columns["IMAGE_DIR"].Visible = false;
            dataPokemon.Columns["STATE"].Visible = false;
            dataPokemon.Columns["TYPE1"].Visible = false;
            dataPokemon.Columns["TYPE2"].Visible = false;
        }

        private void Detail_but_Click(object sender, EventArgs e)
        {
            try
            {
                Pokedex_main_detail podetail = new Pokedex_main_detail();
                podetail.Usuario = Convert.ToInt32(dataPokemon.SelectedRows[0].Cells[0].Value);
                podetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un pokemon (" + ex.Message + ").");
            }
        }

        private void Agregar_but_Click(object sender, EventArgs e)
        {
            try
            {
                Pokedex_mante poke = new Pokedex_mante();
                poke.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un pokemon (" + ex.Message + ").");
            }
        }

        private void act_but_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Elim_but_Click(object sender, EventArgs e)
        {
            try
            {
                POKEMONBC pokemonbc = new POKEMONBC();
                if (pokemonbc.PokemonEliminar(Convert.ToInt32(dataPokemon.SelectedRows[0].Cells[0].Value)))
                {
                    MessageBox.Show("Pokemon Eliminado");
                    Actualizar();
                } else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El pokemon es invalido o no se pudo eliminar");
            }
        }
    }   
}