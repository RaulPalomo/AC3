using GestioAigua;
using System.Windows.Forms;
using System.Xml;

namespace AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i = 2012; i <=2050; i++)
            {
                comboBox1.Items.Add(i);
                
            }
            Helper.CsvToXml();
            List<string> comarques = Helper.Comarques();
            foreach (string comarca in comarques)
            {
                comboBox2.Items.Add(comarca);
            }
            GenerarTaula(dataGridView1);
        }
        public static void GenerarTaula(DataGridView dg)
        {
            List<Record> records = Helper.Reader();
            dg.DataSource = records;
        }
    }
}
