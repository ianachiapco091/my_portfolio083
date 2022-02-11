import random

class fortune:
    
    def start_game_1(self):
        messages = ["There could be much easier than before...", "You are taking much place right away!",
                    "Why couldn't telling you about this?", "I think that this game could be better next time...",
                    "You can ask yourself why...", "I think that could be right time to tell you...",
                    "Be careful, you can now steping something unpleasant..."]
        text = random.choice(messages)
        return print(text)
    
    def start_game_2(self):
        messages = ["Once you step in, you never come there again...", "There is a time, well yeah...",
                    "The sun goes into the straight line, don't you?", "You step into tall grass...",
                    "Time starts since the last time you step in...", "Can I have something?",
                    "Everything takes patient so I will wait for it...", "You can do that!"]
        text = random.choice(messages)
        return print(text)
    
    def safe(self):
        convo = ["You must be calm today.", "I hope that you are always fine...", "Let them go..."
                 "You are totally safe here, I promise you...", "Have a nice game..."]
    
        poss = random.choice(convo)
        print(poss)