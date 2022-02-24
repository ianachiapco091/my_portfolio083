# Directory (Fill Ups with Contact Number)

def Contact_Number(number):
    if len(number) != 12:
        return False
    for l in range(0, 3):
        if not number[l].isdecimal():
            return False
    if number[3] != '-':
        return False
    for l in range(4, 7):
        if not number[l].isdecimal():
            return False
    for l in range(8, 12):
        if not number[l].isdecimal():
            return False
    return True

number_dire = {'233-568-3977' : 'Colleen', '492-334-9831' :'Albert'}

while True:
    
    print("""
Enter the Full Contact Number: 
    """)
    num = input(">> ")
    
    if num == '':
        break
    
    Contact_Number(num)
    
    print("Result: ")
    if num in number_dire:
        print("You've successfully calling: " + num + '(' + number_dire[num]  + ')')
    else:
        print("It seems that directory is really outdate...")
        print("Who is the owner of this phone number? ")
        stran = input('>> ')
        number_dire[num] = stran
        print("Done!")