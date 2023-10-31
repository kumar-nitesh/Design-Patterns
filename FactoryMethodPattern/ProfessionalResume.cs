using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ProfessionalResume : PageMethod
    {
        public override void CreatePages()
        {
            Pages.Add(new EducationPage());
            Pages.Add(new SkillsPage());
        }
    }
}
