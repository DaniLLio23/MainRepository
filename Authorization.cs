using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ThreeD_Store
{
    public partial class Authorization : Form
    {
        MainMenu telephoneComp = new MainMenu();
        static internal int secretKey = 3; // Ключ для шифрования

        public Authorization()
        {
            InitializeComponent();
            MainMenu.npgsql.Open(); // Открытие подключения к БД
        }

        private void EntranceButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = MainMenu.GetData("SELECT *from users"); // Получение всех записей пользователей
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i]["login"].ToString() == LoginTextBox.Text)
                {
                    if (dataTable.Rows[i]["password"].ToString() == PasswordTextBox.Text)
                    {
                        Hide();
                        telephoneComp.CurrentUser = new User(
                            dataTable.Rows[i]["name"].ToString(),
                            dataTable.Rows[i]["post"].ToString(),
                            Convert.ToBoolean(dataTable.Rows[i]["buyers_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["orders_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["order_item_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["items_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["item_types_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["materials_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["creators_access"]),
                            Convert.ToBoolean(dataTable.Rows[i]["users_access"]),
                            dataTable.Rows[i]["buyers_right"].ToString(),
                            dataTable.Rows[i]["orders_right"].ToString(),
                            dataTable.Rows[i]["order_item_right"].ToString(),
                            dataTable.Rows[i]["items_right"].ToString(),
                            dataTable.Rows[i]["item_types_right"].ToString(),
                            dataTable.Rows[i]["materials_right"].ToString(),
                            dataTable.Rows[i]["creators_right"].ToString(),
                            dataTable.Rows[i]["users_right"].ToString(),
                            dataTable.Rows[i]["login"].ToString(),
                            dataTable.Rows[i]["surname"].ToString(),
                            dataTable.Rows[i]["middle_name"].ToString());
                        telephoneComp.ShowDialog(); // Проверка логина и пароля пользователя, создание объекта User, открытие формы работы с БД
                    }
                    else
                        InncorrectDataLabel.Visible = true;
                }
                else
                    InncorrectDataLabel.Visible = true;
            }
        }

        public static string Crypt(string str, int secretKey) // Шифрование пароля
        {
            var ch = str.ToArray();
            string newStr = "";
            foreach (var c in ch)
                newStr += TopSecret(c, secretKey);
            return newStr;
        }

        public static char TopSecret(char character, int secretKey) // Шифрование посимвольно
        {
            character = (char)(character ^ secretKey);
            return character;
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            InncorrectDataLabel.Visible = false;
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu.npgsql.Close();
            Close();
        }
    }
}
