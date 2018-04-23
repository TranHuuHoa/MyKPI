
namespace MyKPI.Common
{ 
    public interface ICommonDAL
    {
        bool Add(ICommonEntity commonEntity);
        bool Edit(ICommonEntity commonEntity, int ID);
        bool Delete(int ID);
    }
}
