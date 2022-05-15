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
}
