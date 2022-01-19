print("---- My Second Simple Calculator (Two Numbers Only) ----")

# It shows the instruction that user should enter in the "Operator" input

print("""

	For the Operator Input: 

	~ '+' for Addition

	~ '-' for Subtraction

	~ '*' for Multiplication

	~ '/' for Division

	~ '**' for Exponent

	~ '%' for Modolus Division

	~ '//' for Floor Division

	""")

while True:

# try and except blocks shows the consideration for the user who didn't enter number or digits in num1 and num2 variables
	try:
		num1 = float(input("First Number: "))
	except:
		num1 = 0
		print("First Number:", num1)

	operator = input("Operator: ")

	try:
		num2 = float(input("Second Number: "))
	except:
		num2 = 0
		print("Second Number:", num2)

#This if/elif/else conditions based on what users enter sign for the operator that calculates the user's entered two numbers

	if operator == "+":
		oper_num = num1 + num2
		print(oper_num)

	elif operator == "-":
		oper_num = num1 - num2
		print(oper_num)

	elif operator == "*":
		oper_num = num1 * num2
		print(oper_num)

	elif operator == "/":
		oper_num = num1 / num2
		print(oper_num)

	elif operator == '**':
		oper_num = num1 ** num2
		print(oper_num)

	elif operator == '%':
		oper_num = num1 % num2
		print(oper_num)

	elif operator == '//':
		oper_num = num1 // num2
		print(oper_num)

	else:
		#when the user enters that not belong to the instructions on the top of the code
		print("Error!")