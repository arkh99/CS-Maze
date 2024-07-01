/*
Each room is represented by a list

Indexes
0 - Room number
1 - North Room
2 - East Room
3 - South Room
4 - West Room

If value is 0, there is no door in that direction.
Reaching Room 10 will lead to escaping the maze. 
*/
List<List<int>> rooms = [
  [1, 3, 2, 0, 0], // Room 1
  [2, 0, 0, 0, 1], // Room 2
  [3, 6, 0, 1, 0], // Room 3
  [4, 0, 8, 2, 3], // Room 4
  [5, 0, 7, 4, 6], // Room 5
  [6, 0, 5, 3, 0], // Room 6
  [7, 0, 0, 0, 0], // Room 7
  [8, 7, 0, 9, 0], // Room 8
  [9, 8, 0, 10, 2] // Room 9
];
List<string> indexes = ["ROOM", "NORTH", "EAST", "SOUTH", "WEST"];

// the current room
int current = 1;

// the status of the game
bool isActive = true;

// Room
// accept a room number
// if room number is 10, player escapes
// Write the room number and available doors to the console
// if no available doors, player is trapped
// returns false if the player has escaped or is trapped, else returns true 
bool Room (int number)
{ 

  if (number == 10) {
    Console.WriteLine("\nYou have escaped!");
    return false;
  }

  List<int> room = rooms[number - 1];
  List<string> directions = [];
  Console.WriteLine($"\nYou have entered Room {number}");
  
  for (int i = 1; i < indexes.Count; i++) 
  {
    if (room[i] != 0) 
    {
      directions.Add($"{indexes[i]}");
    }
  }
 
  if (directions.Count > 0)
  {
    Console.WriteLine("\nYour available doors are: ");
    foreach (string direction in directions)
    {
      Console.WriteLine(direction);
    }

    return true;
  } 
  
  Console.WriteLine("There is no way out. You are trapped!");
  return false;
}

while (isActive)
{
  // gets the room information
  isActive = Room(current);

  // if action can be taken, ask user for an action
  if (isActive)
  {
    Console.Write("\nWhich door do you choose: ");
    string? direction = Console.ReadLine(); // expects. NORTH, SOUTH, etc

    if (!string.IsNullOrEmpty(direction))
    {
      int index = indexes.IndexOf(direction.ToUpper());
      if (index != -1) 
      {
        current = rooms[current - 1][index];
      } 
      else
      {
        Console.WriteLine("Not a valid response");
      }
    }
    else
    {
      Console.WriteLine("Not a valid response");
    }
  }
  else
  {
    Console.WriteLine("\nWould you like to play again? (Y/y)");
    string? response = Console.ReadLine();
    if (!string.IsNullOrEmpty(response) && response.ToLower() == "y")
    {
      isActive = true;
      current = 1;
    }
  }
}


