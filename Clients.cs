using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TelephoneComp
{
    public partial class Clients : Form
    {
        int id = 0;
        string phoneNumber = ""; // Переменная для обновления ключевого поля
        DataTable reportData; // Объект с данными для отчёта

        public Clients()
        {
            InitializeComponent();
            DataGridView.DataSource = MainMenu.TabClients; // Вывод данных
            if (MainMenu.currentUser.OrdersR == "Только чтение") // Установка в соответствии с правами пользователя
            {
                AddButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
            if (MainMenu.currentUser.OrdersR == "Полный доступ")
            {
                AddButt.Enabled = true;
                EditButt.Enabled = true;
                DeleteButt.Enabled = true;
            }
            reportData = MainMenu.GetData("SELECT mainschema.client.*, mainschema.telephone.\"address\", mainschema.telephone.\"value\", " +
                "mainschema.telephone.\"exempt\" FROM mainschema.client, mainschema.telephone WHERE mainschema.client.\"phonenumber\" = mainschema.telephone.\"phonenumber\"");
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];  // Получение данных в текст боксы
                PhoneNumberBox.Text = row.Cells["phonenumber"].Value.ToString();
                TypeBox.Checked = (bool)row.Cells["type"].Value;
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
                id = Convert.ToInt32(DataGridView.Rows[DataGridView.Rows.Count - 1].Cells["id"].Value) + 1;
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"INSERT INTO mainschema.client (\"id\", \"phonenumber\", " +
                    $"\"type\") VALUES ('{id}', '{PhoneNumberBox.Text}', {TypeBox.Checked})", MainMenu.npgsql);
                npgsqlC.ExecuteNonQuery(); // Добавление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} добавил запись в таблицу Клиенты в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"type\" - '{id}', '{PhoneNumberBox.Text}', " +
                    $"{TypeBox.Checked}");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
                id--;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.client"); // Обновление данных в грид вью
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"UPDATE mainschema.client SET \"id\" = '{id}', " +
                    $"\"phonenumber\" = '{PhoneNumberBox.Text}', \"type\" = {TypeBox.Checked} WHERE phonenumber = @p1", 
                    MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Изменение записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} изменил запись в таблице Клиенты в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"type\" - '{id}', '{PhoneNumberBox.Text}', {TypeBox.Checked}");
            }
            catch
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.client"); // Обновление данных в грид вью 
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
            try
            {
                NpgsqlCommand npgsqlC = new NpgsqlCommand($"DELETE FROM mainschema.client WHERE phonenumber = @p1", MainMenu.npgsql);
                npgsqlC.Parameters.AddWithValue("p1", phoneNumber);
                npgsqlC.ExecuteNonQuery(); // Удаление записи
                MainMenu.LogTXT.WriteLine($"Пользователь {MainMenu.currentUser.SName} " + // Логирование
                    $"{MainMenu.currentUser.Name} {MainMenu.currentUser.MName} удалил запись в таблице Клиенты в " +
                    $"{DateTime.Now}: \"id\", \"phonenumber\", \"type\" - '{id}', '{PhoneNumberBox.Text}', {TypeBox.Checked}");
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.client"); // Обновление данных в грид вью 
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
                DataGridView.DataSource = MainMenu.GetData($"select * from mainschema.client WHERE \"phonenumber\" = @p1", // Поиск записи по фамилии
                    new NpgsqlParameter("p1", SearchBox.Text));
            }
            catch (Exception)
            {
                InncorrectDataLabel.Visible = true;
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = MainMenu.GetData("SELECT * from mainschema.client"); // Обновление данных в грид вью 
        }

        private void ExcelReport_Click(object sender, EventArgs e)
        {
            XLWorkbook excelWB = new XLWorkbook();
            var sw = excelWB.Worksheets.Add(reportData, "Clients");
            sw.Columns().AdjustToContents();
            excelWB.SaveAs("reportClients.xlsx"); // Отчёт в формате xlsx
        }

        private void WordReport_Click(object sender, EventArgs e)
        {
            using (WordprocessingDocument wd = WordprocessingDocument.Create($"reportClients.docx", WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wd.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                paragraph = body.AppendChild(new Paragraph());
                run = paragraph.AppendChild(new Run());
                foreach (DataRow dr in reportData.Rows)
                {
                    foreach (DataColumn col in reportData.Columns)
                    {
                        run.AppendChild(new Text($"{col.ColumnName}--"));
                        run.AppendChild(new Text($"{dr[col]}"));
                        paragraph = body.AppendChild(new Paragraph());
                        run = paragraph.AppendChild(new Run());
                    }
                    paragraph = body.AppendChild(new Paragraph());
                    run = paragraph.AppendChild(new Run());
                }
                mainPart.Document.Save();
            }

        }
    }
}