# A guide to non-trivial (but useful) functions on NEO

## setting specific bytearray element

`byte[] vb = ...; vb[2] = 0x90; // breaks!`

```
        // function: set specific element in bytearray
        private static byte[] bset(byte[] c, int i, byte val)
        {
            Runtime.Notify(val);
            //Runtime.Notify(new byte[1]{val}); // PROBLEMATIC
            byte[] vbase = new byte[0];
            if(val < 0x80)
                vbase = vbase.Concat(((BigInteger)val).AsByteArray());
            else
                vbase = vbase.Concat(((BigInteger)val).AsByteArray().Range(0,1));
            //byte[] novo = c.Range(0, i-1+1).Concat(((BigInteger)val).AsByteArray());
            byte[] novo = c.Range(0, i-1+1).Concat(vbase);
            Runtime.Notify(novo);
            if(i+1 < c.Length)
                novo = novo.Concat(c.Range(i+1,c.Length-i+1));
            return novo;//.Concat(c.Range(i+1, ));
        }
```
