# A Tale of five balloons:

### Game description:
30's first seocnd of our game. 
Our player is a child with a balloon , his goal is to keep on the balloon (otherwise the balloon will bomb, the ballon will tear...).

Demo in itch.io : ----


## Rules and Control:
 * Movement control with arrows
 * Failing while the balloon touch the knife
 * The kid can defand the balloon by touching the knife with his body 

 # Excercies Requirement:
## Script's components and game development control:
* All the player movement is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/Move.cs)
* The rope and the connection between the kid and the balloon [coded here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/Rope.cs) 
* The knife's spawn is [managed here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/SpawnEnemy.cs) 
and his throw power [managed here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/Throw.cs)
* The knife's distroy with annimation [managed here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/Destroyed.cs) 
* Menu's buttons [managed here](https://github.com/dobzik/MainGameDev/blob/master/Lesson9/New%20Unity%20Project/Assets/Scripts/Menu.cs)

# Assets
* Music 
  * Mali Maafe from : https://www.playonloop.com/royalty-free-music/world-and-travel/
* Player (kid) from: https://www.kenney.nl/assets/platformer-characters
* The rest of the assets we created ourselves.



## Notes - resolution issue's:
We had to fit the resolution for the itch.io ,so:
* In unity - if you don't see the sides walls: you should change the resolution from 'Free aspect' to custom resolution of 1920 X 1080.
* In itch.io - If you have a resolution issue's, please zoom out it's should fix it.
