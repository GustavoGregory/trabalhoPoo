using Cadastro_de_peças.Modelos;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Cadastro_de_peças
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void EnvioDataGrid(object peca)
        {
            dataGridView1.DataSource = peca;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Peca> pecas;
            using (StreamReader r = new StreamReader(Configuration.GetListDataPath()))
            {
                string json = r.ReadToEnd();
                Data? listapecas = JsonConvert.DeserializeObject<Data>(json);
                pecas = listapecas.Pecas;
            }
            dataGridView1.DataSource = pecas;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
