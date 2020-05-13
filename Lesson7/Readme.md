# Bibi Gun Readme

### Game description:
`In this game you play with Bibi's astronaut, your goal is to kill  the flying cows as you can.`

Demo in itch.io : https://noamdom.itch.io/bibigun 


### Rules and control: 
* Do not touch the cows.
* collect the power up bebbles to increase your shooting power
* you have 3 lives.
* laser shooting - space key.
* rastart game - 'R' key.
* pausing game - 'P' key.

### Exercise requirements: 
`We implemented sections 1, 3 and 5 in part A.`

#### section 1 - dramatic flow
* We canceled the constant time changing in [this scirpt]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/SpawnManager.cs") (The comment code)

* We added SpawnManger animation that control the waiting time between spawns. The player feel how easy the flow at the begin, and how tempo of enemy attack is increasing each loop

#### section 3 - sounds
* We added a control volume slider, it's require:
	* Adding an AudioMixer.
	* Connecting the slider to AudioMixer - this connection happend [in this scirpt]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/SettingMenu.cs").

	* Connecting the AudioManger object to the AudioMixer this connection happend [in this scirpt]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/AudioManager.cs")
* We added cow's sound affect
	* Downloaded from: https://www.fesliyanstudios.com/royalty-free-sound-effects-download/cow-264
	* [This script]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/RandomMoo.cs) handle the random 'moo' playing.
* We added explosion anumation for the com: [in this scirpt]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/Enemy.cs") - see the the Explode function.

#### section 5 - pausing menu
* Most of the work was in designing the menu.
* The functionality in [this script]("https://github.com/dobzik/MainGameDev/blob/master/Lesson7/BibiGun/Assets/Script/PauseMenu.cs")


