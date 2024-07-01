# CS-Maze
Simple console-based maze game in C# where players navigate through rooms by choosing directional doors to escape the maze by reaching Room 10.

his project is a simple console-based maze game implemented in C#. Players navigate through interconnected rooms represented as a maze, aiming to escape by reaching Room 10.

Description
The maze consists of several rooms, each identified by a unique number. Players start in Room 1 and can move in four possible directions: North, East, South, and West. Each room is represented by a list where:

Index 0: Room number
Index 1: North direction
Index 2: East direction
Index 3: South direction
Index 4: West direction
If a direction value is 0, it means there is no door in that direction. Reaching Room 10 signifies escaping the maze and winning the game.

Features
Room Navigation: Players choose directions (North, East, South, West) to move between rooms.
Dynamic Console Interaction: Console prompts players for input and displays current room details and available directions.
Escape Condition: The game ends when the player reaches Room 10, displaying a victory message.
Techniques Used
List of Lists: Rooms are stored in a List<List<int>>, facilitating efficient navigation through maze rooms.
Console Input Handling: Utilizes Console.ReadLine() to accept player direction choices and manages game flow based on user input.
Conditional Statements and Loops: Implements if, else, and while statements to validate player moves and control game progression.
Getting Started
To run the game:

Clone this repository.
Open the solution in Visual Studio or compile using dotnet build.
Run the executable and follow the on-screen prompts to navigate the maze.
