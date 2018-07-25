
# Bad Examples
## This is a list of examples that (strangely) do not seem to work

<hr>

## C# bad examples
### ternary operators

I believe ternary operators do not seem to work well...

```
using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class KeyValue : Framework.SmartContract
    {
        public static byte[] Main(string op) {
            bool input = op == "write";
            return new byte[1] { input ? (byte)5 : (byte)7 };
        }        
    }
}
// shash: 0xc8c55ca7642a36b65db0b9750b8d3994bd4c20cf  avm:
// 52c56b6c766b00527ac46c766b00c3057772697465876c766b51527ac401
// 0076006c766b51c36307005762040055c4616c7566
```

Using python invocation (in neocompiler.io) with invocation string `write` (or without it) this code gives `FAULT`.

Replacing ternary operator with:
```
if(input)
   return new byte[]{0x05};
else
   return new byte[]{0x07};
// shash: 0x21e1867c74c02ae501976c6b211f9bcbb6cf4f2e avm:
// 51c56b6c766b00527ac46c766b00c3057772697465876409000105616c75
// 660107616c7566
```
it seems to work now (`write` returns 5, and `writex` returns 7). Thanks @Jing for this example.

<hr>

Contribute with us!
