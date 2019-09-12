namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label iD_ПользователиLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label тип_аккаунтаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label регионLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label почтовый_индексLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label элетронная_почтаLabel;
            System.Windows.Forms.Label статус_участияLabel;
            System.Windows.Forms.Label компетенцияLabel;
            System.Windows.Forms.Label дата_поступления_заявкиLabel;
            System.Windows.Forms.Label дата_приездаLabel;
            System.Windows.Forms.Label дата_отъездаLabel;
            System.Windows.Forms.Label потребность_в_гостиницеLabel;
            System.Windows.Forms.Label потребность_в_транспортеLabel;
            this.projectArazDataSet1 = new WindowsFormsApp1.ProjectArazDataSet1();
            this.пользователи1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователи1TableAdapter = new WindowsFormsApp1.ProjectArazDataSet1TableAdapters.Пользователи1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ProjectArazDataSet1TableAdapters.TableAdapterManager();
            this.пользователи1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.пользователи1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ПользователиTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.тип_аккаунтаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.регионTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.почтовый_индексTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.элетронная_почтаTextBox = new System.Windows.Forms.TextBox();
            this.ролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ролиTableAdapter = new WindowsFormsApp1.ProjectArazDataSet1TableAdapters.РолиTableAdapter();
            this.статус_участияTextBox = new System.Windows.Forms.TextBox();
            this.компетенцияTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступления_заявкиTextBox = new System.Windows.Forms.TextBox();
            this.дата_приездаTextBox = new System.Windows.Forms.TextBox();
            this.дата_отъездаTextBox = new System.Windows.Forms.TextBox();
            this.потребность_в_гостиницеTextBox = new System.Windows.Forms.TextBox();
            this.потребность_в_транспортеTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            iD_ПользователиLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            тип_аккаунтаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            регионLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            почтовый_индексLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            элетронная_почтаLabel = new System.Windows.Forms.Label();
            статус_участияLabel = new System.Windows.Forms.Label();
            компетенцияLabel = new System.Windows.Forms.Label();
            дата_поступления_заявкиLabel = new System.Windows.Forms.Label();
            дата_приездаLabel = new System.Windows.Forms.Label();
            дата_отъездаLabel = new System.Windows.Forms.Label();
            потребность_в_гостиницеLabel = new System.Windows.Forms.Label();
            потребность_в_транспортеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectArazDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователи1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователи1BindingNavigator)).BeginInit();
            this.пользователи1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectArazDataSet1
            // 
            this.projectArazDataSet1.DataSetName = "ProjectArazDataSet1";
            this.projectArazDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователи1BindingSource
            // 
            this.пользователи1BindingSource.DataMember = "Пользователи1";
            this.пользователи1BindingSource.DataSource = this.projectArazDataSet1;
            // 
            // пользователи1TableAdapter
            // 
            this.пользователи1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ProjectArazDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АккаунтTableAdapter = null;
            this.tableAdapterManager.КомпетенцияTableAdapter = null;
            this.tableAdapterManager.Пользователи1TableAdapter = this.пользователи1TableAdapter;
            this.tableAdapterManager.РегионTableAdapter = null;
            this.tableAdapterManager.РолиTableAdapter = this.ролиTableAdapter;
            this.tableAdapterManager.Статус_участияTableAdapter = null;
            // 
            // пользователи1BindingNavigator
            // 
            this.пользователи1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пользователи1BindingNavigator.BindingSource = this.пользователи1BindingSource;
            this.пользователи1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пользователи1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пользователи1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.пользователи1BindingNavigatorSaveItem});
            this.пользователи1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пользователи1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пользователи1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пользователи1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пользователи1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пользователи1BindingNavigator.Name = "пользователи1BindingNavigator";
            this.пользователи1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пользователи1BindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.пользователи1BindingNavigator.TabIndex = 0;
            this.пользователи1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // пользователи1BindingNavigatorSaveItem
            // 
            this.пользователи1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пользователи1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пользователи1BindingNavigatorSaveItem.Image")));
            this.пользователи1BindingNavigatorSaveItem.Name = "пользователи1BindingNavigatorSaveItem";
            this.пользователи1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.пользователи1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пользователи1BindingNavigatorSaveItem.Click += new System.EventHandler(this.пользователи1BindingNavigatorSaveItem_Click);
            // 
            // iD_ПользователиLabel
            // 
            iD_ПользователиLabel.AutoSize = true;
            iD_ПользователиLabel.Location = new System.Drawing.Point(20, 66);
            iD_ПользователиLabel.Name = "iD_ПользователиLabel";
            iD_ПользователиLabel.Size = new System.Drawing.Size(97, 13);
            iD_ПользователиLabel.TabIndex = 1;
            iD_ПользователиLabel.Text = "ID Пользователи:";
            // 
            // iD_ПользователиTextBox
            // 
            this.iD_ПользователиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "ID_Пользователи", true));
            this.iD_ПользователиTextBox.Location = new System.Drawing.Point(192, 63);
            this.iD_ПользователиTextBox.Name = "iD_ПользователиTextBox";
            this.iD_ПользователиTextBox.Size = new System.Drawing.Size(347, 20);
            this.iD_ПользователиTextBox.TabIndex = 2;
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(20, 92);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 3;
            логинLabel.Text = "Логин:";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(192, 89);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(347, 20);
            this.логинTextBox.TabIndex = 4;
            // 
            // тип_аккаунтаLabel
            // 
            тип_аккаунтаLabel.AutoSize = true;
            тип_аккаунтаLabel.Location = new System.Drawing.Point(20, 118);
            тип_аккаунтаLabel.Name = "тип_аккаунтаLabel";
            тип_аккаунтаLabel.Size = new System.Drawing.Size(78, 13);
            тип_аккаунтаLabel.TabIndex = 5;
            тип_аккаунтаLabel.Text = "Тип аккаунта:";
            // 
            // тип_аккаунтаTextBox
            // 
            this.тип_аккаунтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Тип_аккаунта", true));
            this.тип_аккаунтаTextBox.Location = new System.Drawing.Point(192, 115);
            this.тип_аккаунтаTextBox.Name = "тип_аккаунтаTextBox";
            this.тип_аккаунтаTextBox.Size = new System.Drawing.Size(347, 20);
            this.тип_аккаунтаTextBox.TabIndex = 6;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(20, 144);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 7;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(192, 141);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(347, 20);
            this.фИОTextBox.TabIndex = 8;
            // 
            // регионLabel
            // 
            регионLabel.AutoSize = true;
            регионLabel.Location = new System.Drawing.Point(20, 170);
            регионLabel.Name = "регионLabel";
            регионLabel.Size = new System.Drawing.Size(46, 13);
            регионLabel.TabIndex = 9;
            регионLabel.Text = "Регион:";
            // 
            // регионTextBox
            // 
            this.регионTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Регион", true));
            this.регионTextBox.Location = new System.Drawing.Point(192, 167);
            this.регионTextBox.Name = "регионTextBox";
            this.регионTextBox.Size = new System.Drawing.Size(347, 20);
            this.регионTextBox.TabIndex = 10;
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(20, 196);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(40, 13);
            городLabel.TabIndex = 11;
            городLabel.Text = "Город:";
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(192, 193);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(347, 20);
            this.городTextBox.TabIndex = 12;
            // 
            // почтовый_индексLabel
            // 
            почтовый_индексLabel.AutoSize = true;
            почтовый_индексLabel.Location = new System.Drawing.Point(20, 222);
            почтовый_индексLabel.Name = "почтовый_индексLabel";
            почтовый_индексLabel.Size = new System.Drawing.Size(99, 13);
            почтовый_индексLabel.TabIndex = 13;
            почтовый_индексLabel.Text = "Почтовый индекс:";
            // 
            // почтовый_индексTextBox
            // 
            this.почтовый_индексTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Почтовый_индекс", true));
            this.почтовый_индексTextBox.Location = new System.Drawing.Point(192, 219);
            this.почтовый_индексTextBox.Name = "почтовый_индексTextBox";
            this.почтовый_индексTextBox.Size = new System.Drawing.Size(347, 20);
            this.почтовый_индексTextBox.TabIndex = 14;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(20, 248);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 15;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(192, 245);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(347, 20);
            this.адресTextBox.TabIndex = 16;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(20, 274);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 17;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(192, 271);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(347, 20);
            this.телефонTextBox.TabIndex = 18;
            // 
            // элетронная_почтаLabel
            // 
            элетронная_почтаLabel.AutoSize = true;
            элетронная_почтаLabel.Location = new System.Drawing.Point(20, 300);
            элетронная_почтаLabel.Name = "элетронная_почтаLabel";
            элетронная_почтаLabel.Size = new System.Drawing.Size(101, 13);
            элетронная_почтаLabel.TabIndex = 19;
            элетронная_почтаLabel.Text = "Элетронная почта:";
            // 
            // элетронная_почтаTextBox
            // 
            this.элетронная_почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователи1BindingSource, "Элетронная_почта", true));
            this.элетронная_почтаTextBox.Location = new System.Drawing.Point(192, 297);
            this.элетронная_почтаTextBox.Name = "элетронная_почтаTextBox";
            this.элетронная_почтаTextBox.Size = new System.Drawing.Size(347, 20);
            this.элетронная_почтаTextBox.TabIndex = 20;
            // 
            // ролиBindingSource
            // 
            this.ролиBindingSource.DataMember = "FK_Роли_Пользователи1";
            this.ролиBindingSource.DataSource = this.пользователи1BindingSource;
            // 
            // ролиTableAdapter
            // 
            this.ролиTableAdapter.ClearBeforeFill = true;
            // 
            // статус_участияLabel
            // 
            статус_участияLabel.AutoSize = true;
            статус_участияLabel.Location = new System.Drawing.Point(20, 326);
            статус_участияLabel.Name = "статус_участияLabel";
            статус_участияLabel.Size = new System.Drawing.Size(86, 13);
            статус_участияLabel.TabIndex = 21;
            статус_участияLabel.Text = "Статус участия:";
            // 
            // статус_участияTextBox
            // 
            this.статус_участияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Статус_участия", true));
            this.статус_участияTextBox.Location = new System.Drawing.Point(192, 323);
            this.статус_участияTextBox.Name = "статус_участияTextBox";
            this.статус_участияTextBox.Size = new System.Drawing.Size(347, 20);
            this.статус_участияTextBox.TabIndex = 22;
            // 
            // компетенцияLabel
            // 
            компетенцияLabel.AutoSize = true;
            компетенцияLabel.Location = new System.Drawing.Point(20, 352);
            компетенцияLabel.Name = "компетенцияLabel";
            компетенцияLabel.Size = new System.Drawing.Size(78, 13);
            компетенцияLabel.TabIndex = 23;
            компетенцияLabel.Text = "Компетенция:";
            // 
            // компетенцияTextBox
            // 
            this.компетенцияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Компетенция", true));
            this.компетенцияTextBox.Location = new System.Drawing.Point(192, 349);
            this.компетенцияTextBox.Name = "компетенцияTextBox";
            this.компетенцияTextBox.Size = new System.Drawing.Size(347, 20);
            this.компетенцияTextBox.TabIndex = 24;
            // 
            // дата_поступления_заявкиLabel
            // 
            дата_поступления_заявкиLabel.AutoSize = true;
            дата_поступления_заявкиLabel.Location = new System.Drawing.Point(20, 378);
            дата_поступления_заявкиLabel.Name = "дата_поступления_заявкиLabel";
            дата_поступления_заявкиLabel.Size = new System.Drawing.Size(145, 13);
            дата_поступления_заявкиLabel.TabIndex = 25;
            дата_поступления_заявкиLabel.Text = "Дата поступления заявки]:";
            // 
            // дата_поступления_заявкиTextBox
            // 
            this.дата_поступления_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Дата_поступления_заявки]", true));
            this.дата_поступления_заявкиTextBox.Location = new System.Drawing.Point(192, 375);
            this.дата_поступления_заявкиTextBox.Name = "дата_поступления_заявкиTextBox";
            this.дата_поступления_заявкиTextBox.Size = new System.Drawing.Size(347, 20);
            this.дата_поступления_заявкиTextBox.TabIndex = 26;
            // 
            // дата_приездаLabel
            // 
            дата_приездаLabel.AutoSize = true;
            дата_приездаLabel.Location = new System.Drawing.Point(20, 404);
            дата_приездаLabel.Name = "дата_приездаLabel";
            дата_приездаLabel.Size = new System.Drawing.Size(81, 13);
            дата_приездаLabel.TabIndex = 27;
            дата_приездаLabel.Text = "Дата приезда:";
            // 
            // дата_приездаTextBox
            // 
            this.дата_приездаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Дата_приезда", true));
            this.дата_приездаTextBox.Location = new System.Drawing.Point(192, 401);
            this.дата_приездаTextBox.Name = "дата_приездаTextBox";
            this.дата_приездаTextBox.Size = new System.Drawing.Size(347, 20);
            this.дата_приездаTextBox.TabIndex = 28;
            // 
            // дата_отъездаLabel
            // 
            дата_отъездаLabel.AutoSize = true;
            дата_отъездаLabel.Location = new System.Drawing.Point(20, 430);
            дата_отъездаLabel.Name = "дата_отъездаLabel";
            дата_отъездаLabel.Size = new System.Drawing.Size(81, 13);
            дата_отъездаLabel.TabIndex = 29;
            дата_отъездаLabel.Text = "Дата отъезда:";
            // 
            // дата_отъездаTextBox
            // 
            this.дата_отъездаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Дата_отъезда", true));
            this.дата_отъездаTextBox.Location = new System.Drawing.Point(192, 427);
            this.дата_отъездаTextBox.Name = "дата_отъездаTextBox";
            this.дата_отъездаTextBox.Size = new System.Drawing.Size(347, 20);
            this.дата_отъездаTextBox.TabIndex = 30;
            // 
            // потребность_в_гостиницеLabel
            // 
            потребность_в_гостиницеLabel.AutoSize = true;
            потребность_в_гостиницеLabel.Location = new System.Drawing.Point(20, 456);
            потребность_в_гостиницеLabel.Name = "потребность_в_гостиницеLabel";
            потребность_в_гостиницеLabel.Size = new System.Drawing.Size(140, 13);
            потребность_в_гостиницеLabel.TabIndex = 31;
            потребность_в_гостиницеLabel.Text = "Потребность в гостинице:";
            // 
            // потребность_в_гостиницеTextBox
            // 
            this.потребность_в_гостиницеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Потребность_в_гостинице", true));
            this.потребность_в_гостиницеTextBox.Location = new System.Drawing.Point(192, 453);
            this.потребность_в_гостиницеTextBox.Name = "потребность_в_гостиницеTextBox";
            this.потребность_в_гостиницеTextBox.Size = new System.Drawing.Size(347, 20);
            this.потребность_в_гостиницеTextBox.TabIndex = 32;
            // 
            // потребность_в_транспортеLabel
            // 
            потребность_в_транспортеLabel.AutoSize = true;
            потребность_в_транспортеLabel.Location = new System.Drawing.Point(20, 482);
            потребность_в_транспортеLabel.Name = "потребность_в_транспортеLabel";
            потребность_в_транспортеLabel.Size = new System.Drawing.Size(146, 13);
            потребность_в_транспортеLabel.TabIndex = 33;
            потребность_в_транспортеLabel.Text = "Потребность в транспорте:";
            // 
            // потребность_в_транспортеTextBox
            // 
            this.потребность_в_транспортеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ролиBindingSource, "Потребность_в_транспорте", true));
            this.потребность_в_транспортеTextBox.Location = new System.Drawing.Point(192, 479);
            this.потребность_в_транспортеTextBox.Name = "потребность_в_транспортеTextBox";
            this.потребность_в_транспортеTextBox.Size = new System.Drawing.Size(347, 20);
            this.потребность_в_транспортеTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Участник";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(209, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(потребность_в_транспортеLabel);
            this.Controls.Add(this.потребность_в_транспортеTextBox);
            this.Controls.Add(потребность_в_гостиницеLabel);
            this.Controls.Add(this.потребность_в_гостиницеTextBox);
            this.Controls.Add(дата_отъездаLabel);
            this.Controls.Add(this.дата_отъездаTextBox);
            this.Controls.Add(дата_приездаLabel);
            this.Controls.Add(this.дата_приездаTextBox);
            this.Controls.Add(дата_поступления_заявкиLabel);
            this.Controls.Add(this.дата_поступления_заявкиTextBox);
            this.Controls.Add(компетенцияLabel);
            this.Controls.Add(this.компетенцияTextBox);
            this.Controls.Add(статус_участияLabel);
            this.Controls.Add(this.статус_участияTextBox);
            this.Controls.Add(элетронная_почтаLabel);
            this.Controls.Add(this.элетронная_почтаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(почтовый_индексLabel);
            this.Controls.Add(this.почтовый_индексTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(регионLabel);
            this.Controls.Add(this.регионTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(тип_аккаунтаLabel);
            this.Controls.Add(this.тип_аккаунтаTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(iD_ПользователиLabel);
            this.Controls.Add(this.iD_ПользователиTextBox);
            this.Controls.Add(this.пользователи1BindingNavigator);
            this.Name = "Form4";
            this.Text = "Участник";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectArazDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователи1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователи1BindingNavigator)).EndInit();
            this.пользователи1BindingNavigator.ResumeLayout(false);
            this.пользователи1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectArazDataSet1 projectArazDataSet1;
        private System.Windows.Forms.BindingSource пользователи1BindingSource;
        private ProjectArazDataSet1TableAdapters.Пользователи1TableAdapter пользователи1TableAdapter;
        private ProjectArazDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользователи1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пользователи1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ПользователиTextBox;
        private ProjectArazDataSet1TableAdapters.РолиTableAdapter ролиTableAdapter;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox тип_аккаунтаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox регионTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox почтовый_индексTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox элетронная_почтаTextBox;
        private System.Windows.Forms.BindingSource ролиBindingSource;
        private System.Windows.Forms.TextBox статус_участияTextBox;
        private System.Windows.Forms.TextBox компетенцияTextBox;
        private System.Windows.Forms.TextBox дата_поступления_заявкиTextBox;
        private System.Windows.Forms.TextBox дата_приездаTextBox;
        private System.Windows.Forms.TextBox дата_отъездаTextBox;
        private System.Windows.Forms.TextBox потребность_в_гостиницеTextBox;
        private System.Windows.Forms.TextBox потребность_в_транспортеTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}