using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal {
    static class Program  {
        // Punto de entrada principal para la aplicación.
        
        [STAThread]

        //Metodo Main
        static void Main()  {
            Application.EnableVisualStyles();    //Habilitar los estilos visuales para la aplicacion
            Application.SetCompatibleTextRenderingDefault(false);   //Establece el motor de representacion predeterminado para algunos controles
            Application.Run(new SubInterfaz());   //Inicia el objeto para su ejecucion
        }

    }
}