
import random

class Introduction:
    
    def title (self):
        title_1 = """
        
        ~~ | ~~ Dice Game (Story 1): The Guest One ~~ | ~~
        
        """
        
        return print(title_1)
    
    def intro(self):
        statement = """
        -- There is something awful when the apperance of a
        student, who dared herself for being called the guest one in the class.
        Despite of being lonely, she can interrupt herself by talking all alone,
        and writing something on her works. And there is a simple game called
        Dice Game, that is made from her without looking at the tutorials. The
        codes seem common, but learned. -- 
        
        """
        
        return print(statement)
    
    def instruction(self):
        intruc = """ 
        -- Instruction to Play this Game: type 'roll' for
        rolling two dices to show the result. Feels like board game but without
        any physical images, only typing. The speaker will tell you where
        your character stands and there are some consequences that once you step
        into it. Let's get started! -- 
        
        """
        
        return print(intruc)
    
    def credit(self):
        credt = """ 
        
        ~~ This Project belongs to the Owner's Portfolio ~~~
        
        """
        
        return print(credt)
    
    def start_menu(self):
        start = """ 
                [ s ] for start
                [ e ] for exit
                """
        
        return print(start)
    
intro_1 = Introduction()
intro_1.title()
intro_1.intro()
intro_1.instruction()
intro_1.start_menu()

intro_1.credit()

start = str(input("Enter (s or e): ")).lower()

# indicator for the game, but never showed up until this game program starts

board_steps = 500
tsteps = 0
space = 150


