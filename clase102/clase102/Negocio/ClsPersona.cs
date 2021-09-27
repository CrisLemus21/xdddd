using clase102.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase102.Negocio
{
    class ClsPersona
    {
        public string persona(persona vari)
        {
            return "";
        }

        public int acceso(persona per)
        {
            if (per.Noombre == "cristian" && per.Contra == 123)
            {
                return 1;
            }
            else
            {
                return 0;
            }


            
        }
    }
}
