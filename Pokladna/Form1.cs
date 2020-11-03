using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PoklZaznam> pokladna;
        IRepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            jsonRepos.VytvorTestData();

            XmlRepos xmlRepos = new XmlRepos("data.xml");
            xmlRepos.VytvorTestData();

            SqlRepos sqlRepos = new SqlRepos();
            


            //repositar = jsonRepos;
            repositar = sqlRepos;
            //repositar = xmlRepos;

            cBoxRok.SelectedIndex = cBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            cBoxMesic.SelectedIndex = DateTime.Now.Month-1;

            pokladna = repositar.NactiVse();
            foreach (var p in pokladna)
            {
                listView1.Items.Add(p.DoLvItem());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxRok_SelectedIndexChanged(object sender, EventArgs e) //oba comboboxy namapovany sem
        {
            if (cBoxMesic.SelectedIndex >= 0 && cBoxRok.SelectedIndex >= 0)
            {
                //pokladna = repositar.Nactimesic(int.Parse(cBoxRok.SelectedItem.ToString()), cBoxMesic.SelectedIndex + 1);
                pokladna = repositar.NactiVse();
                listView1.Items.Clear();
                foreach (var p in pokladna)
                {
                    listView1.Items.Add(p.DoLvItem());
                }
            }
        }

        private void txtDoklad_TextChanged(object sender, EventArgs e)
        {
            btnUloz.Enabled = txtDoklad.Text!="";
        }

        private void txtPopis_TextChanged(object sender, EventArgs e)
        {
            btnNovy.Enabled = txtPopis.Text.Trim() != "" && numericCastka.Value != 0;
        }

        private void numericCastka_ValueChanged(object sender, EventArgs e)
        {
            btnNovy.Enabled = txtPopis.Text.Trim() != "" && numericCastka.Value != 0;
        }

        private void btnNovy_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            PoklZaznam novyZaznam = new PoklZaznam(dtp.Value
                                                , txtPopis.Text
                                                , (double)numericCastka.Value
                                                , txtPoznamka.Text);
            repositar.Vytvorzaznam(novyZaznam);
            txtPopis.Text = "";
            numericCastka.Value = 0;
            txtPoznamka.Text = "";
        }
    }
}
