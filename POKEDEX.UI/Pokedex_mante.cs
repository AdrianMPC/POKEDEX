using POKEDEX.BL.BC;
using POKEDEX.BL.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POKEDEX.UI
{
    public partial class Pokedex_mante : Form
    {
        public int? Userid { get; set; }
        public bool EDIT_FLAG { get; set; }

        public Pokedex_mante()
        {
            InitializeComponent();
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pokedex_mante_Load(object sender, EventArgs e)
        {
            try
            {
                TYPESBC typesbc = new TYPESBC();
                type1_box.DataSource = typesbc.PokemonListar();
                type1_box.ValueMember = "TYPE_ID";
                type1_box.DisplayMember = "TYPE_NAME";
                type2_box.DataSource = typesbc.PokemonListar();
                type2_box.ValueMember = "TYPE_ID";
                type2_box.DisplayMember = "TYPE_NAME";

                if (Userid.HasValue)
                {
                    label1.Text = "Edita el pokemon";
                    EDIT_FLAG = true;
                    POKEMONBC pokemonbc = new POKEMONBC();
                    POKEMONBE pokemonbe = pokemonbc.PokemonObtener(Userid.GetValueOrDefault());
                    type1_box.SelectedValue = pokemonbe.TYPE1;

                    if (pokemonbe.TYPE2.HasValue)
                    {
                        type2_box.SelectedValue = pokemonbe.TYPE2.GetValueOrDefault();
                    } else
                    {
                        type2_box.SelectedValue = -1;
                    }

                    ID_TEXT.Text = pokemonbe.POKEMONID.ToString();
                    URLBOX.Text = pokemonbe.IMAGE_DIR.ToString();
                    Nombre_text.Text = pokemonbe.NAME.ToString();
                    HPtext.Text = pokemonbe.HP.ToString();
                    atk_text.Text = pokemonbe.ATTACK.ToString();
                    def_text.Text = pokemonbe.DEFENSE.ToString();
                    spd_atk_text.Text = pokemonbe.SPEED_ATTACK.ToString();
                    spd_def_text.Text = pokemonbe.SPEED_DEFENSE.ToString();
                    speed_text.Text = pokemonbe.SPEED.ToString();
                    state_box.SelectedText = pokemonbe.STATE;
                }
                else
                {
                    EDIT_FLAG = false;
                    label1.Text = "Agrega tu pokemon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_but_Click(object sender, EventArgs e)
        {
            try
            {
         

                if (EDIT_FLAG)
                {
                    System.Windows.Forms.TextBox[] TextBoxes = {URLBOX, ID_TEXT,Nombre_text 
                            ,HPtext, atk_text, def_text, spd_atk_text, spd_def_text, speed_text};

                    foreach(System.Windows.Forms.TextBox TextBx in TextBoxes)
                    {
                        if (string.IsNullOrEmpty(TextBx.Text))
                        {
                            throw new Exception();
                        }
                    }
                    POKEMONBC pokemonbc = new POKEMONBC();
                    POKEMONBE pokemonbe = new POKEMONBE();
                    pokemonbe.TYPE1 = Convert.ToInt32(type1_box.SelectedValue);
                    pokemonbe.TYPE2 = Convert.ToInt32(type2_box.SelectedValue);
                    pokemonbe.POKEMONID = Convert.ToInt32(ID_TEXT.Text);
                    pokemonbe.NAME = Nombre_text.Text;
                    pokemonbe.HP = Convert.ToInt32(HPtext.Text);
                    pokemonbe.ATTACK = Convert.ToInt32(atk_text.Text);
                    pokemonbe.DEFENSE = Convert.ToInt32(def_text.Text);
                    pokemonbe.SPEED_ATTACK = Convert.ToInt32(spd_atk_text.Text);
                    pokemonbe.SPEED_DEFENSE = Convert.ToInt32(spd_def_text.Text);
                    pokemonbe.SPEED = Convert.ToInt32(speed_text.Text);
                    pokemonbe.STATE = state_box.GetItemText(state_box.SelectedItem);
                    pokemonbe.IMAGE_DIR = URLBOX.Text;

                    if (pokemonbc.PokemonEditar(pokemonbe))
                    {
                        MessageBox.Show("Pokemon editado correctamente!");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                } 
                else
                {
                    System.Windows.Forms.TextBox[] TextBoxes = {URLBOX, ID_TEXT,Nombre_text
                            ,HPtext, atk_text, def_text, spd_atk_text, spd_def_text, speed_text};

                    foreach (System.Windows.Forms.TextBox TextBx in TextBoxes)
                    {
                        if (string.IsNullOrEmpty(TextBx.Text))
                        {
                            throw new Exception();
                        }
                    }

                    POKEMONBC pokemonbc = new POKEMONBC();
                    POKEMONBE pokemonbe = new POKEMONBE();
                    pokemonbe.TYPE1 = Convert.ToInt32(type1_box.SelectedValue);
                    pokemonbe.TYPE2 = Convert.ToInt32(type2_box.SelectedValue);
                    pokemonbe.POKEMONID = Convert.ToInt32(ID_TEXT.Text);
                    pokemonbe.NAME = Nombre_text.Text;
                    pokemonbe.HP = Convert.ToInt32(HPtext.Text);
                    pokemonbe.ATTACK = Convert.ToInt32(atk_text.Text);
                    pokemonbe.DEFENSE = Convert.ToInt32(def_text.Text);
                    pokemonbe.SPEED_ATTACK = Convert.ToInt32(spd_atk_text.Text);
                    pokemonbe.SPEED_DEFENSE = Convert.ToInt32(spd_def_text.Text);
                    pokemonbe.SPEED = Convert.ToInt32(speed_text.Text);
                    pokemonbe.STATE = "ACT";
                    pokemonbe.IMAGE_DIR = URLBOX.Text;

                    if (pokemonbc.PokemonInsertar(pokemonbe))
                    {
                        MessageBox.Show("Pokemon agregado correctamente!");
                        this.Close();
                    } 
                    else
                    {
                        throw new Exception();
                        MessageBox.Show("Error al crear pokemon!");
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void speed_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void visual_imagen_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = URLBOX.Text;
        }

        private void cancelar_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
