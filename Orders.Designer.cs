namespace ThreeD_Store
{
    partial class Orders
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
            this.ClearButt = new System.Windows.Forms.Button();
            this.SearchButt = new System.Windows.Forms.Button();
            this.SearchInfoLabel = new System.Windows.Forms.Label();
            this.InncorrectDataLabel = new System.Windows.Forms.TextBox();
            this.ClearEnterDataButt = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ActionInfoLabel = new System.Windows.Forms.Label();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.AddButt = new System.Windows.Forms.Button();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.BuyerIDLabel = new System.Windows.Forms.Label();
            this.DueDateTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.BuyerIDTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.PaidCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButt
            // 
            this.ClearButt.Location = new System.Drawing.Point(1098, 383);
            this.ClearButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(120, 50);
            this.ClearButt.TabIndex = 288;
            this.ClearButt.Text = "Сбросить";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // SearchButt
            // 
            this.SearchButt.Location = new System.Drawing.Point(898, 383);
            this.SearchButt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.Size = new System.Drawing.Size(120, 50);
            this.SearchButt.TabIndex = 287;
            this.SearchButt.Text = "Найти";
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // SearchInfoLabel
            // 
            this.SearchInfoLabel.AutoSize = true;
            this.SearchInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInfoLabel.Location = new System.Drawing.Point(894, 305);
            this.SearchInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchInfoLabel.Name = "SearchInfoLabel";
            this.SearchInfoLabel.Size = new System.Drawing.Size(218, 25);
            this.SearchInfoLabel.TabIndex = 286;
            this.SearchInfoLabel.Text = "Поиск по ID Заказа";
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
            this.InncorrectDataLabel.TabIndex = 285;
            this.InncorrectDataLabel.Text = "Некорректно введены данные";
            this.InncorrectDataLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InncorrectDataLabel.Visible = false;
            // 
            // ClearEnterDataButt
            // 
            this.ClearEnterDataButt.Location = new System.Drawing.Point(13, 662);
            this.ClearEnterDataButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearEnterDataButt.Name = "ClearEnterDataButt";
            this.ClearEnterDataButt.Size = new System.Drawing.Size(376, 50);
            this.ClearEnterDataButt.TabIndex = 284;
            this.ClearEnterDataButt.Text = "Сбросить поля ввода";
            this.ClearEnterDataButt.UseVisualStyleBackColor = true;
            this.ClearEnterDataButt.Click += new System.EventHandler(this.ClearEnterDataButt_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(898, 341);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(320, 34);
            this.SearchTextBox.TabIndex = 283;
            // 
            // ActionInfoLabel
            // 
            this.ActionInfoLabel.AutoSize = true;
            this.ActionInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionInfoLabel.Location = new System.Drawing.Point(13, 305);
            this.ActionInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionInfoLabel.Name = "ActionInfoLabel";
            this.ActionInfoLabel.Size = new System.Drawing.Size(233, 25);
            this.ActionInfoLabel.TabIndex = 282;
            this.ActionInfoLabel.Text = "Действия с записями";
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(269, 604);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(120, 50);
            this.DeleteButt.TabIndex = 281;
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
            this.EditButt.TabIndex = 280;
            this.EditButt.Text = "Изменить";
            this.EditButt.UseVisualStyleBackColor = true;
            this.EditButt.Click += new System.EventHandler(this.EditButt_Click);
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(13, 604);
            this.AddButt.Margin = new System.Windows.Forms.Padding(4);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(120, 50);
            this.AddButt.TabIndex = 279;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(72, 460);
            this.DueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(152, 26);
            this.DueDateLabel.TabIndex = 278;
            this.DueDateLabel.Text = "Дата доставки";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(102, 423);
            this.OrderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(122, 26);
            this.OrderDateLabel.TabIndex = 277;
            this.OrderDateLabel.Text = "Дата заказа";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(120, 349);
            this.OrderIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(104, 26);
            this.OrderIDLabel.TabIndex = 276;
            this.OrderIDLabel.Text = "ID Заказа";
            // 
            // BuyerIDLabel
            // 
            this.BuyerIDLabel.AutoSize = true;
            this.BuyerIDLabel.Location = new System.Drawing.Point(102, 386);
            this.BuyerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyerIDLabel.Name = "BuyerIDLabel";
            this.BuyerIDLabel.Size = new System.Drawing.Size(122, 26);
            this.BuyerIDLabel.TabIndex = 275;
            this.BuyerIDLabel.Text = "ID Клиента";
            // 
            // DueDateTextBox
            // 
            this.DueDateTextBox.Location = new System.Drawing.Point(232, 457);
            this.DueDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DueDateTextBox.Name = "DueDateTextBox";
            this.DueDateTextBox.Size = new System.Drawing.Size(150, 34);
            this.DueDateTextBox.TabIndex = 274;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(232, 420);
            this.OrderDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(150, 34);
            this.OrderDateTextBox.TabIndex = 273;
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Location = new System.Drawing.Point(232, 346);
            this.OrderIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(150, 34);
            this.OrderIDTextBox.TabIndex = 272;
            // 
            // BuyerIDTextBox
            // 
            this.BuyerIDTextBox.Location = new System.Drawing.Point(232, 383);
            this.BuyerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BuyerIDTextBox.Name = "BuyerIDTextBox";
            this.BuyerIDTextBox.Size = new System.Drawing.Size(150, 34);
            this.BuyerIDTextBox.TabIndex = 271;
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
            this.DataGridView.TabIndex = 270;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(13, 497);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(211, 26);
            this.CountLabel.TabIndex = 290;
            this.CountLabel.Text = "Количество товаров";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(232, 494);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(150, 34);
            this.CountTextBox.TabIndex = 289;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(40, 534);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(184, 26);
            this.SumLabel.TabIndex = 292;
            this.SumLabel.Text = "Стоимость заказа";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(232, 531);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(150, 34);
            this.SumTextBox.TabIndex = 291;
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Location = new System.Drawing.Point(472, 349);
            this.PaidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(107, 26);
            this.PaidLabel.TabIndex = 294;
            this.PaidLabel.Text = "Оплачено";
            // 
            // PaidCheckBox
            // 
            this.PaidCheckBox.AutoSize = true;
            this.PaidCheckBox.Location = new System.Drawing.Point(586, 355);
            this.PaidCheckBox.Name = "PaidCheckBox";
            this.PaidCheckBox.Size = new System.Drawing.Size(18, 17);
            this.PaidCheckBox.TabIndex = 295;
            this.PaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(410, 386);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(168, 26);
            this.AddressLabel.TabIndex = 297;
            this.AddressLabel.Text = "Адрес доставки";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(586, 383);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(250, 34);
            this.AddressTextBox.TabIndex = 296;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 725);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PaidCheckBox);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.SearchInfoLabel);
            this.Controls.Add(this.InncorrectDataLabel);
            this.Controls.Add(this.ClearEnterDataButt);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ActionInfoLabel);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.EditButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.BuyerIDLabel);
            this.Controls.Add(this.DueDateTextBox);
            this.Controls.Add(this.OrderDateTextBox);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.BuyerIDTextBox);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.Label SearchInfoLabel;
        private System.Windows.Forms.TextBox InncorrectDataLabel;
        private System.Windows.Forms.Button ClearEnterDataButt;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label ActionInfoLabel;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label BuyerIDLabel;
        private System.Windows.Forms.TextBox DueDateTextBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.TextBox BuyerIDTextBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.CheckBox PaidCheckBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
    }
}