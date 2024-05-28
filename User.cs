using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Linq;

namespace ThreeD_Store
{
    internal class User
    {
        int id = 0;
        string name, post, login, sName, mName;
        bool BuyersAccess, OrdersAccess, OrderItemAccess, ItemsAccess, ItemTypesAccess, MaterialsAccess,
            CreatorsAccess, UsersAccess;
        string BuyersRight, OrdersRight, OrderItemRight, ItemsRight, ItemTypesRight, MaterialsRight,
            CreatorsRight, UsersRight;

        static public int minLength = 6;
        static public int maxLength = 20;
        static public bool capitals = true;
        static public bool specials = true;

        public User(string post, string name, bool BuyersAccess, bool OrdersAccess, bool OrderItemAccess,
            bool ItemsAccess, bool ItemTypesAccess, bool MaterialsAccess, bool CreatorsAccess, bool UsersAccess,
            string BuyersRight, string OrdersRight, string OrderItemRight, string ItemsRight, string ItemTypesRight,
            string MaterialsRight, string CreatorsRight, string UsersRight, string login, string sName, string mName)
        {
            this.name = name; // Фамилия пользователя
            this.post = post; // Должность пользователя
            this.BuyersAccess = BuyersAccess; // Права на таблицу Telephones
            this.OrdersAccess = OrdersAccess; // Права на таблицу Clients
            this.OrderItemAccess = OrderItemAccess; // Права на таблицу Person
            this.ItemsAccess = ItemsAccess; // Права на таблицу Firm
            this.ItemTypesAccess = ItemTypesAccess; // Права на таблицу RepairApps
            this.MaterialsAccess = MaterialsAccess; // Права на таблицу Calls
            this.CreatorsAccess = CreatorsAccess; // Права на таблицу Exempts
            this.UsersAccess = UsersAccess; // Права на таблицу Countries
            this.BuyersRight = BuyersRight; // Доступ к таблице Telephones
            this.OrdersRight = OrdersRight; // Доступ к таблице Clients
            this.OrderItemRight = OrderItemRight; // Доступ к таблице Person
            this.ItemsRight = ItemsRight; // Доступ к таблице Firm
            this.ItemTypesRight = ItemTypesRight; // Доступ к таблице RepairApps
            this.MaterialsRight = MaterialsRight; // Доступ к таблице Calls
            this.CreatorsRight = CreatorsRight; // Доступ к таблице Exempts
            this.UsersRight = UsersRight; // Доступ к таблице Countries
            this.login = login;
            this.sName = sName;
            this.mName = mName;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Post { get => post; set => post = value; }
        public bool BuyersA { get => BuyersAccess; set => BuyersAccess = value; }
        public bool OrdersA { get => OrdersAccess; set => OrdersAccess = value; }
        public bool OrderItemA { get => OrderItemAccess; set => OrderItemAccess = value; }
        public bool ItemsA { get => ItemsAccess; set => ItemsAccess = value; }
        public bool ItemTypesA { get => ItemTypesAccess; set => ItemTypesAccess = value; }
        public bool MaterialsA { get => MaterialsAccess; set => MaterialsAccess = value; }
        public bool CreatorsA { get => CreatorsAccess; set => CreatorsAccess = value; }
        public bool UsersA { get => UsersAccess; set => UsersAccess = value; }
        public string BuyersR { get => BuyersRight; set => BuyersRight = value; }
        public string OrdersR { get => OrdersRight; set => OrdersRight = value; }
        public string OrderItemR { get => OrderItemRight; set => OrderItemRight = value; }
        public string ItemsR { get => ItemsRight; set => ItemsRight = value; }
        public string ItemTypesR { get => ItemTypesRight; set => ItemTypesRight = value; }
        public string MaterialsR { get => MaterialsRight; set => MaterialsRight = value; }
        public string CreatorsR { get => CreatorsRight; set => CreatorsRight = value; }
        public string UsersR { get => UsersRight; set => UsersRight = value; }
        public string Login { get => login; set => login = value; }
        public string SName { get => sName; set => sName = value; }
        public string MName { get => mName; set => mName = value; }

        static public bool CorrectPassword(string password)
        {
            char[] passwordInChars = password.ToCharArray();
            if (passwordInChars.Length < minLength ) { return false; }
            if (passwordInChars.Length > maxLength ) { return false; }
            if (!capitals && password.Any(char.IsUpper)) { return false; }
            if (!specials && password.Any(char.IsSymbol)) { return false; }
            return true;
        }
    }
}
