# Some invocation examples using Eco platform

On Eco platform (https://neocompiler.io) it is possible to invoke contracts by using `neon-js` library or `neo-python` command line.

Here are some useful examples:

<hr>

`public static byte[] Main(string op, byte[] key, byte[] value)`

Passing string parameter `"write"`, byte array `{0x65, 0x61, 0x6e, 0x67}`, byte array `{0x6a, 0x69, 0x6e, 0x67}`:

Invoke via neo-python `write bytearray(b'\x6e\x61\x6d\x65') bytearray(b'\x6a\x69\x6e\x67')`


<hr>

Contribute with us!
