using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
    public class Model:IModel
    {

        public string GetTitle() {

            return "MVPTest";
        }
    }
}
