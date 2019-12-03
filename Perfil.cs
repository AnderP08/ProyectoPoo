using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    class Perfil
    {
        public Perfil()
        {
            ListCaracteristicas = new List<Caracteristica>();
            ListAmistads = new List<Amistad>();
            ListSolicitudes = new List<Solicitud>();
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  Ciudad { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }

        public List<Caracteristica> ListCaracteristicas { get; set; }

        public List<Solicitud> ListSolicitudes { get; set; }
        public List<Amistad> ListAmistads { get; set; }
    }
}
