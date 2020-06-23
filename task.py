##############
# 11.09.2019 #
##############

import random

def task3():
    print("Задача №3\n")
    cubeEdge = int(input("Ребро куба: "))
    V = cubeEdge ** 3
    S = (cubeEdge ** 2) * 4
    print("Объем куба - {}, площадь боковой поверхности - {}\n".format(V, S))

def task4():
    print("Задача №4\n")
    num1 = int(input("Первое число: "))
    num2 = int(input("Второе число: "))
    arithMean = (num1 + num2) / 2
    geomMean = (num1 * num2) ** 0.5
    print("Среднее арифметическое - {}, среднее геометрическое - {}\n".format(arithMean, geomMean))

def task6():
    print("Задача №6\n")
    katet1 = int(input("Первый катет: "))
    katet2 = int(input("Второй катет: "))
    gip = (katet1 ** 2 + katet2 ** 2) ** 0.5
    S = (katet1 * katet2) / 2
    print("Гипотенуза - {}, площадь - {}".format(round(gip, 2), S))
##############
# 18.09.2019 #
##############
def task24():
    x1 = int(input("x1 = "))
    y1 = int(input("y1 = "))
    x2 = int(input("x2 = "))
    y2 = int(input("y2 = "))
    dist = ((x2 - x1) ** 2 + (y2 - y1) ** 2) ** 0.5
    print("Расстояние = ", round(dist, 2), "\n\n")

def task25():
    x1 = int(input("x1 = "))
    y1 = int(input("y1 = "))
    x2 = int(input("x2 = "))
    y2 = int(input("y2 = "))
    x3 = int(input("x3 = "))
    y3 = int(input("y3 = "))
    a = ((x2 - x1) ** 2 + (y2 - y1) ** 2) ** 0.5
    b = ((x3 - x2) ** 2 + (y3 - y2) ** 2) ** 0.5
    c = ((x3 - x1) ** 2 + (y3 - y1) ** 2) ** 0.5
    if ((a <= 0) or (b <= 0) or (c <= 0)):
        print("Сторона меньше или равна нулю\n\n")
    else:
        P = a + b + c
        p = P / 2
        S = (p * (p - a) * (p - b) * (p - c)) ** 0.5
        print("Периметр = {}\nПлощадь = {}\n\n".format(P, S))

def task31():
    a = int(input("Число: "))
    # Ж) #
    b = a * a * a #1
    c = b * b     #2
    d = c * b     #3
    c = d * b     #4
    J = a * c     #5
    # З) #
    b = a * a     #1
    c = b * a     #2
    d = c * c     #3
    b = d * d     #4
    Z = c * b     #5
    # Л) #
    a = a * a     #1
    a = a * a     #2
    a = a * a     #3
    a = a * a     #4
    a = a * a     #5
    L = a * a     #6
    print("ж) a ^ 13 = {} \nз) a ^ 15 = {} \nл) a ^ 64 = {}\n\n".format(J, Z, L))

def task54():
    x1 = int(input("x1 = "))
    y1 = int(input("y1 = "))
    x2 = int(input("x2 = "))
    y2 = int(input("y2 = "))
    x3 = int(input("x3 = "))
    y3 = int(input("y3 = "))
    A = (y3 - y2) * (x1 - x2) - (y1 - y2) * (x3 - x2)
    B = (y1 - y3) * (x2 - x3) - (y2 - y3) * (x1 - x3)
    C = (y2 - y1) * (x3 - x1) - (y3 - y1) * (x2 - x1)
    BC = (y3 - y2) * (0 - x2) - (0 - y2) * (x3 - x2)
    CA = (y3 - y1) * (0 - x1) - (0 - y1) * (x3 - x1)
    AB = (y2 - y1) * (0 - x1) - (0 - y1) * (x2 - x1)
    if ((y2 - y1) * (x3 - x1) - (y3 - y1) * (x2 - x1) == 0):
        print("Не треугольник\n\n")
    elif ((BC * A >= 0) and (CA * B >= 0) and (AB * C >= 0)):
        print("Начало координат принадлежит треугольнику\n\n")
    else:
        print("Точка н епринадлежит\n\n")

