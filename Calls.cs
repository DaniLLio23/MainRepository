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
    public partial class Calls : Form
    {
        int id = 0;
        string phoneNumber = ""; // Переменная для обновления ключевого поля

        public Calls()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabCalls; // Вывод данных
            if (MainMenu.currentUser.MaterialsR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.MaterialsR == "Полный доступ")
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
                DateBox.Text = row.Cells["date"].Value.ToString();
                CountryBox.Text = row.Cells["country"].Value.ToString();
                TownBox.Text = row.Cells["town"].Value.ToString();
                CallNumberBox.Text = row.Cells["callnumber"].Value.ToString();
                MinutesBox.Text = row.Cells["minutes"].Value.ToString();
                ValueBox.Text = row.Cells["value"].Value.ToString();
                CommentBox.Text = row.Cells["comment"].Value.ToString();
                PhoneNumberBox.Text = row.Cells["phonenumber"].Value.ToString();
                TypeBox.Checked = (bool)row.Cells["type"].Value;
                phoneNumber = row.Cells["phonenumber"].Value.ToString();
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
                if (CountryBox.Text == "" || CountryBox.Text == null) { CountryBox.Text = " "; }
                if (TownBox.Text == "" || TownBox.Text == null) { TownBox.Text = " "; }
                if (CommentBox.Text == "" || CommentBox.Text == null) { CommentBox.Text = " "; }
                id = Convert.ToInt32(DataGridView.Rows[DataGridView.Rows.Count - 1].Cells["id"].Value) + 1;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.calls (\"id\", \"date\", \"country\", " +
                    $"\"town\", \"callnumber\", \"minutes\", \"value\", \"comment\", \"phonenumber\", \"type\") " +
                    $"VALUES ('{id}', '{DateBox.Text}', '{CountryBox.Text}', '{TownBox.Text}', '{CallNumberBox.Text}', " +
                    $"'{MinutesBox.Text}', '{ValueBox.Text}', '{CommentBox.Text}', '{PhoneNumberBox.Text}', " +
                    $"{TypeBox.Checked})", MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Список звонков в " +
                    $"{DateTime.Now}: \"id\", \"date\", \"country\", \"town\", \"callnumber\", \"minutes\", " +
                    $"\"value\", \"comment\", \"phonenumber\", \"type\" - '{id}', '{DateBox.Text}', '{CountryBox.Text}', " +
                    $"'{TownBox.Text}', '{CallNumberBox.Text}', '{MinutesBox.Text}', '{ValueBox.Text}', " +
                    $"'{CommentBox.Text}', '{PhoneNumberBox.Text}', {TypeBox.Checked}");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.calls"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                if (CountryBox.Text == "" || CountryBox.Text == null) { CountryBox.Text = " "; }
                if (TownBox.Text == "" || TownBox.Text == null) { TownBox.Text = " "; }
                if (CommentBox.Text == "" || CommentBox.Text == null) { CommentBox.Text = " "; }
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.calls SET \"id\" = '{id}', " +
                    $"\"date\" = '{DateBox.Text}', \"country\" = '{CountryBox.Text}', \"town\" = '{TownBox.Text}', " +
                    $"\"callnumber\" = '{CallNumberBox.Text}', \"minutes\" = '{MinutesBox.Text}', " +
                    $"\"value\" = '{ValueBox.Text}', \"comment\" = '{CommentBox.Text}', " +
                    $"\"phonenumber\" = '{PhoneNumberBox.Text}', \"type\" = {TypeBox.Checked} " +
                    $"WHERE id = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", id);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Список звонков в " +
                    $"{DateTime.Now}: \"id\", \"date\", \"country\", \"town\", \"callnumber\", \"minutes\", " +
                    $"\"value\", \"comment\", \"phonenumber\", \"type\" - '{id}', '{DateBox.Text}', '{CountryBox.Text}', " +
                    $"'{TownBox.Text}', '{CallNumberBox.Text}', '{MinutesBox.Text}', '{ValueBox.Text}', " +
                    $"'{CommentBox.Text}', '{PhoneNumberBox.Text}', {TypeBox.Checked}");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.calls"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.calls WHERE phonenumber = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Список звонков в " +
                    $"{DateTime.Now}: \"id\", \"date\", \"country\", \"town\", \"callnumber\", \"minutes\", " +
                    $"\"value\", \"comment\", \"phonenumber\", \"type\" - '{id}', '{DateBox.Text}', '{CountryBox.Text}', " +
                    $"'{TownBox.Text}', '{CallNumberBox.Text}', '{MinutesBox.Text}', '{ValueBox.Text}', " +
                    $"'{CommentBox.Text}', '{PhoneNumberBox.Text}', {TypeBox.Checked}");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.calls"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"SELECT *from mainschema.calls WHERE \"phonenumber\" = @p1", // Поиск записи по названию
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.calls"); // Обновление данных в грид вью 
        }
    }
}
