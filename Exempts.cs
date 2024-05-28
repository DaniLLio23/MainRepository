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
    public partial class Exempts : Form
    {
        int id = 0;
        string exempt = ""; // Переменная для обновления ключевого поля

        public Exempts()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabExempts; // Вывод данных
            if (MainMenu.currentUser.CreatorsR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.CreatorsR == "Полный доступ")
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
                ExemptBox.Text = row.Cells["exempt"].Value.ToString();
                ValueBox.Text = row.Cells["value"].Value.ToString();
                exempt = row.Cells["exempt"].Value.ToString();
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
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.exempt (\"id\", \"exempt\", " +
                    $"\"value\") VALUES ('{id}', '{ExemptBox.Text}', '{ValueBox.Text}')", MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Справочник льгот в " +
                    $"{DateTime.Now}: \"id\", \"exempt\", \"value\" - '{id}', '{ExemptBox.Text}', '{ValueBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.exempt"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                if (ExemptBox.Text == "" || ExemptBox.Text == null) { ExemptBox.Text = " "; }
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.exempt SET \"id\" = '{id}', " +
                    $"\"exempt\" = '{ExemptBox.Text}', \"value\" = '{ValueBox.Text}' WHERE exempt = @p1", 
                    MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", exempt);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Справочник льгот в " +
                    $"{DateTime.Now}: \"id\", \"exempt\", \"value\" - '{id}', '{ExemptBox.Text}', '{ValueBox.Text}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.exempt"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.exempt WHERE exempt = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", exempt);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Справочник льгот в " +
                    $"{DateTime.Now}: \"id\", \"exempt\", \"value\" - '{id}', '{ExemptBox.Text}', '{ValueBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.exempt"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"select *from mainschema.exempt WHERE \"exempt\" = @p1", // Поиск записи по фамилии
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.exempt"); ; // Обновление данных в грид вью 
        }
    }
}
