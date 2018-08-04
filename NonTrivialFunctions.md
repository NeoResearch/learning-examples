# A guide to non-trivial (but useful) functions on NEO

## setting specific bytearray element

`byte[] vb = ...; vb[2] = 0x90; // breaks!`

```
// function: set specific element in bytearray
private static byte[] bset(byte[] c, int i, byte val)
{
    byte[] novo = c.Range(0, i-1+1).Concat(((BigInteger)val).AsByteArray().Range(0,1));
    if(i+1 < c.Length)
        novo = novo.Concat(c.Range(i+1,c.Length-i+1));
    return novo;
}
```
