using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public abstract class SchoolAbstractFactory
    {
        public SchoolAbstractFactory()
        {
            
        }

        public abstract IEducation CreatEducation();
    }
}