def task56():
    Wall_1 = int(input("Введите длину отверстия: "))
    Wall_2 = int(input("Введите ширину отверстия: "))
    Brick_1 = int(input("Введите длину кирпича: "))
    Brick_2 = int(input("Введите ширину кирпича: "))
    Brick_3 = int(input("Введите высоту кирпича: "))
    if (((Wall_1 >= Brick_1) and (Wall_2 >= Brick_2)) or (((Wall_1 >= Brick_2) and (Wall_2 >= Brick_3))) or (((Wall_1 >= Brick_1) and (Wall_2 >= Brick_3)))):
        print("Кирпич пройдет\n\n")
    else:
        print("Кирпич не пройдет\n\n")
##############
# 02.10.2019 #
##############
def task77():
    import math
    num1 = 0
    znam = 0
    n = int(input("г) Введите N: "))
    for i in range(n):
        znam += math.sin(i)
        num1 += 1 / (znam + math.sin(i + 1))

    n = int(input("ж) Введите N: "))
    num2 = (3 * n) ** 0.5
    for i in range(1, n):
        n -= 1
        num2 = (3 * n + num2) ** 0.5
    print("г) {}, ж) {}\n".format(num1, num2))

def task82():
    x = int(input("Введите Х : "))
    num3 = 1
    if (x < 65):
        print("Деление на 0")
    else:
        for i in range(1, 65):
            if (i % 2 == 0):
                num3 *= (x - i) / (x - (i + 1))
            else:
                num3 *= (x - (i + 1)) / (x - i)
        print("Ответ - ", num3)
##############
# 09.10.2019 #
##############
def task0():
    user_input = int(input("Сколько яблок? \n>> "))
    user_input1 = user_input % 10
    user_input2 = user_input % 100
    if ((user_input1 == 1) and (user_input2 != 11)):
        print("У вас -", user_input, "яблоко\n")
    elif (user_input1 >= 2 and user_input1 <= 4 and (user_input2 < 10 or user_input2 >= 20)):
        print("У вас -", user_input, "яблока\n")
    else:
        print("У вас -", user_input, "яблок\n")


def task84():
    import math
    n = int(input("n = "))
    x = int(input("x = "))
    sinx = math.sin(x)
    res = sinx
    for i in range(1, n):   
        sinx = math.sin(sinx)
        res = res + sinx
    print("Ответ -", res, "\n")


def euclidean_algorithm(num1, num2):
    while num1 != num2:
        if num1 > num2:
            num1 = num1 - num2
        else:
            num2 = num2 - num1        
    return num1

def task89():
    n = int(input("n = "))
    m = int(input("m = "))
    if ((n > 0) and (m > 0)):
        print("Ответ -", euclidean_algorithm(n, m))
    else:
        print("Число(а) меньше 0")

##############
# 23.10.2019 #
##############
def task91():
    n = int(input("n >> "))
    a0 = 1
    for i in range(1, n + 1):
        a = i * a0 + 1 / i
        a0 = a
    print(a)


def task93():
    x0 = int(input("c >> "))
    x1 = int(input("d >> "))
    q = int(input("q >> "))
    r = int(input("r >> "))
    b = int(input("b >> "))
    n = int(input("n (n >= 2) >> "))
    # x = q * x1 + r * x0 + b
    for i in range(2, n + 1):
        x = q * x1 + r * x0 + b
        x0 = x1
        x1 = x
    print(x)


def task97():
    import math
    x1, y1 = 1, 1
    n = int(input("n >> "))
    for i in range(2, n + 1):
        x = 0.3 * x1
        y = x1 + y1
        x1 = x
        y1 = y
    ans = x / (1 + math.fabs(y))
    print(ans)
    # print(0.3 / 3)


