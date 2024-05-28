namespace ThreeD_Store
{
    partial class Firm
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
            this.ContactPhoneLabel = new System.Windows.Forms.Label();
            this.ContactPhoneBox = new System.Windows.Forms.TextBox();
            this.ClearButt = new System.Windows.Forms.Button();
            this.SearchButt = new System.Windows.Forms.Button();
            this.SearchInfoLabel = new System.Windows.Forms.Label();
            this.InncorrectDataLabel = new System.Windows.Forms.TextBox();
            this.ClearEnterDataButt = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ActionInfoLabel = new System.Windows.Forms.Label();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.AddButt = new System.Windows.Forms.Button();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.INNLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DirectorBox = new System.Windows.Forms.TextBox();
            this.INNBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BankLabel = new System.Windows.Forms.Label();
            this.BankBox = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.LegalAddressLabel = new System.Windows.Forms.Label();
            this.LegalAddressBox = new System.Windows.Forms.TextBox();
            this.AccountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactPhoneLabel
            // 
            this.ContactPhoneLabel.AutoSize = true;
            this.ContactPhoneLabel.Location = new System.Drawing.Point(70, 517);
            this.ContactPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPhoneLabel.Name = "ContactPhoneLabel";
            this.ContactPhoneLabel.Size = new System.Drawing.Size(95, 26);
            this.ContactPhoneLabel.TabIndex = 311;
            this.ContactPhoneLabel.Text = "Телефон";
            // 
            // ContactPhoneBox
            // 
            this.ContactPhoneBox.Location = new System.Drawing.Point(173, 514);
            this.ContactPhoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactPhoneBox.Name = "ContactPhoneBox";
            this.ContactPhoneBox.Size = new System.Drawing.Size(239, 34);
            this.ContactPhoneBox.TabIndex = 310;
            // 
            // ClearButt
            // 
            this.ClearButt.Location = new System.Drawing.Point(1098, 383);
            this.ClearButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(120, 50);
            this.ClearButt.TabIndex = 309;
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
            this.SearchButt.TabIndex = 308;
            this.SearchButt.Text = "Найти";
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // SearchInfoLabel
            // 
            this.SearchInfoLabel.AutoSize = true;
            this.SearchInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInfoLabel.Location = new System.Drawing.Point(893, 305);
            this.SearchInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchInfoLabel.Name = "SearchInfoLabel";
            this.SearchInfoLabel.Size = new System.Drawing.Size(218, 25);
            this.SearchInfoLabel.TabIndex = 307;
            this.SearchInfoLabel.Text = "Поиск по названию";
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
            this.InncorrectDataLabel.TabIndex = 306;
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
            this.ClearEnterDataButt.TabIndex = 305;
            this.ClearEnterDataButt.Text = "Сбросить поля ввода";
            this.ClearEnterDataButt.UseVisualStyleBackColor = true;
            this.ClearEnterDataButt.Click += new System.EventHandler(this.ClearEnterDataButt_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(898, 341);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(320, 34);
            this.SearchBox.TabIndex = 304;
            // 
            // ActionInfoLabel
            // 
            this.ActionInfoLabel.AutoSize = true;
            this.ActionInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionInfoLabel.Location = new System.Drawing.Point(13, 305);
            this.ActionInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionInfoLabel.Name = "ActionInfoLabel";
            this.ActionInfoLabel.Size = new System.Drawing.Size(233, 25);
            this.ActionInfoLabel.TabIndex = 303;
            this.ActionInfoLabel.Text = "Действия с записями";
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(269, 604);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(120, 50);
            this.DeleteButt.TabIndex = 302;
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
            this.EditButt.TabIndex = 301;
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
            this.AddButt.TabIndex = 300;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(13, 475);
            this.DirectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(152, 26);
            this.DirectorLabel.TabIndex = 299;
            this.DirectorLabel.Text = "Управляющий";
            // 
            // INNLabel
            // 
            this.INNLabel.AutoSize = true;
            this.INNLabel.Location = new System.Drawing.Point(108, 433);
            this.INNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INNLabel.Name = "INNLabel";
            this.INNLabel.Size = new System.Drawing.Size(57, 26);
            this.INNLabel.TabIndex = 298;
            this.INNLabel.Text = "ИНН";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(129, 349);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(36, 26);
            this.IDLabel.TabIndex = 297;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 391);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(101, 26);
            this.NameLabel.TabIndex = 296;
            this.NameLabel.Text = "Название";
            // 
            // DirectorBox
            // 
            this.DirectorBox.Location = new System.Drawing.Point(173, 472);
            this.DirectorBox.Margin = new System.Windows.Forms.Padding(4);
            this.DirectorBox.Name = "DirectorBox";
            this.DirectorBox.Size = new System.Drawing.Size(239, 34);
            this.DirectorBox.TabIndex = 295;
            // 
            // INNBox
            // 
            this.INNBox.Location = new System.Drawing.Point(173, 430);
            this.INNBox.Margin = new System.Windows.Forms.Padding(4);
            this.INNBox.Name = "INNBox";
            this.INNBox.Size = new System.Drawing.Size(239, 34);
            this.INNBox.TabIndex = 294;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(173, 346);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(51, 34);
            this.IDBox.TabIndex = 293;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(173, 388);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(239, 34);
            this.NameBox.TabIndex = 292;
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
            this.DataGridView.TabIndex = 291;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(512, 391);
            this.BankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(58, 26);
            this.BankLabel.TabIndex = 313;
            this.BankLabel.Text = "Банк";
            // 
            // BankBox
            // 
            this.BankBox.Location = new System.Drawing.Point(578, 388);
            this.BankBox.Margin = new System.Windows.Forms.Padding(4);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(288, 34);
            this.BankBox.TabIndex = 312;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Location = new System.Drawing.Point(436, 433);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(134, 26);
            this.AccountLabel.TabIndex = 314;
            this.AccountLabel.Text = "Номер счета";
            // 
            // LegalAddressLabel
            // 
            this.LegalAddressLabel.AutoSize = true;
            this.LegalAddressLabel.Location = new System.Drawing.Point(455, 475);
            this.LegalAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LegalAddressLabel.Name = "LegalAddressLabel";
            this.LegalAddressLabel.Size = new System.Drawing.Size(115, 26);
            this.LegalAddressLabel.TabIndex = 315;
            this.LegalAddressLabel.Text = "Юр. адрес";
            // 
            // LegalAddressBox
            // 
            this.LegalAddressBox.Location = new System.Drawing.Point(578, 472);
            this.LegalAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.LegalAddressBox.Name = "LegalAddressBox";
            this.LegalAddressBox.Size = new System.Drawing.Size(288, 34);
            this.LegalAddressBox.TabIndex = 317;
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(578, 430);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(4);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(288, 34);
            this.AccountBox.TabIndex = 316;
            // 
            // Firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 725);
            this.Controls.Add(this.LegalAddressBox);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.LegalAddressLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.ContactPhoneLabel);
            this.Controls.Add(this.ContactPhoneBox);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.SearchInfoLabel);
            this.Controls.Add(this.InncorrectDataLabel);
            this.Controls.Add(this.ClearEnterDataButt);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ActionInfoLabel);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.EditButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.INNLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DirectorBox);
            this.Controls.Add(this.INNBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Firm";
            this.Text = "Firm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactPhoneLabel;
        private System.Windows.Forms.TextBox ContactPhoneBox;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.Label SearchInfoLabel;
        private System.Windows.Forms.TextBox InncorrectDataLabel;
        private System.Windows.Forms.Button ClearEnterDataButt;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label ActionInfoLabel;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label INNLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DirectorBox;
        private System.Windows.Forms.TextBox INNBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.TextBox BankBox;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label LegalAddressLabel;
        private System.Windows.Forms.TextBox LegalAddressBox;
        private System.Windows.Forms.TextBox AccountBox;
    }
}