namespace AdapterPattern
{
    public interface ISerializerAdapter
    {
        string Serialize<T>(object objectToSerialize);
    }
}
