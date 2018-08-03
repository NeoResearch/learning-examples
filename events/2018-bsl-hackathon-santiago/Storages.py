from boa.interop.Neo.Storage import Get, Put, GetContext
from boa.interop.Neo.Runtime import Notify

context = GetContext()

def Main():
    Put(context, "Hello", "World")
    value = Get(context, "Hello")
    Notify(value)
