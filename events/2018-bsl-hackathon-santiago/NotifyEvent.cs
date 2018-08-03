using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;
using System.ComponentModel;

namespace Neo.SmartContract
{
    public class NotifyEvent : Framework.SmartContract
    {
         [DisplayName("Event")]
        public static event Action<BigInteger, String> Event;
        
        public static void Main()
        {
            BigInteger i = 10;
            String j = "Hello";
            Runtime.Notify(i, j);
            Event(i,j);
        }
    }
}
