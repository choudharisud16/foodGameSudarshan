# The Food Game
The Food Game is a personal project developed using <a href="https://unity.com/" target="_blank">Unity</a> to showcase my skills in game development. The objective of the game is to collect healthy food items while avoiding unhealthy ones, with a time limit of 15 seconds. This project demonstrates my ability to design, program, and implement basic game mechanics in Unity.

* Game Details/ Functionality :
  * The game features a player character placed in an open field, with various food items falling from the sky.
  * Helathy Food Items: Melons, peaches, and tomatoes.
  * Unhealthy Food Items: Doughnuts, candy, and soda cans.
  * The player can control the character using W key to move forward, A key to turn and move left, S key to turn around move backward, D key to turn and move right and the Spacebar to jump.
  * The goal is to collect as many healthy food items as possible while avoiding unhealthy items.
  * Scoring System:
    * Total number of healthy food items collected is calculated by adding together the total number of melons, tomatoes, and peaches.
    * Total number of unhealthy food items collected is calculated by adding together the total number of candies, doughnuts, and soda cans.
  * Winning Condition: The player wins if the number of healthy food items collected exceeds the number of unhealthy food items.
  * Losing Condition: The player loses if the number of unhealthy food items collected surpasses the healthy food items.
* Technical Stack:
  * Programming Language: C#
  * Tools : Unity, Visual Studio Code, <a href="https://www.mixamo.com/" traget="_blank">Mixamo</a>, Git bash
* Scripts:
 <table>
  <thead>
      <th>Script Name</th>
      <th>Purpose</th>
  </thead>
  <tbody>
    <tr>
      <td>CandyCanesUIInvetotyText.cs</td>
      <td>Updating the score text for candy canes collected</td>
    </tr>
    <tr>
      <td>CandyInventory.cs</td>
      <td>Perform the calculation when player collides with a candy.</td>
    </tr>
    <tr>
      <td>CountDownTimmerScript.cs</td>
      <td>Script for the countdown timer.</td>
    </tr>
    <tr>
      <td>DoughnutInventory.cs</td>
      <td>Perform the calculation when player collides with a doughnut.</td>
    </tr>
    <tr>
      <td>DoughnutsUIInvetotyText.cs</td>
      <td>Updating the score text for doughnuts collected</td>
    </tr>
    <tr>
      <td>MellonsUIInvetotyText.cs</td>
      <td>Updating the score text for melons collected</td>
    </tr>
    <tr>
      <td>MelonsInventory.cs</td>
      <td>Perform the calculation when player collides with a melon.</td>
    </tr>
    <tr>
      <td>PeachInventoryUIScript.cs</td>
      <td>Updating the score text for peaches collected</td>
    </tr>
    <tr>
      <td>PeachesInventory.cs</td>
      <td>Perform the calculation when player collides with a peach.</td>
    </tr>
    <tr>
      <td>PlayerController.cs</td>
      <td>Script for controlling the player movemnets and gravity.</td>
    </tr>
    <tr>
      <td>PlayerInventory.cs</td>
      <td>Script that increments respective food item the player collides with.</td>
    </tr>
    <tr>
      <td>RandomObjectSpawner.cs</td>
      <td>Script for randomly spawind the food items from sky on the ground.</td>
    </tr>
    <tr>
      <td>RestartHandler.cs</td>
      <td>Script that restarts the game on clicking the restart button by the end of the game.</td>
    </tr>
    <tr>
      <td>SodaCansUIInvetotyText.cs</td>
      <td>Updating the score text for soda cans collected</td>
    </tr>
    <tr>
      <td>SodasInventory.cs</td>
      <td>Perform the calculation when player collides with a soda can.</td>
    </tr>
    <tr>
      <td>TomatoesInventory.cs</td>
      <td>Perform the calculation when player collides with a tomato.</td>
    </tr>
    <tr>
      <td>TomatoesUIINvetotyText.cs</td>
      <td>Updating the score text for tomatoes collected</td>
    </tr>
    <tr>
      <td>WinOrLose.cs</td>
      <td>Script that performs the winning and losing condition and displays the message on the screen once the game ends.</td>
    </tr>
  </tbody>
</table>





