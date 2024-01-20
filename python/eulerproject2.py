a = 1
b = 1
total=0
    
for i in range(1 , 100):
    f = a+b
    a = b
    b = f
    if b%2==0 and b < 4000000:
            total+=f
            
print(total)