using ArraySegundoParcial.Entidades;
using System.Data;

namespace SegundoParcialTema2.Windows
{
    public partial class FrmPrincipalAE : Form
    {
        public FrmPrincipalAE()
        {
            InitializeComponent();
        }

        private Esfera esfera;

        List<TipoDeBorde> listaBordes = Enum.GetValues(typeof(TipoDeBorde))
                .Cast<TipoDeBorde>().ToList();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            CrearRadioButtonsBordes();
            if (esfera != null)
            {
                txtRadio.Text = esfera.Radio.ToString();
                SelectRadioButton(esfera.TipoDeBorde);
                cboColores.SelectedItem = esfera.TipoDeRelleno;
            }
        }

        private void SelectRadioButton(TipoDeBorde tipoDeBorde)
        {
            var key = $"rbt{tipoDeBorde.ToString()}";
            var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
            rb.Checked = true;
        }

        private void CrearRadioButtonsBordes()
        {
            int x = 6;
            int y = 22;
            bool check = true;
            foreach (var itemBorde in listaBordes)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rbt{itemBorde.ToString()}",
                    Text = itemBorde.ToString(),
                    Location = new Point(x, y),
                    Checked = check
                };
                gbxBordes.Controls.Add(rb);
                y += 20;
                check = false;
            }
        }

        private void CargarComboColores()
        {
            var listaColores = Enum.GetValues(typeof(TipoDeRelleno))
               .Cast<TipoDeRelleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        public Esfera GetEsfera()
        {
            return esfera;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esfera == null)
                {
                    esfera = new Esfera();
                }
                esfera.Radio = int.Parse(txtRadio.Text);
                esfera.TipoDeBorde = ObtenerTipoDeBordes();
                esfera.TipoDeRelleno = (TipoDeRelleno)cboColores.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private TipoDeBorde ObtenerTipoDeBordes()
        {
            TipoDeBorde tipo = 0;
            foreach (var itemBorde in listaBordes)
            {
                var key = $"rbt{itemBorde.ToString()}";
                var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
                if (rb.Checked)
                {
                    tipo = itemBorde;
                    break;
                }
            }
            return tipo;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtRadio.Text, out int radio))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Radio no valido");
            }
            else if (radio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Radio debe ser mayor a 0(cero)");
            }
            return valido;
        }

        public void SetEsfera(Esfera? esfera)
        {
            this.esfera = esfera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
