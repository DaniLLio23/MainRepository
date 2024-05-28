using Npgsql;
using System.Data;

namespace ThreeD_Store_UnitTest
{
    [TestClass]
    public class AuthorizationUnitTest
    {
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=threed_store");
        NpgsqlCommand npgsqlCommand;
        NpgsqlDataAdapter npgsqlAdapter;
        public DataTable datatable;

        [TestMethod]
        public void AuthorizationTest01_Passed()
        {
            string query = $"SELECT login = @Login, password = @Password FROM users WHERE id = {1}";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@Login", "admin");
            npgsqlCommand.Parameters.AddWithValue("@Password", "admin123");
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"admin123", GetUser($"SELECT password FROM users WHERE id = {1}").ToString());
        }

        [TestMethod]
        public void AuthorizationTest02_Failed()
        {
            string query = $"SELECT login = @Login, password = @Password FROM users WHERE id = {1}";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@Login", "admin");
            npgsqlCommand.Parameters.AddWithValue("@Password", "admin123");
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"admin321", GetUser($"SELECT password FROM users WHERE id = {1}").ToString());
        }

        [TestMethod]
        public void AuthorizationTest03_Passed()
        {
            string query = $"SELECT login = @Login, password = @Password FROM users WHERE id = {1}";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@Login", "admin");
            npgsqlCommand.Parameters.AddWithValue("@Password", "admin123");
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"admin", GetLogin($"SELECT login FROM users WHERE id = {1}").ToString());
        }

        [TestMethod]
        public void AuthorizationTest04_Failed()
        {
            string query = $"SELECT login = @Login, password = @Password FROM users WHERE id = {1}";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@Login", "new_admin");
            npgsqlCommand.Parameters.AddWithValue("@Password", "adminqwe");
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"new_admin", GetLogin($"SELECT login FROM users WHERE id = {1}").ToString());
        }

        [TestMethod]
        public void PasswordTest01_Passed()
        {
            SetUser(8, 16, true, true);
            Assert.AreEqual(true, User.CorrectPassword("ABCdef123$%^"));
        }

        [TestMethod]
        public void PasswordTest02_Failed()
        {
            SetUser(6, 12, true, true);
            Assert.AreEqual(true, User.CorrectPassword("abc12"));
        }

        [TestMethod]
        public void PasswordTest03_Failed()
        {
            SetUser(6, 12, true, true);
            Assert.AreEqual(true, User.CorrectPassword("abcdefgh12345678"));
        }

        [TestMethod]
        public void PasswordTest04_Failed()
        {
            SetUser(8, 16, false, true);
            Assert.AreEqual(true, User.CorrectPassword("ABCDefg1234"));
        }

        [TestMethod]
        public void PasswordTest05_Failed()
        {
            SetUser(8, 16, false, false);
            Assert.AreEqual(true, User.CorrectPassword("abcdefg!@#$"));
        }

        string GetUser(string text)
        {
            string query = text;
            npgsqlAdapter = new NpgsqlDataAdapter(query, npgsqlConnection);
            npgsqlConnection.Open();
            datatable = new DataTable();
            npgsqlAdapter.Fill(datatable);
            npgsqlConnection.Close();
            return datatable.Rows[0]["password"].ToString();
        }


        string GetLogin(string text)
        {
            string query = text;
            npgsqlAdapter = new NpgsqlDataAdapter(query, npgsqlConnection);
            npgsqlConnection.Open();
            datatable = new DataTable();
            npgsqlAdapter.Fill(datatable);
            npgsqlConnection.Close();
            return datatable.Rows[0]["login"].ToString();
        }

        public void SetUser(int min, int max, bool cap, bool spec)
        {
            User.minLength = min;
            User.maxLength = max;
            User.capitals = cap;
            User.specials = spec;
        }

    }
}
