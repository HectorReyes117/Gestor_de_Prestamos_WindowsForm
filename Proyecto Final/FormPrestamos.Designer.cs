namespace Proyecto_Final
{
    partial class FormPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarDatos = new Guna.UI.WinForms.GunaTextBox();
            this.txtEliminarID = new Guna.UI.WinForms.GunaTextBox();
            this.txtEditarID = new Guna.UI.WinForms.GunaTextBox();
            this.botonBuscar = new Guna.UI.WinForms.GunaButton();
            this.botonEliminar = new Guna.UI.WinForms.GunaButton();
            this.botonEditar = new Guna.UI.WinForms.GunaButton();
            this.botonGuardar = new Guna.UI.WinForms.GunaButton();
            this.DataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtCuotas = new Guna.UI.WinForms.GunaTextBox();
            this.txtCliente = new Guna.UI.WinForms.GunaTextBox();
            this.txtMontoPrestamo = new Guna.UI.WinForms.GunaTextBox();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.RadioFecha = new Guna.UI.WinForms.GunaRadioButton();
            this.RadioCliente = new Guna.UI.WinForms.GunaRadioButton();
            this.txtFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Red;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(860, 302);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 12;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 68;
            this.gunaButton2.Text = "REFRESCAR";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(327, 480);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(24, 20);
            this.gunaLabel10.TabIndex = 67;
            this.gunaLabel10.Text = "ID";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(327, 394);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(24, 20);
            this.gunaLabel9.TabIndex = 66;
            this.gunaLabel9.Text = "ID";
            // 
            // txtBuscarDatos
            // 
            this.txtBuscarDatos.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarDatos.BaseColor = System.Drawing.Color.White;
            this.txtBuscarDatos.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarDatos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarDatos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarDatos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscarDatos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarDatos.Location = new System.Drawing.Point(233, 598);
            this.txtBuscarDatos.Name = "txtBuscarDatos";
            this.txtBuscarDatos.PasswordChar = '\0';
            this.txtBuscarDatos.Radius = 12;
            this.txtBuscarDatos.Size = new System.Drawing.Size(220, 32);
            this.txtBuscarDatos.TabIndex = 62;
            // 
            // txtEliminarID
            // 
            this.txtEliminarID.BackColor = System.Drawing.Color.Transparent;
            this.txtEliminarID.BaseColor = System.Drawing.Color.White;
            this.txtEliminarID.BorderColor = System.Drawing.Color.Silver;
            this.txtEliminarID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEliminarID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEliminarID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEliminarID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEliminarID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEliminarID.Location = new System.Drawing.Point(233, 503);
            this.txtEliminarID.Name = "txtEliminarID";
            this.txtEliminarID.PasswordChar = '\0';
            this.txtEliminarID.Radius = 12;
            this.txtEliminarID.Size = new System.Drawing.Size(220, 32);
            this.txtEliminarID.TabIndex = 61;
            // 
            // txtEditarID
            // 
            this.txtEditarID.BackColor = System.Drawing.Color.Transparent;
            this.txtEditarID.BaseColor = System.Drawing.Color.White;
            this.txtEditarID.BorderColor = System.Drawing.Color.Silver;
            this.txtEditarID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditarID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEditarID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEditarID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEditarID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditarID.Location = new System.Drawing.Point(233, 417);
            this.txtEditarID.Name = "txtEditarID";
            this.txtEditarID.PasswordChar = '\0';
            this.txtEditarID.Radius = 12;
            this.txtEditarID.Size = new System.Drawing.Size(220, 32);
            this.txtEditarID.TabIndex = 60;
            // 
            // botonBuscar
            // 
            this.botonBuscar.AnimationHoverSpeed = 0.07F;
            this.botonBuscar.AnimationSpeed = 0.03F;
            this.botonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.botonBuscar.BaseColor = System.Drawing.Color.Red;
            this.botonBuscar.BorderColor = System.Drawing.Color.Black;
            this.botonBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.botonBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonBuscar.ForeColor = System.Drawing.Color.White;
            this.botonBuscar.Image = null;
            this.botonBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.botonBuscar.Location = new System.Drawing.Point(22, 588);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.botonBuscar.OnHoverImage = null;
            this.botonBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.botonBuscar.Radius = 12;
            this.botonBuscar.Size = new System.Drawing.Size(160, 42);
            this.botonBuscar.TabIndex = 59;
            this.botonBuscar.Text = "BUSCAR";
            this.botonBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.AnimationHoverSpeed = 0.07F;
            this.botonEliminar.AnimationSpeed = 0.03F;
            this.botonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.botonEliminar.BaseColor = System.Drawing.Color.Red;
            this.botonEliminar.BorderColor = System.Drawing.Color.Black;
            this.botonEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.botonEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonEliminar.ForeColor = System.Drawing.Color.White;
            this.botonEliminar.Image = null;
            this.botonEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.botonEliminar.Location = new System.Drawing.Point(22, 503);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.botonEliminar.OnHoverImage = null;
            this.botonEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.botonEliminar.Radius = 12;
            this.botonEliminar.Size = new System.Drawing.Size(160, 42);
            this.botonEliminar.TabIndex = 58;
            this.botonEliminar.Text = "ELIMINAR";
            this.botonEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.AnimationHoverSpeed = 0.07F;
            this.botonEditar.AnimationSpeed = 0.03F;
            this.botonEditar.BackColor = System.Drawing.Color.Transparent;
            this.botonEditar.BaseColor = System.Drawing.Color.Red;
            this.botonEditar.BorderColor = System.Drawing.Color.Black;
            this.botonEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonEditar.FocusedColor = System.Drawing.Color.Empty;
            this.botonEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonEditar.ForeColor = System.Drawing.Color.White;
            this.botonEditar.Image = null;
            this.botonEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.botonEditar.Location = new System.Drawing.Point(22, 417);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.botonEditar.OnHoverImage = null;
            this.botonEditar.OnPressedColor = System.Drawing.Color.Black;
            this.botonEditar.Radius = 12;
            this.botonEditar.Size = new System.Drawing.Size(160, 42);
            this.botonEditar.TabIndex = 57;
            this.botonEditar.Text = "EDITAR";
            this.botonEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.AnimationHoverSpeed = 0.07F;
            this.botonGuardar.AnimationSpeed = 0.03F;
            this.botonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.botonGuardar.BaseColor = System.Drawing.Color.Red;
            this.botonGuardar.BorderColor = System.Drawing.Color.Black;
            this.botonGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.botonGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonGuardar.ForeColor = System.Drawing.Color.White;
            this.botonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botonGuardar.Image")));
            this.botonGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.botonGuardar.Location = new System.Drawing.Point(285, 305);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.botonGuardar.OnHoverImage = null;
            this.botonGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.botonGuardar.Radius = 12;
            this.botonGuardar.Size = new System.Drawing.Size(148, 39);
            this.botonGuardar.TabIndex = 56;
            this.botonGuardar.Text = "GUARDAR";
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(468, 28);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(552, 259);
            this.DataGridView.TabIndex = 55;
            this.DataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView.ThemeStyle.ReadOnly = false;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(98, 255);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel5.TabIndex = 54;
            this.gunaLabel5.Text = "Cuotas";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(97, 197);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(55, 20);
            this.gunaLabel4.TabIndex = 53;
            this.gunaLabel4.Text = "Cliente";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(12, 142);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(140, 20);
            this.gunaLabel3.TabIndex = 52;
            this.gunaLabel3.Text = "Monto de Prestamo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(105, 83);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(47, 20);
            this.gunaLabel2.TabIndex = 51;
            this.gunaLabel2.Text = "Fecha";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(128, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(24, 20);
            this.gunaLabel1.TabIndex = 50;
            this.gunaLabel1.Text = "ID";
            // 
            // txtCuotas
            // 
            this.txtCuotas.BackColor = System.Drawing.Color.Transparent;
            this.txtCuotas.BaseColor = System.Drawing.Color.White;
            this.txtCuotas.BorderColor = System.Drawing.Color.Silver;
            this.txtCuotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuotas.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCuotas.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCuotas.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCuotas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCuotas.Location = new System.Drawing.Point(165, 255);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.PasswordChar = '\0';
            this.txtCuotas.Radius = 12;
            this.txtCuotas.Size = new System.Drawing.Size(268, 32);
            this.txtCuotas.TabIndex = 49;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtCliente.BaseColor = System.Drawing.Color.White;
            this.txtCliente.BorderColor = System.Drawing.Color.Silver;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCliente.Location = new System.Drawing.Point(165, 197);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.Radius = 12;
            this.txtCliente.Size = new System.Drawing.Size(268, 32);
            this.txtCliente.TabIndex = 48;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.txtMontoPrestamo.BaseColor = System.Drawing.Color.White;
            this.txtMontoPrestamo.BorderColor = System.Drawing.Color.Silver;
            this.txtMontoPrestamo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoPrestamo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMontoPrestamo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMontoPrestamo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMontoPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontoPrestamo.Location = new System.Drawing.Point(165, 142);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.PasswordChar = '\0';
            this.txtMontoPrestamo.Radius = 12;
            this.txtMontoPrestamo.Size = new System.Drawing.Size(268, 32);
            this.txtMontoPrestamo.TabIndex = 47;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(165, 28);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 12;
            this.txtID.Size = new System.Drawing.Size(268, 32);
            this.txtID.TabIndex = 45;
            // 
            // RadioFecha
            // 
            this.RadioFecha.BackColor = System.Drawing.Color.Transparent;
            this.RadioFecha.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioFecha.Checked = true;
            this.RadioFecha.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioFecha.FillColor = System.Drawing.Color.White;
            this.RadioFecha.Location = new System.Drawing.Point(257, 563);
            this.RadioFecha.Name = "RadioFecha";
            this.RadioFecha.Size = new System.Drawing.Size(68, 20);
            this.RadioFecha.TabIndex = 69;
            this.RadioFecha.Text = "Fecha";
            // 
            // RadioCliente
            // 
            this.RadioCliente.BackColor = System.Drawing.Color.Transparent;
            this.RadioCliente.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioCliente.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioCliente.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioCliente.FillColor = System.Drawing.Color.White;
            this.RadioCliente.Location = new System.Drawing.Point(347, 563);
            this.RadioCliente.Name = "RadioCliente";
            this.RadioCliente.Size = new System.Drawing.Size(72, 20);
            this.RadioCliente.TabIndex = 70;
            this.RadioCliente.Text = "Cliente";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Transparent;
            this.txtFecha.BaseColor = System.Drawing.Color.White;
            this.txtFecha.BorderColor = System.Drawing.Color.Silver;
            this.txtFecha.CustomFormat = null;
            this.txtFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(165, 83);
            this.txtFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFecha.OnPressedColor = System.Drawing.Color.Black;
            this.txtFecha.Radius = 12;
            this.txtFecha.Size = new System.Drawing.Size(268, 30);
            this.txtFecha.TabIndex = 71;
            this.txtFecha.Text = "20/11/2020";
            this.txtFecha.Value = new System.DateTime(2020, 11, 20, 2, 18, 22, 249);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final.Properties.Resources.ImagrnInformacion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 658);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.RadioCliente);
            this.Controls.Add(this.RadioFecha);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.txtBuscarDatos);
            this.Controls.Add(this.txtEliminarID);
            this.Controls.Add(this.txtEditarID);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.txtID);
            this.Name = "FormPrestamos";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txtBuscarDatos;
        private Guna.UI.WinForms.GunaTextBox txtEliminarID;
        private Guna.UI.WinForms.GunaTextBox txtEditarID;
        private Guna.UI.WinForms.GunaButton botonBuscar;
        private Guna.UI.WinForms.GunaButton botonEliminar;
        private Guna.UI.WinForms.GunaButton botonEditar;
        private Guna.UI.WinForms.GunaButton botonGuardar;
        private Guna.UI.WinForms.GunaDataGridView DataGridView;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtCuotas;
        private Guna.UI.WinForms.GunaTextBox txtCliente;
        private Guna.UI.WinForms.GunaTextBox txtMontoPrestamo;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaRadioButton RadioFecha;
        private Guna.UI.WinForms.GunaRadioButton RadioCliente;
        private Guna.UI.WinForms.GunaDateTimePicker txtFecha;
    }
}