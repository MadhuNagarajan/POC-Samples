/// <summary>
/// 
/// </summary>
namespace MakeMedia.Repository
{
    public interface IRepository //<TEntity, in TKey> where TEntity : class
    {
        void DBSave();        
    }
}
