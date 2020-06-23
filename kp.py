# Ржевский В. С. гр. 1013 вариант 10-19
import math

def task_1():
	n = int(input("n >> "))
	summa = 0
	for i in range(n + 1):
		summa += ((2 ** i ) * math.pow(-1, i)) / math.factorial(i)
	return summa

def task_2():
	x0 = 1
	x1 = 1
	k = 2
	eps = float(input("eps >> "))
	xk = (3 - x0 ** 3) / 5
	while (not(math.fabs(xk - x0) < eps)):
		# print("x0 = {} x1 = {} xk = {}".format(x0, x1, xk))
		k += 1
		x0 = x1
		x1 = xk
		xk = (3 - x0 ** 3) / 5
	print(x0, x1)
	print(xk, "\t", k)

def main():
	print(task_1())
	task_2()

main()
