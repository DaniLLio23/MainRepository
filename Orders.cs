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
    public partial class Orders : Form
    {
        int id = 0; // Переменная для обновления ключевого поля

        public Orders()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabPerson; // Вывод данных
            if (MainMenu.currentUser.OrderItemR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.OrderItemR == "Полный доступ")
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
                OrderIDTextBox.Text = row.Cells["id"].Value.ToString();
                BuyerIDTextBox.Text = row.Cells["sname"].Value.ToString();
                OrderDateTextBox.Text = row.Cells["name"].Value.ToString();
                DueDateTextBox.Text = row.Cells["mname"].Value.ToString();
                CountTextBox.Text = row.Cells["passport"].Value.ToString();
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
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.person (\"id\", \"sname\", " +
                    $"\"name\", \"mname\",\"passport\") VALUES ('{OrderIDTextBox.Text}', '{BuyerIDTextBox.Text}', '{OrderDateTextBox.Text}', " +
                    $"'{DueDateTextBox.Text}', '{CountTextBox.Text}')", MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Физ. лица в " +
                    $"{DateTime.Now}: \"id\", \"sname\" \"name\", \"mname\",\"passport\" - '{OrderIDTextBox.Text}', '{BuyerIDTextBox.Text}', " +
                    $"'{OrderDateTextBox.Text}', '{DueDateTextBox.Text}', '{CountTextBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.person"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.person SET \"id\" = '{OrderIDTextBox.Text}', " +
                    $"\"sname\" = '{BuyerIDTextBox.Text}', \"name\" = '{OrderDateTextBox.Text}', \"mname\" = '{DueDateTextBox.Text}', " +
                    $"\"passport\" = '{CountTextBox.Text}' WHERE id = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", id);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Физ. лица в " +
                    $"{DateTime.Now}: \"id\", \"sname\" \"name\", \"mname\",\"passport\" - '{OrderIDTextBox.Text}', '{BuyerIDTextBox.Text}', " +
                    $"'{OrderDateTextBox.Text}', '{DueDateTextBox.Text}', '{CountTextBox.Text}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.person"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.person WHERE id = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", id);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Физ. лица в " +
                    $"{DateTime.Now}: \"id\", \"sname\" \"name\", \"mname\",\"passport\" - '{OrderIDTextBox.Text}', '{BuyerIDTextBox.Text}', " +
                    $"'{OrderDateTextBox.Text}', '{DueDateTextBox.Text}', '{CountTextBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.person"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"select *from mainschema.person WHERE \"sname\" = @p1", // Поиск записи по фамилии
                    new NpgsqlParameter("p1", SearchTextBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.person"); // Обновление данных в грид вью 
        }
    }
}
