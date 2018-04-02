using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
    public class PresenterImpl:IPresenter
    {
        private IView _view;
        private IModel _model;
        public PresenterImpl(IView view) {
            _view = view;
            _view.ButtonSubmitEvent += _view_ButtonSubmitEvent;
            _model = new Model();
        }

        //void IPresenter.Submit()
        //{
        //    if(_view != null)
        //        _view.ButtonSubmitEvent +=_view_ButtonSubmitEvent;
        //}

        private void _view_ButtonSubmitEvent(object sender, EventArgs e)
        {
            string title = _model.GetTitle();
            _view.showTitle(title);
        }
    }
}
