
import random

class Consequence:
    
    def auditory_imagery(self):
        conseq = ["*The Unusual Echo!*", "*Crying Mockingbird*", "*Train crosses the rails*",
                  "*Tearing Sound of the Tree Branch*", "A Wild Boar", "*whistle*", "Waterfalls",
                  "Falling Rocks", "Echoed Sound of any Instrumental Instrument"]
        
        respon = random.choice(conseq)
        print("You Hear: ", respon)
        
    def guess_one_secrets(self):
        conseq = ["See the Primal Horror (Sp1ad_!@)", "When I Touch a Latched Knob (rlP_0I;N)",
                  "Come Back! (eI_eN16<)", "Tired of Tutorials (^$n_/xi=)", "Programming Habit (BKo!%*19)",
                  "My Talents (anG&rtW1)", "Keep an Eye to You (sdE-90Fv)", "It is Time to Quit News (gL0vd33)"]
        
        respon = random.choice(conseq)
        print("You Got: ", respon)
        
    def fruits(self):
        conseq = ["Coconut", "Mango", "Apple", "Grapefruit", "Dragonfruit", "Orange", "Lemon", "Lime",
                  "Passion Fruit"]
        
        respon = random.choice(conseq)
        print(respon)
        
    def nuts(self):
        conseq = ["Walnut", "Almond", "Chestnut", "Peanut", "Cashew", "Hazelnut", "Pistachio"]
        
        respon = random.choice(conseq)
        print("You Pick: ", respon)
        
    def decision_food(self, keep):
        if keep == 'yes':
            print("You eat that fruit and proceed...")
        elif keep == 'no':
            print("Since you bring your bag, keep that...")
        else:
            print("You drop that and leave...")
        
    def obstacles(self):
        conseq = ["A Deer", "Fog with the flock of random birds", "A Rock", "A Log that suddenly lying into your front",
                  "A Post", "Barrels", "An Owl"]
        
        respon = random.choice(conseq)
        print("You Encounter: ", respon)
        
        speeq = ["These things that I ever wanted to watch!", "Even nature can make this consequences...",
                 "You can even see, ignore, avoid, and wait, what you want...", "They are just catch up your attention...",
                 "Be careful!!", "I guess that you should check them before you proceed..."]
        scop = random.choice(speeq)
        print("My Thoughts: ", scop)
            
    def bees (self):
        happ = ["The Bees Sting you and Leave", "Ohh... Good Bees, have a drop of honey...",
                "The Bees still cover the Hive!"]
        
        stin = random.choice(happ)
        
        print(stin)
        
        print("Cover yourself! Else it could be much worse!")
        
    def other_speak(self):
        conseq = ["Well... Back to the Game!", "Feeling Nervous? Sit and Relax...", "Calm now...",
                  "How many fruits that falling into your head?", "Chills? You can sleep...",
                  "Exhausted after taking out the objects that block on your way, well... That's life!",
                  "Painful? I will heal your wounds and you are fine.", "Do you pick some fruits and nuts? Eat them!"]
        
        respon = random.choice(conseq)
        print("Thoughts: ", respon)
        
        if respon == "Do you pick some fruits and nuts? Eat them!":
            
            concluc = ["Well, it looks delicious, do you?", "You know that I drank one bottle of honey...",
                       "Oh thanks, I never wish that I should leave...", "I hope that you are fine",
                       "To be fair among us, do you think what way that you should go...", "Thank you."]
            
            bubbly = random.choice(concluc)
            print(bubbly)
            
        else:
            
            print("Drink some water...")