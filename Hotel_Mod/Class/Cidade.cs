using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mod.Class
{
    internal class Cidade
    {
        public int cidade_id { get; set; }
        public string cidade_nome { get; set; }
        public DateTime data_cadastro {  get; set; }
        public DateTime dat_ult_alt { get; set; }
        public bool ativo { get; set; }

    }
}
