
import random

class Consequence:
    
    def auditory_imagery(self):
        conseq = ["*The Unusual Echo!*", "*Crying Mockingbird*", "*Train crosses the rails*",
                  "*Tearing Sound of the Tree Branch*", "A Wild Boar", "*whistle*"]
        
        respon = random.choice(conseq)
        print("You Hear: ", respon)
        
    def guess_one_secrets(self):
        conseq = ["See the Primal Horror (Sp1ad_!@)", "When I Touch a Latched Knob (rlP_0I;N)",
                  "Come Back! (eI_eN16<)", "Tired of Tutorials (^$n_/xi=)", "Programmin Habit (BKo!%*19)",
                  "My Talents (anG&rtW1)", "Keep an Eye to You (sdE-90Fv)"]
        
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