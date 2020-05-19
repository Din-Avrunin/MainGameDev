# Icy doodle Readme

### Game description:
In the game you play with the Gimli dwarf , tring to atchive all the flags, by jumping up, until you find it.

Demo in itch.io : https://aripash.itch.io/icy-doodle


## Control and Rules:
 * Right and Left arrow to tur move right  and left.
 * Jump with spcae. 
 * Do not touch the bad smileys , they dangerous.
 * Tip: Try to use the wall for higher Jumping (it's a feature).
 * Your goal: Jump up until you got the flag.

 Excercies Requirement:
#### physics object
* All the player movement is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/Move.cs)
* The camera movement and defeat is handle:
    * [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameManager.cs) 
    * [and here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/follow_player.cs)



### Manage levels
* The start/end game is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameMenu.cs)
* The transition between levels and defeats is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameManager.cs)




## Notes - resolution issue's:
We had to fit the resolution fot the itch.io so, if you any problem:
* In unity: if you don't see the sides walls, you should change the resolution from 'Free aspect' to custom resolution of 1920 X 1080
* In itch.io: If you have a resolution issue's, please zoom out it's sould fix it.
