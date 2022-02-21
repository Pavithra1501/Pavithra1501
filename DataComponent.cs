using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    public class DataComponent
    {


        static string CONNECTIONSTRING = @"Data Source=RILPT183;Initial Catalog=boutique;User ID=sa;Password=sa123 ";
        public void AddNewDress(Dress dress)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = "INSERT INTO Dress VALUES(@Id,@Color,@Brand,@Size)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", dress.DressId);
                cmd.Parameters.AddWithValue("@Color", dress.DressColor);
                cmd.Parameters.AddWithValue("@Brand", dress.DressBrand);
                cmd.Parameters.AddWithValue("@Size", dress.DressSize);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Details not added!");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }



        public void UpdateDress(Dress dress)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = $"UPDATE DRESS set DressColor = '{ dress.DressId }', DressBrand = '{dress.DressBrand}', DressSize= '{dress.DressSize}'" +
                    $"" +
                    $" WHERE DressId = {dress.DressId}";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("No Details were updated");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void DeleteDress(int id)
        {
            Dress dress = new Dress();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Dress WHERE DressId = " + id;
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 0)
                        throw new Exception("Cannot Delete Dress");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}










                                                                                                                                                                           
    

