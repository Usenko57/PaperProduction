using System.Windows.Forms;

namespace PaperProduction
{
    partial class AddToDatabaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.invoiceCalculationLabel = new System.Windows.Forms.Label();
            this.invoiceCalculationTextBox = new System.Windows.Forms.TextBox();
            this.orderNameLabel = new System.Windows.Forms.Label();
            this.orderNameTextBox = new System.Windows.Forms.TextBox();
            this.typeOfPrintedMatterLabel = new System.Windows.Forms.Label();
            this.typeOfPrintedMatterComboBox = new System.Windows.Forms.ComboBox();
            this.sourceOfFinancingLabel = new System.Windows.Forms.Label();
            this.sourceOfFinancingComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.equipmentСomboBox = new System.Windows.Forms.ComboBox();
            this.circulationLabel = new System.Windows.Forms.Label();
            this.circulationTextBox = new System.Windows.Forms.TextBox();
            this.productFormatLabel = new System.Windows.Forms.Label();
            this.productFormatComboBox = new System.Windows.Forms.ComboBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.sheetShareLabel = new System.Windows.Forms.Label();
            this.sheetShareTextBox = new System.Windows.Forms.TextBox();
            this.colorfulnessBlockLabel = new System.Windows.Forms.Label();
            this.colorfulnessBlockComboBox = new System.Windows.Forms.ComboBox();
            this.colorfulСoverLabel = new System.Windows.Forms.Label();
            this.colorfulCoverComboBox = new System.Windows.Forms.ComboBox();
            this.technicalNeedsLabel = new System.Windows.Forms.Label();
            this.technicalNeedsComboBox = new System.Windows.Forms.ComboBox();
            this.paperDensityComboBox = new System.Windows.Forms.ComboBox();
            this.paperDensityLabel = new System.Windows.Forms.Label();
            this.paperNameLabel = new System.Windows.Forms.Label();
            this.paperNameComboBox = new System.Windows.Forms.ComboBox();
            this.bindingMaterialsLabel = new System.Windows.Forms.Label();
            this.bindingMaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.goViewButton = new System.Windows.Forms.Button();
            this.masterFilmCoverLabel = new System.Windows.Forms.Label();
            this.masterFilmCoverTextBox = new System.Windows.Forms.TextBox();
            this.addPaper = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Header = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceCalculationLabel
            // 
            this.invoiceCalculationLabel.AutoSize = true;
            this.invoiceCalculationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invoiceCalculationLabel.Location = new System.Drawing.Point(19, 22);
            this.invoiceCalculationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceCalculationLabel.Name = "invoiceCalculationLabel";
            this.invoiceCalculationLabel.Size = new System.Drawing.Size(206, 25);
            this.invoiceCalculationLabel.TabIndex = 0;
            this.invoiceCalculationLabel.Text = "Расчёт-накладная №";
            // 
            // invoiceCalculationTextBox
            // 
            this.invoiceCalculationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invoiceCalculationTextBox.Location = new System.Drawing.Point(233, 19);
            this.invoiceCalculationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceCalculationTextBox.Name = "invoiceCalculationTextBox";
            this.invoiceCalculationTextBox.Size = new System.Drawing.Size(184, 30);
            this.invoiceCalculationTextBox.TabIndex = 1;
            // 
            // orderNameLabel
            // 
            this.orderNameLabel.AutoSize = true;
            this.orderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNameLabel.Location = new System.Drawing.Point(20, 62);
            this.orderNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNameLabel.Name = "orderNameLabel";
            this.orderNameLabel.Size = new System.Drawing.Size(216, 25);
            this.orderNameLabel.TabIndex = 2;
            this.orderNameLabel.Text = "Наименование заказа";
            // 
            // orderNameTextBox
            // 
            this.orderNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNameTextBox.Location = new System.Drawing.Point(233, 62);
            this.orderNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderNameTextBox.Name = "orderNameTextBox";
            this.orderNameTextBox.Size = new System.Drawing.Size(323, 30);
            this.orderNameTextBox.TabIndex = 3;
            // 
            // typeOfPrintedMatterLabel
            // 
            this.typeOfPrintedMatterLabel.AutoSize = true;
            this.typeOfPrintedMatterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfPrintedMatterLabel.Location = new System.Drawing.Point(19, 106);
            this.typeOfPrintedMatterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeOfPrintedMatterLabel.Name = "typeOfPrintedMatterLabel";
            this.typeOfPrintedMatterLabel.Size = new System.Drawing.Size(243, 25);
            this.typeOfPrintedMatterLabel.TabIndex = 4;
            this.typeOfPrintedMatterLabel.Text = "Вид печатной продукции";
            // 
            // typeOfPrintedMatterComboBox
            // 
            this.typeOfPrintedMatterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfPrintedMatterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfPrintedMatterComboBox.FormattingEnabled = true;
            this.typeOfPrintedMatterComboBox.Location = new System.Drawing.Point(233, 100);
            this.typeOfPrintedMatterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeOfPrintedMatterComboBox.Name = "typeOfPrintedMatterComboBox";
            this.typeOfPrintedMatterComboBox.Size = new System.Drawing.Size(268, 33);
            this.typeOfPrintedMatterComboBox.TabIndex = 5;
            this.typeOfPrintedMatterComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfPrintedMatterComboBox_SelectedIndexChanged);
            // 
            // sourceOfFinancingLabel
            // 
            this.sourceOfFinancingLabel.AutoSize = true;
            this.sourceOfFinancingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceOfFinancingLabel.Location = new System.Drawing.Point(613, 150);
            this.sourceOfFinancingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceOfFinancingLabel.Name = "sourceOfFinancingLabel";
            this.sourceOfFinancingLabel.Size = new System.Drawing.Size(265, 25);
            this.sourceOfFinancingLabel.TabIndex = 6;
            this.sourceOfFinancingLabel.Text = "Источник финансирования";
            // 
            // sourceOfFinancingComboBox
            // 
            this.sourceOfFinancingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceOfFinancingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceOfFinancingComboBox.FormattingEnabled = true;
            this.sourceOfFinancingComboBox.Location = new System.Drawing.Point(820, 147);
            this.sourceOfFinancingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceOfFinancingComboBox.Name = "sourceOfFinancingComboBox";
            this.sourceOfFinancingComboBox.Size = new System.Drawing.Size(173, 33);
            this.sourceOfFinancingComboBox.TabIndex = 7;
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentLabel.Location = new System.Drawing.Point(20, 146);
            this.equipmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(145, 25);
            this.equipmentLabel.TabIndex = 8;
            this.equipmentLabel.Text = "Оборудование";
            // 
            // equipmentСomboBox
            // 
            this.equipmentСomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentСomboBox.FormattingEnabled = true;
            this.equipmentСomboBox.Location = new System.Drawing.Point(233, 141);
            this.equipmentСomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentСomboBox.Name = "equipmentСomboBox";
            this.equipmentСomboBox.Size = new System.Drawing.Size(216, 33);
            this.equipmentСomboBox.TabIndex = 9;
            this.equipmentСomboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentСomboBox_SelectedIndexChanged);
            // 
            // circulationLabel
            // 
            this.circulationLabel.AutoSize = true;
            this.circulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circulationLabel.Location = new System.Drawing.Point(20, 208);
            this.circulationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.circulationLabel.Name = "circulationLabel";
            this.circulationLabel.Size = new System.Drawing.Size(73, 25);
            this.circulationLabel.TabIndex = 10;
            this.circulationLabel.Text = "Тираж";
            // 
            // circulationTextBox
            // 
            this.circulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circulationTextBox.Location = new System.Drawing.Point(77, 205);
            this.circulationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.circulationTextBox.Name = "circulationTextBox";
            this.circulationTextBox.Size = new System.Drawing.Size(68, 30);
            this.circulationTextBox.TabIndex = 11;
            // 
            // productFormatLabel
            // 
            this.productFormatLabel.AutoSize = true;
            this.productFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productFormatLabel.Location = new System.Drawing.Point(319, 203);
            this.productFormatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.productFormatLabel.Name = "productFormatLabel";
            this.productFormatLabel.Size = new System.Drawing.Size(176, 25);
            this.productFormatLabel.TabIndex = 12;
            this.productFormatLabel.Text = "Формат изделия";
            // 
            // productFormatComboBox
            // 
            this.productFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productFormatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productFormatComboBox.FormattingEnabled = true;
            this.productFormatComboBox.Location = new System.Drawing.Point(453, 203);
            this.productFormatComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.productFormatComboBox.Name = "productFormatComboBox";
            this.productFormatComboBox.Size = new System.Drawing.Size(73, 33);
            this.productFormatComboBox.TabIndex = 13;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeLabel.Location = new System.Drawing.Point(613, 200);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(130, 25);
            this.volumeLabel.TabIndex = 14;
            this.volumeLabel.Text = "Объём(стр.)";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeTextBox.Location = new System.Drawing.Point(713, 195);
            this.volumeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(184, 30);
            this.volumeTextBox.TabIndex = 15;
            // 
            // sheetShareLabel
            // 
            this.sheetShareLabel.AutoSize = true;
            this.sheetShareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheetShareLabel.Location = new System.Drawing.Point(613, 253);
            this.sheetShareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sheetShareLabel.Name = "sheetShareLabel";
            this.sheetShareLabel.Size = new System.Drawing.Size(123, 25);
            this.sheetShareLabel.TabIndex = 16;
            this.sheetShareLabel.Text = "Доля листа";
            // 
            // sheetShareTextBox
            // 
            this.sheetShareTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheetShareTextBox.Location = new System.Drawing.Point(713, 253);
            this.sheetShareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sheetShareTextBox.Name = "sheetShareTextBox";
            this.sheetShareTextBox.Size = new System.Drawing.Size(184, 30);
            this.sheetShareTextBox.TabIndex = 17;
            // 
            // colorfulnessBlockLabel
            // 
            this.colorfulnessBlockLabel.AutoSize = true;
            this.colorfulnessBlockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorfulnessBlockLabel.Location = new System.Drawing.Point(20, 320);
            this.colorfulnessBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorfulnessBlockLabel.Name = "colorfulnessBlockLabel";
            this.colorfulnessBlockLabel.Size = new System.Drawing.Size(180, 25);
            this.colorfulnessBlockLabel.TabIndex = 20;
            this.colorfulnessBlockLabel.Text = "Красочность блок";
            // 
            // colorfulnessBlockComboBox
            // 
            this.colorfulnessBlockComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorfulnessBlockComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorfulnessBlockComboBox.FormattingEnabled = true;
            this.colorfulnessBlockComboBox.Location = new System.Drawing.Point(178, 320);
            this.colorfulnessBlockComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorfulnessBlockComboBox.Name = "colorfulnessBlockComboBox";
            this.colorfulnessBlockComboBox.Size = new System.Drawing.Size(216, 33);
            this.colorfulnessBlockComboBox.TabIndex = 21;
            // 
            // colorfulСoverLabel
            // 
            this.colorfulСoverLabel.AutoSize = true;
            this.colorfulСoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorfulСoverLabel.Location = new System.Drawing.Point(448, 323);
            this.colorfulСoverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorfulСoverLabel.Name = "colorfulСoverLabel";
            this.colorfulСoverLabel.Size = new System.Drawing.Size(219, 25);
            this.colorfulСoverLabel.TabIndex = 22;
            this.colorfulСoverLabel.Text = "Красочность обложки";
            // 
            // colorfulCoverComboBox
            // 
            this.colorfulCoverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorfulCoverComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorfulCoverComboBox.FormattingEnabled = true;
            this.colorfulCoverComboBox.Location = new System.Drawing.Point(618, 323);
            this.colorfulCoverComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorfulCoverComboBox.Name = "colorfulCoverComboBox";
            this.colorfulCoverComboBox.Size = new System.Drawing.Size(165, 33);
            this.colorfulCoverComboBox.TabIndex = 23;
            // 
            // technicalNeedsLabel
            // 
            this.technicalNeedsLabel.AutoSize = true;
            this.technicalNeedsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicalNeedsLabel.Location = new System.Drawing.Point(26, 410);
            this.technicalNeedsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.technicalNeedsLabel.Name = "technicalNeedsLabel";
            this.technicalNeedsLabel.Size = new System.Drawing.Size(199, 25);
            this.technicalNeedsLabel.TabIndex = 30;
            this.technicalNeedsLabel.Text = "Технические нужды";
            // 
            // technicalNeedsComboBox
            // 
            this.technicalNeedsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicalNeedsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicalNeedsComboBox.FormattingEnabled = true;
            this.technicalNeedsComboBox.Location = new System.Drawing.Point(169, 410);
            this.technicalNeedsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.technicalNeedsComboBox.Name = "technicalNeedsComboBox";
            this.technicalNeedsComboBox.Size = new System.Drawing.Size(136, 33);
            this.technicalNeedsComboBox.TabIndex = 31;
            // 
            // paperDensityComboBox
            // 
            this.paperDensityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperDensityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperDensityComboBox.FormattingEnabled = true;
            this.paperDensityComboBox.Location = new System.Drawing.Point(494, 410);
            this.paperDensityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.paperDensityComboBox.Name = "paperDensityComboBox";
            this.paperDensityComboBox.Size = new System.Drawing.Size(125, 33);
            this.paperDensityComboBox.TabIndex = 34;
            // 
            // paperDensityLabel
            // 
            this.paperDensityLabel.AutoSize = true;
            this.paperDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperDensityLabel.Location = new System.Drawing.Point(360, 413);
            this.paperDensityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paperDensityLabel.Name = "paperDensityLabel";
            this.paperDensityLabel.Size = new System.Drawing.Size(186, 25);
            this.paperDensityLabel.TabIndex = 35;
            this.paperDensityLabel.Text = "Плотность бумаги";
            // 
            // paperNameLabel
            // 
            this.paperNameLabel.AutoSize = true;
            this.paperNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperNameLabel.Location = new System.Drawing.Point(658, 418);
            this.paperNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paperNameLabel.Name = "paperNameLabel";
            this.paperNameLabel.Size = new System.Drawing.Size(220, 25);
            this.paperNameLabel.TabIndex = 36;
            this.paperNameLabel.Text = "Наименование бумаги";
            // 
            // paperNameComboBox
            // 
            this.paperNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperNameComboBox.FormattingEnabled = true;
            this.paperNameComboBox.Location = new System.Drawing.Point(820, 413);
            this.paperNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.paperNameComboBox.Name = "paperNameComboBox";
            this.paperNameComboBox.Size = new System.Drawing.Size(370, 33);
            this.paperNameComboBox.TabIndex = 37;
            // 
            // bindingMaterialsLabel
            // 
            this.bindingMaterialsLabel.AutoSize = true;
            this.bindingMaterialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingMaterialsLabel.Location = new System.Drawing.Point(27, 68);
            this.bindingMaterialsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bindingMaterialsLabel.Name = "bindingMaterialsLabel";
            this.bindingMaterialsLabel.Size = new System.Drawing.Size(254, 25);
            this.bindingMaterialsLabel.TabIndex = 40;
            this.bindingMaterialsLabel.Text = "Переплётные материалы";
            // 
            // bindingMaterialsComboBox
            // 
            this.bindingMaterialsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingMaterialsComboBox.FormattingEnabled = true;
            this.bindingMaterialsComboBox.Location = new System.Drawing.Point(209, 65);
            this.bindingMaterialsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.bindingMaterialsComboBox.Name = "bindingMaterialsComboBox";
            this.bindingMaterialsComboBox.Size = new System.Drawing.Size(400, 33);
            this.bindingMaterialsComboBox.TabIndex = 41;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(711, 69);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(123, 25);
            this.countLabel.TabIndex = 42;
            this.countLabel.Text = "Количество";
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTextBox.Location = new System.Drawing.Point(796, 69);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(184, 30);
            this.countTextBox.TabIndex = 43;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(1017, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 51);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // goViewButton
            // 
            this.goViewButton.Location = new System.Drawing.Point(965, 22);
            this.goViewButton.Name = "goViewButton";
            this.goViewButton.Size = new System.Drawing.Size(252, 44);
            this.goViewButton.TabIndex = 45;
            this.goViewButton.Text = "Перейти к поиску";
            this.goViewButton.UseVisualStyleBackColor = true;
            this.goViewButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // masterFilmCoverLabel
            // 
            this.masterFilmCoverLabel.AutoSize = true;
            this.masterFilmCoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterFilmCoverLabel.Location = new System.Drawing.Point(861, 328);
            this.masterFilmCoverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.masterFilmCoverLabel.Name = "masterFilmCoverLabel";
            this.masterFilmCoverLabel.Size = new System.Drawing.Size(241, 25);
            this.masterFilmCoverLabel.TabIndex = 46;
            this.masterFilmCoverLabel.Text = "Мастер-плёнка обложка";
            // 
            // masterFilmCoverTextBox
            // 
            this.masterFilmCoverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterFilmCoverTextBox.Location = new System.Drawing.Point(1033, 325);
            this.masterFilmCoverTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.masterFilmCoverTextBox.Name = "masterFilmCoverTextBox";
            this.masterFilmCoverTextBox.Size = new System.Drawing.Size(184, 30);
            this.masterFilmCoverTextBox.TabIndex = 47;
            // 
            // addPaper
            // 
            this.addPaper.Location = new System.Drawing.Point(1215, 413);
            this.addPaper.Name = "addPaper";
            this.addPaper.Size = new System.Drawing.Size(41, 36);
            this.addPaper.TabIndex = 48;
            this.addPaper.Text = "+";
            this.addPaper.UseVisualStyleBackColor = true;
            this.addPaper.Click += new System.EventHandler(this.addPaper_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(625, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bindingMaterialsComboBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bindingMaterialsLabel);
            this.groupBox1.Controls.Add(this.countTextBox);
            this.groupBox1.Controls.Add(this.countLabel);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 161);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переплётные материалы";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(624, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(116, 32);
            this.Header.TabIndex = 51;
            this.Header.Text = "Бумага";
            // 
            // AddToDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1305, 627);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addPaper);
            this.Controls.Add(this.masterFilmCoverTextBox);
            this.Controls.Add(this.masterFilmCoverLabel);
            this.Controls.Add(this.goViewButton);
            this.Controls.Add(this.paperNameComboBox);
            this.Controls.Add(this.paperNameLabel);
            this.Controls.Add(this.paperDensityLabel);
            this.Controls.Add(this.paperDensityComboBox);
            this.Controls.Add(this.technicalNeedsComboBox);
            this.Controls.Add(this.technicalNeedsLabel);
            this.Controls.Add(this.colorfulCoverComboBox);
            this.Controls.Add(this.colorfulСoverLabel);
            this.Controls.Add(this.colorfulnessBlockComboBox);
            this.Controls.Add(this.colorfulnessBlockLabel);
            this.Controls.Add(this.sheetShareTextBox);
            this.Controls.Add(this.sheetShareLabel);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.productFormatComboBox);
            this.Controls.Add(this.productFormatLabel);
            this.Controls.Add(this.circulationTextBox);
            this.Controls.Add(this.circulationLabel);
            this.Controls.Add(this.equipmentСomboBox);
            this.Controls.Add(this.equipmentLabel);
            this.Controls.Add(this.sourceOfFinancingComboBox);
            this.Controls.Add(this.sourceOfFinancingLabel);
            this.Controls.Add(this.typeOfPrintedMatterComboBox);
            this.Controls.Add(this.typeOfPrintedMatterLabel);
            this.Controls.Add(this.orderNameTextBox);
            this.Controls.Add(this.orderNameLabel);
            this.Controls.Add(this.invoiceCalculationTextBox);
            this.Controls.Add(this.invoiceCalculationLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddToDatabaseForm";
            this.Text = "Добавление в базу";
            this.Load += new System.EventHandler(this.PaperProduction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invoiceCalculationLabel;
        private System.Windows.Forms.TextBox invoiceCalculationTextBox;
        private System.Windows.Forms.Label orderNameLabel;
        private System.Windows.Forms.TextBox orderNameTextBox;
        private System.Windows.Forms.Label typeOfPrintedMatterLabel;
        private System.Windows.Forms.ComboBox typeOfPrintedMatterComboBox;
        private System.Windows.Forms.Label sourceOfFinancingLabel;
        private System.Windows.Forms.ComboBox sourceOfFinancingComboBox;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.ComboBox equipmentСomboBox;
        private System.Windows.Forms.Label circulationLabel;
        private System.Windows.Forms.TextBox circulationTextBox;
        private System.Windows.Forms.Label productFormatLabel;
        private System.Windows.Forms.ComboBox productFormatComboBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label sheetShareLabel;
        private System.Windows.Forms.TextBox sheetShareTextBox;
        private System.Windows.Forms.Label colorfulnessBlockLabel;
        private System.Windows.Forms.ComboBox colorfulnessBlockComboBox;
        private System.Windows.Forms.Label colorfulСoverLabel;
        private System.Windows.Forms.ComboBox colorfulCoverComboBox;
        private System.Windows.Forms.Label technicalNeedsLabel;
        private System.Windows.Forms.ComboBox technicalNeedsComboBox;
        private System.Windows.Forms.ComboBox paperDensityComboBox;
        private System.Windows.Forms.Label paperDensityLabel;
        private System.Windows.Forms.Label paperNameLabel;
        private System.Windows.Forms.ComboBox paperNameComboBox;
        private System.Windows.Forms.Label bindingMaterialsLabel;
        private System.Windows.Forms.ComboBox bindingMaterialsComboBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button goViewButton;
        private System.Windows.Forms.Label masterFilmCoverLabel;
        private System.Windows.Forms.TextBox masterFilmCoverTextBox;
        private System.Windows.Forms.Button addPaper;
        private Button button1;
        private GroupBox groupBox1;
        private Label Header;
    }
}

