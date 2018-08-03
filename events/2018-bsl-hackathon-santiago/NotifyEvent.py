from boa.interop.Neo.Runtime import Notify
from boa.interop.Neo.Action import RegisterAction

Event = RegisterAction('Event', 'Number', 'String')

def Main():
    integer = 1
    string = "hello"
    Event(integer,string)
    Notify(integer,string)
