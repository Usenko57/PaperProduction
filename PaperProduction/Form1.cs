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
    public partial class AddToDatabaseForm : Form
    {
        int prev_locationY { get; set; }

        int prev_locationBindingMaterialsY { get; set; }

        string[] paperNames = { "Бумага А3 80 г/м2 500 л \"SvetoCopi\"",
                "Бумага Colo Copy, 120 A3, 250 л","Бумага Ксерокс Кол+Глосс Коатед 120 А3 500 л",
            "Бумага Colo Copy, 160 A3, 250 л","Бумага Color Glossy, 170 SRA3, 250 л","Бумага Color Copi, 200 SRA3, 250 л",
            "Бумага Color Copi, 280 SRA3, 250 л","Бумага Ксерокс Колотек+Глосс, 280, SRA3",
            "Бумага IQ Color голубой, 160 А3, 250 л Австрия", "Бумага IQ Color желтый, 160 А3, 250 л Австрия",
            "Бумага IQ Color розовый 160 А3, 250 л Австрия", "Бумага дизайн. гл. 2-ст, млеч. путь, 120 г/м2, 720х1020",
            "Бумага дизайн. гл. 2-ст, млеч. путь, 290 г/м2, 720х1020"};

        string[] bindingMaterials = { "Картон коробочный м. КТ, фор. 74*105 см, толщ. 09 мм",
            "Пласт. Пружина 8 мм", "Проволока д/провол. шв. Машин № 21 0,8 мм (боб. 2 кг)",
                "Проволочные скобы в блоках по 5000 шт. 66/8", "Заготовка обложек для переплета / 100 шт / 0,15 мм",
                "Картон Eskaboard 2 мм, 70*1000 мм, ДВ, Нидерланды", "Клей Kilitomett V 150 10 кг","Клей ПВА \"ДП 5070\"",
                "Метал.пружина белая d 8 (5/16)","Переплетный м-л на бум. осн. \"Бумвинил\" цв. виш. ",
                "Пластик. элемент для переплета 10 мм зел. (100 шт) РФ", "Пластик. элемент для переплета 10 мм чер (100 шт) ЛИТВ",
                "Пластик. элемент для переплета 8 мм бел (100 шт), РФ", "Пленка д. лам.пакет 303*426 (А3) 175 микр глян.",
                "Пленка д. лам.пакет 303*426 (А3) 175 микр мат.", "Скобы 66/6 (5000)", "Скобы 66/8+ (5000)", "Скобы для DBM-20 (5000 шт)"
            };

        string[] paperDensityNames = { "80", "120", "160", "170", "200", "280" };

        string[] technicalNeeds = { "1,03", "1,04", "1,06", "1,1", "1,133" };

        List<ComboBox> paperComboBoxes { get; set; }

        List<ComboBox> bindingMaterialsComboBoxes { get; set; }

        List<ComboBox> paperDensityComboBoxes { get; set; }

        List<ComboBox> technicalNeedsComboBoxes { get; set; }

        List<TextBox> countTextBoxes { get; set; }
        public AddToDatabaseForm()
        {
            InitializeComponent();
            initForm();
            prev_locationY = paperNameComboBox.Location.Y;
            paperComboBoxes = new List<ComboBox>();
            prev_locationBindingMaterialsY = bindingMaterialsComboBox.Location.Y;
            bindingMaterialsComboBoxes = new List<ComboBox>();
            paperDensityComboBoxes = new List<ComboBox>();
            technicalNeedsComboBoxes = new List<ComboBox>();
            countTextBoxes = new List<TextBox>();
        }

        private void initForm()
        {
            WindowState = FormWindowState.Maximized;
            hideMasterFilm();
            typeOfPrintedMatterComboBox.Items.AddRange(new string[] { "книжно-журнальная", "изобразительная", "бланочная" });
            equipmentСomboBox.Items.AddRange(new string[] { "RISO", "Ксерокс", "МФУ" });
            productFormatComboBox.Items.AddRange(new string[] { "А3", "А4", "А5", "А6" });
            colorfulnessBlockComboBox.Items.AddRange(new string[] { "1+0", "1+1", "4+0", "4+1" });
            colorfulCoverComboBox.Items.AddRange(new string[] { "1+0", "1+1", "4+0", "4+1" });
            paperDensityComboBox.Items.AddRange(paperDensityNames);
            technicalNeedsComboBox.Items.AddRange(technicalNeeds);
            paperNameComboBox.Items.AddRange(paperNames);
            bindingMaterialsComboBox.Items.AddRange(bindingMaterials);
            sourceOfFinancingComboBox.Items.AddRange(new string[] { "б", "б/в" });
        }

        private void hideMasterFilm()
        {
            masterFilmCoverLabel.Hide();
            masterFilmCoverTextBox.Hide();
        }

        private void showMasterFilm()
        {
            masterFilmCoverLabel.Show();
            masterFilmCoverTextBox.Show();
        }

        private void textBox_validating(object sender, EventArgs e)
        {

        }

        private void PaperProduction_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            double val;
            double printing_forms = double.Parse(volumeTextBox.Text) / double.Parse(sheetShareTextBox.Text);
            double net_print_run = double.Parse(circulationTextBox.Text) * printing_forms;
            double masterFilmText = equipmentСomboBox.Text == "RISO" ? double.Parse(volumeTextBox.Text) / double.Parse(sheetShareTextBox.Text) * 1.1 : 0;
            double masterFilmCover = double.TryParse(masterFilmCoverTextBox.Text, out val) ? double.Parse(masterFilmCoverTextBox.Text) : 0;
            double paper1 = net_print_run * double.Parse(technicalNeedsComboBox.Text) + 6 * masterFilmText +
                6 * masterFilmCover;
            double m = 0;
            List<string> papers = new List<string>();
            List<string> technicalNeedsList = new List<string>();
            List<string> paperDensitiesList = new List<string>();
            List<string> counts = new List<string>();
            papers.Add(paperNameComboBox.Text);
            technicalNeedsList.Add(technicalNeedsComboBox.Text);
            paperDensitiesList.Add(paperDensityComboBox.Text);
            for (int i = 0; i < paperComboBoxes.Count(); i++)
            {
                papers.Add(paperComboBoxes[i].Text);
                technicalNeedsList.Add(technicalNeedsComboBoxes[i].Text);
                paperDensitiesList.Add(paperDensityComboBoxes[i].Text);
            }
            List<string> bindingMaterials = new List<string>();
            bindingMaterials.Add(bindingMaterialsComboBox.Text);
            counts.Add(countTextBox.Text);
            for (int i = 0; i < bindingMaterialsComboBoxes.Count(); i++)
            {
                bindingMaterials.Add(bindingMaterialsComboBoxes[i].Text);
                counts.Add(countTextBoxes[i].Text);
            }
            switch (paperDensityComboBox.Text)
            {
                case "80": m = 0.01; break;
                case "120": m = 0.015; break;
                case "160": m = 0.02; break;
                case "170": m = 0.021; break;
                case "200": m = 0.025; break;
                case "280": m = 0.035; break;
            }
            MySqlCommand command = new MySqlCommand("call addData(@invoice_calculation, @orderName, @typeOfPrintedMatter, @equipment," +
                "@sourceOfFinancing, @circulation, @productFormat, @pageVolume, @sheetShare, @printing_forms, " +
                "@сolorfull_block, @cover_art, @master_film_text, @master_film_cover, @net_print_run," +
                "@technical_needs, @paper1, @paper_density, @paper_name, @total_weight);", db.GetConnection());
            command.Parameters.Add("@orderName", MySqlDbType.VarChar).Value = orderNameTextBox.Text;
            command.Parameters.Add("@typeOfPrintedMatter", MySqlDbType.Enum).Value = typeOfPrintedMatterComboBox.Text;
            command.Parameters.Add("@equipment", MySqlDbType.VarChar).Value = equipmentСomboBox.Text;
            command.Parameters.Add("@circulation", MySqlDbType.Double).Value = double.Parse(circulationTextBox.Text);
            command.Parameters.Add("@productFormat", MySqlDbType.Enum).Value = productFormatComboBox.Text;
            command.Parameters.Add("@sourceOfFinancing", MySqlDbType.Enum).Value = sourceOfFinancingComboBox.Text;
            command.Parameters.Add("@pageVolume", MySqlDbType.Double).Value = double.Parse(volumeTextBox.Text);
            command.Parameters.Add("@sheetShare", MySqlDbType.Double).Value = double.Parse(sheetShareTextBox.Text);
            command.Parameters.Add("@printing_forms", MySqlDbType.Double).Value = Math.Round(printing_forms, 4);
            command.Parameters.Add("@сolorfull_block", MySqlDbType.Enum).Value = colorfulnessBlockComboBox.Text;
            command.Parameters.Add("@cover_art", MySqlDbType.Enum).Value = colorfulCoverComboBox.Text;
            command.Parameters.Add("@master_film_text", MySqlDbType.Double).Value = masterFilmText;
            command.Parameters.Add("@master_film_cover", MySqlDbType.VarChar).Value = masterFilmCoverTextBox.Text;
            command.Parameters.Add("@net_print_run", MySqlDbType.Double).Value = Math.Round(net_print_run, 4);
            command.Parameters.Add("@technical_needs", MySqlDbType.VarChar).Value = string.Join("; ", technicalNeedsList);
            command.Parameters.Add("@paper1", MySqlDbType.Double).Value = Math.Round(paper1, 4);
            command.Parameters.Add("@paper_density", MySqlDbType.VarChar).Value = string.Join("; ", paperDensitiesList);
            command.Parameters.Add("@paper_name", MySqlDbType.VarChar).Value = string.Join(";  ", papers.ToArray());
            command.Parameters.Add("@total_weight", MySqlDbType.Double).Value = Math.Round(paper1 * m, 4);
            command.Parameters.Add("@invoice_calculation", MySqlDbType.Int32).Value = invoiceCalculationTextBox.Text;

            command.CommandText += "insert into binding_materials(name_of_binding_materials,count) values ";

            for (int i = 0; i < bindingMaterials.Count; i++)
            {
                command.Parameters.Add("@name_of_binding_materials" + i.ToString(), MySqlDbType.VarChar).Value = bindingMaterials[i];
                command.Parameters.Add("@count" + i.ToString(), MySqlDbType.VarChar).Value = counts[i];
                command.CommandText += "(@name_of_binding_materials" + i.ToString() + ", ";
                command.CommandText += "@count" + i.ToString() + ")";
                if (i < bindingMaterials.Count - 1)
                    command.CommandText += ",";
                else
                    command.CommandText += ";";
            }                     

            db.OpenConnection();
            if (command.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Добавлено в базу");
                clearFields();
            }
            else
                MessageBox.Show("Не получилось добавить в базу");            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            View form = new View();
            form.Show();
        }

        private void equipmentСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentСomboBox.Text == "RISO")
            {
                masterFilmCoverLabel.Show();
                masterFilmCoverTextBox.Show();
            }
            else
            {
                masterFilmCoverLabel.Hide();
                masterFilmCoverTextBox.Hide();
            }
        }

        private void typeOfPrintedMatterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void masterFilmCoverLabel_Click(object sender, EventArgs e)
        {

        }

        private void masterFilmCoverTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPaper_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox()
            {
                Name = "paperNameComboBox" + paperComboBoxes.Count.ToString(),
                Location = new Point(820, prev_locationY + 35),
                Size = new Size(370, 33),
                DropDownWidth = 370,
                DropDownStyle = ComboBoxStyle.DropDown
            };

            ComboBox comboBox1 = new ComboBox()
            {
                Name = "paperDensityComboBox" + paperDensityComboBoxes.Count.ToString(),
                Size = paperDensityComboBox.Size,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(494, prev_locationY + 35),
            };

            ComboBox comboBox2 = new ComboBox()
            {
                Name = "technicalNeedsComboBox" + technicalNeedsComboBoxes.Count.ToString(),
                Size = technicalNeedsComboBox.Size,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(169, prev_locationY + 35),
            };

            comboBox.Items.AddRange(paperNames);
            comboBox1.Items.AddRange(paperDensityNames);
            comboBox2.Items.AddRange(technicalNeeds);
            this.Controls.Add(comboBox);
            this.Controls.Add(comboBox1);
            this.Controls.Add(comboBox2);
            paperComboBoxes.Add(comboBox);
            paperDensityComboBoxes.Add(comboBox1);
            technicalNeedsComboBoxes.Add(comboBox2);
            prev_locationY += 35;
            groupBox1.Location = new Point(groupBox1.Location.X, groupBox1.Location.Y + 35);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox()
            {
                Name = "bindingMaterialsComboBox" + paperComboBoxes.Count.ToString(),
                Location = new Point(209, prev_locationBindingMaterialsY + 35),
                Size = new Size(400, 33),
                Font = new Font(bindingMaterialsComboBox.Font.Name, bindingMaterialsComboBox.Font.Size, bindingMaterialsComboBox.Font.Style),
                DropDownWidth = 400,
                DropDownStyle = ComboBoxStyle.DropDown
            };

            TextBox textBox = new TextBox()
            {
                Name = "countTextBox" + countTextBoxes.Count.ToString(),
                Location = new Point(796, prev_locationBindingMaterialsY + 35),
                Size = new Size(184, 30),
                Font = new Font(countTextBox.Font.Name, countTextBox.Font.Size, countTextBox.Font.Style)
            };

            comboBox.Items.AddRange(bindingMaterials);
            this.Controls.Add(comboBox);
            this.Controls.Add(textBox);
            this.groupBox1.Controls.Add(comboBox);
            this.groupBox1.Controls.Add(textBox);
            bindingMaterialsComboBoxes.Add(comboBox);
            countTextBoxes.Add(textBox);
            prev_locationBindingMaterialsY += 35;
        }

        private void paperDensityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
