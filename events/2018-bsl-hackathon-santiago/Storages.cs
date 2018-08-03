using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Storages : Framework.SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World"); // write it into blockchain storage using a key
            byte[] data = Storage.Get(Storage.CurrentContext, "Hello"); // get it from blockchain storage using a key
            Runtime.Notify(data, data.AsString());
        }
    }
}
