import random, sys
import pyinputplus as pypi

pick_list = []
des = pypi.inputYesNo("Want to Create Choice? ")

if des == 'yes':
    print("Create One Choice: ")
    while True:
        choice = input(">> ")
        pick_list.append(choice)
        
        if choice == '':
            print("The Choice Creator is now Closed!")
            break
        else:
            continue
    
    print(pick_list)
    while True:
        deci = pypi.inputYesNo("Random Pick based on the Choice above? ")
    
        if deci == 'yes':
            roll = random.choice(pick_list)
            print("""
---------------------------------------------------------------------
""")
            print("You got: ",roll)
        else:
            break
    
else:
    sys.exit()