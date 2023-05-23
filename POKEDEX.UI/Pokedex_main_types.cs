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
    public partial class Pokedex_main_types : Form
    {
        public Pokedex_main_types()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            TYPESBC pokemonbc = new TYPESBC();

            dataGridView1.DataSource = pokemonbc.PokemonListar(); ;
            dataGridView1.Columns["TYPE_STATE"].Visible = false;
          
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pokedex_main_types_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void atras_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void act_but_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void insertar_but_Click(object sender, EventArgs e)
        {
            try
            {
                Pokedex_main_types_mante podetail = new Pokedex_main_types_mante();
                podetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ocurrió en la insercion del objeto");
            }
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            try
            {
                Pokedex_main_types_mante podetail = new Pokedex_main_types_mante();
                podetail.UserID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                podetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un tipo (" + ex.Message + ").");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TYPESBC typebc = new TYPESBC();
                if (typebc.TypeEliminar(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)))
                {
                    MessageBox.Show("Tipo eliminado");
                    Actualizar();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El tipo es invalido o no se pudo eliminar");
            }
        }
    }
}
