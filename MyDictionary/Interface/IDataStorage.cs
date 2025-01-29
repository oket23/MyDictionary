namespace MyDictionary.Forms
{
    public interface IDataStorage<T>
    {
        void Save(List<T> data, string path);
        List<T> Get(string path);
    }
}
