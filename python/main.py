#Phython1
#2023-10-26

import random

dice1= random.randint(1,6)
dice2= random.randint(1,6)

result = dice1 + dice2

print (result)

how_many_times = 1000000

outcome = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

for i in range(1, how_many_times):
    dice1= random.randint(1,6)
    dice2= random.randint(1,6)
    result = dice1 + dice2
    outcome[result -2] += 1
    #print(result, end=",")
    
print(outcome)

for i in range(11):
    #print(i+2, outcome[i])
    print("%2d %8d %10.4f" % (i+2, outcome[i], 100*outcome[i]/how_many_times))
