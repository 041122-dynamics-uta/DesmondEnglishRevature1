using System.Data.SqlClient;
using DigitalRecordStoreModel;

namespace Repo;
public class DigitalRepoClass 
{       
    public DigitalMapperClass _mapper { get; set; }

    string connectionString = "Server=tcp:marcelenglishserver.database.windows.net,1433;Initial Catalog=marcelenglishDB;Persist Security Info=False;User ID=DesmondEnglishdB;Password=revature$scooler2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
         
     public DigitalRepoClass()
    {
        this._mapper = new DigitalMapperClass();
    }

    public List<StoreClass> StoreClassList()
    {
        string myQuery1 = "SELECT * FROM Stores;";
        //using block creates the SqlConnection.
        //SqlConnection is the object that communicates with the Db.
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Connection.Open();//open connection to Db
            SqlDataReader results = command.ExecuteReader();//actually conduct query.

            //query the Repo Db for the list of Stores
            //USE ADO.NET .........
            //use the mapper to transfer the values in to Stores objects in a List<StoreClass>.
            List<StoreClass> sc = new List<StoreClass>();
            while (results.Read())
            {
                sc.Add(this._mapper.DboToStore(results));//send in the row of the reader to be mapped.
            }

            query1.Close();
            return sc;
        }
    }
}    