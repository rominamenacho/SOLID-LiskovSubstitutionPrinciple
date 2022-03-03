using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Turtle:Animal
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Hunt()
        {
            throw new NotImplementedException();
        }
    }
}
//el hecho de sobreescribir los metodos rompe el principio
//por el cual una clase hija puede ser usada como si fuera una clase padre
//sin alterar su comportamiento