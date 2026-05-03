using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.BDsimulador
{
    public class DatosPrueba
    {
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static List<Rol> Roles = new List<Rol>();

        static DatosPrueba()
        {
            Roles.Add(new Rol(1111, "Administrador"));
            Roles.Add(new Rol(2222, "Auditor"));
            Roles.Add(new Rol(3333, "Operador"));

            Usuarios.Add(new Usuario(20111110, "ManolitoR", "manolito", "Manolito Ramirez", 2222));
            Usuarios.Add(new Usuario(21000001, "BenitoG", "benito", "Garcia Benito", 1111));
            Usuarios.Add(new Usuario(19000111, "FelipeG", "felipe", "Gonzales felipe", 3333));
        }
    }
}
