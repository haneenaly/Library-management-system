using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    internal class availablebooks
    {
        public string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        public MySqlConnection cnn;
        public availablebooks()
        {
            cnn = new MySqlConnection(connectionString);
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int ISBN { get; set; }
        public string Status { get; set; }
        public int Branch { get; set; }

        public List<availablebooks> availableBooksData()
        {
            List<availablebooks> listData = new List<availablebooks>();


            try
            {
                cnn.Open();

                string selectData = "SELECT * FROM book WHERE Status = 'available'";
                MySqlCommand cmd = new MySqlCommand(selectData, cnn);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Log to verify the query and check if it returns data
                Console.WriteLine("Executing Query: " + selectData);


                while (reader.Read())
                {
                    availablebooks dab = new availablebooks();
                    dab.ID = (int)reader["BookID"];
                    dab.Title = reader.GetString("Title");
                    dab.Author = reader.GetString("Author");
                    dab.Genre = reader.GetString("Genre");
                    dab.ISBN = (int)reader["ISBN"];
                    dab.Status = reader.GetString("Status");
                    dab.Branch = (int)reader["Branch"];

                    listData.Add(dab);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database:" + ex);
            }
            finally
            {
                cnn.Close();
            }

            return listData;
        }
    }
}
