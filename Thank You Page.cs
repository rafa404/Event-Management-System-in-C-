using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class Thank_You_Page : Form
    {
        public Thank_You_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Thank_You_Page_Load(object sender, EventArgs e)
        {

        }

        private void closeprogrambuttonbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
