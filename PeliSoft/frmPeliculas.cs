using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmPeliculas : DevExpress.XtraEditors.XtraForm
    {
        private string codFol = "PSOF-0000";
        private string folio;
        private bool isfound = false;
        private int id;

        public frmPeliculas(int idUser,string folio)
        {
            InitializeComponent();
            Usuario usuario = new Usuario() { IdUsuario = idUser }.getById();
            id = idUser;
            this.folio = folio;
            lbUser.Text = usuario.nombre;
            lbFolio.Text = folio;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            //string folio = Misc.SumaFolio(codFol, 1);
            //Random myObject = new Random();
            //int ranNum = myObject.Next(100, 150);
            lbFolio.Text = this.folio;
            cargar();
            this.btnClean.Visible = false;
            //XtraMessageBox.Show("Valor" + folio, Application.ProductName,
            //MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            peliculaBindingSource.ResetBindings(true);
            peliculaBindingSource.DataSource = new Pelicula().GetAll();
            this.btnFind.Visible = true;
        }

        private void cargar()
        {
            peliculaBindingSource.ResetBindings(true);
            generoBindingSource.DataSource = new Genero().GetAll();
            luLen.DataSource = new Lenguas().GetAll();
            luGen.DataSource = new Genero().GetAll();
            peliculaBindingSource.DataSource = new Pelicula().GetAll();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }


        private void btnAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gcPeliculas.MainView as ColumnView;
            int[] selectedRowHandles = view.GetSelectedRows();
            if (selectedRowHandles.Length >= 0)
            {
                view.FocusedRowHandle = selectedRowHandles[0];
                view.CopyToClipboard();
                string valor = view.GetRowCellDisplayText(selectedRowHandles[0], view.Columns[0]);
                decimal costo = decimal.Parse(view.GetRowCellDisplayText(selectedRowHandles[0], view.Columns[6]));
                int idP = Int32.Parse(valor);
                new Pelicula()
                {
                    folio = lbFolio.Text,
                    idPelicula = idP,
                    costo = costo,
                    idUsuario = id
                }.AddCarrito();
                XtraMessageBox.Show("Añadida al carrito", Application.ProductName, MessageBoxButtons.OK
               , MessageBoxIcon.Information);

            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (!txtPelicula.Text.Equals(""))
            {
                peliculaBindingSource.ResetBindings(true);
                if (new Pelicula() { titulo = txtPelicula.Text }.getByTitulo() != null)
                {
                    peliculaBindingSource.DataSource = new Pelicula()
                    { titulo = txtPelicula.Text }.getByTitulo();
                    generoBindingSource.DataSource = new Genero().GetAll();
                    luLen.DataSource = new Lenguas().GetAll();
                    luGen.DataSource = new Genero().GetAll();
                    //isFound = true;
                    return;
                }
                XtraMessageBox.Show("sin resultados ", Application.ProductName, MessageBoxButtons.OK
                  , MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                //XtraMessageBox.Show("campo vacio ", Application.ProductName, MessageBoxButtons.OK
                //  , MessageBoxIcon.Exclamation);
                cargar();
                return;
            }
            cargar();
            isfound = false;

        }
    }
}