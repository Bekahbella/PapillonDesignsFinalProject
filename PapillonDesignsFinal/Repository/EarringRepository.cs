using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PapillonDesignsFinal.Repository
{
    public class EarringRepository
    {

    }
}



//public List<AlbumModel> GetAllAlbums()
//{
//    connection(); //calling our connection method
//    List<Models.AlbumModel> AlbumList = new List<AlbumModel>();
//    //defining our connection
//    SqlCommand com = new SqlCommand("Select_All_Albums", conn); //creating sql command called com that is equal to a new sql command that takes two parameters
//    com.CommandType = CommandType.StoredProcedure; //telling sql what type of command it is, stored procedure
//    SqlDataAdapter da = new SqlDataAdapter(com); //our connection what we use to receive data back
//    DataTable table = new DataTable();

//    conn.Open(); //establishes connection to our database
//    da.Fill(table);//using data adapter to get data
//    conn.Close();//if connection isn't closed it would b a connection that couldn't be used

//    //run the loop
//    foreach (DataRow dr in table.Rows) //loop through and start assigning things into that data row
//    {
//        AlbumList.Add(
//            new AlbumModel
//            {
//                AlbumId = Convert.ToInt32(dr["AlbumId"]), //converting to int32 because C# needs a byte number
//                        Title = Convert.ToString(dr["Title"]),
//                Price = Convert.ToDecimal(dr["Price"]),
//                AlbumArtUrl = Convert.ToString(dr["AlbumArtUrl"])
//            });

//    }

//    return AlbumList;
}