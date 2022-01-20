import random

player_num = 0
secret_num = random.randint(1, 100)
al_guess = 0
rem_guess = 15

print("I am thinking of a number between 1 to 100")

while al_guess <= rem_guess:
    
    player_num = int(input("Enter a guess number: "))
    al_guess = al_guess + 1
    
    if player_num < secret_num:
        print("OK, but your guess number is lower...")
        
        if al_guess == rem_guess:
            print("I am so sorry, you didn't guess that number...")
            print("And that number is: ", secret_num, "... Better luck next time...")
            break
            
    
    elif player_num > secret_num:
        print("Well, but your guess number is higher...")
        
        if al_guess == rem_guess:
            print("I am so sorry, you didn't guess that number...")
            print("And that number is: ", secret_num, "... Better luck next time...")
            break
        
    elif player_num == secret_num:
        print("You finally guess that number at " , al_guess, " guesses!")
        break