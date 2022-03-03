using LiskovSubstitutionPrinciple.refactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal turtle = new Turtle();
            turtle.Hunt();//LANZARA EXCEPCION


            //luego del refactor podriamos enviar a cazar a los animales
            //sin que lance un excepcion ya que la toruga no estara en este list
             void GoToHunt(List<IHunt> hunters)
            {
                foreach(var hunter in hunters)
                {
                    hunter.Hunt();
                }
            }
        }
    }
}
