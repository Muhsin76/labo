#FibonacciNumbers
import fibolip

print(fibolip.fibo1(20))

print(fibolip.fibo2(20))

for i in range (1,10):
    print(fibolip.fibor(i))

x = fibolip.fibo1(10)
print(x)

y = []
last = len(x)-1
for i in range(last,-1, -1):
    y.append(x[i])
print (y)

z =  x

x.reverse()
print (x)
print (z)