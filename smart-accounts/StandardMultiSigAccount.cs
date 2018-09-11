using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using Neo.VM;

namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        public static readonly byte[] pubkey1 = "036245f426b4522e8a2901be6ccc1f71e37dc376726cc6665d80c5997e240568fb".HexToBytes();
        public static readonly byte[] pubkey2 = "0303897394935bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0d".HexToBytes();
        public static readonly byte[] pubkey3 = "02e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d6313625a930874b4".HexToBytes();

        public static bool Main(byte[][] signatures)
        {
            byte[][] pubkeys = new[] {pubkey1, pubkey2, pubkey3};
            int m = 2;
            //return (signatures.Length == m) && VerifySignatures(signatures, pubkeys);
            if(signatures.Length != m)
                return false;
            else
                return VerifySignatures(signatures, pubkeys);
        }
    }
}

//53c56b6c766b00527ac453c576006121036245f426b4522e8a2901be6ccc
//1f71e37dc376726cc6665d80c5997e240568fbc476516121030389739493
//5bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0dc47652
//612102e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d631362
//5a930874b4c46c766b51527ac4526c766b52527ac46c766b00c3c06c766b
//52c39c63080000616c75666c766b00c36c766b51c3ae616c7566

//5221036245f426b4522e8a2901be6ccc1f71e37dc376726cc6665d80c5997e240568fb210303897394935bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0d2102e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d6313625a930874b453ae
