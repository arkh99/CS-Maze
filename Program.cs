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


