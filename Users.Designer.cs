namespace ThreeD_Store
{
    partial class Users
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BuyersComboBox = new System.Windows.Forms.ComboBox();
            this.ActionInfoLabel = new System.Windows.Forms.Label();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Label();
            this.AddButt = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MNameLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.MNameTextBox = new System.Windows.Forms.TextBox();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ClearEnterDataButt = new System.Windows.Forms.Button();
            this.AccessInfoLabel = new System.Windows.Forms.Label();
            this.BuyersLabel = new System.Windows.Forms.Label();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrderItemLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemTypesLabel = new System.Windows.Forms.Label();
            this.MaterialsLabel = new System.Windows.Forms.Label();
            this.CreatorsLabel = new System.Windows.Forms.Label();
            this.ItemTypesCheckBox = new System.Windows.Forms.CheckBox();
            this.CreatorsCheckBox = new System.Windows.Forms.CheckBox();
            this.MaterialsCheckBox = new System.Windows.Forms.CheckBox();
            this.OrdersCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.OrdersItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.BuyersCheckBox = new System.Windows.Forms.CheckBox();
            this.Должность = new System.Windows.Forms.Label();
            this.InncorrectDataLabel = new System.Windows.Forms.TextBox();
            this.SearchInfoLabel = new System.Windows.Forms.Label();
            this.SearchButt = new System.Windows.Forms.Button();
            this.ClearButt = new System.Windows.Forms.Button();
            this.OrdersComboBox = new System.Windows.Forms.ComboBox();
            this.OrdersItemsComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.CreatorsComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.ItemTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PostComboBox = new System.Windows.Forms.ComboBox();
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.UsersCheckBox = new System.Windows.Forms.CheckBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(898, 341);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(320, 34);
            this.SearchBox.TabIndex = 174;
            // 
            // BuyersComboBox
            // 
            this.BuyersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyersComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyersComboBox.FormattingEnabled = true;
            this.BuyersComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.BuyersComboBox.Location = new System.Drawing.Point(662, 341);
            this.BuyersComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BuyersComboBox.Name = "BuyersComboBox";
            this.BuyersComboBox.Size = new System.Drawing.Size(207, 27);
            this.BuyersComboBox.TabIndex = 164;
            // 
            // ActionInfoLabel
            // 
            this.ActionInfoLabel.AutoSize = true;
            this.ActionInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionInfoLabel.Location = new System.Drawing.Point(13, 305);
            this.ActionInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionInfoLabel.Name = "ActionInfoLabel";
            this.ActionInfoLabel.Size = new System.Drawing.Size(233, 25);
            this.ActionInfoLabel.TabIndex = 163;
            this.ActionInfoLabel.Text = "Действия с записями";
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(269, 604);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(120, 50);
            this.DeleteButt.TabIndex = 161;
            this.DeleteButt.Text = "Удалить";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // EditButt
            // 
            this.EditButt.Location = new System.Drawing.Point(141, 604);
            this.EditButt.Margin = new System.Windows.Forms.Padding(4);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(120, 50);
            this.EditButt.TabIndex = 160;
            this.EditButt.Text = "Изменить";
            this.EditButt.UseVisualStyleBackColor = true;
            this.EditButt.Click += new System.EventHandler(this.EditButt_Click);
            // 
            // In
            // 
            this.In.AutoSize = true;
            this.In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.In.Location = new System.Drawing.Point(877, 619);
            this.In.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(0, 31);
            this.In.TabIndex = 158;
            this.In.Visible = false;
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(13, 604);
            this.AddButt.Margin = new System.Windows.Forms.Padding(4);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(120, 50);
            this.AddButt.TabIndex = 157;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(63, 461);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(72, 26);
            this.LoginLabel.TabIndex = 149;
            this.LoginLabel.Text = "Логин";
            // 
            // MNameLabel
            // 
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Location = new System.Drawing.Point(30, 424);
            this.MNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(105, 26);
            this.MNameLabel.TabIndex = 148;
            this.MNameLabel.Text = "Отчество";
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Location = new System.Drawing.Point(34, 350);
            this.SNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(101, 26);
            this.SNameLabel.TabIndex = 146;
            this.SNameLabel.Text = "Фамилия";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(53, 498);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 26);
            this.PasswordLabel.TabIndex = 147;
            this.PasswordLabel.Text = "Пароль";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(82, 387);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 26);
            this.NameLabel.TabIndex = 145;
            this.NameLabel.Text = "Имя";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(143, 495);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 34);
            this.PasswordTextBox.TabIndex = 137;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(143, 458);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(200, 34);
            this.LoginTextBox.TabIndex = 136;
            // 
            // MNameTextBox
            // 
            this.MNameTextBox.Location = new System.Drawing.Point(143, 421);
            this.MNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MNameTextBox.Name = "MNameTextBox";
            this.MNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.MNameTextBox.TabIndex = 135;
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(143, 347);
            this.SNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.SNameTextBox.TabIndex = 134;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 384);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 34);
            this.NameTextBox.TabIndex = 133;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(13, 13);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(1205, 280);
            this.DataGridView.TabIndex = 132;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ClearEnterDataButt
            // 
            this.ClearEnterDataButt.Location = new System.Drawing.Point(13, 662);
            this.ClearEnterDataButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearEnterDataButt.Name = "ClearEnterDataButt";
            this.ClearEnterDataButt.Size = new System.Drawing.Size(376, 50);
            this.ClearEnterDataButt.TabIndex = 178;
            this.ClearEnterDataButt.Text = "Сбросить поля ввода";
            this.ClearEnterDataButt.UseVisualStyleBackColor = true;
            this.ClearEnterDataButt.Click += new System.EventHandler(this.ClearEnterDataButt_Click);
            // 
            // AccessInfoLabel
            // 
            this.AccessInfoLabel.AutoSize = true;
            this.AccessInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessInfoLabel.Location = new System.Drawing.Point(414, 305);
            this.AccessInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccessInfoLabel.Name = "AccessInfoLabel";
            this.AccessInfoLabel.Size = new System.Drawing.Size(212, 25);
            this.AccessInfoLabel.TabIndex = 179;
            this.AccessInfoLabel.Text = "Доступ к таблицам";
            // 
            // BuyersLabel
            // 
            this.BuyersLabel.AutoSize = true;
            this.BuyersLabel.Location = new System.Drawing.Point(445, 342);
            this.BuyersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyersLabel.Name = "BuyersLabel";
            this.BuyersLabel.Size = new System.Drawing.Size(186, 26);
            this.BuyersLabel.TabIndex = 180;
            this.BuyersLabel.Text = "Таблица клиентов";
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Location = new System.Drawing.Point(462, 374);
            this.OrdersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(169, 26);
            this.OrdersLabel.TabIndex = 181;
            this.OrdersLabel.Text = "Таблица заказов";
            // 
            // OrderItemLabel
            // 
            this.OrderItemLabel.AutoSize = true;
            this.OrderItemLabel.Location = new System.Drawing.Point(365, 405);
            this.OrderItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderItemLabel.Name = "OrderItemLabel";
            this.OrderItemLabel.Size = new System.Drawing.Size(266, 26);
            this.OrderItemLabel.TabIndex = 182;
            this.OrderItemLabel.Text = "Список товаров на заказы";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(429, 435);
            this.ItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(202, 26);
            this.ItemsLabel.TabIndex = 183;
            this.ItemsLabel.Text = "Таблица продукции";
            // 
            // ItemTypesLabel
            // 
            this.ItemTypesLabel.AutoSize = true;
            this.ItemTypesLabel.Location = new System.Drawing.Point(354, 469);
            this.ItemTypesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemTypesLabel.Name = "ItemTypesLabel";
            this.ItemTypesLabel.Size = new System.Drawing.Size(277, 26);
            this.ItemTypesLabel.TabIndex = 184;
            this.ItemTypesLabel.Text = "Справочник типов товаров";
            // 
            // MaterialsLabel
            // 
            this.MaterialsLabel.AutoSize = true;
            this.MaterialsLabel.Location = new System.Drawing.Point(383, 501);
            this.MaterialsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaterialsLabel.Name = "MaterialsLabel";
            this.MaterialsLabel.Size = new System.Drawing.Size(248, 26);
            this.MaterialsLabel.TabIndex = 185;
            this.MaterialsLabel.Text = "Справочник материалов";
            // 
            // CreatorsLabel
            // 
            this.CreatorsLabel.AutoSize = true;
            this.CreatorsLabel.Location = new System.Drawing.Point(405, 536);
            this.CreatorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatorsLabel.Name = "CreatorsLabel";
            this.CreatorsLabel.Size = new System.Drawing.Size(226, 26);
            this.CreatorsLabel.TabIndex = 186;
            this.CreatorsLabel.Text = "Таблица поставщиков";
            // 
            // ItemTypesCheckBox
            // 
            this.ItemTypesCheckBox.AutoSize = true;
            this.ItemTypesCheckBox.Location = new System.Drawing.Point(639, 473);
            this.ItemTypesCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemTypesCheckBox.Name = "ItemTypesCheckBox";
            this.ItemTypesCheckBox.Size = new System.Drawing.Size(18, 17);
            this.ItemTypesCheckBox.TabIndex = 194;
            this.ItemTypesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreatorsCheckBox
            // 
            this.CreatorsCheckBox.AutoSize = true;
            this.CreatorsCheckBox.Location = new System.Drawing.Point(639, 539);
            this.CreatorsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatorsCheckBox.Name = "CreatorsCheckBox";
            this.CreatorsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.CreatorsCheckBox.TabIndex = 193;
            this.CreatorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaterialsCheckBox
            // 
            this.MaterialsCheckBox.AutoSize = true;
            this.MaterialsCheckBox.Location = new System.Drawing.Point(639, 505);
            this.MaterialsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialsCheckBox.Name = "MaterialsCheckBox";
            this.MaterialsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.MaterialsCheckBox.TabIndex = 192;
            this.MaterialsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrdersCheckBox
            // 
            this.OrdersCheckBox.AutoSize = true;
            this.OrdersCheckBox.Location = new System.Drawing.Point(639, 377);
            this.OrdersCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersCheckBox.Name = "OrdersCheckBox";
            this.OrdersCheckBox.Size = new System.Drawing.Size(18, 17);
            this.OrdersCheckBox.TabIndex = 197;
            this.OrdersCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemsCheckBox
            // 
            this.ItemsCheckBox.AutoSize = true;
            this.ItemsCheckBox.Location = new System.Drawing.Point(639, 441);
            this.ItemsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsCheckBox.Name = "ItemsCheckBox";
            this.ItemsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.ItemsCheckBox.TabIndex = 196;
            this.ItemsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrdersItemsCheckBox
            // 
            this.OrdersItemsCheckBox.AutoSize = true;
            this.OrdersItemsCheckBox.Location = new System.Drawing.Point(639, 409);
            this.OrdersItemsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersItemsCheckBox.Name = "OrdersItemsCheckBox";
            this.OrdersItemsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.OrdersItemsCheckBox.TabIndex = 195;
            this.OrdersItemsCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuyersCheckBox
            // 
            this.BuyersCheckBox.AutoSize = true;
            this.BuyersCheckBox.Location = new System.Drawing.Point(639, 345);
            this.BuyersCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BuyersCheckBox.Name = "BuyersCheckBox";
            this.BuyersCheckBox.Size = new System.Drawing.Size(18, 17);
            this.BuyersCheckBox.TabIndex = 198;
            this.BuyersCheckBox.UseVisualStyleBackColor = true;
            // 
            // Должность
            // 
            this.Должность.AutoSize = true;
            this.Должность.Location = new System.Drawing.Point(13, 535);
            this.Должность.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Должность.Name = "Должность";
            this.Должность.Size = new System.Drawing.Size(122, 26);
            this.Должность.TabIndex = 200;
            this.Должность.Text = "Должность";
            // 
            // InncorrectDataLabel
            // 
            this.InncorrectDataLabel.BackColor = System.Drawing.SystemColors.Control;
            this.InncorrectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InncorrectDataLabel.Enabled = false;
            this.InncorrectDataLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InncorrectDataLabel.ForeColor = System.Drawing.Color.Red;
            this.InncorrectDataLabel.Location = new System.Drawing.Point(898, 441);
            this.InncorrectDataLabel.Margin = new System.Windows.Forms.Padding(4);
            this.InncorrectDataLabel.Multiline = true;
            this.InncorrectDataLabel.Name = "InncorrectDataLabel";
            this.InncorrectDataLabel.Size = new System.Drawing.Size(320, 30);
            this.InncorrectDataLabel.TabIndex = 210;
            this.InncorrectDataLabel.Text = "Некорректно введены данные";
            this.InncorrectDataLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InncorrectDataLabel.Visible = false;
            // 
            // SearchInfoLabel
            // 
            this.SearchInfoLabel.AutoSize = true;
            this.SearchInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInfoLabel.Location = new System.Drawing.Point(893, 305);
            this.SearchInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchInfoLabel.Name = "SearchInfoLabel";
            this.SearchInfoLabel.Size = new System.Drawing.Size(213, 25);
            this.SearchInfoLabel.TabIndex = 211;
            this.SearchInfoLabel.Text = "Поиск по фамилии";
            // 
            // SearchButt
            // 
            this.SearchButt.Location = new System.Drawing.Point(898, 383);
            this.SearchButt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.Size = new System.Drawing.Size(120, 50);
            this.SearchButt.TabIndex = 212;
            this.SearchButt.Text = "Найти";
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // ClearButt
            // 
            this.ClearButt.Location = new System.Drawing.Point(1098, 383);
            this.ClearButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(120, 50);
            this.ClearButt.TabIndex = 213;
            this.ClearButt.Text = "Сбросить";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // OrdersComboBox
            // 
            this.OrdersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrdersComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersComboBox.FormattingEnabled = true;
            this.OrdersComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.OrdersComboBox.Location = new System.Drawing.Point(662, 373);
            this.OrdersComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersComboBox.Name = "OrdersComboBox";
            this.OrdersComboBox.Size = new System.Drawing.Size(207, 27);
            this.OrdersComboBox.TabIndex = 214;
            // 
            // OrdersItemsComboBox
            // 
            this.OrdersItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrdersItemsComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersItemsComboBox.FormattingEnabled = true;
            this.OrdersItemsComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.OrdersItemsComboBox.Location = new System.Drawing.Point(662, 405);
            this.OrdersItemsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersItemsComboBox.Name = "OrdersItemsComboBox";
            this.OrdersItemsComboBox.Size = new System.Drawing.Size(207, 27);
            this.OrdersItemsComboBox.TabIndex = 215;
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.ItemsComboBox.Location = new System.Drawing.Point(662, 437);
            this.ItemsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(207, 27);
            this.ItemsComboBox.TabIndex = 216;
            // 
            // CreatorsComboBox
            // 
            this.CreatorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreatorsComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatorsComboBox.FormattingEnabled = true;
            this.CreatorsComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.CreatorsComboBox.Location = new System.Drawing.Point(662, 535);
            this.CreatorsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatorsComboBox.Name = "CreatorsComboBox";
            this.CreatorsComboBox.Size = new System.Drawing.Size(207, 27);
            this.CreatorsComboBox.TabIndex = 219;
            // 
            // MaterialsComboBox
            // 
            this.MaterialsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialsComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialsComboBox.FormattingEnabled = true;
            this.MaterialsComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.MaterialsComboBox.Location = new System.Drawing.Point(662, 501);
            this.MaterialsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialsComboBox.Name = "MaterialsComboBox";
            this.MaterialsComboBox.Size = new System.Drawing.Size(207, 27);
            this.MaterialsComboBox.TabIndex = 218;
            // 
            // ItemTypesComboBox
            // 
            this.ItemTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypesComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemTypesComboBox.FormattingEnabled = true;
            this.ItemTypesComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.ItemTypesComboBox.Location = new System.Drawing.Point(662, 469);
            this.ItemTypesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemTypesComboBox.Name = "ItemTypesComboBox";
            this.ItemTypesComboBox.Size = new System.Drawing.Size(207, 27);
            this.ItemTypesComboBox.TabIndex = 217;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(877, 689);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 31);
            this.label10.TabIndex = 221;
            this.label10.Visible = false;
            // 
            // PostComboBox
            // 
            this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostComboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostComboBox.FormattingEnabled = true;
            this.PostComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Бухгалтер",
            "Ремонтник"});
            this.PostComboBox.Location = new System.Drawing.Point(143, 532);
            this.PostComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(200, 34);
            this.PostComboBox.TabIndex = 224;
            this.PostComboBox.SelectedIndexChanged += new System.EventHandler(this.PostBox_SelectedIndexChanged);
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Items.AddRange(new object[] {
            "Нет доступа",
            "Только чтение",
            "Полный доступ"});
            this.UsersComboBox.Location = new System.Drawing.Point(662, 570);
            this.UsersComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(207, 27);
            this.UsersComboBox.TabIndex = 227;
            // 
            // UsersCheckBox
            // 
            this.UsersCheckBox.AutoSize = true;
            this.UsersCheckBox.Location = new System.Drawing.Point(639, 574);
            this.UsersCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersCheckBox.Name = "UsersCheckBox";
            this.UsersCheckBox.Size = new System.Drawing.Size(18, 17);
            this.UsersCheckBox.TabIndex = 226;
            this.UsersCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(395, 568);
            this.UsersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(236, 26);
            this.UsersLabel.TabIndex = 225;
            this.UsersLabel.Text = "Таблица пользователей";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 725);
            this.Controls.Add(this.UsersComboBox);
            this.Controls.Add(this.UsersCheckBox);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.PostComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CreatorsComboBox);
            this.Controls.Add(this.MaterialsComboBox);
            this.Controls.Add(this.ItemTypesComboBox);
            this.Controls.Add(this.ItemsComboBox);
            this.Controls.Add(this.OrdersItemsComboBox);
            this.Controls.Add(this.OrdersComboBox);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.SearchInfoLabel);
            this.Controls.Add(this.InncorrectDataLabel);
            this.Controls.Add(this.Должность);
            this.Controls.Add(this.BuyersCheckBox);
            this.Controls.Add(this.OrdersCheckBox);
            this.Controls.Add(this.ItemsCheckBox);
            this.Controls.Add(this.OrdersItemsCheckBox);
            this.Controls.Add(this.ItemTypesCheckBox);
            this.Controls.Add(this.CreatorsCheckBox);
            this.Controls.Add(this.MaterialsCheckBox);
            this.Controls.Add(this.CreatorsLabel);
            this.Controls.Add(this.MaterialsLabel);
            this.Controls.Add(this.ItemTypesLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.OrderItemLabel);
            this.Controls.Add(this.OrdersLabel);
            this.Controls.Add(this.BuyersLabel);
            this.Controls.Add(this.AccessInfoLabel);
            this.Controls.Add(this.ClearEnterDataButt);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.BuyersComboBox);
            this.Controls.Add(this.ActionInfoLabel);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.EditButt);
            this.Controls.Add(this.In);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.MNameLabel);
            this.Controls.Add(this.SNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.MNameTextBox);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox BuyersComboBox;
        private System.Windows.Forms.Label ActionInfoLabel;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Label In;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label MNameLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox MNameTextBox;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ClearEnterDataButt;
        private System.Windows.Forms.Label AccessInfoLabel;
        private System.Windows.Forms.Label BuyersLabel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label OrderItemLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label ItemTypesLabel;
        private System.Windows.Forms.Label MaterialsLabel;
        private System.Windows.Forms.Label CreatorsLabel;
        private System.Windows.Forms.CheckBox ItemTypesCheckBox;
        private System.Windows.Forms.CheckBox CreatorsCheckBox;
        private System.Windows.Forms.CheckBox MaterialsCheckBox;
        private System.Windows.Forms.CheckBox OrdersCheckBox;
        private System.Windows.Forms.CheckBox ItemsCheckBox;
        private System.Windows.Forms.CheckBox OrdersItemsCheckBox;
        private System.Windows.Forms.CheckBox BuyersCheckBox;
        private System.Windows.Forms.Label Должность;
        private System.Windows.Forms.TextBox InncorrectDataLabel;
        private System.Windows.Forms.Label SearchInfoLabel;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.ComboBox OrdersComboBox;
        private System.Windows.Forms.ComboBox OrdersItemsComboBox;
        private System.Windows.Forms.ComboBox ItemsComboBox;
        private System.Windows.Forms.ComboBox CreatorsComboBox;
        private System.Windows.Forms.ComboBox MaterialsComboBox;
        private System.Windows.Forms.ComboBox ItemTypesComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PostComboBox;
        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.CheckBox UsersCheckBox;
        private System.Windows.Forms.Label UsersLabel;
    }
}