using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoMAUI.Models
{
    public class clsMisionCompletada : clsMision
    {
        private DateTime fechaFinalizada;

        public DateTime FechaFinalizada { 
            get { return fechaFinalizada; } 
            set { fechaFinalizada = value; } 
        }

        public clsMisionCompletada(clsMision m) 
        {
            this.Id = m.Id;
            this.Nombre = m.Nombre;
            this.Descripcion = m.Descripcion;
            this.Recompensa = m.Recompensa;
            fechaCompletada();
        }

        private void fechaCompletada()
        {
            this.fechaFinalizada= DateTime.Now;
        }
    }
}
