namespace TelephoneComp
{
    partial class Telephones
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ExemptBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ExemptLabel = new System.Windows.Forms.Label();
            this.AddButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.ActionInfoLabel = new System.Windows.Forms.Label();
            this.ClearEnterDataButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButt
            // 
            this.ClearButt.Location = new System.Drawing.Point(1098, 383);
            this.ClearButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(120, 50);
            this.ClearButt.TabIndex = 269;
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
            this.SearchButt.TabIndex = 268;
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
            this.SearchInfoLabel.Size = new System.Drawing.Size(298, 25);
            this.SearchInfoLabel.TabIndex = 267;
            this.SearchInfoLabel.Text = "Поиск по номеру телефона";
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
            this.InncorrectDataLabel.TabIndex = 266;
            this.InncorrectDataLabel.Text = "Некорректно введены данные";
            this.InncorrectDataLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InncorrectDataLabel.Visible = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(898, 341);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(320, 34);
            this.SearchBox.TabIndex = 243;
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
            this.DataGridView.TabIndex = 225;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(193, 388);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(600, 34);
            this.AddressBox.TabIndex = 226;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(193, 346);
            this.PhoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(600, 34);
            this.PhoneNumberBox.TabIndex = 227;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(193, 430);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(600, 34);
            this.ValueBox.TabIndex = 228;
            // 
            // ExemptBox
            // 
            this.ExemptBox.Location = new System.Drawing.Point(193, 472);
            this.ExemptBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExemptBox.Name = "ExemptBox";
            this.ExemptBox.Size = new System.Drawing.Size(600, 34);
            this.ExemptBox.TabIndex = 229;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(112, 391);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 26);
            this.AddressLabel.TabIndex = 232;
            this.AddressLabel.Text = "Адрес";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 349);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(172, 26);
            this.PhoneNumberLabel.TabIndex = 233;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(108, 433);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(77, 26);
            this.ValueLabel.TabIndex = 235;
            this.ValueLabel.Text = "Сумма";
            // 
            // ExemptLabel
            // 
            this.ExemptLabel.AutoSize = true;
            this.ExemptLabel.Location = new System.Drawing.Point(107, 475);
            this.ExemptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExemptLabel.Name = "ExemptLabel";
            this.ExemptLabel.Size = new System.Drawing.Size(78, 26);
            this.ExemptLabel.TabIndex = 236;
            this.ExemptLabel.Text = "Льгота";
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(13, 604);
            this.AddButt.Margin = new System.Windows.Forms.Padding(4);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(120, 50);
            this.AddButt.TabIndex = 237;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // EditButt
            // 
            this.EditButt.Location = new System.Drawing.Point(141, 604);
            this.EditButt.Margin = new System.Windows.Forms.Padding(4);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(120, 50);
            this.EditButt.TabIndex = 239;
            this.EditButt.Text = "Изменить";
            this.EditButt.UseVisualStyleBackColor = true;
            this.EditButt.Click += new System.EventHandler(this.EditButt_Click);
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(269, 604);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(120, 50);
            this.DeleteButt.TabIndex = 240;
            this.DeleteButt.Text = "Удалить";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // ActionInfoLabel
            // 
            this.ActionInfoLabel.AutoSize = true;
            this.ActionInfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionInfoLabel.Location = new System.Drawing.Point(13, 305);
            this.ActionInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionInfoLabel.Name = "ActionInfoLabel";
            this.ActionInfoLabel.Size = new System.Drawing.Size(233, 25);
            this.ActionInfoLabel.TabIndex = 241;
            this.ActionInfoLabel.Text = "Действия с записями";
            // 
            // ClearEnterDataButt
            // 
            this.ClearEnterDataButt.Location = new System.Drawing.Point(13, 662);
            this.ClearEnterDataButt.Margin = new System.Windows.Forms.Padding(4);
            this.ClearEnterDataButt.Name = "ClearEnterDataButt";
            this.ClearEnterDataButt.Size = new System.Drawing.Size(376, 50);
            this.ClearEnterDataButt.TabIndex = 244;
            this.ClearEnterDataButt.Text = "Сбросить поля ввода";
            this.ClearEnterDataButt.UseVisualStyleBackColor = true;
            this.ClearEnterDataButt.Click += new System.EventHandler(this.ClearEnterDataButt_Click);
            // 
            // Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 725);
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
            this.Controls.Add(this.ExemptLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ExemptBox);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Telephones";
            this.Text = "Telephones";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.Label SearchInfoLabel;
        private System.Windows.Forms.TextBox InncorrectDataLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.TextBox ExemptBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label ExemptLabel;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Label ActionInfoLabel;
        private System.Windows.Forms.Button ClearEnterDataButt;
    }
}