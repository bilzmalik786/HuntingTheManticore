# HuntingTheManticore

Objectives:
• Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15. 
The game starts at round 1.
• Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen 
afterward.
• Run the game in a loop until either the Manticore’s or city’s health reaches 0.
• Before the second player’s turn, display the round number, the city’s health, and the Manticore’s 
health. 
• Compute how much damage the cannon will deal this round: 10 points if the round number is a 
multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to 
the player.
• Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too 
far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected 
amount.
• If the Manticore is still alive, reduce the city’s health by 1.
• Advance to the next round.
• When the Manticore or the city’s health reaches 0, end the game and display the outcome.
• Use different colors for different types of messages.
• Note: This is the largest program you have made so far. Expect it to take some time! 
• Note: Use methods to focus on solving one problem at a time.
• Note: This version requires two players, but in the future, we will modify it to allow the computer 
to randomly place the Manticore so that it can be a single-player game.


