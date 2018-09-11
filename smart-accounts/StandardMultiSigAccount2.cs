// Implementing MultiSig manually on Verification script (not using CHECKMULTISIG)

using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;
namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        public static readonly byte[] pubkey1 = "036245f426b4522e8a2901be6ccc1f71e37dc376726cc6665d80c5997e240568fb".HexToBytes();
        public static readonly byte[] pubkey2 = "0303897394935bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0d".HexToBytes();
        public static readonly byte[] pubkey3 = "02e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d6313625a930874b4".HexToBytes();

        public static bool CheckMultiSig(byte[][] signatures, byte[][] pubkeys, int m)
        {
            int n = pubkeys.Length;
            if(signatures.Length != m)
                return false;

            for (int i = 0, j = 0; i < m && j < n;)
            {
                if (VerifySignature(signatures[i], pubkeys[j]))
                    i++;
                j++;
                if (m - i > n - j)
                    return false;
            }
            return true;
        }

        // =================================================================
        // REMEMBER TO PUSH SIGNATURES IN REVERSE ORDER FOR PACKING IN ARRAY
        // This is different from "standard multisig", which don't use array
        // =================================================================
        // PUSH40 - sig pubkey2
        // PUSH40 - sig pubkey1
        // 52
        // C1 (PACK)
        // =================================================================

        public static bool Main(byte[][] signatures)
        {
            byte[][] pubkeys = new[] {pubkey1, pubkey2, pubkey3};
            int m = 2;

            return CheckMultiSig(signatures, pubkeys, m);
        }
    }
}

/*
53c56b6c766b00527ac453c576006121036245f426b4522e8a2901be6ccc
1f71e37dc376726cc6665d80c5997e240568fbc476516121030389739493
5bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0dc47652
612102e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d631362
5a930874b4c46c766b51527ac4526c766b52527ac46c766b00c36c766b51
c36c766b52c3615272650700616c756656c56b6c766b00527ac46c766b51
527ac46c766b52527ac46c766b51c3c06c766b53527ac46c766b00c3c06c
766b52c39c63080000616c7566006c766b54527ac4006c766b55527ac462
58006c766b00c36c766b54c3c36c766b51c36c766b55c3c3ac6411006c76
6b54c351936c766b54527ac46c766b55c351936c766b55527ac46c766b52
c36c766b54c3946c766b53c36c766b55c394a163080000616c75666c766b
54c36c766b52c3a26311006c766b55c36c766b53c39f6392ff51616c7566
*/

//5221036245f426b4522e8a2901be6ccc1f71e37dc376726cc6665d80c5997e240568fb210303897394935bb5418b1c1c4cf35513e276c6bd313ddd1330f113ec3dc34fbd0d2102e2baf21e36df2007189d05b9e682f4192a101dcdf07eed7d6313625a930874b453ae
