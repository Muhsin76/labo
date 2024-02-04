import csv
grade_st1 = []
grade_st2 = []
grade_st3 = []
grade_st4 = []
grades= []
filename = 'grades.csv'
with open(filename) as file:
    reader = csv.reader(file)
    header_row = next(reader)

    for row in reader:
        grade = int(row[2])
        grades.append(grade)
        student = row[0]
        subject = row[1]
        if  student == 'st_A':
            grade_st1.append(grade)
        elif student == 'st_B':
            grade_st2.append(grade)
        elif student =='st_C' :
            grade_st3.append(grade)
        else:
            grade_st4.append(grade)

        print

    avg_st1 = round(sum(grade_st1)/len(grade_st1),2)
    avg_st2 = round(sum(grade_st2)/len(grade_st2),2)
    avg_st3 = round(sum(grade_st3)/len(grade_st3),2)
    avg_st4 = round(sum(grade_st4)/len(grade_st4),2)

    print (f"the average grades for st1 is {avg_st1}")
    print (f"the average grades for st2 is {avg_st2}")
    print (f"the average grades for st3 is {avg_st3}")
    print (f"the average grades for st4 is {avg_st4}")

    import matplotlib.pyplot as plt

    #plt.style.use('seaborn')
    fig, ax = plt.subplots()

    bar_colors = ['tab:green', 'tab:red', 'tab:orange', 'tab:blue']
    averages = [avg_st1, avg_st2, avg_st3, avg_st4]
    amounts = [len(grade_st1), len(grade_st2), len(grade_st3), len(grade_st4)]
    students = ['st1', 'st2', 'st3', 'st4']

    ax.pie(amounts, labels=students, autopct='%1.1f%%')

    plt.show()

    '''''
    ax.bar(students , averages, color = bar_colors, width = 0.4)
    ax.set_ylabel('Average grade')
    ax.set_title('Average grade for students')
    plt.show()
    '''''
import csv
grade_math = []
grade_physics = []
grade_programming = []
grades = []
filename = 'grades.csv'
with open(filename) as file:
    reader = csv.reader(file)
    header_row = next(reader)

    for row in reader:
        grade = int(row[2])
        grades.append(grade)
        student = row[0]
        subject = row[1]
        if  subject == 'math':
            grade_math.append(grade)
        elif subject == 'physics':
            grade_physics.append(grade)
        else:
            grade_programming.append(grade)

    avg_math = round(sum(grade_math)/len(grade_math),2)
    avg_physics = round(sum(grade_physics)/len(grade_physics),2)
    avg_programming = round(sum(grade_programming)/len(grade_programming),2)

    print(f"the average maths is {avg_math}")
    print (f"the average grades is {avg_physics}")
    print (f"the average grades is {avg_programming}")

    import matplotlib.pyplot as plt

    #plt.style.use('seaborn')
    fig, ax = plt.subplots()

    bar_colors = ['tab:green', 'tab:red', 'tab:orange']
    averages = [avg_math, avg_physics, avg_programming]
    subjects = ['math', 'physics', 'programming']

    ax.bar(subjects , averages, color = bar_colors, width = 0.4)
    ax.set_ylabel('Average grade')
    ax.set_title('Average grade for subjects')
    plt.show()