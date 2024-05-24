import pycom, socket
import time
import uos
import machine, os, network
from machine import SD
from machine import UART
from network import WLAN
import _thread
from machine import Pin

uos.dupterm(None)

uart = UART(0, baudrate=115200)
uart.init(115200)

# def sdWrite(str):
#     try:
#         if str != None:
#             f = open(fileName,'a')
#             f.write(str)
#             f.write('\n')
#             f.close()
#     except:
#         return

def sendData():
    try:
        while True:
            time.sleep(1)
	    pycom.rgbled(0x00ff00)
            newData = uart.read()
	    pycom.rgbled(0x0000ff)
            if newData != None:
                print(newData.decode("utf-8"))
		pycom.rgbled(0xff0000)
    except:
        return
# sd = SD()
# os.mount(sd,'/sd')
# f = open(fileName,'w')

_thread.start_new_thread(sendData, ())
