using System.Data.SqlClient;
using Repo;
using DigitalRecordStoreModel;

namespace digitalStoreDomain;
public class BusinessLayerClass
{
    //inject the dependency into the class
    private DigitalRepoClass _repo { get; set; }
    public BusinessLayerClass(DigitalRepoClass r)
    {
        this._repo = r;
    }

    public List<StoreClass> StoreClassList()
    {
        List<StoreClass> sc = _repo.StoreClassList();
        return sc;
    }

    public CustomerClass NewCustomer(string sUser, string sPass, string email, string fname, string lname, DateTime DateCreated)
    {
        CustomerClass c = _repo.NewCustomer(fname, lname, email, sUser, sPass, DateCreated);
        return c;
    }

    public List<ProductClass> ProductClassList()
    {
        List<ProductClass> pc = _repo.ProductClassList();
        return pc;
    }

    // public CustomerClass NewCustomer(string sUser, string sPass, string email, string fname, string lname, object dateCreated)
    // {
    //     throw new NotImplementedException();
    // }
}
