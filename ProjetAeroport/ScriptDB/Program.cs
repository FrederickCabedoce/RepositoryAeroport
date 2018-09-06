using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlCommand cmd = new SqlCommand();
            SqlParameter sp1 = new SqlParameter();
            SqlParameter sp2 = new SqlParameter();
            SqlParameter sp3 = new SqlParameter();
            SqlParameter sp4 = new SqlParameter();
            SqlParameter sp5 = new SqlParameter();
            SqlParameter sp6 = new SqlParameter();
            string id ="", origine ="", destination="", logo="", porte="", typevol="";
            DateTime date = DateTime.Now;

            Console.WriteLine(date);
            Console.ReadLine();

           /* con = new SqlConnection("Data Source=(local);Initial Catalog=ProjetAeroport;Integrated Security=True");




                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@ORIGINE", SqlDbType.VarChar).Value = origine;
                cmd.Parameters.Add("@DESTINATION", SqlDbType.VarChar).Value = destination;
                cmd.Parameters.Add("@LOGO", SqlDbType.VarChar).Value = logo;
                cmd.Parameters.Add("@PORTE", SqlDbType.VarChar).Value = porte;
                cmd.Parameters.Add("@TYPEVOL", SqlDbType.VarChar).Value = typevol;


                cmd = new SqlCommand("InsertVol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();*/
            }
    }
}
