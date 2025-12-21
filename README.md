# Die: The Rolling Dice Game

Welcome to Die! This game is a heavily improved remake of the original hit game [DIE](https://tnaz.itch.io/die) make for GMTK 2022. It offers enhanced features, a new 2d art style, and more!

I feel it is important to clarify that this is my first REAL game in a sense. It's the first game I've developed by myself and is my first game I didn't use a game engine for. There are issues/bugs, but I find pleasure in them since it shows the imperfections of something that shouldn't be perfect. This was made in 1 week, with VERY VERY little time available, so I don't feel obligated to make changes. This is open source so feel free to use my stuff!

## ✒️ Description

In this combat round marathon you will traverse 9 distinct levels in order to achieve ascension. Players will play as a newly freed die and will attempt to liberate its brethren while avoiding the Corrupted. The land of dice is a land of balance. The Corrupted keep the Controlled in check, preventing one from ascending and keeping the world from being destroyed. This game is the legend of Die, the rolling die who saved it all. Or well... tried to. In the many timelines of Die, there were times of failure. Times when Die lost all his dots and became one with those he despises. Will your time be different? Will you achieve ascension?

## 🕹️ Gameplay

Players begin in Level 1 with the ability to move Die around the lush Dietopia plains by using `ARROW KEYS`. The goal is for them to liberate all the Controlled. In simpler terms, they must collide with the Green Dice in order to reduce their dots to 0, "liberating" them from existence. Players must avoid the Corrupted, the Red Dice, while navigating through the level. Colliding with a Corrupted will strip a dot away, but also weaken the Corrupted itself, making it lose a dot, since you will absorb some of its Corrupted essence.

Level 2 is where Die makes his first step towards ascension and learns the ability to manipulate time around him. This allows the player to use the new dash ability by hitting the `Z` key, allowing for a burst of motion in a direction. The dash can be cancelled by clicking any key. Players will be able to test out this new dash ability in the much larger Dietopia pits, while chasing a larger selection of Controlled.

With Die becoming more unstable, he is now able to phase as of Level 3, the Dietopia rock deposits. Phasing allows the player to go "through" anything inside the bounds of the map by clicking the `X` key. Unfortunately, Die's unstable state causes him to lose his touch of phasing rather quickly, also requiring a period of time to recharge. Due to new developments, security has been increased and more Corrupted are patrolling.

Levels 4, 5, and 6 follow the story of Die as he progresses through the Dietopia desert, factory, and frosted wasteland. Featuring larger maps with different designs, more Corrupted, and more Controlled, drastically changing the difficulty of the game.

Finalizing the increase of difficulty is the Final 3. Levels 7, 8, 9, is where Die has achieved catastrophic levels of destruction. Level 7 Dietopia starts to tear between cold and hot. Following this level, in level 8 the player will complete the ending of the world, having the world crumble into magma. Finally Die will ascend and will exist in the void, where the player will conquer the nightmares of Die in one last fight. During these levels, the player will receive 1 extra dot at the start of each level due to Die nearing his ascension. The game will be hard, but not impossible.

#### Gameboards

For the gameboards, they are all designed using Tiled off of my tilesheets for each level. Here they are below.

#### Level 1

![Level1](./Game/Content/Images/Levels/PNG/level1.png)

#### Level 2

![Level2](./Game/Content/Images/Levels/PNG/level2.png)

#### Level 3

![Level3](./Game/Content/Images/Levels/PNG/level3.png)

#### Level 4

![Level4](./Game/Content/Images/Levels/PNG/level4.png)

#### Level 5

![Level5](./Game/Content/Images/Levels/PNG/level5.png)

#### Level 6

![Level6](./Game/Content/Images/Levels/PNG/level6.png)

#### Level 7

![Level7](./Game/Content/Images/Levels/PNG/level7.png)

#### Level 8

![Level8](./Game/Content/Images/Levels/PNG/level8.png)

#### Level 9

![Level9](./Game/Content/Images/Levels/PNG/level9.png)

### 🎨 Assets

The goal is to make this game be my sole creation while respecting the atmosphere of 2d top down pixel art games. To achieve this, 99% of assets of any sort will be made by me. This being said, things like the peaberrybase font (generic font) I did not make, but it is copyright free. Attributions are made accordingly.

#### 🖼️ Images

All images are personally made. Below are the dice spritesheets I made for this game.

#### Die (You as the player)

![Die](./Game/Content/Images/Dice/player_dice.png)

#### Dash (When Die is dashing)

![Dash](./Game/Content/Images/Dice/player_dash_dice.png)

#### Ascension (When at level 9 / Die is phasing)

![Ascension](./Game/Content/Images/Dice/player_ascension_dice.png)

#### Target Dice (Controlled)

![Target](./Game/Content/Images/Dice/target_dice.png)

#### Enemy Dice (Corrupted)

![Enemy](./Game/Content/Images/Dice/enemy_dice.png)

#### ✏️ Fonts

For fonts, I'm using a copyright free font (has a license permitting the use of this font for any means, in any capacity) found on itch.io.

[PeaberryBase](https://emhuo.itch.io/peaberry-pixel-font)

I'm also using a custom font I made! The Die font!

#### 🔊 Sounds

All music and sound effects are made by me.

#### 📚 Libraries/Frameworks

I'm using the [Monogame](https://docs.monogame.net/articles/index.html) framework to help with general game stuff, such as running the game, dealing with graphics, and providing data types such as Vector2.

I'm also using [Pleasing](https://github.com/franknorton/Pleasing) for tweening and easing, since it would take way too long to implement a fully in-depth one needed for this game.

Finally, I use [GUM](https://docs.flatredball.com/gum/code/monogame) for everything UI.

#### 📝 Documentation

All internal comments; Method headers, Inline comments Comment blocks; are written by me. This README file was also all written by me based off of the template given with this assignment. Can proudly say all the code is authentically written without AI.
