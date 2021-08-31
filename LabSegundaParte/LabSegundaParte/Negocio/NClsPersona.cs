using LabSegundaParte.Entidades;
using System;

namespace LabSegundaParte.Negocio
{
    public class NClsPersona

    {
        ClsPersona per = new ClsPersona(0, 0);
        public string CalcularIMc()
        {

            double pro = per.Peso / Math.Pow(per.Altura, 2);
            if (pro < 20)
            {
                return "peso es ideal";


            }
            if (pro > 25)
            {
                return "tiene sobre peso";
            }
            

           












        }
        
        


    }   }
