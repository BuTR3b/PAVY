def task_1():	
	x = float(input("x >> "))
	y = float(input("y >> "))
	if ((x * x + y * y <= 4) and (x <= y) and (x > 0)) or ((x * x + y * y >= 4) and (y <= x) and (x <= 2) and (y >= 0)):
		print("Точка входит")
	else:
		print("Не входит")

def task_2():
	x = float(input("x >> "))
	y = float(input("y >> "))
	if ((x * x + y * y <= 4) and (x >= y) and (-x <= y)) or ((y >= 0) and (-x >= y)):
		print("Точка входит")
	else:
		print("Не входит")

task_2()