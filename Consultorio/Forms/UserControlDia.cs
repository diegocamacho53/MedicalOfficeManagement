using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Formularios
{
    public partial class UserControlDia : UserControl
    {
        public UserControlDia()
        {
            InitializeComponent();
        }

        private void UserControlIDDia_Load(object sender, EventArgs e)
        {

        }
        public void dia (int numDia)
        {
            IdDia.Text = numDia + "";
        }
    }


}
