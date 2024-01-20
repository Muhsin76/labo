import random

t = [1, 2, 3, 4]
r = random.sample(t, len(t))

print(t)
print(r)

Q = ['Q1', 'Q2', 'Q3', 'Q4', 'Q5']

A1 =['ANS_1a', 'ANS_1b', 'ANS_1c', 'ANS_1d']
A2 =['ANS_2a', 'ANS_2b', 'ANS_2c', 'ANS_2d']
A3 =['ANS_3a', 'ANS_3b', 'ANS_3c', 'ANS_3d']
A4 =['ANS_4a', 'ANS_4b', 'ANS_4c', 'ANS_4d']
A5 =['ANS_5a', 'ANS_5b', 'ANS_5c', 'ANS_5d']

QS = random.sample(Q, len(Q))

for q in QS:
    print(q)

