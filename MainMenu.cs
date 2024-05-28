using Npgsql;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TelephoneComp
{
    public partial class MainMenu : Form
    {
        static internal User currentUser; // Текущий пользователь
        static DataTable tabTelephones, tabClients, tabPerson, tabFirm, tabRepairApps,  // Таблицы БД
            tabCalls, tabExempts, tabCountries, tabTowns, tabUsers;
        static internal StreamWriter LogTXT = new StreamWriter("log.txt", true); // Файл для логирования
        static internal NpgsqlConnection npgsql = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=threed_store"); // Соединение с БД
        static NpgsqlCommand npgsqlCommand = new NpgsqlCommand(); // Команда для SQL

        internal User CurrentUser { get => currentUser; set => currentUser = value; }
        internal static DataTable TabTelephones { get => tabTelephones; set => tabTelephones = value; }
        internal static DataTable TabClients { get => tabClients; set => tabClients = value; }
        internal static DataTable TabPerson { get => tabPerson; set => tabPerson = value; }
        internal static DataTable TabFirm { get => tabFirm; set => tabFirm = value; }
        internal static DataTable TabRepairApps { get => tabRepairApps; set => tabRepairApps = value; }
        internal static DataTable TabCalls { get => tabCalls; set => tabCalls = value; }
        internal static DataTable TabExempts { get => tabExempts; set => tabExempts = value; }
        internal static DataTable TabCountries { get => tabCountries; set => tabCountries = value; }
        internal static DataTable TabTowns { get => tabTowns; set => tabTowns = value; }
        internal static DataTable TabUsers { get => tabUsers; set => tabUsers = value; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void TelephoneComp_Load(object sender, EventArgs e)
        {
            if (!CurrentUser.BuyersA) // Установка доступа к таблицам
                BuyersButton.Enabled = false;
            if (!CurrentUser.OrdersA)
                BuyersButton.Enabled = false;
            if (!CurrentUser.OrderItemA)
                OrdersButton.Enabled = false;
            if (!CurrentUser.ItemsA)
                ItemsButton.Enabled = false;
            if (!CurrentUser.ItemTypesA)
                OrderItemButton.Enabled = false;
            if (!CurrentUser.MaterialsA)
                ItemTypesButton.Enabled = false;
            if (!CurrentUser.CreatorsA)
                MaterialsButton.Enabled = false;
            if (!CurrentUser.UsersA)
                CreatorsButton.Enabled = false;
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name} {currentUser.MName}" + // Логирование
                $"зашёл в БД в {DateTime.Now}");
        }

        private void TelephonesButt_Click(object sender, EventArgs e)
        {
            tabTelephones = GetData("SELECT * from mainschema.telephone");
            Telephones telephonesTable = new Telephones();
            telephonesTable.Show(); // Открытие формы Telephones
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Telephones в {DateTime.Now}");
        }

        private void ClientsButt_Click(object sender, EventArgs e)
        {
            tabClients = GetData("SELECT *from mainschema.client");
            Clients clientsTable = new Clients();
            clientsTable.Show(); // Открытие формы Clients
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Clients в {DateTime.Now}");
        }

        private void PersonButt_Click(object sender, EventArgs e)
        {
            tabPerson = GetData("SELECT * from mainschema.person");
            Orders personTable = new Orders();
            personTable.Show(); // Открытие формы Person
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Person в {DateTime.Now}");
        }

        private void FirmButt_Click(object sender, EventArgs e)
        {
            tabFirm = GetData("SELECT * from mainschema.firm");
            Firm firmTable = new Firm();
            firmTable.Show(); // Открытие формы Firm
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Firm в {DateTime.Now}");
        }

        private void RepairAppsButt_Click(object sender, EventArgs e)
        {
            tabRepairApps = GetData("SELECT * from mainschema.repairapp");
            RepairApps repairAppsTable = new RepairApps();
            repairAppsTable.Show(); // Открытие формы RepairApps
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу RepairApps в {DateTime.Now}");
        }

        private void CallsButt_Click(object sender, EventArgs e)
        {
            tabCalls = GetData("SELECT * from mainschema.calls");
            Calls callsTable = new Calls();
            callsTable.Show(); // Открытие формы Calls
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Calls в {DateTime.Now}");
        }

        private void ExemptsButt_Click(object sender, EventArgs e)
        {
            tabExempts = GetData("SELECT * from mainschema.exempt");
            Exempts exemptsTable = new Exempts();
            exemptsTable.Show(); // Открытие формы Exempts
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Exempts в {DateTime.Now}");
        }

        private void CountriesButt_Click(object sender, EventArgs e)
        {
            tabCountries = GetData("SELECT * from mainschema.country");
            Countries сountriesTable = new Countries();
            сountriesTable.Show(); // Открытие формы Countries
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Countries в {DateTime.Now}");
        }

        private void UsersButt_Click(object sender, EventArgs e)
        {
            tabUsers = GetData("SELECT * from mainschema.users");
            Users usersTable = new Users();
            usersTable.Show(); // Открытие формы Users
            LogTXT.WriteLine($"Пользователь {currentUser.SName} {currentUser.Name}" + // Логирование
                $"{currentUser.MName} открыл таблицу Users в {DateTime.Now}");
        }

        public static DataTable GetData(string sql)
        {
            npgsqlCommand.Connection = npgsql; // Подключение команды к БД
            DataTable dataTable = new DataTable();
            npgsqlCommand.CommandText = sql;
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader(); // Выполнение запроса на получение данных
            dataTable.Load(npgsqlDataReader); // Загрузка данных 
            return dataTable;
        }

        public static DataTable GetData(string sql, NpgsqlParameter npgsqlParameter) // Получение данных с одним параметром
        {
            npgsqlCommand.Connection = npgsql;
            DataTable dataTable = new DataTable();
            npgsqlCommand.CommandText = sql;
            npgsqlCommand.Parameters.Add(npgsqlParameter);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();
            dataTable.Load(npgsqlDataReader);
            npgsqlCommand = new NpgsqlCommand();
            return dataTable;
        }

        public static DataTable GetData(string sql, NpgsqlParameter npgsqlParameter01,
            NpgsqlParameter npgsqlParameter02) // Получение данных с двумя параметрами
        {
            npgsqlCommand.Connection = npgsql;
            DataTable dataTable = new DataTable();
            npgsqlCommand.CommandText = sql;
            npgsqlCommand.Parameters.Add(npgsqlParameter01);
            npgsqlCommand.Parameters.Add(npgsqlParameter02);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();
            dataTable.Load(npgsqlDataReader);
            npgsqlCommand = new NpgsqlCommand();
            return dataTable;
        }

        public static void ClearForm(Form form) // Очистка текстбоксов и чекбоксов
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls[i] is TextBox)
                    (form.Controls[i] as TextBox).Text = null;
                if (form.Controls[i] is CheckBox)
                    (form.Controls[i] as CheckBox).Checked = false;
                if (form.Controls[i] is ComboBox)
                    (form.Controls[i] as ComboBox).SelectedItem = null;
            }
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
