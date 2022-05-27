using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliSoft
{
    public partial class borrar : DevExpress.XtraEditors.XtraForm
    {
        public borrar()
        {
            InitializeComponent();
        }

        private void borrar_Load(object sender, EventArgs e)
        {
            lenguasBindingSource.DataSource = new Lenguas().GetAll();
        }
    }
}