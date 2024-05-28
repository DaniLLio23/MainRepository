using Npgsql;
using System;
using System.Windows.Forms;

namespace ThreeD_Store
{
    public partial class Telephones : Form
    {
        int id = 0;
        string phoneNumber = ""; // Переменная для обновления ключевого поля

        public Telephones()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabTelephones; // Вывод данных
            if (MainMenu.currentUser.BuyersR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.BuyersR == "Полный доступ")
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
                PhoneNumberBox.Text = row.Cells["phonenumber"].Value.ToString();
                AddressBox.Text = row.Cells["address"].Value.ToString();
                ValueBox.Text = row.Cells["value"].Value.ToString();
                ExemptBox.Text = row.Cells["exempt"].Value.ToString();
                phoneNumber = PhoneNumberBox.Text;
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
                if (ExemptBox.Text == "" || ExemptBox.Text == null) { ExemptBox.Text = " "; }
                id = Convert.ToInt32(DataGridView.Rows[DataGridView.Rows.Count - 1].Cells["id"].Value) + 1;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.telephone (\"id\", \"phonenumber\", " +
                    $"\"address\", \"value\",\"exempt\") VALUES ('{id}', @p1, @p2, " +
                    $"'{ValueBox.Text}', '{ExemptBox.Text}')", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", PhoneNumberBox.Text);
                npgsqlC.Parameters.AddWithValue("p2", AddressBox.Text);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Телефоны в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"address\", \"value\", \"exempt\" - '{id}', " +
                    $"'{PhoneNumberBox.Text}', '{AddressBox.Text}', '{ValueBox.Text}', '{ExemptBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.telephone"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                if (ExemptBox.Text == "" || ExemptBox.Text == null) { ExemptBox.Text = " "; }
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.telephone SET \"id\" = '{id}', " +
                    $"\"phonenumber\" = @p1, \"address\" = @p2, " +
                    $"\"value\" = '{ValueBox.Text}', \"exempt\" = '{ExemptBox.Text}' " +
                    $"WHERE phonenumber = @p3", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", PhoneNumberBox.Text);
                npgsqlC.Parameters.AddWithValue("p2", AddressBox.Text);
                npgsqlC.Parameters.AddWithValue("p3", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Телефоны в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"address\", \"value\", \"exempt\" - '{id}', " +
                    $"'{PhoneNumberBox.Text}', '{AddressBox.Text}', '{ValueBox.Text}', '{ExemptBox.Text}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.telephone"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.telephone WHERE phonenumber = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Телефоны в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"address\", \"value\", \"exempt\" - '{id}', " +
                    $"'{PhoneNumberBox.Text}', '{AddressBox.Text}', '{ValueBox.Text}', '{ExemptBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.telephone"); // Обновление данных в грид вью 
        }

        private void ClearEnterDataButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            MainMenu.ClearForm(this); // Очистка текстбоксов 
        }

        private void SearchButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                DataGridView.DataSource = MainMenu.GetData($"select *from mainschema.telephone WHERE \"phonenumber\" = @p1", // Поиск записи по фамилии
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.telephone"); // Обновление данных в грид вью 
        }
    }
}
