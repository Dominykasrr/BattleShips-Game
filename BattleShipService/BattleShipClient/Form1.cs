using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    public partial class Form1 : Form
    {
        ServiceReference1.PortalClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.PortalClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (proxy.Login(tbName.Text, tbPasswd.Text)) MessageBox.Show("u did it");
<<<<<<< HEAD
            Form Battle_Ship = new Battle_Ship();
            Battle_Ship.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //
        }

        public void playerLoggedIn(string name)
        {
            throw new NotImplementedException();
=======
>>>>>>> origin/master
        }
    }
}
