using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class PageMethod
    {
        private List<PageFactory> _pages = new List<PageFactory>();

        public PageMethod()
        {
            this.CreatePages();
        }
        public List<PageFactory> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
