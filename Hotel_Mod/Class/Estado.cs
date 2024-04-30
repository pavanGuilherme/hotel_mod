using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mod.Class
{
    internal class Estado
    {
        public int estado_id {  get; set; }
        public string estado_nome {  get; set; }
        public string uf {  get; set; }
        public string ddd {  get; set; }
        public bool ativo { get; set; }
        public DateTime data_cadastro {  get; set; }
        public DateTime dat_ult_alt { get; set; }


    }
}
