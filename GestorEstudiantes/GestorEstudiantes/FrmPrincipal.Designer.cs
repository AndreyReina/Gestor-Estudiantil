namespace GestorEstudiantes
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabRegistro = new TabPage();
            groupBox1 = new GroupBox();
            chkDeportes = new CheckBox();
            chkMusica = new CheckBox();
            chkArte = new CheckBox();
            lblMensajeRegistro = new Label();
            groupGenero = new GroupBox();
            rbtFemenino = new RadioButton();
            rbtMasculino = new RadioButton();
            btnRegistrar = new Button();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblNotas = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            tabVisualizacion = new TabPage();
            lblInfo = new Label();
            pbEstado = new PictureBox();
            lstNombres = new ListBox();
            btnGuardar = new Button();
            btnCargar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnCorreo = new Button();
            dgvEstudiantes = new DataGridView();
            tabControl1.SuspendLayout();
            tabRegistro.SuspendLayout();
            groupBox1.SuspendLayout();
            groupGenero.SuspendLayout();
            tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRegistro);
            tabControl1.Controls.Add(tabVisualizacion);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 520);
            tabControl1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(groupBox1);
            tabRegistro.Controls.Add(lblMensajeRegistro);
            tabRegistro.Controls.Add(groupGenero);
            tabRegistro.Controls.Add(btnRegistrar);
            tabRegistro.Controls.Add(txtNota3);
            tabRegistro.Controls.Add(txtNota2);
            tabRegistro.Controls.Add(txtNota1);
            tabRegistro.Controls.Add(txtEdad);
            tabRegistro.Controls.Add(txtNombre);
            tabRegistro.Controls.Add(lblNotas);
            tabRegistro.Controls.Add(lblEdad);
            tabRegistro.Controls.Add(lblNombre);
            tabRegistro.Location = new Point(4, 24);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.Padding = new Padding(3);
            tabRegistro.Size = new Size(792, 492);
            tabRegistro.TabIndex = 0;
            tabRegistro.Text = "Registro";
            tabRegistro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkDeportes);
            groupBox1.Controls.Add(chkMusica);
            groupBox1.Controls.Add(chkArte);
            groupBox1.Location = new Point(268, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 70);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recreacion";
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(6, 22);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 19);
            chkDeportes.TabIndex = 9;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(85, 23);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(64, 19);
            chkMusica.TabIndex = 10;
            chkMusica.Text = "Música";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(6, 44);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(48, 19);
            chkArte.TabIndex = 11;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // lblMensajeRegistro
            // 
            lblMensajeRegistro.AutoSize = true;
            lblMensajeRegistro.Location = new Point(84, 287);
            lblMensajeRegistro.Name = "lblMensajeRegistro";
            lblMensajeRegistro.Size = new Size(0, 15);
            lblMensajeRegistro.TabIndex = 13;
            // 
            // groupGenero
            // 
            groupGenero.Controls.Add(rbtFemenino);
            groupGenero.Controls.Add(rbtMasculino);
            groupGenero.Location = new Point(30, 150);
            groupGenero.Name = "groupGenero";
            groupGenero.Size = new Size(200, 70);
            groupGenero.TabIndex = 8;
            groupGenero.TabStop = false;
            groupGenero.Text = "Género";
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(10, 44);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 1;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(10, 22);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 0;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(156, 244);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 30);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(300, 107);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(80, 23);
            txtNota3.TabIndex = 7;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(210, 107);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(80, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(120, 107);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(80, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(120, 67);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(80, 23);
            txtEdad.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(30, 110);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(41, 15);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "Notas:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(30, 70);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.Controls.Add(lblInfo);
            tabVisualizacion.Controls.Add(pbEstado);
            tabVisualizacion.Controls.Add(lstNombres);
            tabVisualizacion.Controls.Add(btnGuardar);
            tabVisualizacion.Controls.Add(btnCargar);
            tabVisualizacion.Controls.Add(txtBuscar);
            tabVisualizacion.Controls.Add(btnBuscar);
            tabVisualizacion.Controls.Add(btnCorreo);
            tabVisualizacion.Controls.Add(dgvEstudiantes);
            tabVisualizacion.Location = new Point(4, 24);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(792, 492);
            tabVisualizacion.TabIndex = 1;
            tabVisualizacion.Text = "Visualización";
            tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(20, 380);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 7;
            // 
            // pbEstado
            // 
            pbEstado.Location = new Point(580, 320);
            pbEstado.Name = "pbEstado";
            pbEstado.Size = new Size(120, 80);
            pbEstado.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEstado.TabIndex = 6;
            pbEstado.TabStop = false;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 15;
            lstNombres.Location = new Point(580, 120);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(190, 184);
            lstNombres.TabIndex = 3;
            lstNombres.SelectedIndexChanged += lstNombres_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(580, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar CSV";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(580, 20);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(120, 30);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar CSV";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(20, 340);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(230, 338);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 27);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCorreo
            // 
            btnCorreo.Location = new Point(350, 338);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Size = new Size(120, 27);
            btnCorreo.TabIndex = 8;
            btnCorreo.Text = "Enviar Correo";
            btnCorreo.UseVisualStyleBackColor = true;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(20, 20);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(540, 300);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.CellDoubleClick += dgvEstudiantes_CellDoubleClick;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(tabControl1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Estudiantes";
            tabControl1.ResumeLayout(false);
            tabRegistro.ResumeLayout(false);
            tabRegistro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupGenero.ResumeLayout(false);
            groupGenero.PerformLayout();
            tabVisualizacion.ResumeLayout(false);
            tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabVisualizacion;

        // Registro
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.GroupBox groupGenero;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkArte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMensajeRegistro;

        // Visualización
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbEstado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCorreo; // <<--- Declaración añadida
        private GroupBox groupBox1;
    }
}
