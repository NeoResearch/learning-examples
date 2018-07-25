# Some invocation examples using Eco platform

On Eco platform (https://neocompiler.io) it is possible to invoke contracts by using `neon-js` library or `neo-python` command line.

Here are some useful examples:

<hr>

`public static byte[] Main(string op, byte[] key, byte[] value)`

Passing string parameter `"write"`, byte array `{0x65, 0x61, 0x6e, 0x67}`, byte array `{0x6a, 0x69, 0x6e, 0x67}`:

Invoke via neo-python `write bytearray(b'\x6e\x61\x6d\x65') bytearray(b'\x6a\x69\x6e\x67')`


<hr>

Random examples and invocation stack:

python oi ["abc"]
PUSHBYTES3: 0x476709 PUSH1 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi ["oi"]
PUSHBYTES2: 0x6f69 PUSH1 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi ["oab"]
PUSHBYTES3: 0x6f6162 PUSH1 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi ["ab"]
PUSHBYTES2: 0x1218 PUSH1 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi [ab]              => [ab] é visto como string literal "[ab]"
PUSHBYTES4: 0x5b61625d PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi ["ab","cd"]
PUSHBYTES2: 0xdc18 PUSHBYTES2: 0x1218 PUSH2 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi [ "ab" , "cd" ]
PUSHBYTES2: 0xdc18 PUSHBYTES2: 0x1218 PUSH2 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi ["oi1","oi2"]
PUSHBYTES3: 0x6f6932 PUSHBYTES3: 0x6f6931 PUSH2 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

python oi [ "oi1" , "oi2" ]
PUSHBYTES3: 0x6f6932 PUSHBYTES3: 0x6f6931 PUSH2 PACK PUSHBYTES2: 0x6f69 APPCALL: cf1ee6e00c5aa501390125694670090b649123b1

neonjs [{"type":"String","value":"oi"},{"type":"Array", "value": [{"type":"String","value":"oi1"},{"type":"String","value":"oi2"}]}]
PUSHBYTES3: 0x6f6932 PUSHBYTES3: 0x6f6931 PUSH2 PACK PUSHBYTES2: 0x6f69 APPCALL: 09c6f365ade1464246cc927794bc5704c2a27c3c


Contribute with us!
