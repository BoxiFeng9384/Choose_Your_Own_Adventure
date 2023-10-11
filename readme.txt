Requirement:
	At any part of your code (31 pts): 
		1.	At the very least 5 different classes that handle your code. (Points defined in the class’ section)
		There are 6 Class in total in the program.
		
		2.	From those 5 classes at least 2 of them need to be inherited in some way. (Points defined in the derived class’ section)
		The Character Class is the parent class for Player class and Enemy Class
	
		3.	Have any of your classes use a static variable in a meaningful way. (1 pt)
		In Room Class Line 16, I use a static variable to count room number which lead to a secret path.

		4.	Implement polymorphic behavior in some way. (10 pts)
			The printinfo method in Character Class Line 61,Player Class Line 86,Enemy Class Line 64

		5.	Implement recursion in some way. (10 pts)
			The Fight method in Player Class Line 51 and in Enemy Class Line 43 together create a recursion. As long as the enemy's HP do not equal or less than 0, it will work forever.

		6.	Implement any type of loop in some way. (10 pts)
		In Player Class Line 43, the Display Inventory use for each loop to display all the item in Inventory. In Door Class Line 26, the Opendoor Method use a for loop to see whether the player have the key to open the door.

	For each class (5pts per class, 25 total):
		1.	Have at least 3 different variable members (1 pt)
		2.	Have proper access modifiers, your fields need to be private and protected (on a per use basis) (1pt)
		3.	Use properties, declare getters and setters when appropriate. (1 pt)
		4.	Do not use the default constructor, even if the class does not take in any arguments when instantiated, you need to code the constructor behavior. (1 pt)
		5.	Use at least one example of method overloading. (1pt)
			In Player Class Line 51 and Line 69, there are two fight method constructing a method overload as the	two method have different parameter type, Enemy and Character.

	For each derived class (3 pts per derived class, 6pts total):
		1.	Have at least 1 new variable that is not part of the parent class (1 pt)
		2.	Show a meaningful purpose for being a derived class. (1 pt)
			The meaning for make Player and Enemy as derived class for Character is that I could use the base of Character class to distinguish different kind of character. The character class serve as the NPC template, the Enemy class serve as the enemy NPC template which have more behavior than normal NPC. The Player class serve as the Player Character template which teh player could play.

		3.	Have at least one overridden method. (1 pt)
			The printinfo method in Character Class Line 61,Player Class Line 86,Enemy Class Line 64

	For the main program (33 pts):
		4.	Rooms will be created and stored using a linked list. (10 pts)
			In Room Class Line 54, there are Room variable serve as the pointer to the next room and the previous room.
		5.	Rooms may either contain:
			a.	Enemy to fight (2 pts) or
			b.	Loot to collect (2 pts)
			Room Class Line 64 ChooseAction Method.
			
		6.	Take user input in account to make choices in your story, this includes options for:
			a.	Choosing a room to progress to (2 pts) or
			b.	Choosing an action to fight an entity in the room (2 pts).
			Room Class Line 131 EnterRoom Method

		7.	When you win a battle encounter or loot a room, your user should win an item, which is going to be stored in a data structure, array or list. (5 pts)
			Player Class Line 33, the AddItemToInventory method allow player to add item to the inventory. In Enemy Class Line 58, when the player defeat the enemy it allow player to pick the loot.

		8.	Give the user the option to use an item from their stack to win a battle or unlock a door (5 pts)
			In Door Class Line 21, the OpenDoor method allow player to use the key to open the door, or do they need it?

		9.	When you reach the exit or at any point the user requests, list the remaining items in your stack (5 pts)
			In Room Class Line 161, When the player reach the end, which there is no nextroom, the method will display player's info and the inventory and then exit the program.

	

Game Instruction
	The game is pretty simple. The player just need to make decision to stack their power in order to kill the boss and end the game.There are some secret ways that could make the game much much more easier.