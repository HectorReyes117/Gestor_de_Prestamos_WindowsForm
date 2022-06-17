namespace Proyecto_Final
{
    partial class FormPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botonPagar = new Guna.UI.WinForms.GunaButton();
            this.txtPago = new Guna.UI.WinForms.GunaTextBox();
            this.RadioTotalidad = new Guna.UI.WinForms.GunaRadioButton();
            this.RadioCuota = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaDataGridViewMovimientos = new Guna.UI.WinForms.GunaDataGridView();
            this.DataGridViewPago = new Guna.UI.WinForms.GunaDataGridView();
            this.lblCuotas = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.botonCalcularCuota = new Guna.UI.WinForms.GunaButton();
            this.DataGridViewCuotaPagar = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCuotaPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // botonPagar
            // 
            this.botonPagar.AnimationHoverSpeed = 0.07F;
            this.botonPagar.AnimationSpeed = 0.03F;
            this.botonPagar.BackColor = System.Drawing.Color.Transparent;
            this.botonPagar.BaseColor = System.Drawing.Color.Red;
            this.botonPagar.BorderColor = System.Drawing.Color.Black;
            this.botonPagar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonPagar.FocusedColor = System.Drawing.Color.Empty;
            this.botonPagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonPagar.ForeColor = System.Drawing.Color.White;
            this.botonPagar.Image = ((System.Drawing.Image)(resources.GetObject("botonPagar.Image")));
            this.botonPagar.ImageSize = new System.Drawing.Size(20, 20);
            this.botonPagar.Location = new System.Drawing.Point(78, 309);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonPagar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonPagar.OnHoverForeColor = System.Drawing.Color.White;
            this.botonPagar.OnHoverImage = null;
            this.botonPagar.OnPressedColor = System.Drawing.Color.Black;
            this.botonPagar.Radius = 12;
            this.botonPagar.Size = new System.Drawing.Size(122, 42);
            this.botonPagar.TabIndex = 68;
            this.botonPagar.Text = "PAGAR";
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // txtPago
            // 
            this.txtPago.BaseColor = System.Drawing.Color.White;
            this.txtPago.BorderColor = System.Drawing.Color.Silver;
            this.txtPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPago.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPago.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPago.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPago.Location = new System.Drawing.Point(46, 259);
            this.txtPago.Name = "txtPago";
            this.txtPago.PasswordChar = '\0';
            this.txtPago.Size = new System.Drawing.Size(189, 32);
            this.txtPago.TabIndex = 67;
            // 
            // RadioTotalidad
            // 
            this.RadioTotalidad.BackColor = System.Drawing.Color.Transparent;
            this.RadioTotalidad.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioTotalidad.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioTotalidad.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioTotalidad.FillColor = System.Drawing.Color.White;
            this.RadioTotalidad.Location = new System.Drawing.Point(159, 233);
            this.RadioTotalidad.Name = "RadioTotalidad";
            this.RadioTotalidad.Size = new System.Drawing.Size(86, 20);
            this.RadioTotalidad.TabIndex = 66;
            this.RadioTotalidad.Text = "Totalidad";
            // 
            // RadioCuota
            // 
            this.RadioCuota.BackColor = System.Drawing.Color.Transparent;
            this.RadioCuota.BaseColor = System.Drawing.SystemColors.Control;
            this.RadioCuota.Checked = true;
            this.RadioCuota.CheckedOffColor = System.Drawing.Color.Gray;
            this.RadioCuota.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RadioCuota.FillColor = System.Drawing.Color.White;
            this.RadioCuota.Location = new System.Drawing.Point(46, 233);
            this.RadioCuota.Name = "RadioCuota";
            this.RadioCuota.Size = new System.Drawing.Size(73, 20);
            this.RadioCuota.TabIndex = 65;
            this.RadioCuota.Text = "Cuotas";
            // 
            // gunaDataGridViewMovimientos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewMovimientos.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewMovimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewMovimientos.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewMovimientos.Location = new System.Drawing.Point(381, 355);
            this.gunaDataGridViewMovimientos.Name = "gunaDataGridViewMovimientos";
            this.gunaDataGridViewMovimientos.RowHeadersVisible = false;
            this.gunaDataGridViewMovimientos.RowHeadersWidth = 51;
            this.gunaDataGridViewMovimientos.RowTemplate.Height = 24;
            this.gunaDataGridViewMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewMovimientos.Size = new System.Drawing.Size(594, 258);
            this.gunaDataGridViewMovimientos.TabIndex = 64;
            this.gunaDataGridViewMovimientos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewMovimientos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewMovimientos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewMovimientos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewMovimientos.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridViewMovimientos.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewMovimientos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DataGridViewPago
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPago.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPago.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPago.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewPago.EnableHeadersVisualStyles = false;
            this.DataGridViewPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewPago.Location = new System.Drawing.Point(381, 45);
            this.DataGridViewPago.Name = "DataGridViewPago";
            this.DataGridViewPago.RowHeadersVisible = false;
            this.DataGridViewPago.RowHeadersWidth = 51;
            this.DataGridViewPago.RowTemplate.Height = 24;
            this.DataGridViewPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPago.Size = new System.Drawing.Size(594, 258);
            this.DataGridViewPago.TabIndex = 63;
            this.DataGridViewPago.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewPago.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewPago.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewPago.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewPago.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewPago.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewPago.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewPago.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewPago.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewPago.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewPago.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewPago.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewPago.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewPago.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewPago.ThemeStyle.ReadOnly = false;
            this.DataGridViewPago.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewPago.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewPago.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewPago.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewPago.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewPago.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewPago.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.BackColor = System.Drawing.Color.Transparent;
            this.lblCuotas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuotas.Location = new System.Drawing.Point(609, 320);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(167, 20);
            this.lblCuotas.TabIndex = 69;
            this.lblCuotas.Text = "Movimientos Prestamos";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(652, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(48, 20);
            this.gunaLabel2.TabIndex = 73;
            this.gunaLabel2.Text = "Pagos";
            // 
            // botonCalcularCuota
            // 
            this.botonCalcularCuota.AnimationHoverSpeed = 0.07F;
            this.botonCalcularCuota.AnimationSpeed = 0.03F;
            this.botonCalcularCuota.BackColor = System.Drawing.Color.Transparent;
            this.botonCalcularCuota.BaseColor = System.Drawing.Color.Red;
            this.botonCalcularCuota.BorderColor = System.Drawing.Color.Black;
            this.botonCalcularCuota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonCalcularCuota.FocusedColor = System.Drawing.Color.Empty;
            this.botonCalcularCuota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonCalcularCuota.ForeColor = System.Drawing.Color.White;
            this.botonCalcularCuota.Image = ((System.Drawing.Image)(resources.GetObject("botonCalcularCuota.Image")));
            this.botonCalcularCuota.ImageSize = new System.Drawing.Size(20, 20);
            this.botonCalcularCuota.Location = new System.Drawing.Point(52, 145);
            this.botonCalcularCuota.Name = "botonCalcularCuota";
            this.botonCalcularCuota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.botonCalcularCuota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.botonCalcularCuota.OnHoverForeColor = System.Drawing.Color.White;
            this.botonCalcularCuota.OnHoverImage = null;
            this.botonCalcularCuota.OnPressedColor = System.Drawing.Color.Black;
            this.botonCalcularCuota.Radius = 12;
            this.botonCalcularCuota.Size = new System.Drawing.Size(183, 42);
            this.botonCalcularCuota.TabIndex = 75;
            this.botonCalcularCuota.Text = "CALCULAR CUOTA";
            this.botonCalcularCuota.Click += new System.EventHandler(this.botonCalcularCuota_Click);
            // 
            // DataGridViewCuotaPagar
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewCuotaPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCuotaPagar.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCuotaPagar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCuotaPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCuotaPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewCuotaPagar.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCuotaPagar.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewCuotaPagar.EnableHeadersVisualStyles = false;
            this.DataGridViewCuotaPagar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCuotaPagar.Location = new System.Drawing.Point(88, 70);
            this.DataGridViewCuotaPagar.Name = "DataGridViewCuotaPagar";
            this.DataGridViewCuotaPagar.RowHeadersVisible = false;
            this.DataGridViewCuotaPagar.RowHeadersWidth = 51;
            this.DataGridViewCuotaPagar.RowTemplate.Height = 24;
            this.DataGridViewCuotaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCuotaPagar.Size = new System.Drawing.Size(127, 37);
            this.DataGridViewCuotaPagar.TabIndex = 76;
            this.DataGridViewCuotaPagar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewCuotaPagar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewCuotaPagar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCuotaPagar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewCuotaPagar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCuotaPagar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCuotaPagar.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewCuotaPagar.ThemeStyle.ReadOnly = false;
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCuotaPagar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final.Properties.Resources.ImagrnInformacion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 625);
            this.Controls.Add(this.DataGridViewCuotaPagar);
            this.Controls.Add(this.botonCalcularCuota);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.RadioTotalidad);
            this.Controls.Add(this.RadioCuota);
            this.Controls.Add(this.gunaDataGridViewMovimientos);
            this.Controls.Add(this.DataGridViewPago);
            this.Name = "FormPagos";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCuotaPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton botonPagar;
        private Guna.UI.WinForms.GunaTextBox txtPago;
        private Guna.UI.WinForms.GunaRadioButton RadioTotalidad;
        private Guna.UI.WinForms.GunaRadioButton RadioCuota;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewMovimientos;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewPago;
        private Guna.UI.WinForms.GunaLabel lblCuotas;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton botonCalcularCuota;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewCuotaPagar;
    }
}