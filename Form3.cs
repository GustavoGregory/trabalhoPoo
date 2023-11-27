using Cadastro_de_peças.Modelos;
using Newtonsoft.Json;

namespace Cadastro_de_peças
{
    public partial class Form3 : Form
    {
        private string jsonListaPecas;
        public Form3()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valueName = textName.Text;
            string valueType = textType.Text;

            Peca peca = new Peca(valueName, valueType, DateTime.Now, new List<PropriedadeDinamica>());

            using (StreamReader r = new StreamReader(Configuration.GetListDataPath()))
            {
                string json = r.ReadToEnd();
                Data? listapecas = JsonConvert.DeserializeObject<Data>(json);

                if(listapecas.Pecas is null)
                    listapecas.Pecas = new List<Peca> { peca };
                else
                    listapecas.Pecas.Add(peca);

                string serializedObject = JsonConvert.SerializeObject(listapecas, Formatting.Indented);

                jsonListaPecas = serializedObject;
            }
                File.WriteAllText(Configuration.GetListDataPath(), jsonListaPecas);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_add1.Visible = false;
            txt_add_key2.Visible = true;
            txt_add_val2.Visible = true;
            btn_add2.Visible = true;
            btn_del2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_add2.Visible = false;
            btn_del2.Visible = false;
            txt_add_key3.Visible = true;
            txt_add_val3.Visible = true;
            btn_add3.Visible = true;
            btn_del3.Visible = true;
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            btn_add3.Visible = false;
            btn_del3.Visible = false;
            txt_add_key4.Visible = true;
            txt_add_val4.Visible = true;
            btn_del4.Visible = true;
        }
    }
}
