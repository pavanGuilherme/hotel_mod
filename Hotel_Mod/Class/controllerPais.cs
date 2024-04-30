using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mod.Class
{
    public class controllerPais<T> : Controller<T>
    {
        private DaoPais<T> daoPais; 

        public controllerPais() : base() 
        {
            daoPais = new DaoPais<T>();           
        }

        public override void alterar(T obj)
        {
            daoPais.alterar(obj);
        }
        public override void excluir(int idobj)
        {
            daoPais.excluir(idobj); 
        }

        public override void salvar(T obj)
        {
           daoPais.Salvar(obj);
        }

        public override List<T> GetAll(bool inativos)
        {
            return daoPais.GetAll(inativos);
        }

        public override T pesquisar(int id)
        {
           return daoPais.pesquisar(id);
        }
    }
}
