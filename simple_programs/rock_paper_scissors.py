import random, sys

print("Rock! Paper! Scissors!")

win = 0
lose = 0
tie = 0

print("~~ -{ WINS: ", win, "LOSSES: ", lose, "TIES: ", tie, "}- ~~")

while True:
    print("""          
'r' for ROCK, 'p' for PAPER, 's' for SCISSORS, or 'q' for QUIT
    """)
    
    action = str(input("==> "))
    
    if action == 'r':
        
        gestu_play = "ROCK"
        print(gestu_play)
        
    elif action == 'p':
        
        gestu_play = "PAPER"
        print(gestu_play)
        
    elif action == 's':
        
        gestu_play = "SCISSORS"
        print(gestu_play)

    elif action == 'q':
        sys.exit()
        
    print("versus...")
    
    # To display the Computer's Turn
        
    computer_act = ['r', 'p', 's']
    computer_resp = random.choice(computer_act)
        
    if computer_resp == 'r':
        
        gestu_comp = "ROCK"
        print(gestu_comp)
        
    elif computer_resp == 'p':
        
        gestu_comp = "PAPER"
        print(gestu_comp)
        
    elif computer_resp == 's':
        
        gestu_comp = "SCISSORS"
        print(gestu_comp)
        
    # To display the results (wins, losses, ties)
    
    if gestu_play == gestu_comp:
        
        print("TIE!")
        tie = tie + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'ROCK' and gestu_comp == 'SCISSORS':
        
        print("PLAYER WINS!")
        win = win + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'PAPER' and gestu_comp == 'ROCK':
        
        print("PLAYER WINS!")
        win = win + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'SCISSORS' and gestu_comp == 'PAPER':
        
        print("PLAYER WINS!")
        win = win + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'ROCK' and gestu_comp == 'PAPER':
        
        print("COMPUTER WINS!")
        lose = lose + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'PAPER' and gestu_comp == 'SCISSORS':
        
        print("COMPUTER WINS!")
        lose = lose + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)
        
    elif gestu_play == 'SCISSORS' and gestu_comp == 'ROCK':
        
        print("COMPUTER WINS!")
        lose = lose + 1
        print("WINS: ", win, "LOSSES: ", lose, "TIES: ", tie)