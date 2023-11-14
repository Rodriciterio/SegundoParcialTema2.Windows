namespace SegundoParcialTema2.Windows
{
    partial class FrmPrincipal
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
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ordenarRadioAscendenteToolStripMenuItem = new ToolStripMenuItem();
            ordenarRadioDescendenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            colRadio = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.Nuevo;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 51);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.Borrar;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 51);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.Editar;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 51);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.Filtro;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 51);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Actualizar;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 51);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ordenarRadioAscendenteToolStripMenuItem, ordenarRadioDescendenteToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.Ordenar;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 51);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ordenarRadioAscendenteToolStripMenuItem
            // 
            ordenarRadioAscendenteToolStripMenuItem.Image = Properties.Resources.Ordenar_Ascendente;
            ordenarRadioAscendenteToolStripMenuItem.Name = "ordenarRadioAscendenteToolStripMenuItem";
            ordenarRadioAscendenteToolStripMenuItem.Size = new Size(237, 38);
            ordenarRadioAscendenteToolStripMenuItem.Text = "Ordenar Radio Ascendente";
            ordenarRadioAscendenteToolStripMenuItem.Click += ordenarRadioAscendenteToolStripMenuItem_Click;
            // 
            // ordenarRadioDescendenteToolStripMenuItem
            // 
            ordenarRadioDescendenteToolStripMenuItem.Image = Properties.Resources.Ordenar_Descendente;
            ordenarRadioDescendenteToolStripMenuItem.Name = "ordenarRadioDescendenteToolStripMenuItem";
            ordenarRadioDescendenteToolStripMenuItem.Size = new Size(237, 38);
            ordenarRadioDescendenteToolStripMenuItem.Text = "Ordenar Radio Descendente";
            ordenarRadioDescendenteToolStripMenuItem.Click += ordenarRadioDescendenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.Salir;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 51);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(202, 45);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 48);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de registros:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 296);
            panel2.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colBorde, colRelleno, colArea, colVolumen });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 296);
            dgvDatos.TabIndex = 0;
            // 
            // colRadio
            // 
            colRadio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRadio.HeaderText = "Radio";
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            colBorde.HeaderText = "Borde";
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            colBorde.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelleno
            // 
            colRelleno.HeaderText = "Relleno";
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            colRelleno.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colArea
            // 
            colArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colVolumen
            // 
            colVolumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDatos;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
        private ToolStripMenuItem ordenarRadioAscendenteToolStripMenuItem;
        private ToolStripMenuItem ordenarRadioDescendenteToolStripMenuItem;
    }
}