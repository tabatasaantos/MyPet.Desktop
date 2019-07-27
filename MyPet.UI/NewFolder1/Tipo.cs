using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.UI.NewFolder1
{
    public class Tipo
    {
        internal int idTipo;

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Caracteristicas { get; set; }
        public string Nome { get; internal set; }
    }
}
