using GestioAigua;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2012; i <= 2050; i++)
            {
                cbAny.Items.Add(i);

            }
            Helper.CsvToXml();
            Dictionary<int, string> comarques = Helper.Comarques();
            cbComarca.DataSource = new BindingSource(comarques, null);
            cbComarca.DisplayMember = "Value";
            cbComarca.ValueMember = "Key";
            GenerarTaula(dataGridView1);
        }
        public static void GenerarTaula(DataGridView dg)
        {
            List<Record> records = Helper.Reader();
            dg.DataSource = records;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Regex digitos = new Regex(@"^\d+$");
            Regex decimales = new Regex(@"^\d+(\.\d{2})?$|^\d+$");
            if (!cbComarca.Contains(cbComarca) || !cbAny.Contains(cbAny) || !digitos.IsMatch(txtPoblacio.Text) || !digitos.IsMatch(txtXarxa.Text) || !digitos.IsMatch(txtAct.Text) || !digitos.IsMatch(txtTotal.Text) || !decimales.IsMatch(txtCapita.Text))
            {
                if (!digitos.IsMatch(txtPoblacio.Text))
                {
                    errorPoblacio.SetError(txtPoblacio, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(txtXarxa.Text))
                {
                    errorXarxa.SetError(txtXarxa, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(txtAct.Text))
                {
                    errorAct.SetError(txtAct, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(txtTotal.Text))
                {
                    errorTotal.SetError(txtTotal, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!decimales.IsMatch(txtCapita.Text))
                {
                    errorCapita.SetError(txtCapita, "Debe ser un numero mayor a 0 i como màximo con 2 decimales");
                }
                if (!cbComarca.Contains(cbComarca))
                {
                    errorComarca.SetError(cbComarca, "Debe seleccionar una comarca");
                }
                if (!cbAny.Contains(cbAny))
                {
                    errorAny.SetError(cbAny, "Debe seleccionar un año");
                }

            }
            else
            {
                errorAct.Clear();
                errorCapita.Clear();
                errorPoblacio.Clear();
                errorTotal.Clear();
                errorXarxa.Clear();
                errorComarca.Clear();
                errorAny.Clear();
                errorPoblacio.Clear();


                Record record = new Record();
                record.Any = (int)cbAny.SelectedItem;
                record.CodiComarca = (int)cbComarca.SelectedValue;
                record.Comarca = cbComarca.Text;
                record.Poblacio = int.Parse(txtPoblacio.Text);
                record.DomesticXarxa = int.Parse(txtXarxa.Text);
                record.ActivitatsEconomiques = int.Parse(txtAct.Text);
                record.Total = int.Parse(txtTotal.Text);
                record.ConsumDomesticPerCapita = double.Parse(txtCapita.Text);
                Helper.Append(record);
                GenerarTaula(dataGridView1);
            }
        }

        private void btnNetejaar_Click(object sender, EventArgs e)
        {
            cbAny.SelectedIndex = -1;
            cbComarca.SelectedIndex = -1;
            txtAct.Text = "";
            txtCapita.Text = "";
            txtPoblacio.Text = "";
            txtTotal.Text = "";
            txtXarxa.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {

                lblMitja.Text = Helper.CalcConsum(dataGridView1.Rows[n].Cells[2].Value.ToString());
                lblPob.Text = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value) > 200000 ? "Si" : "No";
                lblAlt.Text = Helper.ConsDomesticAlt(dataGridView1.Rows[n].Cells[0].Value.ToString(), dataGridView1.Rows[n].Cells[2].Value.ToString()) == dataGridView1.Rows[n].Cells[2].Value.ToString() ? "Si" : "No";
                lblBaix.Text = Helper.ConsDomesticBaix(dataGridView1.Rows[n].Cells[0].Value.ToString(), dataGridView1.Rows[n].Cells[2].Value.ToString()) == dataGridView1.Rows[n].Cells[2].Value.ToString() ? "Si" : "No";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
