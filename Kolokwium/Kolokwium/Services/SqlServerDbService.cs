using Kolokwium.DTOs.Requests;
using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public class SqlServerDbService : IDbService
    {
        private const string ConString = "Data Source=db-mssql;Initial Catalog=s19337;Integrated Security=True";


        public Prescription AddMedicament(MedicamentRequest request)
        {
            using (var con = new SqlConnection(ConString))
            using (var com = new SqlCommand())
            {

                com.Connection = con;
                con.Open();
                var tran = con.BeginTransaction();
                com.Transaction = tran;




                return null;
            }
        }

        public IEnumerable<Prescription> GetPrescription(string lastName)
        {

            var list = new List<Prescription>();

            using (SqlConnection con = new SqlConnection(ConString))
            using (SqlCommand com = new SqlCommand())
            {
                try
                {
                    com.Connection = con;

                    if(lastName == null) com.CommandText = "select date, dueDate from prescription order by date";
                    else
                    {
                        com.CommandText = "select date, dueDate from prescription, patient  " +
                            "where lastName = @lastName and patient.IdPatient=prescription.idPatient";
                            

                        com.Parameters.AddWithValue("lastName", lastName);

                    }

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        var pr = new Prescription();

                        pr.Date = dr["date"].ToString();
                        pr.DueDate = dr["dueDate"].ToString();

                        list.Add(pr);
                    }

                }
                catch (SqlException exc)
                {
                    return null;
                }
            }

            return list;

        }

    }



}
