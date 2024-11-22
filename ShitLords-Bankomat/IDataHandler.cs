namespace Shitlords_Bankomat
{
    public interface IDataHandler<T>
    {
        public string FilePath { get; set; }

        public T Load();

        public T Load(string id);

        public List<T> LoadAll();

        // Overloaded LoadAll method, used to filter after user id
        public List<T> LoadAll(string userid);

        public void Save(T saveThis);
        public void SaveAll(List<T> saveList);

        public void Delete(T deleteThis);


    }
}
