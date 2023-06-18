using System;
using System.Data;

namespace DataTable_Kullanimi
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Arac");

            dt.Columns.Add("AraçID");
            dt.Columns.Add("Plaka");
            dt.Columns.Add("Marka");
            dt.Columns.Add("Model");

            dt.Rows.Add(1, 69, "Mercedes", "S serisi");
            dt.Rows.Add(2, 34, "AstonMartin", "Vulcan");

            DataTable dt1 = new DataTable("Kişi");
            dt1.Columns.Add("KişiID");
            dt1.Columns.Add("KişiAd");
            dt1.Columns.Add("KişiSoyad");
            dt1.Columns.Add("SahipAracID");

            dt1.Rows.Add(1, "Salih", "Doğan", 1);
            dt1.Rows.Add(2, "Emirhan", "Karabacak", 2);

            if (comboBox1.Text == "Araç")
            {
                DataSet st = new DataSet();
                st.Tables.Add(dt);
                dataGridView1.DataSource = st.Tables[0];
            }
            else if (comboBox1.Text == "Kişi")
            {
                DataSet st = new DataSet();
                st.Tables.Add(dt1);
                dataGridView1.DataSource = st.Tables[0];
            }

        }
    }
}
