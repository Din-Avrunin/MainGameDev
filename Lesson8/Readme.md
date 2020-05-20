# Icy doodle Readme

### Game description:
In this game you will play with the Gimli dwarf , try to achieve all the flags, by jumping up, until you find them.

Demo in itch.io : https://aripash.itch.io/icy-doodle


## Control and Rules:
 * Right and Left arrow to move right  and left.
 * Jump with space. 
 * Do not touch the bad smilies, they dangerous.
 * Tip: Try to use the wall for higher Jump (it's a feature).
 * Your goal: Jump up until you got the flag.

 # Excercies Requirement:
## physics object
* All the player movement is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/Move.cs)
* The camera movement and defeat is handle:
    * [defeat](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameManager.cs) 
    * [camera movement](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/follow_player.cs)



### Manage levels
* The start/end game is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameMenu.cs)
* The transition between levels and defeats is managed [here](https://github.com/dobzik/MainGameDev/blob/master/Lesson8/icy%20doodle/Assets/Script/GameManager.cs)


## Levels Design:
We had 5 levels in this game, each level the difficulty is getting harder.
* level 1 - inlclude large paltforms, in zigzag order 
* level 2 - Has a smaller paltrforms, and the gap between them is bigger
* level 3 : We added moving paltforms 
* level 4 : Has enemies (smilies) , each touch wiil defeat the player return to the level's begin
* level 5 : mix of all the aspects, it's require a high control in the player movement and his jumps.



## Notes - resolution issue's:
We had to fit the resolution for the itch.io ,so:
* In unity - if you don't see the sides walls: you should change the resolution from 'Free aspect' to custom resolution of 1920 X 1080.
* In itch.io - If you have a resolution issue's, please zoom out it's should fix it.
