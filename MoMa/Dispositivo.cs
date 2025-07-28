using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaMo
{
    internal class Dispositivo
    {
        private int idDispositivo;
        private string Nome;
        private List<Alarme> Alarmes;

        public List<Alarme> alarmesDispositivo() { return new List<Alarme>(); }
        public void acionarAlarme() { }
        public void ligarDispositivo() { }
        public void desligarDispostivo() { }

    }
}
