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
    public partial class Prestamos : Form
    {
        string nameUser;
        string[] razasDisponibles = { "raza1", "raza2", "raza3", "raza4", "raza5" };
        string[] lugaresDisponibles;
        int[] cuotasDisponibles = { 12, 24, 36, 60, 120, 180, 240 };
        Dictionary<int, double> interesesBase;


        public Prestamos(string nombre)
        {
            InitializeComponent();

            // Recibir nombre del Form Inicio
            nameUser = nombre;


            // Añadir lugares.txt a lugaresDisponibles
            string listaLugares = Properties.Resources.lugares.ToString(); /* Guardar lugares.txt en un string */
            /* Split separa cada uno de los string de lugares.txt con \r\n y así obtener distintos strings por separado y cada uno se guarde en el string lugaresDisponibles | SringSplitOption.RemoveEmptyEntries se encarga de eliminar cada uno de los espacios en blando que llegara a haber */
            lugaresDisponibles = listaLugares.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            // Inicializamos el diccionario
            interesesBase = new Dictionary<int, double>();

            int i;
            double intereses;
            for (i = 0, intereses = 3.0; i < cuotasDisponibles.Length; i++, intereses += 0.5)
            {
                interesesBase[cuotasDisponibles[i]] = intereses; /* Le asignamos los intereses a cada una de las cuotasDisponibles */
            }
        }

        // Evento cuando carga el Form
        private void Prestamos_Load(object sender, EventArgs e)
        {
            // Concatenar LBL_nombre con el nombre que recibimos del Form Inicio
            LBL_nombre.Text += nameUser;

            // Llenar CBO
            popularRaza();
            popularCiudades();
            popularCuotas();
        }

        private void popularCuotas()
        {
            for(int i = 0; i < cuotasDisponibles.Length; i++)
            {
                CBO_cuotas.Items.Add(cuotasDisponibles[i]); 
            }
        }

        private void popularCiudades()
        {
            for (int i = 0; i < lugaresDisponibles.Length; i++)
            { 
                CBO_origen.Items.Add(lugaresDisponibles[i]);
            }
        }

        private void popularRaza()
        {
            for (int i = 0; i < razasDisponibles.Length; i++)
            {
                CBO_raza.Items.Add(razasDisponibles[i]);
            }
        }

        private void BTN_confirmar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (CBO_raza.SelectedIndex < 0 || CBO_origen.SelectedIndex < 0)
            {
                // Panel izquierdo tiene algún error
                errorProvider1.SetError(panel_DatosPersonales, "Debes completar todas las opciones");
            }
            else if ((TXT_monto.Text == "") || !(TXT_monto.Text.All(Char.IsDigit)) || CBO_cuotas.SelectedIndex < 0)
            {
                // Panel derecho tiene algún error
                errorProvider1.SetError(panel_DatosPrestamo, "Ingresa un monto numérico y selecciona una cuota");
            }
            else
            {
                // Ningún error

            }
        }

        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            // Guardar opción seleccionada de los CBO
            string razaSeleccionada = CBO_raza.SelectedItem.ToString().ToLower();
            string lugarSeleccionado = CBO_origen.SelectedItem.ToString().ToLower();
            int cuotaSeleccionada = (int)CBO_cuotas.SelectedItem;
            double intereses = interesesBase[cuotaSeleccionada];

            // Si razaSeleccionada es raza1 o raza5, se le aumentan los intereses un .3
            if (new [] { "raza1", "raza5" }.Contains(razaSeleccionada)) intereses += .3;
            // Si lugarSeleccionado es rivendell, tirion o valinor se le restan los intereses un .3
            if (new[] { "rivendell", "tirion", "valinor" }.Contains(lugarSeleccionado)) intereses -= .3;

            return intereses;
        }

    }
}
