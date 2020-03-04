using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Model.Model;

namespace Dao
{
    public class clsDAO
    {
       private static SqlConnection conexao()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-6UOMJI2\SQLEXPRESS;Initial Catalog=bdCDP;Integrated Security=True");

            cn.Open();
            return cn;
        }
       

        public static IEnumerable GetAtletas()
        {
            SqlDataReader dr ;
            List<Atleta> listAtleta = new List<Atleta>();
            string query = "select * from Atleta";
            using (SqlConnection cn = conexao())
            {
                using (SqlCommand cmd = new SqlCommand("", cn))
                {
                 dr=cmd.ExecuteReader();

                   

                    while (dr.Read())
                    {
                        Atleta a = new Atleta();

                        a.Cod = int.Parse(dr["Cod"].ToString());
                        a.Nome = dr["Nome"].ToString();

                        listAtleta.Add(a);
                    }
                }


            }

            return listAtleta;
        }



    }
}
