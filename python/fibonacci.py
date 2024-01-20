#FibonacciNumbers
#MuhsinKaraali

import random

def fibo1(n):
    a = 1
    b = 1
    flist = [1 , 1]
    for i in range(n):
        f = a+b 
        a = b
        b = f
        flist.append(f)
    return(flist)

print(fibo1(20))
