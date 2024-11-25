
namespace Shitlords_Bankomat
{
    public class TransactionDataHandler : IDataHandler<Transaction>
    {
        public string FilePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete(Transaction deleteThis)
        {
            throw new NotImplementedException();
        }

        public Transaction Load()
        {
            throw new NotImplementedException();
        }

        public Transaction Load(string id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> LoadAll()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> LoadAll(string userid)
        {
            throw new NotImplementedException();
        }

        public void Save(Transaction saveThis)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(List<Transaction> saveList)
        {
            throw new NotImplementedException();
        }
    }
}
