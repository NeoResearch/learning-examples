using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using Neo.VM;

namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        public static readonly byte[] pubkey = "031a6c6fbbdf02ca351745fa86b9ba5a9452d785ac4f7fc2b7548ca2a46c4fcf4a".HexToBytes();

        public static bool Main(byte[] signature)
        {
            return VerifySignature(signature, pubkey);
        }
    }
}

// 51c56b6a00527ac46a00c321031a6c6fbbdf02ca351745fa86b9ba5a9452d785ac4f7fc2b7548ca2a46c4fcf4aac6c7566
// equivalent to: 21031a6c6fbbdf02ca351745fa86b9ba5a9452d785ac4f7fc2b7548ca2a46c4fcf4aac
