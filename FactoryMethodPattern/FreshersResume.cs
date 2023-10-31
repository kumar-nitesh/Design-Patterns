using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FreshersResume : PageMethod
    {
        public override void CreatePages()
        {
            Pages.Add(new EducationPage());
        }
    }
}
