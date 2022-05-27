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
    public partial class fmrCarrito : DevExpress.XtraEditors.XtraForm
    {
        private int idU;
        private string folio;
        public fmrCarrito()
        {
            InitializeComponent();
        }
        public fmrCarrito(int id)
        {
            InitializeComponent();
            idU = id;
            //this.folio = folio;
        }
        private void Carrito_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gcCarrito.MainView as ColumnView;
            int[] selectedRowHandles = view.GetSelectedRows();
            if (selectedRowHandles.Length >= 0)
            {
                view.FocusedRowHandle = selectedRowHandles[0];
                view.CopyToClipboard();
                string valor = view.GetRowCellDisplayText(selectedRowHandles[0], view.Columns[0]);
                int idP = Int32.Parse(valor);
                new Carrito() { idCarrito = idP }.delete();
                XtraMessageBox.Show("Removida", Application.ProductName, MessageBoxButtons.OK
               , MessageBoxIcon.Information);
                cargar();
            }
        }
        // Aqui van metodos de la clase que se llaman cuando se necesitan
        private void cargar()
        {
            carritoBindingSource.DataSource = new Carrito().GetAll();
            lupPelicula.DataSource = new Pelicula().GetAll();
            lupUsuario.DataSource = new Usuario().GetAll();
        }
    }
}