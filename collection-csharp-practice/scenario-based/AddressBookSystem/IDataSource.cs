namespace AddressBookSystem
{
    internal interface IDataSource<T>
    {
        void Save(IEnumerable<T> contacts, string source);
        List<T> Load(string source);
    }
}
