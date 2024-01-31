words=["python","java","python","c++","c","c++","python"]
w_python= 0
w_java= 0
w_cplus= 0
w_c= 0

for word in words:
        word = word.lower()

        if word == 'python':
            w_python += 1
        elif word == 'java':
            w_java += 1
        elif word == 'c++':
            w_cplus += 1
        elif word == 'c':
            w_c +=1
print(f'Letter "python" found {w_python} times')
print(f'Letter "java" found {w_java} times')
print(f'Letter "c++" found {w_cplus} times')
print(f'Letter "c" found {w_c} times')

import matplotlib.pyplot as plt

fig, ax = plt.subplots()

bar_colors = ['tab:red', 'tab:blue', 'tab:green']

apperances = [w_python, w_java, w_cplus, w_c]
all_words = ['python', 'java', 'c++', 'c']

ax.bar(all_words, apperances, color = bar_colors, width = 0.4)
ax.set_ylabel('words apperances')
ax.set_title('Number of apperances in a text')