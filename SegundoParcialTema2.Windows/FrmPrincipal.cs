using ArraySegundoParcial.Entidades;
using ArraySegundoParcial.Datos;
namespace SegundoParcialTema2.Windows
{
    public partial class FrmPrincipal : Form
    {
        private RepositorioDeEsferas repo;
        private List<Esfera> lista;
        int intValor;
        bool filterOn = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeEsferas();
            ActualizarCantidadRegistros();
        }

        private void ActualizarCantidadRegistros()
        {
            if (intValor > 0)
            {
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmPrincipalAE frm = new FrmPrincipalAE() { Text = "Agregar Esfera" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Esfera esfera = frm.GetEsfera();
            if (!repo.Existe(esfera))
            {
                repo.Agregar(esfera);
                txtCantidad.Text = repo.GetCantidad().ToString();
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, esfera);
                AgregarFila(r);
                MessageBox.Show("Esfera Agregada", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[colRadio.Index].Value = esfera.Radio;
            r.Cells[colBorde.Index].Value = esfera.TipoDeBorde;
            r.Cells[colRelleno.Index].Value = esfera.TipoDeRelleno;
            r.Cells[colArea.Index].Value = esfera.Area();
            r.Cells[colVolumen.Index].Value = esfera.Volumen();

            r.Tag = esfera;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar la esfera?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Esfera esfera = filaSeleccionada.Tag as Esfera;
            repo.Borrar(esfera);
            txtCantidad.Text = repo.GetCantidad().ToString();
            QuitarFila(filaSeleccionada);
            MessageBox.Show("Esfera borrada", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow filaSeleccionada)
        {
            dgvDatos.Rows.Remove(filaSeleccionada);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaseleccionada = dgvDatos.SelectedRows[0];
            Esfera esfera = (Esfera)filaseleccionada.Tag;
            Esfera esferaCopia = (Esfera)esfera.Clone();
            int radioAnterior = esfera.Radio;
            FrmPrincipalAE frm = new FrmPrincipalAE() { Text = "Editar esfera" };
            frm.SetEsfera(esfera);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            esfera = frm.GetEsfera();
            if (!repo.Existe(esfera))
            {
                repo.Editar(esferaCopia, esfera);
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                var stringValor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del radio de la esfera a filtrar",
                    "Filtrar por mayor o igual",
                    "0", 400, 400);
                if (!int.TryParse(stringValor, out intValor))
                {
                    return;
                }
                if (intValor <= 0)
                {
                    return;
                }
                lista = repo.Filtrar(intValor);
                tsbFiltrar.BackColor = Color.DarkRed;
                filterOn = true;
                MostrarDatosEnGrilla();
                ActualizarCantidadRegistros();
            }
            else
            {
                MessageBox.Show("Filtro aplicado! \nDebe actualizar la grilla",
                  "Advertencia",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();
            }

        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var esfera in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, esfera);
                AgregarFila(r);
            }
        }

        private void ordenarRadioAscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAsc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void ordenarRadioDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDesc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }
    }
}
