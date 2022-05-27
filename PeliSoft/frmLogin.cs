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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        bool ok = false;
        private int idUser = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Preguntar si desea cerrar sesion
            if (XtraMessageBox.Show("¿Desea cerrar la aplicación?", Application.ProductName,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user.Equals("") || pass.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar los campos", Application.ProductName, MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
                return;
            }
            
            Login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void obtenerid()
        {
            Usuario obj = new Usuario()
            {
                nombre = txtUser.EditValue.ToString(),
                password = txtPass.EditValue.ToString()
            }.Login();
            idUser = obj.IdUsuario;
        }
        private void Login()
        {
            if(new Usuario() { nombre = txtUser.EditValue.ToString(),
                password = txtPass.EditValue.ToString()
            }.Login() !=null)
            {
                if(new Usuario()
                {
                    nombre = txtUser.EditValue.ToString(),
                    password = txtPass.EditValue.ToString()
                }.SU() != null)
                {
                    obtenerid();
                    frmMain frmAD = new frmMain(true, idUser, txtUser.EditValue.ToString());
                    frmAD.Show();
                    this.Hide();
                }
                else
                {
                    obtenerid();
                    this.Hide();
                    frmMain frm = new frmMain(idUser, txtUser.EditValue.ToString());
                    frm.Show();
                }
                txtPass.EditValue = "";
                txtUser.EditValue = "";

            }
            else
            {
                XtraMessageBox.Show("Credenciales incorrectas", Application.ProductName, MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
            }
        }
    }  
}