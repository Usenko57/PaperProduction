using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperProduction
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            initComboBoxes();
            numericUpDown2.Maximum = int.MaxValue;
            numericUpDown2.Value = 1000000000;
            dataGridView1.DataSource = GetElements();
            dataGridView2.DataSource = GetMaterials();
            setCollumnWidth();
        }

        private DataTable GetElements()
        {
            DB db = new DB();
            DataTable papers = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("call selectPapers(@paperName, @masterFilmText, " +
                "@masterFilmCover, @fromInvoiceCalculation, @toInvoiceCalculation);", db.GetConnection()))
            {
                db.GetConnection().Open();
                cmd.Parameters.Add("@paperName", MySqlDbType.VarChar).Value = "%" + comboBox1.Text + "%";
                cmd.Parameters.Add("@masterFilmText", MySqlDbType.VarChar).Value = textBox1.Text + "%";
                cmd.Parameters.Add("@masterFilmCover", MySqlDbType.VarChar).Value = textBox2.Text + "%";
                cmd.Parameters.Add("@fromInvoiceCalculation", MySqlDbType.VarChar).Value = numericUpDown1.Value;
                cmd.Parameters.Add("@toInvoiceCalculation", MySqlDbType.VarChar).Value = numericUpDown2.Value;
                MySqlDataReader reader = cmd.ExecuteReader();
                papers.Load(reader);
            }
            return papers;
        }

        private DataTable GetMaterials()
        {
            DB db = new DB();
            DataTable materials = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("call selectBindingMaterials(@nameOfBindingMaterials);", db.GetConnection()))
            {
                db.GetConnection().Open();
                cmd.Parameters.Add("@nameOfBindingMaterials", MySqlDbType.VarChar).Value = "%" + comboBox2.Text + "%";
                MySqlDataReader reader = cmd.ExecuteReader();
                materials.Load(reader);
            }
            return materials;
        }

        private void initComboBoxes()
        {
            comboBox1.Items.AddRange(new string[] { "","Бумага А3 80 г/м2 500 л \"SvetoCopi\"",
                "Бумага Colo Copy, 120 A3, 250 л","Бумага Ксерокс Кол+Глосс Коатед 120 А3 500 л",
            "Бумага Colo Copy, 160 A3, 250 л","Бумага Color Glossy, 170 SRA3, 250 л","Бумага Color Copi, 200 SRA3, 250 л",
            "Бумага Color Copi, 280 SRA3, 250 л","Бумага Ксерокс Колотек+Глосс, 280, SRA3",
            "Бумага IQ Color голубой, 160 А3, 250 л Австрия", "Бумага IQ Color желтый, 160 А3, 250 л Австрия",
            "Бумага IQ Color розовый 160 А3, 250 л Австрия", "Бумага дизайн. гл. 2-ст, млеч. путь, 120 г/м2, 720х1020",
            "Бумага дизайн. гл. 2-ст, млеч. путь, 290 г/м2, 720х1020"});
            comboBox2.Items.AddRange(new string[] { "","Картон коробочный м. КТ, фор. 74*105 см, толщ. 09 мм",
            "Пласт. Пружина 8 мм", "Проволока д/провол. шв. Машин № 21 0,8 мм (боб. 2 кг)",
                "Проволочные скобы в блоках по 5000 шт. 66/8", "Заготовка обложек для переплета / 100 шт / 0,15 мм",
                "Картон Eskaboard 2 мм, 70*1000 мм, ДВ, Нидерланды", "Клей Kilitomett V 150 10 кг","Клей ПВА \"ДП 5070\"",
                "Метал.пружина белая d 8 (5/16)","Переплетный м-л на бум. осн. \"Бумвинил\" цв. виш. ",
                "Пластик. элемент для переплета 10 мм зел. (100 шт) РФ", "Пластик. элемент для переплета 10 мм чер (100 шт) ЛИТВ",
                "Пластик. элемент для переплета 8 мм бел (100 шт), РФ", "Пленка д. лам.пакет 303*426 (А3) 175 микр глян.",
                "Пленка д. лам.пакет 303*426 (А3) 175 микр мат.", "Скобы 66/6 (5000)", "Скобы 66/8+ (5000)", "Скобы для DBM-20 (5000 шт)"
            });
        }

        private void setCollumnWidth()
        {
            DataGridViewColumn collumn = dataGridView1.Columns[18];
            collumn.Width = 300;
            collumn = dataGridView1.Columns[1];
            collumn.Width = 300;
            collumn = dataGridView1.Columns[2];
            collumn.Width = 115;
            collumn = dataGridView2.Columns[0];
            collumn.Width = 310;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetElements();
            dataGridView2.DataSource = GetMaterials();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToExcel(dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToExcel(dataGridView1);     
        }

        public void ToExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                xcelApp.Cells[1, i].EntireRow.Font.Bold = true;
            }
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;                    
                }
            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }       
    }
}
