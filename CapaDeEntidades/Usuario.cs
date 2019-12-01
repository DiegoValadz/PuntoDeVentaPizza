using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private int id;
        private string  nombre, userName, contraseña, turno, horasPorTurno, puesto, correo, telefono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Turno { get => turno; set => turno = value; }
        public string HorasPorTurno { get => horasPorTurno; set => horasPorTurno = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id { get => id; set => id = value; }
    }
}
