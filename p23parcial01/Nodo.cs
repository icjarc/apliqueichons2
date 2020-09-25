using System;
using System.Collections.Generic;
using System.Linq;

namespace p23parcial01
{
    class Nodo{

        private string ip, tipo, so;

        private int puertos,saltos;
        
        private List<Vulnerabilidad> vulnerabilidades;
        
        public Nodo(string ip, string tipo, int puertos, int saltos, string so){
            this.ip = ip;
            this.tipo =  tipo;
            this.puertos = puertos;
            this.saltos = saltos;
            this.so = so;
            vulnerabilidades = new List<Vulnerabilidad>();
        }
        public string Ip{
            get{return ip;} set{ip = value;}
        }
        public string Tipo{
            get{return tipo;} set{tipo = value;}
        }
        public int Puertos{
            get{return puertos;} set{puertos = value;}
        }
        public int Saltos{
            get{return saltos;} set{saltos = value;}
        }
        public string SO{
            get{return so;} set{so = value;}
        }
        public List<Vulnerabilidad> Vulnerabilidades{
            get{return vulnerabilidades;}
        }
        public void AumentaVulnerabilidad(Vulnerabilidad vul){
            vulnerabilidades.Add(vul);
        }
        public override string ToString() =>
            $"Ip:{Ip}, Tipo:{Tipo}, Puertos:{Puertos}, Saltos:{Saltos}, S.O:{SO}";
    }
}
// EP1 RenteriaCabreraJulioArturo