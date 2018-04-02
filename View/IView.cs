using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
    public interface IView
    {
        //void setPresenter(IPresenter presenter);
        void showTitle(string title);
        event EventHandler ButtonSubmitEvent;  
    }
}
