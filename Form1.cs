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
    public partial class Form1 : Form,IView
    {
        private IPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            setPresenter(new PresenterImpl(this));
        }

        public void setPresenter(IPresenter presenter)
        {
            this._presenter = presenter;
        }

       public  void showTitle(string title)
        {
            MessageBox.Show(title);
        }

        public event EventHandler ButtonSubmitEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ButtonSubmitEvent != null)
                ButtonSubmitEvent(sender,e);
        }

    }
}
