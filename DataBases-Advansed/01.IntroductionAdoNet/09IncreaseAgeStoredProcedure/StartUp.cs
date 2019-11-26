namespace _09.IncreaseAgeStoredProcedure
{
    using System;
    using System.Data.SqlClient;

    using _01.InitialSetup;

    public class StartUp
    {
        public static void Main()
        {
            var id = int.Parse(Console.ReadLine());

            using var connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();
            try
            {
                CreateProcedure(connection);
            }
            catch (Exception e)
            { 
                Console.WriteLine("Stored Procedure usp_GetOlder already exists !");
                Console.WriteLine("Please delete usp_GetOlder from database-MinionsBD and try again !");
            }
            ExecuteProcedure(connection, id);
            PrintMinionById(connection, id);
        }
        private static void PrintMinionById(SqlConnection connection, int id)
        {
            using (var command = new SqlCommand(Queries.SelectMinionById, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var minionName = (string)dataReader[0];
                        var minionAge = (int)dataReader[1];

                        Console.WriteLine($"{minionName} – {minionAge} years old");
                    }
                }
            }
        }
        private static void ExecuteProcedure(SqlConnection connection, int id)
        {
            using (var command = new SqlCommand(Queries.ExecuteProcedure, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        private static void CreateProcedure(SqlConnection connection)
        {
            using (var command = new SqlCommand(Queries.CreateGetOlderProcedure, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
