using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeliSoft
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private int idUser;
        private bool su;
        private string codFol = "PSOF-0000";
        public frmMain(int id, string username)
        {
            InitializeComponent();
            XtraMessageBox.Show("Bienvenido: " + username, Application.ProductName, MessageBoxButtons.OK
    , MessageBoxIcon.Information);
            idUser = id;
            su = false;
        }
        public frmMain(bool su, int id, string username)
        {
            InitializeComponent();
            XtraMessageBox.Show("Bienvenido: " + username, Application.ProductName, MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
            idUser = id;
            this.su = su;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //Preguntar si desea cerrar sesion
            if (XtraMessageBox.Show("¿Desea cerrar la sesión?", Application.ProductName,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                recuperarForm();
            }
        }

        private void btnLogOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void recuperarForm()
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmLogin))
                {
                    form.Visible = true;
                    return;
                }
        }

        private void btnPeliculas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmPeliculas))
                {
                    form.Activate();
                    return;
                }
            new frmPeliculas(idUser,Misc.SumaFolio(codFol,1))
            { MdiParent = this }.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCarrito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(fmrCarrito))
                {
                    form.Activate();
                    return;
                }
            new fmrCarrito(idUser,Misc.SumaFolio(codFol,1))
            { MdiParent = this }.Show();
        }

    }
}
