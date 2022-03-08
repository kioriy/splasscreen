using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splashScreen
{
    public partial class FrmSplasScreen : Form
    {
        int contador = 0;

        List<string> list_descripcion_progreso = new List<string>
        {
            "Conectando con el servidor...",
            "Verificando nuevas versiones...",
            "Cargando información de la base de datos...",
            "Validando licencia del producto...",
            "Estamos terminando..",
            "La paciencia es una virtud...",
            "Te cuento un chiste...",
            "Ahi va.... ",
            "A no te creas ya terminamos...",
            "Muchas gracias por la espera ; ) ..."

        };

        public FrmSplasScreen()
        {
            InitializeComponent();
            lDescripionProgreso.Text = "";
        }

        private void tLoading_Tick(object sender, EventArgs e)
        {
            loadProgressBar(contador);
            contador++;

            if (contador == 10)
            {
                pbLoading.Value = 10;
                Application.Exit();
            }
        }

        public void loadProgressBar(int increment)
        {
            lDescripionProgreso.Text = list_descripcion_progreso[increment];

            pbLoading.Value = (increment + 1);
        }
    }
}
