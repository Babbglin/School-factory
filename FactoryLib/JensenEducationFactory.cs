using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public class JensenEducationFactory:SchoolAbstractFactory
    {
        public override IEducation CreatEducation()
        {
            return new JensenEducation();
        }
    }
}
