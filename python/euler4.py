#largestpolindrom
def is_poli(n):
    s = str(n)
    d = len(s)
    for i in range(d):
        if s[i] !=s[d-1-i]:
            return False
    return True
    
largepoli = 0
num1 = 0
num2 = 0

for a in range(100,1000):
    for b in range(100,1000):
        number = a*b    
        if is_poli(number) and number>largepoli:
            largepoli = number
            num1 = a
            num2 = b

print(largepoli,"=",num1,"*",num2)

    
            