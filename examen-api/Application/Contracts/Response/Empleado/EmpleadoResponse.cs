using System;

namespace examen_api.Application.Contracts.Response.Empleado
{
    public class EmpleadoResponse
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public bool afp { get; set; }
        public int cargo_id { get; set; }
        public string nombre_cargo { get; set; }
        public decimal sueldo { get; set; }
    }
}

