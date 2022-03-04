using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoNaucalpan
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();                
        }

        // BTN_solicitar
        private void BTN_solicitar_Click(object sender, EventArgs e)
        {
            // using nos permite eliminar a futuro la instanciaPrestamos para así ahorrar recursos en la memoria
            using (Prestamos instanciaPrestamos = new Prestamos(TXT_nombre.Text.Trim())) instanciaPrestamos.ShowDialog();
        }

        // BTN_salir
        private void BTN_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Formulario
        private void Inicio_Load(object sender, EventArgs e)
        {
            BTN_solicitar.Enabled = false;
        }

        // Input
        private void TXT_nombre_TextChanged(object sender, EventArgs e)
        {
            controlDeBTN();
        }

        // Método para validar TXT
        private void controlDeBTN()
        {
            // Validar que el nombre no esté vacío && que el texto sea únicamente letras
            if(TXT_nombre.Text.Trim() != string.Empty && TXT_nombre.Text.All(Char.IsLetter))
            {
                BTN_solicitar.Enabled = true;
                errorProvider1.SetError(TXT_nombre, "");
            } else
            {
                // Validar si el texto está vacío
                if (TXT_nombre.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(TXT_nombre, "Completa este campo");
                }
                // Validar si el texto contiene números o caracteres especiales
                if (!TXT_nombre.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(TXT_nombre, "El nombre debe de contener únicamente letras");
                }

                BTN_solicitar.Enabled = false;
                TXT_nombre.Focus();
            }
        }
    }
}
