# Capstone Project of the Udacity's VR Developer Nanodegree.
### by Esteban Struve (Nov 2018)

<img src="logoblack.png" width=50 >

### Description:
This project is focused on transmitting fear of survival to the user. It is designed like a game to survive the Amazon jungle. It is both real and fitcional featuring animals and plants
from the jungle but also evil spirits attacking the player. This project shows what I've learned during the terms of the Nanodegree of VR Developer from Udacity. Every aspect since the 
conceptualization stage until performance optimization is done by me with free, non-copyright resources.

<img src="SouloftheJunglePoster">

### Platform: 
Developed for SteamVR which is compatible wiht both Oculus Rift & HTC Vive
Unity version 2017.2.0f3
SteamVR SDK v1.2.3

### Build: 
The build is described as the following list of scenes

1_VideoIntro

2_Scene0

3_Scene1

4_Scene2

5_Scene3

6_Scene4

7_Scene5

8_Scene6

9_FinalScene


### Videos: 

The video of the GamePlay:
[YouTube: Soul of the Jungle - GamePlay](https://youtu.be/9BYCLTteVAM)

The Video of the description of the project:
[YouTube: Soul of the Jungle - Achievements](https://youtu.be/dUVt2ze7s6c)

### List of Achievements:
#### Fundamentals:
**Scale (100):** Correctly use scale to make the user feel small or large relative to another object.
User testing was used several times to make sure scales would be correctly perceived.

**Animation (100):** Create an animation, either via scripting or a tool like Mecanim, to bring your scene to life.
Animations are extensively used. Both taken from Mixamo.com and made by me. The hands move to climb, the characters move, the enemies move, the weapon moves, the helicopter, etc.

**Lighting (100):** Use a mix of baked and real-time lighting to add realistic shading to each scene.
Both baked and real-time lighting was added to most of the scene to boost performance. Also, light probe groups were added.

**Locomotion (100):** Create a locomotion system that is appropriate to your experience.
Three types were used:
Brief preset paths for the camera rig during the timelines programmed.
Climbing locomotion for two scenes where the player needs to reach a place to move forwatd to the next scene.
Standing and shooting scene where the player is fixed into a position but can use 6-DOF to perform the shooting action. Enemies come to the player.

**Physics (100):** Simulate Physics forces in your experience. For example, depending on your experience, you may want to simulate gravity.
Physics is used for the player to fall when not grabbing to climb, for the arrows to shoot properly, to bounce and fall out or stay stuck into the floor.
Colliders are disabled to prevent unwanted behaviour and bust performance of the application.

**Empathy (100):** Design an experience that helps others empathize with a different point of view.
Shooting scenes are meant to provide the player the chance to defend an innocent and vulnerable character. Both Jessica and Phil are used to cause empathy from the player.

**Video Player (100 - 2x with Lighting):** Create a video (does not have to be 360) and play it at some point during your experience.
The video player is used in the second scene to explain the story of the game as a preamble to the action. The video was made entirely by me with non-copyright material.

#### Completeness:
**Gamification (250):** Make your experience fun by adding in a reward system. You can choose to gamify your experience by rewarding achievement, exploration, or competition.
The player is rewarded with moving on to the final shooting scene when completing the magic spell and given magic darts. 
Every level creates the sense of going to higher ground and moving on to survive.

**Diegetic UI (250):** Instead of adding a lot of text to your scenes, represent interface elements naturally so users intuitively find things for themselves.
Demo hands animations were added the first time the player faces a new situations where the controllers are needed.
The natural way the hands move to show the player what to do allows the use of very little text and sometimes no instructions.

**3D Modelling (250):** Create your own custom 3D model. This could be in a tool like Blender, Maya, or in a VR app like Tilt Brush or Medium.
The bridge and the old TV was made by me in Maya 2018. In the video it is shown how I work to produce this simple 3D models costumized for this app.

#### Challenges:
**Speech Recognition (500):** Use the microphone for input and use Speech to Text solutions as means to cause events in your world.
The magic spell scene was exclusivemly created for this purpose. The player is instructed to repeat 4 strange words to unlock the chest and win the prize.

**User Testing (250 – 2x if 750 pts in Completeness):** Complete at least 2 User Tests and show the notes in your video about what you learned from each test. 
The user testing was an essential part of this development. The game was intensively tested with two users at every level.
This allow to solve a lot of issues:
-Scale was corrected in several objects of the scenes
-The locomotion was adjusted to feel more natural
-The reset position in the first climbing scene was created detected the problem of going out of the starting position when climbing up
-The bridge swinging dynamics was adjested to prevent going left
-The voices were changed to make them feel real and the voice features to transmit emotion the player
-The shooting action was fixed when realizing the arrows were interacting with player's body colliders and shooting in weird directions.
-A lot was acheived by user testing!
