using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMG
{
    public interface IController
    {
        public Controller()
        {
           void PortionHerstellen();
           void FreifahrenBereit();
           void LeerFahren();
        }

        private void PortionHerstellen(object sender, EventArgs e)
        {
            Console.WriteLine("Portion wird hergestellt");
        }
       
        private void FreifahrenBereit(object sender, EventArgs e)
        {
            Console.WriteLine("Freifahren auf Bereit gesetzt");
        }
        
        private void LeerFahren(object sender, EventArgs e)
        {
            Console.WriteLine("Leerfahren wird ausgeführt");
        }
    }
}
