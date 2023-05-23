using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using POKEDEX.BL.BC;
using POKEDEX.BL.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POKEDEX.UI
{
    public partial class Pokedex_main_types_mante : Form
    {
        public int? UserID { get; set; }
        private bool EDIT_FLAG;
        public Pokedex_main_types_mante()
        {
            InitializeComponent();
        }

        private void Pokedex_main_types_mante_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserID.HasValue)
                {
                    label_title.Text = "Edita el tipo";
                    statebox.Visible = true;
                    label3.Visible = true;
                    EDIT_FLAG = true;
                    TYPESBC typebc = new TYPESBC();
                    TYPESBE typebe = typebc.TypeObtener(UserID.GetValueOrDefault());

                    id_text.Text = typebe.TYPE_ID.ToString();
                    id_text.ReadOnly = true;
                    nombre_text.Text = typebe.TYPE_NAME;

            }
                else
                {
                    EDIT_FLAG = false;
                    id_text.ReadOnly = false;
                    statebox.Visible = false;
                    label3.Visible = false;
                    label_title.Text = "Crea un nuevo tipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void aceptar_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (EDIT_FLAG)
                {
                  
                    if (string.IsNullOrEmpty(nombre_text.Text))
                    {
                        throw new Exception("Rellene todos los espacios en blanco!");
                    }
                    
                    TYPESBC typesbc = new TYPESBC();
                    TYPESBE typesbe = new TYPESBE();

                    typesbe.TYPE_ID = Convert.ToInt32(id_text.Text);
                    typesbe.TYPE_NAME = nombre_text.Text;
                    typesbe.TYPE_STATE = statebox.GetItemText(statebox.SelectedItem);


                    if (typesbc.TypeEditar(typesbe))
                    {
                        MessageBox.Show("Tipo editado correctamente!");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Error al editar Tipo");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(nombre_text.Text))
                    {
                        throw new Exception("Rellene todos los espacios en blanco!");
                    }

                    TYPESBC typesbc = new TYPESBC();
                    TYPESBE typesbe = new TYPESBE();

                    typesbe.TYPE_ID = Convert.ToInt32(id_text.Text);
                    typesbe.TYPE_NAME = nombre_text.Text;
                    typesbe.TYPE_STATE = "ACT";


                    if (typesbc.TypeInsertar(typesbe))
                    {
                        MessageBox.Show("Tipo agregado correctamente!");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Error al agregar el Tipo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal -> " + ex.Message);
            }
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