def task_101():
    import math
    num_a = int(input("a = "))
    num_x = int(input("x = "))
    num_e = int(input("e = "))
    y0 = num_a
    yi = (y0 + num_x / y0) / 2
    i = 1
    while (math.fabs(yi ** 2 - y0 ** 2) >= num_e):
        y0 = yi
        yi = (y0 + num_x / y0) / 2
        i += 1
    print(yi)


def task_102():
    import math
    i = 1
    x0 = 1
    xn = (2 - x0 ** 3) / 5
    while (math.fabs(xn - x0) >= 10 ** -5):
        x0 = xn
        xn = (2 - x0 ** 3) / 5
        i += 1
    print(xn, i)


def task_103(): # ???
    import math
    num_e = float(input("e = "))
    y0 = 1
    yn = (y0 + 1) / (y0 + 2)
    while(not(yn - y0 < num_e)):
        y0 = yn
        yn = (y0 + 1) / (y0 + 2)
    print(yn)


def class_work_old():
    import math
    x = float(input("x = "))
    n = int(input("n = "))

    if (x > 0):
        num_1 = math.sqrt(5 * x)
        for i in range(2, n + 1):
            num_1 = math.sqrt(5 * i + num_1)
        print(num_1)

    else:
        # num_2 = math.sin(x)
        summa = 0
        # summa += num_2
        for i in range(1, n + 1):
            num_2 = math.sin(x ** i)
            for j in range(2, i + 1):
                num_2 = num_2 + math.sin(num_2)
                # summa += num_2
        print(num_2)


def class_work_1():
    eps = float(input(">> "))
    ai = 2 / 3
    fact = 1
    fact2 = 2
    summa = ai
    i = 1
    while(not(ai > eps)):
        ai = (2 * fact) / (3 * fact2)
        i += 1
        fact *= i
        fact2 *= 2 * i * (2 * i - 1)
        summa += ai
    print(summa)


# def class_work():
#     import math
#     eps = float(input(">> "))
#     a_last = 0.5
#     b_last = 0.5
#     a = 2 * b_last + a_last
#     b = 2 * math.pow(a_last, 2) + b_last
#     s1 = (a_last + b_last) / (2 + a_last ** 2 + b_last ** 2)
#     s_last = (a + b) / (2 + a ** 2 + b ** 2)
#     while (not(math.fabs())):
#         pass


def task_kp_13():
    import math
    n = int(input("n >> "))
    num_1 = 0
    for i in range(n, 0, -1):
        num_1 = math.sqrt(num_1 + 3 ** (2 * i))
    print(num_1, "\n\n")

    n = int(input("n >> "))
    x = float(input("X >> "))
    min_raznost = 1000000
    otv = None
    for i in range(1, n + 1):
        num_2 = math.exp(math.cos(x ** (2 * i))) * math.sin(x ** (3 * i))
        zahlen = round(num_2)
        raznost = math.fabs(math.fabs(zahlen) - math.fabs(num_2))
        # print("\nЧисло - {} \nБлижайшее - {} \nРазность - {}".format(num_2, zahlen, raznost))
        if (min_raznost > raznost):
            min_raznost = raznost
            otv = num_2
    print(otv)


def class_work_2():
    import random
    array = [random.randint(-100, 100) for i in range(100)]
    print(array)
    summa = 0
    for i in range(len(array)):
        if (array[i] % 2 == 0):
            summa += array[i]
    print(summa)

    max_num = array[0]
    for i in range(0, len(array), 2):
        if (max_num < array[i]):
            max_num = array[i]
    print(max_num)

    min_num = array[0]
    for i in range(1, len(array), 2):
        if (min_num > array[i]):
            min_num = array[i]
    print(min_num)

    for i in range(len(array)):
        if (array[i] < 0):
            array[i] = (array[i] ** 2) * (-1)
    print(array)


def class_work_3():
    import random
    array = [random.randint(-100, 100) for i in range(10)]
    array_2 = []
    print(array)
    max_len = 0
    for i in range(len(array)):
        if (array[i] > 0):
            max_len += 1
        else:
            array_2.append(max_len)
            max_len = 0
            
    max_num = array_2[0]
    for i in range(len(array_2)):
        if (max_num < array_2[i]):
            max_num = array_2[i]
    print(max_num)


