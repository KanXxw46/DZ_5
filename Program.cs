using System;
using System.Data.SqlClient;

namespace Hw_05
{
    class Program
    {
        public static object Label1 { get; private set; }

        static void Main(string[] args)
        {
            SqlConnection conn = null;

            InitializeComponent();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-O33O61B",
                InitialCatalog = "MyDB",
                IntegratedSecurity = true, 
            };
            conn = new SqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                Label1.Content = $"Соедение к {builder.InitialCatalog} успешно произведено!";
            }
            catch (SqlException ex)
            {
                Label1.Content = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private static void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
