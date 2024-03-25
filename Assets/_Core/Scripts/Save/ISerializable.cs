public interface ISerializable<T> where T : DataTransferObject
{
    T Serialized();

    void Deserialized(T dataTransferObject);
}
