
namespace PeliSoft
{
    partial class fmrCarrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCarrito));
            this.gcCarrito = new DevExpress.XtraGrid.GridControl();
            this.carritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCarrito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCarrito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPelicula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupPelicula = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnSell = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCarrito
            // 
            this.gcCarrito.DataSource = this.carritoBindingSource;
            this.gcCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCarrito.Location = new System.Drawing.Point(0, 30);
            this.gcCarrito.MainView = this.gvCarrito;
            this.gcCarrito.Name = "gcCarrito";
            this.gcCarrito.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lupUsuario,
            this.lupPelicula});
            this.gcCarrito.Size = new System.Drawing.Size(700, 450);
            this.gcCarrito.TabIndex = 0;
            this.gcCarrito.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCarrito});
            // 
            // carritoBindingSource
            // 
            this.carritoBindingSource.DataSource = typeof(BLL.Carrito);
            // 
            // gvCarrito
            // 
            this.gvCarrito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCarrito,
            this.colfolio,
            this.colidPelicula,
            this.colcosto,
            this.colidUsuario});
            this.gvCarrito.GridControl = this.gcCarrito;
            this.gvCarrito.Name = "gvCarrito";
            this.gvCarrito.OptionsView.ShowGroupPanel = false;
            // 
            // colidCarrito
            // 
            this.colidCarrito.FieldName = "idCarrito";
            this.colidCarrito.MinWidth = 26;
            this.colidCarrito.Name = "colidCarrito";
            this.colidCarrito.Visible = true;
            this.colidCarrito.VisibleIndex = 0;
            this.colidCarrito.Width = 98;
            // 
            // colfolio
            // 
            this.colfolio.FieldName = "folio";
            this.colfolio.MinWidth = 26;
            this.colfolio.Name = "colfolio";
            this.colfolio.Visible = true;
            this.colfolio.VisibleIndex = 1;
            this.colfolio.Width = 98;
            // 
            // colidPelicula
            // 
            this.colidPelicula.Caption = "Pelicula";
            this.colidPelicula.ColumnEdit = this.lupPelicula;
            this.colidPelicula.FieldName = "idPelicula";
            this.colidPelicula.MinWidth = 26;
            this.colidPelicula.Name = "colidPelicula";
            this.colidPelicula.Visible = true;
            this.colidPelicula.VisibleIndex = 2;
            this.colidPelicula.Width = 98;
            // 
            // lupPelicula
            // 
            this.lupPelicula.AutoHeight = false;
            this.lupPelicula.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupPelicula.DataSource = this.peliculaBindingSource;
            this.lupPelicula.DisplayMember = "titulo";
            this.lupPelicula.Name = "lupPelicula";
            this.lupPelicula.ValueMember = "idPelicula";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(BLL.Pelicula);
            // 
            // colcosto
            // 
            this.colcosto.FieldName = "costo";
            this.colcosto.MinWidth = 26;
            this.colcosto.Name = "colcosto";
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 3;
            this.colcosto.Width = 98;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Usuario";
            this.colidUsuario.ColumnEdit = this.lupUsuario;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.MinWidth = 26;
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 4;
            this.colidUsuario.Width = 98;
            // 
            // lupUsuario
            // 
            this.lupUsuario.AutoHeight = false;
            this.lupUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUsuario.DataSource = this.usuarioBindingSource;
            this.lupUsuario.DisplayMember = "nombre";
            this.lupUsuario.Name = "lupUsuario";
            this.lupUsuario.ValueMember = "IdUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BLL.Usuario);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDel,
            this.btnSell});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSell, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Remover del carrito";
            this.btnDel.Id = 0;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.LargeImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnSell
            // 
            this.btnSell.Caption = "Completar venta";
            this.btnSell.Id = 1;
            this.btnSell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.ImageOptions.Image")));
            this.btnSell.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSell.ImageOptions.LargeImage")));
            this.btnSell.Name = "btnSell";
            this.btnSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSell_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 480);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // fmrCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.gcCarrito);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fmrCarrito";
            this.Text = "-- Carrito --";
            this.Load += new System.EventHandler(this.Carrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCarrito;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCarrito;
        private System.Windows.Forms.BindingSource carritoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidCarrito;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colidPelicula;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnSell;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupPelicula;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
    }
}