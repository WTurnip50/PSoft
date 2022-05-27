
namespace PeliSoft
{
    partial class frmPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeliculas));
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenguasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            this.gcPeliculas = new DevExpress.XtraGrid.GridControl();
            this.gvPeliculas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPelicula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidGenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luGen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colaño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colduracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidLenguaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luLen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsinopsis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCLiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            this.lbFolio = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.txtPelicula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnView = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPelicula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(BLL.Pelicula);
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataSource = typeof(BLL.Genero);
            // 
            // lenguasBindingSource
            // 
            this.lenguasBindingSource.DataSource = typeof(BLL.Lenguas);
            // 
            // btnClean
            // 
            this.btnClean.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Appearance.Options.UseFont = true;
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.Location = new System.Drawing.Point(894, 98);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(119, 33);
            this.btnClean.TabIndex = 24;
            this.btnClean.Text = "Limpiar";
            // 
            // gcPeliculas
            // 
            this.gcPeliculas.DataSource = this.peliculaBindingSource;
            this.gcPeliculas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPeliculas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPeliculas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPeliculas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPeliculas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPeliculas.Location = new System.Drawing.Point(0, 167);
            this.gcPeliculas.MainView = this.gvPeliculas;
            this.gcPeliculas.Name = "gcPeliculas";
            this.gcPeliculas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.luGen,
            this.luLen});
            this.gcPeliculas.Size = new System.Drawing.Size(1025, 501);
            this.gcPeliculas.TabIndex = 22;
            this.gcPeliculas.UseEmbeddedNavigator = true;
            this.gcPeliculas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPeliculas});
            // 
            // gvPeliculas
            // 
            this.gvPeliculas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPelicula,
            this.coltitulo,
            this.colidGenero,
            this.colaño,
            this.colduracion,
            this.colidLenguaje,
            this.colcosto,
            this.colsinopsis,
            this.colfolio,
            this.colidCLiente});
            this.gvPeliculas.GridControl = this.gcPeliculas;
            this.gvPeliculas.Name = "gvPeliculas";
            this.gvPeliculas.OptionsView.ShowAutoFilterRow = true;
            this.gvPeliculas.OptionsView.ShowGroupPanel = false;
            // 
            // colidPelicula
            // 
            this.colidPelicula.FieldName = "idPelicula";
            this.colidPelicula.MinWidth = 26;
            this.colidPelicula.Name = "colidPelicula";
            this.colidPelicula.Visible = true;
            this.colidPelicula.VisibleIndex = 0;
            this.colidPelicula.Width = 98;
            // 
            // coltitulo
            // 
            this.coltitulo.FieldName = "titulo";
            this.coltitulo.MinWidth = 26;
            this.coltitulo.Name = "coltitulo";
            this.coltitulo.Visible = true;
            this.coltitulo.VisibleIndex = 1;
            this.coltitulo.Width = 98;
            // 
            // colidGenero
            // 
            this.colidGenero.ColumnEdit = this.luGen;
            this.colidGenero.FieldName = "idGenero";
            this.colidGenero.MinWidth = 26;
            this.colidGenero.Name = "colidGenero";
            this.colidGenero.Visible = true;
            this.colidGenero.VisibleIndex = 2;
            this.colidGenero.Width = 98;
            // 
            // luGen
            // 
            this.luGen.AutoHeight = false;
            this.luGen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luGen.DataSource = this.generoBindingSource;
            this.luGen.DisplayMember = "descripcion";
            this.luGen.Name = "luGen";
            this.luGen.ValueMember = "idGenero";
            // 
            // colaño
            // 
            this.colaño.FieldName = "año";
            this.colaño.MinWidth = 26;
            this.colaño.Name = "colaño";
            this.colaño.Visible = true;
            this.colaño.VisibleIndex = 3;
            this.colaño.Width = 98;
            // 
            // colduracion
            // 
            this.colduracion.FieldName = "duracion";
            this.colduracion.MinWidth = 26;
            this.colduracion.Name = "colduracion";
            this.colduracion.Visible = true;
            this.colduracion.VisibleIndex = 4;
            this.colduracion.Width = 98;
            // 
            // colidLenguaje
            // 
            this.colidLenguaje.ColumnEdit = this.luLen;
            this.colidLenguaje.FieldName = "idLenguaje";
            this.colidLenguaje.MinWidth = 26;
            this.colidLenguaje.Name = "colidLenguaje";
            this.colidLenguaje.Visible = true;
            this.colidLenguaje.VisibleIndex = 5;
            this.colidLenguaje.Width = 98;
            // 
            // luLen
            // 
            this.luLen.AutoHeight = false;
            this.luLen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLen.DataSource = this.lenguasBindingSource;
            this.luLen.DisplayMember = "descripcion";
            this.luLen.Name = "luLen";
            this.luLen.ValueMember = "idLenguaje";
            // 
            // colcosto
            // 
            this.colcosto.FieldName = "costo";
            this.colcosto.MinWidth = 26;
            this.colcosto.Name = "colcosto";
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 6;
            this.colcosto.Width = 98;
            // 
            // colsinopsis
            // 
            this.colsinopsis.FieldName = "sinopsis";
            this.colsinopsis.MinWidth = 26;
            this.colsinopsis.Name = "colsinopsis";
            this.colsinopsis.Visible = true;
            this.colsinopsis.VisibleIndex = 7;
            this.colsinopsis.Width = 98;
            // 
            // colfolio
            // 
            this.colfolio.FieldName = "folio";
            this.colfolio.MinWidth = 26;
            this.colfolio.Name = "colfolio";
            this.colfolio.Width = 98;
            // 
            // colidCLiente
            // 
            this.colidCLiente.FieldName = "idCLiente";
            this.colidCLiente.MinWidth = 26;
            this.colidCLiente.Name = "colidCLiente";
            this.colidCLiente.Width = 98;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(93, 98);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(153, 30);
            this.lbUser.TabIndex = 21;
            this.lbUser.Text = "NO DISPONIBLE";
            // 
            // lbFolio
            // 
            this.lbFolio.Appearance.Font = new System.Drawing.Font("Tahoma", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolio.Appearance.Options.UseFont = true;
            this.lbFolio.Location = new System.Drawing.Point(67, 65);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(154, 25);
            this.lbFolio.TabIndex = 20;
            this.lbFolio.Text = "NO DISPONIBLE";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 30);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Folio:";
            // 
            // btnFind
            // 
            this.btnFind.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Appearance.Options.UseFont = true;
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(772, 98);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(107, 33);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Buscar";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(500, 99);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelicula.Properties.Appearance.Options.UseFont = true;
            this.txtPelicula.Size = new System.Drawing.Size(246, 32);
            this.txtPelicula.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(532, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(180, 30);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Titulo de la pelicula";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 30);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Usuario:";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnView});
            this.barManager2.MaxItemId = 2;
            this.barManager2.StatusBar = this.bar4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Agregar al carrito";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = global::PeliSoft.Properties.Resources.icons8_ecommerce_32;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick_1);
            // 
            // btnView
            // 
            this.btnView.Caption = "VerCarrito";
            this.btnView.Id = 1;
            this.btnView.Name = "btnView";
            // 
            // bar4
            // 
            this.bar4.BarName = "Barra de estado";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Barra de estado";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1025, 51);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 648);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1025, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 51);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 597);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1025, 51);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 597);
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 668);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.gcPeliculas);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbFolio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- Peliculas --";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPelicula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private System.Windows.Forms.BindingSource lenguasBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnClean;
        private DevExpress.XtraGrid.GridControl gcPeliculas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPeliculas;
        private DevExpress.XtraGrid.Columns.GridColumn colidPelicula;
        private DevExpress.XtraGrid.Columns.GridColumn coltitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colidGenero;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luGen;
        private DevExpress.XtraGrid.Columns.GridColumn colaño;
        private DevExpress.XtraGrid.Columns.GridColumn colduracion;
        private DevExpress.XtraGrid.Columns.GridColumn colidLenguaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luLen;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colsinopsis;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colidCLiente;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private DevExpress.XtraEditors.LabelControl lbFolio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.TextEdit txtPelicula;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnView;
    }
}