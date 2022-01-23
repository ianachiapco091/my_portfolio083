import random, sys

def getfortune(answer_num):
    
    if answer_num == 1:
        ans = "You may rely on it!"
        return ans
        
    elif answer_num == 2:
        ans = "Without a Doubt"
        return ans
        
    elif answer_num == 3:
        ans = "As I see it, yes!"
        return ans
    
    elif answer_num == 4:
        ans = "Most Likely."
        return ans
        
    elif answer_num == 5:
        ans = "It is Decidedly so."
        return ans
        
    elif answer_num == 6:
        ans = "Ask again later."
        return ans
    
    elif answer_num == 7:
        ans = "Cannot Predict now."
        return ans
    
    elif answer_num == 8:
        ans = "Better not to tell you now"
        return ans
    
    elif answer_num == 9:
        ans = "Reply hazy, ask again later."
        return ans
    
    elif answer_num == 10:
        ans = "Concetrate and ask again."
        return ans
        
    elif answer_num == 11:
        ans = "My source says no."
        return ans
    
    elif answer_num == 12:
        ans = "Outlook not so good."
        return ans
        
    elif answer_num == 13:
        ans = "Don't Count on it."
        return ans
    
    elif answer_num == 14:
        ans = "Very Doubful."
        return ans
    
        
    elif answer_num == 15:
        ans = "My reply is no."
        return ans
    
while True:
    print("""
  Enter 'get' to show the fortune for your question
          """)
          
    command = input("---> ").lower()
    
    if command == 'get':
        roll = random.randint(1, 15)
        fortune = getfortune(roll)
        print("""
 The Fortune is: """, fortune)
        
    else:
        sys.exit()
    