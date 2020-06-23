import random
import math


def task_6(num):
	if (num <= 1):
		return 1
	else:
		return num * task_6(num - 1)

def task_2(start_num, last_num):
	all_nums = set(range(start_num, last_num + 1))
	not_primes = set()
	i = 2
	while (i ** 2 <= last_num):
		for j in range(i ** 2, last_num + 1, i):
			not_primes.add(j)
		i += 1
	primes = sorted(all_nums - not_primes)
	try:
		primes.remove(0)
		primes.remove(1)
		primes.remove(2)
	except:
		pass
	print(primes, "\n")

def task_3(steps):
	for i in range(steps):
		print("{}{}{}".format('_' * (steps - i - 1), '#' * (i * 2 + 1), '_' * (steps - i - 1)))

##########
#20.11.19#
##########
def to_base(num, base):
	return to_base(num // base, base) + str(num % base) if num >= base else str(num)

def my_split(string, delimetr):
	result = []
	s = ''
	for char in string:
		if char != delimetr:
			s += char
		elif s != '':
			result.append(s)
			s = ''
	return result

def get_primes(n):
	a = [1, 2, 3]
	if n <= 4:
		return a
	for i in range(4, n + 1):
		a.append(*[range(4, n + 1)])
	i = 2
	while i ** 2 < n:
		for i in range(i ** 2, n, i):
			a[i] = -1
		i += 1

##########
#27.11.19#
##########
def neil(n):
	array = [[0 for i in range(n)] for i in range(n)]
	turn = int(n / 2)
	i = 0
	for k in range(1, turn + 1): # проход по виткам 
		# заполнение
		for j in range(k - 1, n - k + 1): # верх гориз 
			i += 1
			array[k - 1][j] = i
		for j in range(k, n - k + 1): # правый верти
			i += 1
			array[j][n - k] = i
		for j in range(n - k - 1, k - 1, - 1): # нижний гориз
			i += 1
			array[n - k][j] = i
		for j in range(n - k - 1, k, - 1): # левый верти
			i += 1
			array[j][k - 1] = i
	if (n % 2 == 1): # индусский код
		array[turn][turn] = n ** 2
	# return array
	for i in range(n):
		for j in range(n):
			print(array[i][j], end = "\t")
		print("\n")


def game_life():
	n = int(input("n >> "))
	field = [[random.choice(('#', '+')) for i in range(n)] for i in range(n)]
	for i in range(n):
		for j in range(n):
			print(field[i][j], end = ' ')
		print("\n")


def task_seq():
	n = int(input("n >> "))
	summa = 0
	for i in range(n):
		if (i % 2 == 0):
			summa += i
		else:
			summa += i * -1
		print(summa)

def task_array():
	n = int(input("n >> "))
	array = [int(input(">> ")) for i in range(n)]
	num = 1
	for i in range(n):
		num *= array[i]
	for i in range(n):
		array[i] = num * (array[i] ** -1)
	print(array)

def array_3():
	n = int(input("n >> "))
	array = [int(input(">> ")) for i in range(n)]
	array_proizv = []
	# proizv = 1
	for i in range(n):
		for j in range(i, n):
			for k in range(j, n):
				proizv = array[k] * array[j]
				array_proizv.append(proizv)
			proizv = 1
	print(array_proizv)

def q1():
	summa = 0
	n = int(input(">> "))
	m = int(input(">> "))
	if m == 0:
		return 1
	if m == 1:
		return n
	while n > 1:
		n = (n - m) + 1
		if (n > 0):
			summa += n
		return summa

def trees():
	class Node:
		def __init__(self, value):
			self.value = value
			self.left = None
			self.right = None
			self.parent = None
		def print_str(self):
			return self.value

	class tree(object):
		def __init__(self, root):
			self.root = None
		def _add_value(self, node, value):
			if node == None:
				node = Node(value)
				return 
			if self.value < node.value:
				if node.left == None:
					node.left = Node(value)
			else:
				_add_value(value, node.left)
		def add(self, value):
			_add_value(value, root)
		def _print_tree(self):
			# if self.root == None:
			# 	return ''
			# node = self.root
			# while node.left != None:
			# 	node = node.left
			if node != None:
				yield node
				_print_tree(node, left)
				_print_tree(node, right)

		def print_tree(self):
			if self.root == None:
				return ''
			return _print_tree(root)

	b = tree()


def main():
	trees()

main()

# бинарное дерево