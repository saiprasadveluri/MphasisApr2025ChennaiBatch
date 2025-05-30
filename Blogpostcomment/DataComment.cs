using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blogpostcomment
{
    public class DataBComment : IDisposable
    {
        private const string ConString = "Data Source=.;Initial Catalog=BloggingAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection _connection;

        public DataBComment()
        {
            _connection = new SqlConnection(ConString);
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
            }
        }

        public List<BComment> GetAllComments()
        {
            List<BComment> comments = new List<BComment>();

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            string cmdText = "SELECT * FROM Comment";
            using SqlCommand sqlCommand = new(cmdText, _connection);
            using SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comments.Add(new BComment()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Comment