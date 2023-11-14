namespace SegundoParcialTema2.Windows
{
    partial class FrmPrincipalAE
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            btnOk = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtRadio = new TextBox();
            gbxBordes = new GroupBox();
            cboColores = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.Done;
            btnOk.Location = new Point(163, 364);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(114, 61);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Close;
            btnCancelar.Location = new Point(462, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 61);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 58);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el radio de la esfera:";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(429, 55);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 3;
            // 
            // gbxBordes
            // 
            gbxBordes.Location = new Point(187, 220);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Size = new Size(363, 100);
            gbxBordes.TabIndex = 5;
            gbxBordes.TabStop = false;
            gbxBordes.Text = "Tipo de bordes";
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(429, 136);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(121, 23);
            cboColores.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 139);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 7;
            label3.Text = "Seleccione el color del relleno de la esfera:";
            // 
            // FrmPrincipalAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cboColores);
            Controls.Add(gbxBordes);
            Controls.Add(txtRadio);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "FrmPrincipalAE";
            Text = "FrmPrincipalAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private Label label3;
        private ComboBox cboColores;
        private GroupBox gbxBordes;
        private TextBox txtRadio;
        private Label label1;
    }
}