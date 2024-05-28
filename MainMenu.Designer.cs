namespace TelephoneComp
{
    partial class MainMenu
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
            this.BuyersButton = new System.Windows.Forms.Button();
            this.ItemTypesButton = new System.Windows.Forms.Button();
            this.OrderItemButton = new System.Windows.Forms.Button();
            this.CreatorsButton = new System.Windows.Forms.Button();
            this.MaterialsButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ItemsButton = new System.Windows.Forms.Button();
            this.UsersButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuyersButton
            // 
            this.BuyersButton.Location = new System.Drawing.Point(12, 12);
            this.BuyersButton.Name = "BuyersButton";
            this.BuyersButton.Size = new System.Drawing.Size(314, 40);
            this.BuyersButton.TabIndex = 1;
            this.BuyersButton.Text = "Клиенты";
            this.BuyersButton.UseVisualStyleBackColor = true;
            this.BuyersButton.Click += new System.EventHandler(this.ClientsButt_Click);
            // 
            // ItemTypesButton
            // 
            this.ItemTypesButton.Location = new System.Drawing.Point(12, 196);
            this.ItemTypesButton.Name = "ItemTypesButton";
            this.ItemTypesButton.Size = new System.Drawing.Size(314, 40);
            this.ItemTypesButton.TabIndex = 3;
            this.ItemTypesButton.Text = "Типы товаров";
            this.ItemTypesButton.UseVisualStyleBackColor = true;
            this.ItemTypesButton.Click += new System.EventHandler(this.CallsButt_Click);
            // 
            // OrderItemButton
            // 
            this.OrderItemButton.Location = new System.Drawing.Point(12, 104);
            this.OrderItemButton.Name = "OrderItemButton";
            this.OrderItemButton.Size = new System.Drawing.Size(314, 40);
            this.OrderItemButton.TabIndex = 2;
            this.OrderItemButton.Text = "Список продукции на заказы";
            this.OrderItemButton.UseVisualStyleBackColor = true;
            this.OrderItemButton.Click += new System.EventHandler(this.RepairAppsButt_Click);
            // 
            // CreatorsButton
            // 
            this.CreatorsButton.Location = new System.Drawing.Point(12, 288);
            this.CreatorsButton.Name = "CreatorsButton";
            this.CreatorsButton.Size = new System.Drawing.Size(314, 40);
            this.CreatorsButton.TabIndex = 5;
            this.CreatorsButton.Text = "Поставщики";
            this.CreatorsButton.UseVisualStyleBackColor = true;
            this.CreatorsButton.Click += new System.EventHandler(this.CountriesButt_Click);
            // 
            // MaterialsButton
            // 
            this.MaterialsButton.Location = new System.Drawing.Point(12, 242);
            this.MaterialsButton.Name = "MaterialsButton";
            this.MaterialsButton.Size = new System.Drawing.Size(314, 40);
            this.MaterialsButton.TabIndex = 4;
            this.MaterialsButton.Text = "Материалы";
            this.MaterialsButton.UseVisualStyleBackColor = true;
            this.MaterialsButton.Click += new System.EventHandler(this.ExemptsButt_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(12, 58);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(314, 40);
            this.OrdersButton.TabIndex = 7;
            this.OrdersButton.Text = " Заказы";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.PersonButt_Click);
            // 
            // ItemsButton
            // 
            this.ItemsButton.Location = new System.Drawing.Point(12, 150);
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Size = new System.Drawing.Size(314, 40);
            this.ItemsButton.TabIndex = 8;
            this.ItemsButton.Text = "Продукция";
            this.ItemsButton.UseVisualStyleBackColor = true;
            this.ItemsButton.Click += new System.EventHandler(this.FirmButt_Click);
            // 
            // UsersButt
            // 
            this.UsersButt.Location = new System.Drawing.Point(12, 401);
            this.UsersButt.Name = "UsersButt";
            this.UsersButt.Size = new System.Drawing.Size(314, 40);
            this.UsersButt.TabIndex = 9;
            this.UsersButt.Text = "Пользователи";
            this.UsersButt.UseVisualStyleBackColor = true;
            this.UsersButt.Click += new System.EventHandler(this.UsersButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.Location = new System.Drawing.Point(473, 401);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(197, 40);
            this.ExitButt.TabIndex = 10;
            this.ExitButt.Text = "Выход";
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.UsersButt);
            this.Controls.Add(this.ItemsButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.CreatorsButton);
            this.Controls.Add(this.MaterialsButton);
            this.Controls.Add(this.ItemTypesButton);
            this.Controls.Add(this.OrderItemButton);
            this.Controls.Add(this.BuyersButton);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.TelephoneComp_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BuyersButton;
        private System.Windows.Forms.Button ItemTypesButton;
        private System.Windows.Forms.Button OrderItemButton;
        private System.Windows.Forms.Button CreatorsButton;
        private System.Windows.Forms.Button MaterialsButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ItemsButton;
        private System.Windows.Forms.Button UsersButt;
        private System.Windows.Forms.Button ExitButt;
    }
}