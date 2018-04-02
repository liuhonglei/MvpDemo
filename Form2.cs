using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class Form2 : Form,IView
    {
        private IPresenter _presenter;
        public Form2()
        {
            InitializeComponent();
            setPresenter(new PresenterImpl(this));
        }

        public void setPresenter(IPresenter presenter)
        {
            this._presenter = presenter;
        }
        void IView.showTitle(string title)
        {
            buttonEdit1.Text = title;
        }

        public event EventHandler ButtonSubmitEvent;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ButtonSubmitEvent != null)
                ButtonSubmitEvent(sender,e);
        }

        
        
    }
}
