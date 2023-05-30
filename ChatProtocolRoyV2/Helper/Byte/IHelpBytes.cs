namespace ChatProtocolRoyV2.Helper.Byte;

public interface IHelpBytes : IHelp
{
    byte[] ObjectToByteArray<T>(T obj);
    T FromByteArray<T>(byte[] byteArray);
    byte[] CombineByteArrays(params byte[][] arrays);
}