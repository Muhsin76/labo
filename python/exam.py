def prime(n):
    if n < 2:
        return False
    for i in range(2,n-1):
        if n % i == 0:
            return False
    return True

def count_primes(a,b):
    counter = 0
    for num in range(a,b+1):
        if prime(num):
            counter += 1
    return counter

a = int(input("enter the first number:"))
b = int(input("enter the last number:"))
print(count_primes(a,b))



   
