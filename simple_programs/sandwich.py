# This small program is the project that I had already solved
# From the practice project : Sandwich Maker
# Automate the Boring Stuff with Python by Al Sweigart

import sys
import pyinputplus as pyip

prices = {'wheat': 2.00, 'white': 1.05, 
          'sourdough': 4.00,'chicken': 3.00,
          'turkey': 5.00, 'ham': 2.00,
          'egg': 0.50, 'bacon': 1.00,
          'sausage': 1.00, 'fillet': 0.80,
          'tofu': 4.50,'cheddar': 4.00, 
          'swiss': 6.50, 'mozzarella': 4.50,
          'mayo': 0.05, 'mustard': 0.20,
          'lettuce': 2.50, 'tomato': 1.50,
          'catsup': 0.02}

order = []
extra = ['mayo', 'mustard', 'lettuce', 'tomato', 'catsup']
total = 0.00

while True:
    bread = pyip.inputMenu(['wheat', 'white', 'sourdough'],
                           'Choose one type of bread: ''\n')
    order.append(bread)

    protein = pyip.inputMenu(['chicken', 'turkey', 'ham', 'tofu',
                              'egg', 'bacon', 'sausage', 'fillet'],
                             'Choose one protein: ''\n')
    order.append(protein)

    cheese_opt = pyip.inputYesNo('Want some cheese? ')

    if cheese_opt == 'yes':
        cheese = pyip.inputMenu(['cheddar', 'swiss', 'mozzarella'],
                                'Choose one type of cheese: ''\n')
        order.append(cheese)
        
    else:
        cheese = ''
        
    extra_opt = pyip.inputYesNo('Want some extra? ')
    
    if extra_opt == 'yes':
        for g in extra:
            respo = pyip.inputYesNo(g + ', you want? ')
            if respo == 'yes':
                order.append(g)

    sand_count = pyip.inputInt(prompt='How many sandwiches? ', min=1)
    
    print('\n\n' 'Your Order: ''\n')
    for items in order:
        if items in prices.keys():
            total += prices.get(items)
            print(items + ' - $' + str(prices.get(items)))
    
    print('\n' + 'Total Price per Sandwich: ' + str(total))
    print('\n' + 'Total Price of your Order: ' + str(total * sand_count))
    print("""
---------------------------------------------------------------------------------""")
    command = pyip.inputMenu(['continue', 'exit'], "Command (continue or exit): "'\n')
    
    if command == 'continue':
        continue
    elif command == 'exit':
        break
        sys.exit()