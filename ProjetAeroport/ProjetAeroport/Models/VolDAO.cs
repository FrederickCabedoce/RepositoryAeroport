using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetAeroport.Models
{
    public class VolDAO
    {

        public static DataSet FetchAll()
        {
            string query = "Select * from Vol";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet datas = new DataSet();



            SqlConnection connection = Database.GetConnection();


            using (var command = new SqlCommand(query, connection)) {
                /*using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                           reader.GetDateTime(7), reader.GetString(8)));
                }*/

                adapter.SelectCommand = command;
                adapter.Fill(datas);
                adapter.Dispose();



            }
        
            

            return datas;

        }//Fin FetchAll

        public static DataSet FetchByDate(DateTime date)
        {
            string query = "Select * from VolsVueEntrant where DATE = '@DATE'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet datas = new DataSet();  
            

            SqlConnection connection = Database.GetConnection();

            using (var command = new SqlCommand(query, connection))
            {
                SqlParameter param = new SqlParameter();//Requete Parametrer
                param.ParameterName = "@DATE";
                param.Value = date;

                adapter.SelectCommand = command;
                adapter.Fill(datas);
                adapter.Dispose();
                

               /* using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        //monVol.ID = reader.GetString(0);
                        //monVol.Destination = reader.GetString(1);
                        //monVol.Etat = reader.GetString(2);
                        //monVol.Logo = reader.GetString(3);
                        //monVol.Prevu = reader.GetString(4);
                        //monVol.Revise = reader.GetString(5);
                        //monVol.Porte = reader.GetString(6);
                        //monVol.Date = reader.GetDateTime(7);
                        //monVol.TypeVol = reader.GetString(8);

                        listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), reader.GetString(8)));

                    }
                }*/
            }

            return datas;

        }//Fin FetchByDate

        public static DataSet FetchByType(string type,string jour)
        {
            string query;

            if (type == "Entrant")
            {
                 query = "select * from VolsVueEntrant where DATE = @JOUR";
            }
            else {
                 query = "select * from VolsVueSortant where DATE = @JOUR";
            }

       
            SqlParameter param = new SqlParameter(); // Requete parametrer
            param.ParameterName = "@JOUR";
            param.Value = jour;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet datas = new DataSet();

            
            SqlConnection connection = Database.GetConnection();


            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(param);

                adapter.SelectCommand = command;
                adapter.Fill(datas);
                adapter.Dispose();

                
                /*using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                           reader.GetDateTime(7), reader.GetString(8)));
                    }
                }*/


                return datas;



            }//Fin FetchAll
        }
    }
}