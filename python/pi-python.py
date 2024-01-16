def number_pi(n):
    pi = 0
    i = 0
    #accuracy = 1
    #acurate_value =  3,141592653589
    
    while i < n:
        sign = (-1)**(i)
        denom = 2*i + 1
        pi = pi + sign/denom
        i += 1
        
    return 4*pi
    
print (number_pi(10000))