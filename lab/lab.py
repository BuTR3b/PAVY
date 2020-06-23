import random
import matplotlib.pyplot as plt

QS_compare = 0
QS_transpos = 0

def bubble_sort(array):
	compare = 0
	transpos = 0
	for i in range(len(array) - 1):
		for j in range(len(array) - 1):
			compare += 1
			if (array[j] > array[j + 1]):
				array[j], array[j + 1] = array[j + 1], array[j]
				transpos += 1
	return (compare, transpos)

def bubble_super_sort(array):
	compare = 0
	transpos = 0
	for i in range(len(array)):
		swaped = False
		for j in range(len(array) - i - 1):
			compare += 1
			if (array[j] > array[j + 1]):
				array[j], array[j + 1] = array[j + 1], array[j]
				transpos += 1
				swaped = True
		if (not swaped):
			break
	return (compare, transpos)

def selection_sort(array):
	compare = 0
	transpos = 0
	for i in range(len(array)):
		smallest = i
		for j in range(i + 1, len(array)):
			compare += 1
			if (array[smallest] > array[j]):
				smallest = j
		if (smallest != i):
			array[i], array[smallest] = array[smallest], array[i]
			transpos += 1
	return (compare, transpos)

def insert_sort(array):
	compare = 0
	transpos = 0
	for i in range(len(array)):
		tmp = array[i]
		key = i
		compare += 1
		while (key > 0 and array[key - 1] > tmp):
			key -= 1
			array[key + 1], array[key] = array[key], array[key + 1]
			# compare += 1
			transpos += 1
		array[key] = tmp
	return (compare, transpos)

