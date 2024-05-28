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

namespace ThreeD_Store
{
    public partial class RepairApps : Form
    {
        int id = 0;
        string phoneNumber = ""; // Переменная для обновления ключевого поля

        public RepairApps()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabRepairApps; // Вывод данных
            if (MainMenu.currentUser.ItemTypesR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.ItemTypesR == "Полный доступ")
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
                AppDateBox.Text = row.Cells["appdate"].Value.ToString();
                AcceptSNameBox.Text = row.Cells["acceptsname"].Value.ToString();
                PhoneNumberBox.Text = row.Cells["phonenumber"].Value.ToString();
                RepairDateBox.Text = row.Cells["repairdate"].Value.ToString();
                ValueBox.Text = row.Cells["value"].Value.ToString();
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
                id = Convert.ToInt32(DataGridView.Rows[DataGridView.Rows.Count - 1].Cells["id"].Value) + 1;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.repairapp (\"id\", \"appdate\", " +
                    $"\"acceptsname\", \"phonenumber\", \"repairdate\", \"value\") VALUES ('{id}', '{AppDateBox.Text}', " +
                    $"'{AcceptSNameBox.Text}', '{PhoneNumberBox.Text}', '{RepairDateBox.Text}', '{ValueBox.Text}')", 
                    MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Заявки на ремонт в " +
                    $"{DateTime.Now}: \"id\", \"appdate\", \"acceptsname\", \"phonenumber\", \"repairdate\", " +
                    $"\"value\" - '{id}', '{AppDateBox.Text}', '{AcceptSNameBox.Text}', '{PhoneNumberBox.Text}', " +
                    $"'{RepairDateBox.Text}', '{ValueBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.repairapp"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.repairapp SET \"id\" = '{id}', " +
                    $"\"appdate\" = '{AppDateBox.Text}', \"acceptsname\" = '{AcceptSNameBox.Text}', " +
                    $"\"phonenumber\" = '{PhoneNumberBox.Text}', \"repairdate\" = '{RepairDateBox.Text}', " +
                    $"\"value\" = '{ValueBox.Text}' WHERE phonenumber = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Заявки на ремонт в " +
                    $"{DateTime.Now}: \"id\", \"appdate\", \"acceptsname\", \"phonenumber\", \"repairdate\", " +
                    $"\"value\" - '{id}', '{AppDateBox.Text}', '{AcceptSNameBox.Text}', '{PhoneNumberBox.Text}', " +
                    $"'{RepairDateBox.Text}', '{ValueBox.Text}'");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.repairapp"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.repairapp WHERE phonenumber = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Заявки на ремонт в " +
                    $"{DateTime.Now}: \"id\", \"appdate\", \"acceptsname\", \"phonenumber\", \"repairdate\", " +
                    $"\"value\" - '{id}', '{AppDateBox.Text}', '{AcceptSNameBox.Text}', '{PhoneNumberBox.Text}', " +
                    $"'{RepairDateBox.Text}', '{ValueBox.Text}'");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.repairapp"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"SELECT * from mainschema.repairapp WHERE \"phonenumber\" = @p1", // Поиск записи по названию
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.repairapp"); // Обновление данных в грид вью 
        }
    }
}
