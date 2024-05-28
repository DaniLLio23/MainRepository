using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneComp
{
    public partial class Firm : Form
    {
        int id = 0; // Переменная для обновления ключевого поля

        public Firm()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabFirm; // Вывод данных
            if (MainMenu.currentUser.ItemsR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.ItemsR == "Полный доступ")
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
                IDBox.Text = row.Cells["id"].Value.ToString();
                NameBox.Text = row.Cells["name"].Value.ToString();
                INNBox.Text = row.Cells["inn"].Value.ToString();
                DirectorBox.Text = row.Cells["director"].Value.ToString();
                ContactPhoneBox.Text = row.Cells["contactphone"].Value.ToString();
                BankBox.Text = row.Cells["bank"].Value.ToString();
                AccountBox.Text = row.Cells["account"].Value.ToString();
                LegalAddressBox.Text = row.Cells["legaladdress"].Value.ToString();
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
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.firm (\"id\", \"name\", \"inn\", " +
                    $"\"director\", \"contactphone\", \"bank\", \"account\",\"legaladdress\") VALUES ('{IDBox.Text}', " +
                    $"'{NameBox.Text}', '{INNBox.Text}', '{DirectorBox.Text}', '{ContactPhoneBox.Text}', '{BankBox.Text}', " +
                    $"'{AccountBox.Text}', '{LegalAddressBox.Text}')", MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Юр. лица в " +
                    $"{DateTime.Now}: \"id\", \"name\", \"inn\", \"director\",\"contactphone\", \"bank\", \"account\", " +
                    $"\"legaladdress\" - '{IDBox.Text}', '{NameBox.Text}', '{INNBox.Text}', '{DirectorBox.Text}', " +
                    $"'{ContactPhoneBox.Text}', '{BankBox.Text}', '{AccountBox.Text}', '{LegalAddressBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.firm"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.firm SET \"id\" = '{IDBox.Text}', " +
                    $"\"name\" = '{NameBox.Text}', \"inn\" = '{INNBox.Text}', \"director\" = '{DirectorBox.Text}', " +
                    $"\"contactphone\" = '{ContactPhoneBox.Text}', \"bank\" = '{BankBox.Text}', " +
                    $"\"account\" = '{AccountBox.Text}', \"legaladdress\" = '{LegalAddressBox.Text}' " +
                    $"WHERE id = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", id);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Юр. лица в " +
                    $"{DateTime.Now}: \"id\", \"name\", \"inn\", \"director\",\"contactphone\", \"bank\", \"account\", " +
                    $"\"legaladdress\" - '{IDBox.Text}', '{NameBox.Text}', '{INNBox.Text}', '{DirectorBox.Text}', " +
                    $"'{ContactPhoneBox.Text}', '{BankBox.Text}', '{AccountBox.Text}', '{LegalAddressBox.Text}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.firm"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.firm WHERE id = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", id);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Юр. лица в " +
                    $"{DateTime.Now}: \"id\", \"name\", \"inn\", \"director\",\"contactphone\", \"bank\", \"account\", " +
                    $"\"legaladdress\" - '{IDBox.Text}', '{NameBox.Text}', '{INNBox.Text}', '{DirectorBox.Text}', " +
                    $"'{ContactPhoneBox.Text}', '{BankBox.Text}', '{AccountBox.Text}', '{LegalAddressBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.firm"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"SELECT *from mainschema.firm WHERE \"name\" = @p1", // Поиск записи по названию
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.firm"); // Обновление данных в грид вью 
        }
    }
}
