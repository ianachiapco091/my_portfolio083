import random

class game_ending:
    
    def ending(self):
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