if start == "s":
    
    # as the game start, the loop begins
    
    while board_steps >= tsteps:
        
        # this input that indicates based on the decision of the player
        roll = input("""

Roll ('yes' to roll them!' or 'no' to leave the entire game)? """).lower()
        
        if roll == "yes":
            
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
                
                banne = ["Congratulation, you are just finish the game!", "That's what I ever said to you!",
                         "After you finish this, I will show up!", "Keep in Touch!", "What a Good Player!"]
                
                adver = random.choice(banne)
                print(adver)
                
                print("""
                      
                      || --- ~~ Game Menu ~~ --- ||
                      
            Type 'sec' if you want to go to the Guest One's Secrets
            
            Type 'habit' if you want to go to the Guest One's Habits
            
            Type 'works' if you want to go to the My Works List
            
            Type 'note' if you want to the Self Conversation
            
            """)
            
            # when the game isn't finished
                                
            else:
                print("Board Steps Left: ", "{ ", board_steps, " }")
                
                print("{{ ------------------------------------------- }}")
            
            
            # adding value to the tsteps until reaching the amount of what steps has
            
            while tsteps <= steps:
            
                tsteps += 1
                
                # one random message a time that can appear, it can be repeated
                
                if tsteps <= 4:
            
                    messages = ["There could be much easier than before...", "You are taking much place right away!",
                                "Why couldn't telling you about this?", "I think that this game could be better next time...",
                                "You can ask yourself why...", "I think that could be right time to tell you...",
                                "Be careful, you can now steping something unpleasant..."]
                    text = random.choice(messages)
                    print(text)
                    
                else:
                    
                    messages = ["Once you step in, you never come there again...", "There is a time, well yeah...",
                                "The sun goes into the straight line, don't you?", "You step into tall grass...",
                                "Time starts since the last time you step in...", "Can I have something?",
                                "Everything takes patient so I will wait for it...", "You can do that!"]
                    text = random.choice(messages)
                    print(text)
                    
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
                            conseq = ["*The Unusual Echo!*", "*Crying Mockingbird*", "*Train crosses the rails*",
                                      "*Tearing Sound of the Tree Branch*", "A Wild Boar", "*whistle*"]
                            
                            respon = random.choice(conseq)
                            print("You Hear: ", respon)
                            
                        # this condition with random module gives the player one secret
                            
                        elif event == "Revealing one of the Guest One's Secrets":
                            conseq = ["See the Primal Horror (Sp1ad_!@)", "When I Touch a Latched Knob (rlP_0I;N)",
                                      "Come Back! (eI_eN16<)", "Tired of Tutorials (^$n_/xi=)", "Programmin Habit (BKo!%*19)",
                                      "My Talents (anG&rtW1)", "Keep an Eye to You (sdE-90Fv)"]
                            
                            respon = random.choice(conseq)
                            print("You Got: ", respon)
                            
                        # this condition with random module requires the player to have a visual imagery
                        elif event == "That fresh fruit is falling into you!":
                            conseq = ["Coconut", "Mango", "Apple", "Grapefruit", "Dragonfruit", "Orange", "Lemon", "Lime",
                                      "Passion Fruit"]
                            
                            respon = random.choice(conseq)
                            print("You Pick: ", respon)
                            
                            # this input function asks the player as he / she decides to keep or eat
                            
                            decision = input("Do you Keep that (yes or no)? ").lower()
                            
                            # if yes, the space number decreases by 1
                            if decision == "yes":
                                
                                space = space - 1
                                print("Space Available: ", space)
                                
                                if space == 0:
                                    
                                    print("Oh no! Your storage is full!")
                                    
                                else:
                                    
                                    print("Available Space!")
                                
                            else:
                                
                                print("You eat that fruit and leave...")
                                
                            
                        elif event == "That nut is falling into you!":
                            conseq = ["Walnut", "Almond", "Chestnut", "Peanut", "Cashew", "Hazelnut", "Pistachio"]
                            
                            respon = random.choice(conseq)
                            print("You Pick: ", respon)
                            
                            decision = input("Do you Keep that (yes or no)? ").lower()
                            
                            # if yes, the space number decreases by 1
                            if decision == "yes":
                                
                                space = space - 1
                                print("Space Available: ", space)
                                
                                if space == 0:
                                    
                                    print("Oh no! Your storage is full!")
                                    
                                else:
                                    
                                    print("Available Space!")
                                
                            else:
                                
                                print("You eat that nut and leave...")
                            
                        elif event == "There is something mysterious at your front...":
                            conseq = ["A Deer", "Fog with the flock of random birds", "A Rock", "A Log that suddenly lying into your front",
                                      "A Post", "Barrels", "An Owl"]
                            
                            respon = random.choice(conseq)
                            print("You Encounter: ", respon)
                            
                            if event == "A Rock" or "A Log that suddenly lying into your front" or "Barrels":
                                
                                print("You carry that obstacle away from your path...")
                                
                            elif event == "A Deer" or "An Owl":
                                
                                print("You must wait for it to go away in your front, if they are already gave you way, then proceed...")
                                
                            elif event == "A Post" or "Fog with the flock of random birds":
                                
                                print("Maybe, they are just having your attention...")
                                
                        elif event == "There is a beehive":
                            
                            happ = ["The Bees Sting you and Leave", "Ohh... Good Bees, have a drop of honey...",
                                    "The Bees still cover the Hive!"]
                            
                            stin = random.choice(happ)
                            
                            print(stin)
                            
                            print("Cover yourself! Else it could be much worse!")
                                
                        else:
                            conseq = ["Well... Back to the Game!", "Feeling Nervous? Sit and Relax...", "Calm now...",
                                      "How many fruits that falling into your head?", "Chills? You can sleep...",
                                      "Exhausted after taking out the objects that block on your way, well... That's life!",
                                      "Painful? I will heal your wounds and you are fine.", "Do you pick some fruits and nuts? Eat them!"]
                            
                            respon = random.choice(conseq)
                            print("Thoughts: ", respon)
                            
                            if respon == "Do you pick some fruits and nuts? Eat them!":
                                
                                space = space + 1
                                
                                print("Available Space: ", space)
                                
                            else:
                                
                                print("Drink some water...")
                        
                    else:
                            
                        convo = ["You must be calm today.", "I hope that you are always fine...", "Let them go..."
                                 "You are totally safe here, I promise you...", "Have a nice game..."]
                    
                        poss = random.choice(convo)
                        print(poss)
                    
        else:
            break
    
else:
    print("exit!")

        
    