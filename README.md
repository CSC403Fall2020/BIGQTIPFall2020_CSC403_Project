# Fall2020_CSC403_Project
## Description
A simple Game written in C# using Windows Forms on a .NET framework

------------------------------------------------------------------------------

## Running Program
Can only be run in Visual Studio 19 with source code by running the solution.
No executable available.

------------------------------------------------------------------------------

## Features
------------------------------------------------------------------------------

### FEATURE - Random Enemies
- Date: 11/08/2020
- This feature created 2 new enemies and allows for spawning 3 random and unique enemies from the total pool of enemies

##### **RandomIntegers()**
This function returns an integer array with three unique integers. The integers are random and determine which enemies are spawned. Enemies visibility is determined through this array.

##### **SpawnEnemies()**
This function does not return a value. This function initially sets all enemy models to invisible and then loops through the return of RandomIntegers() to determine which enemy models to make visible (spawn).

##### **Other Changes**
- Created 2 new enemies : Tony the tiger and Ronald McDonald.
- Change in exising function tmrPlayerMove_Tick() to only fight enemies that are also visible to the exisiting condition checks.


----------------------------------------------------------------------------

### FEATURE - Experience
- Date: 11/11/2020
- Adds Experience Tracking. Including Random experience from enemies, an XP bar in the battle form as well as an indicator on enemy picture for how much experience they will give on death.

##### **UpdateExperienceBar(int xpGain)**
This functions paramater is xpGain which is a random integer designated at enemy instantiation.
This will check if the player has exceeded the 100 needed points needed for a level incrementing the level when successful. The experience bar UI is adjusted based on the % the player is away from leveling up. Level is updated and displayed in a label next to the experience bar and the enemy portrait contains another level displaying the enemies experience given on death.

This function is called in btnAttack_Click(). Here UpdateExperienceBar will only be called if the player is still alive and the enemy has been killed.

##### **GenerateExperience()**
generates a random integer between two specified values. This function is called to generate a random experience amount for characters.

#### **Other Changes**
Battle Character class has added three member variables:
   - ExperienceOnDeath which sets it's value based on GenerateExperience().
   - ExperienceToLevel which is the amount needed until the next level is achieved.
   - CurrentLevel which is the players current level.
   
-------------------------------------------------------------------------------------

### FEATURE - Exit Button
-Date: 11/11/2020
-Adds button that exits the application
   -Confirmation box appears that ensures user wants to exit the entire application (YES or NO)
   
-Had to create as label since design elements (walls and characters) were sitting in foreground, covering the button
-Created function for label click functionality, btnExitGame_Click() in FrmLevel.cs which works with instantiated label in FrmLevel.Designer.cs


----------------------------------------------------------------------------

### FEATURE - Escape Button
Date: 11/08/2020
This feature adds a button "escape" to exit the fight window.


#### **btnRun_Click()**
This function set the battle instance to null and close the window. It does not return any value.

### **Other change**
- Created, initialized and configured button "escape".
- Added button escape to fight window.

----------------------------------------------------------------------------

### FEATURE - Random dialogues during fights
Date: 11/16/2020
This feature displays labels of random dialogues based on ennemies health level after the button attack is clicked.

#### **RandomText()**
This function returns a string value. This function initially create a random variable and a list of of strings. Then, the index of the list is randomized and the content of said index is assigned to a string variable that is going to be returned.

#### **Other Changes**
- Modified btAttack_Click() function to display dialogue/remove labels during fights.
- Increased character's health to 30 in order to allow for more dialogue to be displayed.
- Decreased main characters attack points form 4 to 3 to allow for more dialogue cto be displayed.
- Created and initialized Labels "dialogue1", "dialogue2", "dialogue3"

----------------------------------------------------------------------------

### FEATURE - SFX
- Date: 11/17/2020
- This feature adds sound effects for the battles in game.

#### **RandomText()**
This function plays a sound dependent upon the enemy for the current battle. It does not return any value.

#### **Other Changes**
- Modified btAttack_Click() to play sounds upon death of enemies and characters as well as attack sounds.
- Created 8 new sounds: Attack_Sound, Enemies_Die, Koolaid_Dies, Peanut_Dies, Flamin_Battle, Koolaid_Battle, Ronald_Battle, and Tony_Battle

-------------------------------------------------------------------------------------

### FEATURE - Enemies Die
-Date: 11/17/2020
-When the player defeats an enemy in battle, after the battle window closes, the enemy and it's collider are hidden from the player on the map.
#### **frm_FormClosed()**
in the FrmLevel class, is called when battle form is closed using an event handler in the Fight() method
first checks to see if the player defeated the enemy by calling frmBattle.EnemyDied()
then gets what enemy was defeated by calling frmBattle.CurrentEnemy() and deletes that enemies picture on FrmLevel
#### **EnemyDied()**
In the FrmBattle class, returns boolean true if player killed the enemy in battle, false if not 
#### **CurrentEnemy()**
In the FrmBattle class, returns Type enemey, the current enemy that the player is against
#### **Hide()**
In the collider class, method that deletes collider
#### **Other Changes**
-Added names to enemy's class
-Added Boolean value to FrmBattle to track if enemy is defeated

----------------------------------------------------------------------------

### FEATURE - Player Becomes Cheeto Cat
- Date: 11/17/2020
- This feature changes the player's sprite to a cheeto cat when the player is killed by the cheeto enemy.

#### **PlayerDied()**
This function returns a boolean for if the player died. Returns true if the player is killed by the cheeto.

#### **Other Changes**
- Modified frm_FormClosed() to check if the player was killed by the cheeto and updates the player's sprite if so.
- Created 1 new sprite for the player: cheeto_cat
- Added a wrapper for the player sprite

### FEATURE - Multiple rooms
- Date: 11/18/2020
- This feature is in beta and has not been pulled to the main, the branch for this feature is 2rooms
- This feature will not be in the product due to not being completed before end of sprint.
