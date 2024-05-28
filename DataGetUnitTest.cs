using Npgsql;
using System.Data.Odbc;
using System.Data;

namespace ThreeD_Store_UnitTest
{
    [TestClass]
    public class DataGetUnitTest
    {
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=threed_store");
        NpgsqlCommand npgsqlCommand;
        NpgsqlDataAdapter npgsqlAdapter;
        public DataTable datatable;

        [TestMethod]
        public void SelectDataTest_Passed()
        {
            string query = $"SELECT buyer_name FROM buyers WHERE buyer_id = @BuyerID";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@BuyerID", 1);
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"Зайцев А. Е.", GetData($"SELECT buyer_name FROM buyers WHERE buyer_id = {1}", "buyer_name").ToString());
        }

        [TestMethod]
        public void InsertDataTest_Passed()
        {
            string query = $"INSERT INTO buyers VALUES (@BuyerID, @BuyerName)";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@BuyerID", 10000001);
            npgsqlCommand.Parameters.AddWithValue("@BuyerName", "TestBuyer");
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        [TestMethod]
        public void UpdateDataTest_Passed()
        {
            string query = "UPDATE buyers SET buyer_name = @BuyerName WHERE buyer_id = @BuyerID";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@BuyerName", "NewTestBuyer");
            npgsqlCommand.Parameters.AddWithValue("@BuyerID", 10000001);
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        [TestMethod]
        public void DeleteDataTest_Passed()
        {
            string query = "DELETE FROM buyers WHERE buyer_id = @BuyerID";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@BuyerID", 10000001);
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        [TestMethod]
        public void DeleteDataTest_Failed()
        {
            string query = "DELETE FROM buyers WHERE buyer_id = @BuyerID";
            npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("@BuyerID", 10000002);
            npgsqlConnection.Open();
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            Assert.AreEqual($"10000002", GetData($"SELECT buyer_id = {10000002} FROM buyers", "buyer_id").ToString());
        }

        string GetData(string command, string column)
        {
            string query = command;
            npgsqlAdapter = new NpgsqlDataAdapter(query, npgsqlConnection);
            npgsqlConnection.Open();
            datatable = new DataTable();
            npgsqlAdapter.Fill(datatable);
            npgsqlConnection.Close();
            return datatable.Rows[0][$"{column}"].ToString();
        }
    }
}
