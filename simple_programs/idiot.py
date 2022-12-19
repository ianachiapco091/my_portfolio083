import pyinputplus as pyip

language = pyip.inputMenu(["en", "de"], "[en] English     [de] Deutsch" '\n')

if language == 'de':
    while True:
        prompt = 'Wollen Sie wissen, wie man einen Idioten stundenlang aufhält?'
        response = pyip.inputYesNo(prompt, yesVal = 'ja', noVal = 'nein')
        
        if response == 'nein':
            print('Danke. Schönen Tag noch...')
            break
        
elif language == 'en':
    while True:
        prompt = 'Do you want to know how to keep an Idiot for hours?'
        response = pyip.inputYesNo(prompt)
        
        if response == 'no':
            print("Thank you. Have a nice day...")
            break