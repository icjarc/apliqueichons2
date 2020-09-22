
using System;

namespace p15cuentabancariav1
{
    class CuentaBancaria 
    {
        protected double saldo;
        public CuentaBancaria(double saldo){ // constructor
            this.saldo = saldo;
            }
        public double Saldo {
            get { return saldo;}
        }

        public void Deposita(double cant){
            saldo+=cant;
        }
        public virtual bool Retira(double cant){  
            if(saldo>=cant){
                saldo-=cant;
                return true;
            }else return false;
        }
        
        }
}