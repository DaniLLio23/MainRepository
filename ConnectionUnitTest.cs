using Npgsql;

namespace ThreeD_Store_UnitTest
{
    [TestClass]
    public class ConnectionUnitTest
    {
        [TestMethod]
        public void ConnectionTest01_Passed()
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=threed_store");
            npgsqlConnection.Open();
        }

        [TestMethod]
        public void ConnectionTest02_Failed()
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwertyui;Database=threed_store");
            npgsqlConnection.Open();
        }
    }
}