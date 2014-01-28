using System;

namespace DaoLogistica.ENTIDAD
{
    public class Config
    {
        public Config(int id, string clave)
        {
            Id = id;
            Clave = clave;
        }

        public Config()
        {
            Id = 0;
            Clave = String.Empty;
        }

        public int Id { get; set; }

        public string Clave { get; set; }
    }
}
