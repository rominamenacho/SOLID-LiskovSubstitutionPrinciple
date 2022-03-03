using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Animal
    {
        public virtual void Run() { }

        public virtual void Hunt() { }

        public virtual void Walk() { }

    }
}