def shaker_sort(array):
	compare = 0
	transpos = 0
	for i in range(len(array) // 2):
		j = 0
		while (j < len(array) - 1):
			compare += 1
			if (array[j] > array[j + 1]):
				array[j], array[j + 1] = array[j + 1], array[j]
				transpos += 1
			j += 1
		j = len(array) - 2
		while (j > 0):
			compare += 1
			if (array[j] > array[j + 1]):
				array[j], array[j + 1] = array[j + 1], array[j]
				transpos += 1
			j -= 1
	return (compare, transpos)

def shell_sort(array):
	compare = 0
	transpos = 0
	step = int(len(array) // 2)
	while (step > 0):
		for i in range(len(array)):
			tmp = array[i]
			key = i
			compare += 1
			while (key > step - 1 and array[key - step] > tmp):
				key -= step
				array[key + step] = array[key]
				# compare += 1
				transpos += 1
			array[key] = tmp
		step = int(step / 2)
	return (compare, transpos)

def quick_sort(array, start, finish):
	if (len(array) < 2):
		return array
	global QS_compare
	global QS_transpos
	mean = array[(start + finish) // 2]
	left = start
	right = finish
	while (left < right):
		while (array[left] < mean):
			left += 1
			QS_compare += 1
		while (array[right] > mean):
			right -= 1
			QS_compare += 1
		if (left <= right):
			array[left],array[right] = array[right], array[left]
			left += 1
			right -= 1
			QS_transpos += 1
	if (start < right):
		quick_sort(array, start, right)
	if (left < finish):
		quick_sort(array, left, finish)
	return (QS_compare, QS_transpos)

def stupid_sort(array):
	compare = 0
	transpos = 0
	i = 1 
	size = len(array)
	while i < size:
		transpos += 1
		if array[i - 1] > array[i]:
			array[i - 1], array[i] = array[i], array[i - 1]
			compare += 1
			i = 1
		else:
			i += 1
	return (compare, transpos)

def compare_graphic(x, y):
	fig = plt.figure()
	ax = fig.add_subplot(111)
	ax.set_title("Сравнения")
	ax.set_ylabel("Кол-во сравнений")
	ax.set_xlabel("Размер массивов")
	ax.plot(x, y[:6], label = "Пузырёк", color = "orange", linewidth = 4)
	ax.plot(x, y[6:12], label = "Пузырёк+", color = "r", linewidth = 4)
	ax.plot(x, y[12:18], label = "Выборка", color = "y", linewidth = 4)
	ax.plot(x, y[18:24], label = "Вставка", color = "g", linewidth = 4)
	ax.plot(x, y[24:30], label = "Шейкер", color = "c", linewidth = 4)
	ax.plot(x, y[30:36], label = "Шелла", color = "m", linewidth = 4)
	ax.plot(x, y[36:42], label = "Быстрая", color = "k", linewidth = 4)
	ax.plot(x, y[42:48], label = "Глупая", color = "b", linewidth = 4)
	plt.grid(True)
	plt.legend()
	plt.savefig("COMPARE.png")
	plt.show()

def transpos_graphic(x, y):
	fig = plt.figure()
	ax = fig.add_subplot(111)
	ax.set_title("Перестановки")
	ax.set_ylabel("Кол-во перестановок")
	ax.set_xlabel("Размер массивов")
	ax.plot(x, y[:6], label = "Пузырёк", color = "orange", linewidth = 2)
	ax.plot(x, y[6:12], label = "Пузырёк+", color = "r", linewidth = 2)
	ax.plot(x, y[12:18], label = "Выборка", color = "y", linewidth = 2)
	ax.plot(x, y[18:24], label = "Вставка", color = "g", linewidth = 2)
	ax.plot(x, y[24:30], label = "Шейкер", color = "c", linewidth = 2)
	ax.plot(x, y[30:36], label = "Шелла", color = "m", linewidth = 2)
	ax.plot(x, y[36:42], label = "Быстрая", color = "k", linewidth = 2)
	ax.plot(x, y[42:48], label = "Глупая", color = "b", linewidth = 2)
	plt.grid(True)
	plt.legend()
	plt.savefig("TRANSPOS.png")
	plt.show()

def main():

	array_sizes = (5, 10, 15, 20, 25, 30)

	bubble_data = []
	bubble_super_data = []
	selection_data = []
	insert_data = []
	shaker_data = []
	shell_data = []
	quick_data = []
	stupid_data = []
	all_data = []
	compare_data = []
	transpos_data = []

	bubble_compare = 0
	bubble_transpos = 0
	bubble_super_compare = 0
	bubble_super_transpos = 0
	selection_compare = 0
	selection_transpos = 0
	insert_compare = 0
	insert_transpos = 0
	shaker_compare = 0
	shaker_transpos = 0
	shell_compare = 0
	shell_transpos = 0
	quick_compare = 0
	quick_transpos = 0
	global QS_compare
	global QS_transpos
	stupid_compare = 0
	stupid_transpos = 0

	for i in range(5, 35, 5):
		for j in range(10):
			array_1 = [random.randint(-100, 100) for k in range(i)]
			array_2 = array_1[:]
			array_3 = array_1[:]
			array_4 = array_1[:]
			array_5 = array_1[:]
			array_6 = array_1[:]
			array_7 = array_1[:]
			array_8 = array_1[:]

			bubble_nums = bubble_sort(array_1)
			bubble_compare += bubble_nums[0]
			bubble_transpos += bubble_nums[1]

			bubble_super_nums = bubble_super_sort(array_2)
			bubble_super_compare += bubble_super_nums[0]
			bubble_super_transpos += bubble_super_nums[1]

			selection_nums = selection_sort(array_3)
			selection_compare += selection_nums[0]
			selection_transpos += selection_nums[1]

			insert_nums = insert_sort(array_4)
			insert_compare += insert_nums[0]
			insert_transpos += insert_nums[1]

			shaker_nums = shaker_sort(array_5)
			shaker_compare += shaker_nums[0]
			shaker_transpos += shaker_nums[1]

			shell_nums = shell_sort(array_6)
			shell_compare += shell_nums[0]
			shell_transpos += shell_nums[1]

			quick_nums = quick_sort(array_7, 0, len(array_7) - 1)
			quick_compare += quick_nums[0]
			quick_transpos += quick_nums[1]
			QS_compare = 0
			QS_transpos = 0

			stupid_nums = stupid_sort(array_8)
			stupid_compare += stupid_nums[0]
			stupid_transpos += stupid_nums[1]
			

		bubble_data.append((bubble_compare / 10, bubble_transpos / 10))
		bubble_compare = 0
		bubble_transpos = 0

		bubble_super_data.append((bubble_super_compare / 10, bubble_super_transpos / 10))
		bubble_super_compare = 0
		bubble_super_transpos = 0

		selection_data.append((selection_compare / 10, selection_transpos / 10))
		selection_compare = 0
		selection_transpos = 0

		insert_data.append((insert_compare / 10, insert_transpos / 10))
		insert_compare = 0
		insert_transpos = 0

		shaker_data.append((shaker_compare / 10, shaker_transpos / 10))
		shaker_compare = 0
		shaker_transpos = 0

		shell_data.append((shell_compare / 10, shell_transpos / 10))
		shell_compare = 0
		shell_transpos = 0

		quick_data.append((quick_compare / 10, quick_transpos / 10))
		quick_transpos = 0
		quick_compare = 0

		stupid_data.append((stupid_compare / 10, stupid_transpos / 10))
		stupid_compare = 0
		stupid_transpos = 0
	
	all_data.append(bubble_data)
	all_data.append(bubble_super_data)
	all_data.append(selection_data)
	all_data.append(insert_data)
	all_data.append(shaker_data)
	all_data.append(shell_data)
	all_data.append(quick_data)
	all_data.append(stupid_data)

	for i in range(len(all_data)):
		for j in range(len(all_data[i])):
			compare_data.append(all_data[i][j][0])
			# print(i, all_data[i][j])
			transpos_data.append(all_data[i][j][1])

	compare_graphic(array_sizes, compare_data)
	transpos_graphic(array_sizes, transpos_data)

main()
