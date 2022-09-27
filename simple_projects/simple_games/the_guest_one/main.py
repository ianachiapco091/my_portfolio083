# imported from the Python Modules
import random, sys
import pyinputplus as pyip

# imported from the creator's own modules.
from intro_menu import Introduction
from game_fortune import fortune
from game_consequences import Consequence
from game_ends import game_ending

# assign each class into the basic labels    
intro_1 = Introduction()
intro_1.title()
intro_1.intro()
intro_1.instruction()
intro_1.start_menu()
intro_1.credit()

game_1 = fortune()
game_2 = Consequence()
game_end_1 = game_ending()


# this code below is about to start the game or just quit.
start = pyip.inputYesNo("Do you want to play this board game? ")

# indicator for the game, but never showed up until this game program starts

board_steps = 500
tsteps = 0

if start == "yes":
    
    # as the game start, the loop begins
    
    while board_steps >= tsteps:
        
        # this input that indicates based on the decision of the player
        roll = pyip.inputChoice(['roll', 'hold', 'quit'],"""

Roll ('roll' to roll them!' or 'hold' to pause the game. And enter 'quit' to leave)? """).lower()
        
        if roll == "roll":
            
            print("{{ ------------------------------------------- }}")
            
            # by using random module, these two variables can only show numbers only (from 1 to 6)
        
            dice_1 = random.randint(1, 6)
            dice_2 = random.randint(1, 6)
        
            print("{ ", dice_1, " }, { " , dice_2, " }")
        
            top = dice_1 + dice_2
            
            # that variable adds and shows to the player how many steps that ever take
            
            print(top)
            print("{{ ------------------------------------------- }}")
            steps = top
            tsteps = 0
            
            # the more steps were added, the more board_steps were decreased
            
            board_steps = board_steps - steps
            
            # when the board_steps were running out or less than 0
                            
            if board_steps <= 0:
                
                game_end_1.ending()
                
            # when the game isn't finished
                                
            else:
                print("Board Steps Left: ", "{ ", board_steps, " }")
                print("{{ ------------------------------------------- }}")
                
            # adding value to the tsteps until reaching the amount of what steps has
            
            while tsteps <= steps:
            
                tsteps += 1
                
                # one random message a time that can appear, it can be repeated
                
                if tsteps <= 4:
                    game_1.start_game_1()
                    
                else:
                    game_1.start_game_2()
                    
                if tsteps == steps:
                    # this random module can decide to choose when the player can put into fortune or fate
                
                    fortune = ["safe", "consequence"]
                    fate = random.choice(fortune)
                    print(fate)
                        
                    if fate == "consequence":
                        
                        happen = ["You are now screwed!", "Do you hear that?", "That fresh fruit is falling into you!",
                                  "There is a beehive", "Revealing one of the Guest One's Secrets",
                                  "There is something mysterious at your front...", "That nut is falling into you!"]
                        event = random.choice(happen)
                        print(event)
                        
                        # this condition with random module requires the player to have auditory imagery
                        
                        if event == "Do you hear that?":
                            
                            game_2.auditory_imagery()
                            
                        # this condition with random module gives the player one secret
                            
                        elif event == "Revealing one of the Guest One's Secrets":
                            
                            game_2.guess_one_secrets()
                            
                        # this condition with random module requires the player to have a visual imagery
                        elif event == "That fresh fruit is falling into you!":
                            
                            game_2.fruits()
                            
                            # this input function asks the player as he / she decides to keep or eat
                            
                            decision = input("Do you want to eat that (yes or no)? ").lower()
                            
                            game_2.decision_food(decision)
                            
                        elif event == "That nut is falling into you!":
                            
                            game_2.nuts()
                            
                            decision = input("Do you Keep that (yes or no)? ").lower()
                            
                            game_2.decision_food(decision)
                            
                        elif event == "There is something mysterious at your front...":
                            game_2.obstacles()
                                
                        elif event == "There is a beehive":
                            game_2.bees()
                        else:
                            game_2.other_speak()
                    else:
                        game_1.safe()
                        
        elif roll == 'hold':
            
            #this code below that was been used to paused game.
            print("Game Pause... \n\n\n\n")
            
            pause = pyip.inputYesNo("Do you want to continue?")
            
            if pause == 'yes':
                continue
        
        elif roll == 'quit':
            print("You quit the game")
            sys.exit()
    
elif start == 'no':
    sys.exit()

        
    