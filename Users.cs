using Npgsql;
using System;
using System.Windows.Forms;

namespace TelephoneComp
{
    public partial class Users : Form
    {
        int id = 0;
        string login = ""; // Переменная для обновления ключевого поля

        public Users()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabUsers; // Вывод данных
            if (MainMenu.currentUser.UsersR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.UsersR == "Полный доступ")
            {
                AddButt.Enabled = true;
                EditButt.Enabled = true;
                DeleteButt.Enabled = true;
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];  // Получение данных в текст боксы
                LoginTextBox.Text = row.Cells["login"].Value.ToString();
                SNameTextBox.Text = row.Cells["sName"].Value.ToString();
                NameTextBox.Text = row.Cells["name"].Value.ToString();
                MNameTextBox.Text = row.Cells["mName"].Value.ToString();
                PostComboBox.Text = row.Cells["post"].Value.ToString();
                PasswordTextBox.Text = row.Cells["password"].Value.ToString();
                BuyersCheckBox.Checked = (bool)row.Cells["rTelephones"].Value;
                OrdersCheckBox.Checked = (bool)row.Cells["rClients"].Value;
                OrdersItemsCheckBox.Checked = (bool)row.Cells["rPerson"].Value;
                ItemsCheckBox.Checked = (bool)row.Cells["rFirm"].Value;
                ItemTypesCheckBox.Checked = (bool)row.Cells["rRepairApps"].Value;
                MaterialsCheckBox.Checked = (bool)row.Cells["rCalls"].Value;
                CreatorsCheckBox.Checked = (bool)row.Cells["rExempts"].Value;
                UsersCheckBox.Checked = (bool)row.Cells["rUsers"].Value;
                BuyersComboBox.SelectedItem = row.Cells["aTelephones"].Value;
                OrdersComboBox.SelectedItem = row.Cells["aClients"].Value;
                OrdersItemsComboBox.SelectedItem = row.Cells["aPerson"].Value;
                ItemsComboBox.SelectedItem = row.Cells["aFirm"].Value;
                ItemTypesComboBox.SelectedItem = row.Cells["aRepairApps"].Value;
                MaterialsComboBox.SelectedItem = row.Cells["aCalls"].Value;
                CreatorsComboBox.SelectedItem = row.Cells["aExempts"].Value;
                UsersComboBox.SelectedItem = row.Cells["aUsers"].Value;
                login = LoginTextBox.Text;
                id = Convert.ToInt32(row.Cells["id"].Value);
            }
            catch (Exception)
            {

            }
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                id = Convert.ToInt32(DataGridView.Rows[DataGridView.Rows.Count - 1].Cells["id"].Value) + 1;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.users (\"id\", \"login\", \"sname\", \"name\", " +
                    $"\"mname\", \"post\", \"password\", \"rTelephones\", \"rClients\", \"rPerson\", \"rFirm\", \"rRepairApps\"," +
                    $"\"rCalls\", \"rExempts\", \"rCountries\", \"rTowns\", \"rUsers\", \"aTelephones\", \"aClients\", \"aPerson\", " +
                    $"\"aFirm\", \"aRepairApps\", \"aCalls\", \"aExempts\", \"aCountries\", \"aTowns\", \"aUsers\") " +
                    $"VALUES ('{id}', @p1, @p2, @p3, @p4, '{PostComboBox.SelectedItem}', " +
                    $"'{Authorization.Crypt(PasswordTextBox.Text, Authorization.secretKey)}', {BuyersCheckBox.Checked}, {OrdersCheckBox.Checked}, " +
                    $"{OrdersItemsCheckBox.Checked}, {ItemsCheckBox.Checked}, {ItemTypesCheckBox.Checked}, {MaterialsCheckBox.Checked}, {CreatorsCheckBox.Checked}, " +
                    $"{UsersCheckBox.Checked}, '{BuyersComboBox.SelectedItem}', " +
                    $"'{OrdersComboBox.SelectedItem}', '{OrdersItemsComboBox.SelectedItem}', '{ItemsComboBox.SelectedItem}', " +
                    $"'{ItemTypesComboBox.SelectedItem}', '{MaterialsComboBox.SelectedItem}', '{CreatorsComboBox.SelectedItem}', " +
                    $"''{UsersComboBox.SelectedItem}')", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", LoginTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p2", SNameTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p3", NameTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p4", MNameTextBox.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Пользователи в " +
                    $"{DateTime.Now}: \"id\", \"login\", \"sname\", \"name\", \"mname\", \"post\", \"password\", \"rTelephones\", " +
                    $"\"rClients\", \"rPerson\", \"rFirm\", \"rRepairApps\", \"rCalls\", \"rExempts\", \"rCountries\", \"rTowns\", " +
                    $"\"rUsers\", \"aTelephonesBox\", \"aClients\", \"aPerson\", \"aFirm\", \"aRepairApps\", \"aCalls\", " +
                    $"\"aExempts\", \"aCountries\", \"aTowns\", \"aUsers\" - '{id}', '{LoginTextBox.Text}', {SNameTextBox.Text}', " +
                    $"'{NameTextBox.Text}', '{MNameTextBox.Text}', '{PostComboBox.SelectedItem}', " +
                    $"'{Authorization.Crypt(PasswordTextBox.Text, Authorization.secretKey)}', {BuyersCheckBox.Checked}, {OrdersCheckBox.Checked}, " +
                    $"{OrdersItemsCheckBox.Checked}, {ItemsCheckBox.Checked}, {ItemTypesCheckBox.Checked}, {MaterialsCheckBox.Checked}, {CreatorsCheckBox.Checked}, " +
                    $"'{BuyersComboBox.SelectedItem}', '{OrdersComboBox.SelectedItem}', " +
                    $"'{OrdersItemsComboBox.SelectedItem}', '{ItemsComboBox.SelectedItem}', '{ItemTypesComboBox.SelectedItem}', " +
                    $"'{MaterialsComboBox.SelectedItem}', '{CreatorsComboBox.SelectedItem}'," +
                    $"''{UsersComboBox.SelectedItem}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.users"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.users SET \"id\" = '{id}', \"login\" = @p1, \"sname\" = @p2, " +
                    $"\"name\" = @p3, \"mname\" = @p4, \"post\" = '{PostComboBox.SelectedItem}', \"password\" = '{PasswordTextBox.Text}', " +
                    $"\"rTelephones\" = {BuyersCheckBox.Checked}, \"rClients\" = {OrdersCheckBox.Checked}, \"rPerson\" = {OrdersItemsCheckBox.Checked}, " +
                    $"\"rFirm\" = {ItemsCheckBox.Checked}, \"rRepairApps\" = {ItemTypesCheckBox.Checked}, \"rCalls\" = {MaterialsCheckBox.Checked}, " +
                    $"\"rExempts\" = {CreatorsCheckBox.Checked}," +
                    $"\"rUsers\" = {UsersCheckBox.Checked}, \"aTelephones\" = '{BuyersComboBox.SelectedItem}', " +
                    $"\"aClients\" = '{OrdersComboBox.SelectedItem}', \"aPerson\" = '{OrdersItemsComboBox.SelectedItem}', " +
                    $"\"aFirm\" = '{ItemsComboBox.SelectedItem}', \"aRepairApps\" = '{ItemTypesComboBox.SelectedItem}', " +
                    $"\"aCalls\" = '{MaterialsComboBox.SelectedItem}', \"aExempts\" = '{CreatorsComboBox.SelectedItem}', " +
                    $"\"aUsers\" = '{UsersComboBox.SelectedItem}' WHERE login = @p5", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", LoginTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p2", SNameTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p3", NameTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p4", MNameTextBox.Text);
                npgsqlC.Parameters.AddWithValue("p5", login);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Пользователи в " +
                    $"{DateTime.Now}: \"id\", \"login\", \"sname\", \"name\", \"mname\", \"post\", \"password\", \"rTelephones\", " +
                    $"\"rClients\", \"rPerson\", \"rFirm\", \"rRepairApps\", \"rCalls\", \"rExempts\", \"rCountries\", \"rTowns\", " +
                    $"\"rUsers\", \"aTelephones\", \"aClients\", \"aPerson\", \"aFirm\", \"aRepairApps\", \"aCalls\", " +
                    $"\"aExempts\", \"aCountries\", \"aTowns\", \"aUsers\" - '{id}', '{LoginTextBox.Text}', {SNameTextBox.Text}', " +
                    $"'{NameTextBox.Text}', '{MNameTextBox.Text}', '{PostComboBox.SelectedItem}', " +
                    $"'{Authorization.Crypt(PasswordTextBox.Text, Authorization.secretKey)}', {BuyersCheckBox.Checked}, {OrdersCheckBox.Checked}, " +
                    $"{OrdersItemsCheckBox.Checked}, {ItemsCheckBox.Checked}, {ItemTypesCheckBox.Checked}, {MaterialsCheckBox.Checked}, {CreatorsCheckBox.Checked}, " +
                    $"'{BuyersComboBox.SelectedItem}', '{OrdersComboBox.SelectedItem}', " +
                    $"'{OrdersItemsComboBox.SelectedItem}', '{ItemsComboBox.SelectedItem}', '{ItemTypesComboBox.SelectedItem}', " +
                    $"'{MaterialsComboBox.SelectedItem}', '{CreatorsComboBox.SelectedItem}'," +
                    $"'{UsersComboBox.SelectedItem}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.users"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.users WHERE login = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", LoginTextBox.Text);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Пользователи в " +
                    $"{DateTime.Now}: \"id\", \"login\", \"sname\", \"name\", \"mname\", \"post\", \"password\", \"rTelephones\", " +
                    $"\"rClients\", \"rPerson\", \"rFirm\", \"rRepairApps\", \"rCalls\", \"rExempts\", \"rCountries\", \"rTowns\", " +
                    $"\"rUsers\", \"aTelephonesBox\", \"aClients\", \"aPerson\", \"aFirm\", \"aRepairApps\", \"aCalls\", " +
                    $"\"aExempts\", \"aCountries\", \"aTowns\", \"aUsers\" - '{id}', '{LoginTextBox.Text}', {SNameTextBox.Text}', " +
                    $"'{NameTextBox.Text}', '{MNameTextBox.Text}', '{PostComboBox.SelectedItem}', " +
                    $"'{Authorization.Crypt(PasswordTextBox.Text, Authorization.secretKey)}', {BuyersCheckBox.Checked}, {OrdersCheckBox.Checked}, " +
                    $"{OrdersItemsCheckBox.Checked}, {ItemsCheckBox.Checked}, {ItemTypesCheckBox.Checked}, {MaterialsCheckBox.Checked}, {CreatorsCheckBox.Checked}, " +
                    $"'{BuyersComboBox.SelectedItem}', '{OrdersComboBox.SelectedItem}', " +
                    $"'{OrdersItemsComboBox.SelectedItem}', '{ItemsComboBox.SelectedItem}', '{ItemTypesComboBox.SelectedItem}', " +
                    $"'{MaterialsComboBox.SelectedItem}', '{CreatorsComboBox.SelectedItem}'," +
                    $"'{UsersComboBox.SelectedItem}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.users"); // Обновление данных в грид вью 
        }

        private void ClearEnterDataButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            MainMenu.ClearForm(this); // Очистка текстбоксов 
        }

        private void PostBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = PostComboBox.SelectedItem.ToString();
            if (selected == "Администратор") // Автоматические заполнений текстбоксов и чекбоксов при выборе роли
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is CheckBox)
                        (Controls[i] as CheckBox).Checked = true;
                }
                BuyersComboBox.SelectedItem = "Полный доступ";
                OrdersComboBox.SelectedItem = "Полный доступ";
                OrdersItemsComboBox.SelectedItem = "Полный доступ";
                ItemsComboBox.SelectedItem = "Полный доступ";
                ItemTypesComboBox.SelectedItem = "Полный доступ";
                MaterialsComboBox.SelectedItem = "Полный доступ";
                CreatorsComboBox.SelectedItem = "Полный доступ";
                UsersComboBox.SelectedItem = "Полный доступ";
            }
            if (selected == "Менеджер")
            {
                BuyersCheckBox.Checked = true;
                OrdersCheckBox.Checked = true;
                OrdersItemsCheckBox.Checked = true;
                ItemsCheckBox.Checked = true;
                ItemTypesCheckBox.Checked = true;
                MaterialsCheckBox.Checked = true;
                CreatorsCheckBox.Checked = true;
                UsersCheckBox.Checked = true;
                BuyersComboBox.SelectedItem = "Полный доступ";
                OrdersComboBox.SelectedItem = "Полный доступ";
                OrdersItemsComboBox.SelectedItem = "Полный доступ";
                ItemsComboBox.SelectedItem = "Полный доступ";
                ItemTypesComboBox.SelectedItem = "Полный доступ";
                MaterialsComboBox.SelectedItem = "Полный доступ";
                CreatorsComboBox.SelectedItem = "Только чтение";
                UsersComboBox.SelectedItem = "Полный доступ";
            }
            if (selected == "Бухгалтер")
            {
                BuyersCheckBox.Checked = true;
                OrdersCheckBox.Checked = true;
                OrdersItemsCheckBox.Checked = true;
                ItemsCheckBox.Checked = true;
                ItemTypesCheckBox.Checked = false;
                MaterialsCheckBox.Checked = true;
                CreatorsCheckBox.Checked = true;
                UsersCheckBox.Checked = false;
                BuyersComboBox.SelectedItem = "Только чтение";
                OrdersComboBox.SelectedItem = "Полный доступ";
                OrdersItemsComboBox.SelectedItem = "Полный доступ";
                ItemsComboBox.SelectedItem = "Полный доступ";
                ItemTypesComboBox.SelectedItem = "Нет доступа";
                MaterialsComboBox.SelectedItem = "Полный доступ";
                CreatorsComboBox.SelectedItem = "Только чтение";
                UsersComboBox.SelectedItem = "Нет доступа";
            }
            if (selected == "Ремонтник")
            {
                BuyersCheckBox.Checked = true;
                OrdersCheckBox.Checked = false;
                OrdersItemsCheckBox.Checked = false;
                ItemsCheckBox.Checked = false;
                ItemTypesCheckBox.Checked = true;
                MaterialsCheckBox.Checked = false;
                CreatorsCheckBox.Checked = true;
                UsersCheckBox.Checked = false;
                BuyersComboBox.SelectedItem = "Полный доступ";
                OrdersComboBox.SelectedItem = "Нет доступа";
                OrdersItemsComboBox.SelectedItem = "Нет доступа";
                ItemsComboBox.SelectedItem = "Нет доступа";
                ItemTypesComboBox.SelectedItem = "Полный доступ";
                MaterialsComboBox.SelectedItem = "Нет доступа";
                CreatorsComboBox.SelectedItem = "Только чтение";
                UsersComboBox.SelectedItem = "Нет доступа";
            }
        }

        private void SearchButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                DataGridView.DataSource = MainMenu.GetData($"select *from mainschema.users WHERE \"sname\" = @p1", // Поиск записи по фамилии
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.TabUsers; // Обновление данных в грид вью 
        }
    }
}
