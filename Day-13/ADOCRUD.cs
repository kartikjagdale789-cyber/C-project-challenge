using System;
using System.Data.SqlClient;

class ADOCRUD
{
    static string connStr = "your_connection_string";

    static void Main()
    {
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();

            // INSERT
            SqlCommand insert = new SqlCommand("INSERT INTO Students(Name) VALUES('Ajay')", conn);
            insert.ExecuteNonQuery();

            // READ
            SqlCommand read = new SqlCommand("SELECT * FROM Students", conn);
            SqlDataReader dr = read.ExecuteReader();
            while (dr.Read())
                Console.WriteLine(dr["Name"]);
            dr.Close();

            // UPDATE
            SqlCommand update = new SqlCommand("UPDATE Students SET Name='Raj' WHERE Name='Ajay'", conn);
            update.ExecuteNonQuery();

            // DELETE
            SqlCommand delete = new SqlCommand("DELETE FROM Students WHERE Name='Raj'", conn);
            delete.ExecuteNonQuery();
        }
    }
}