def number_pi(accuracy):
    pi = 0
    i = 0
    accurate_value =  3.141592653589/4
    
    while abs(pi - accurate_value)  > accuracy:
        sign = (-1)**(i)
        denom = 2*i + 1
        pi = pi + sign/denom
        i += 1 
        #print(1)
        
    return 4*pi,i
    
#print (number_pi(0.000001))

pi_value =  number_pi(0.01)[0]
iterations = number_pi(0.01)[1]
print(pi_value, iterations)