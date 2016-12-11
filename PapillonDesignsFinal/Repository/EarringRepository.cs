using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PapillonDesignsFinal.Models;
using System.Data;

//namespace PapillonDesignsFinal.Repository
//{
//    public class EarringRepository
//    {
//        private SqlConnection conn;
//        //handle connection related activities

//        private void connection()
//        {
//            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
//            //creating a reference to the connection string from the web.config
//            //creating a repository to connect to our albums and our database
//            conn = new SqlConnection(constr);
//            //creating a new instance of the Sql connection and passing that connection string into it, creates our connection method to connect to our database
//        }



//        public List<JewelryModel> Earrings()
//        {
//            connection(); //calling our connection method
//            List<Models.JewelryModel> EarringList = new List<JewelryModel>();
//            //defining our connection
//            SqlCommand com = new SqlCommand("Earrings", conn); //creating sql command called com that is equal to a new sql command that takes two parameters
//            com.CommandType = CommandType.StoredProcedure; //telling sql what type of command it is, stored procedure
//            SqlDataAdapter da = new SqlDataAdapter(com); //our connection what we use to receive data back
//            DataTable table = new DataTable();

//            conn.Open(); //establishes connection to our database
//            da.Fill(table);//using data adapter to get data
//            conn.Close();//if connection isn't closed it would b a connection that couldn't be used

//            //run the loop
//            foreach (DataRow dr in table.Rows) //loop through and start assigning things into that data row
//            {
//                EarringList.Add(
//                    new JewelryModel
//                    {
//                        JewelryId = Convert.ToInt32(dr["JewelryId"]), //converting to int32 because C# needs a byte number
//                        Title = Convert.ToString(dr["Title"]),
//                        Price = Convert.ToDecimal(dr["Price"]),
//                        Description = Convert.ToString(dr["Description"]),
//                        Color = Convert.ToString(dr["Color"]),
//                        ImageUrl = Convert.ToString(dr["Image"]),
//                        JewelryTypeId = Convert.ToInt32(dr["Jewelry Type"])


//                    });

//            }

//            return EarringList;
//        }
//    }
//}


