using System;
using System.Collections.Generic;
using System.Linq;

namespace p23parcial01
{
    class Red{
        private string empresa , propietario , domicilio;
        private List<Nodo> nodos;
        public Red(string empresa, string propietario, string domicilio){
            this.empresa = empresa;
            this.propietario = propietario;
            this.domicilio = domicilio;
            nodos = new List<Nodo>();
        }
        public string Empresa{
            get{return empresa;} set{empresa = value;}
        }
        public string Propietario{
            get{return propietario;} set{propietario = value;}
        }
        public string Domicilio{
            get{return domicilio;} set{domicilio = value;}
        }
        public List<Nodo> Nodos{
            get{return nodos;}
        }
        public void AumentaNodo(Nodo nod){
            nodos.Add(nod);
        }
    }
}
// EP1 RenteriaCabreraJulioArturo