def task_286():
    import random
    array_1 = [random.randint(-10, 10) for i in range(100)]
    array_2 = []
    print(array_1)
    max_num = array_1[0]

    for i in range(len(array_1)):
        if (max_num < array_1[i]):
            max_num = array_1[i]
    # print(max_num)
    
    for i in range(len(array_1)):
        if (max_num != array_1[i]):
            array_2.append(array_1[i])
    print(array_2)


def task_287():
    import random
    n = int(input("n >> "))
    array_1 = [random.randint(-10, 10) for i in range(n)]
    array_2 = []
    print(array_1)
    max_num = array_1[0]

    for i in range(len(array_1)):
        if (max_num < array_1[i]):
            max_num = array_1[i]

    print(max_num)
    is_max = False

    for i in range(len(array_1)):
        if ((i % 2 == 0) and (array_1[i] != max_num) and not(is_max)):
            array_1[i] *= max_num
        elif (array_1[i] == max_num):
            is_max = True
    print(array_1)


def task_288():
    n = int(input("n >> "))
    array_all = []
    array_minus = []
    znak = True
    var_1 = int(input(">> "))
    tmp = var_1

    if (var_1 > 0):
        array_all.append(var_1)
    else:
        array_all.append(var_1)
        array_minus.append(var_1)

    for i in range(n):
        num = int(input(">> "))
        if (num > 0):
            array_all.append(num)
        else:
            array_all.append(num)
            array_minus.append(num)
        if (tmp * num > 0):
            znak = False
        tmp = num

    if (znak == True):
        print(array_all)
    else:
        print(array_minus)


def class_work():
    import random
    n = int(input(">> "))
    array = [random.randint(1, 100) for i in range(n)]
    print(array)
    array_3 = []
    array_5 = []
    summa_5 = 0
    prozv_3 = 1
    for i in range(len(array)):
        if (array[i] % 3 == 0):
            array_3.append(array[i])
        elif (array[i] % 5 == 0):
            array_5.append(array[i])
    for i in range(len(array_3)):
        prozv_3 *= array[i]
    for i in range(len(array_5)):
        summa_5 += array_5[i]
    try:
        arif = round(summa_5 / len(array_5))
        geom = prozv_3 ** (1/len(array_3))
    except:
        arif = "нет"
        geom = "нет"
    print("Сред ариф = ", arif, "\nСред геом", geom)


    min_num = array[0]
    for i in range(len(array)):
        if (min_num > array[i]):
            min_num = array[i]
    min_i = array.index(min_num)
    try:
        array[min_i] = array[min_i - 1] + array[min_i + 1]
    except:
        array[min_i] = array[min_i - 1]
    finally:
        array[min_i] = array[min_i + 1]
    print(array)    
    
##########
#27.11.19#
##########
def task_292():
    array = [random.randint(-100, 100) for i in range(20)]
    print(array)
    for i in range(10):
        if (array[i] < array[i + 10]):
            tmp = array[i]
            array[i] = array[i + 10]
            array[i + 10] = tmp
    print(array)


def task_300():
    array = [random.randint(-100, 100) for i in range(int(input("n >> ")))]
    array_b = []
    print(array)
    for i in range(1, 11):
        try:
            elem = array[i - 1] + array[i]
            array_b.append(elem)
        except:
            array_b.append(0)
    print(array_b)


def task_302():
    n = input(">> ")
    nums = set()
    for i in range(len(n)):
        nums.add(int(n[i]))
    print("Различных цифр - {}".format(len(nums)))


def main():
    task_292()
    # task_300()
    # task_302()

main()

# список размером 5-30 шаг 5 сортируем 10 раз 
# считаем кол-во сравнений и перестановок
# считаем среднее знач перестановок
# строим графики 
# пузырь+ если перестановок нет, то список отсортирован
# график: х - размер массива, у1 - сравнения, у2 - перестановки 