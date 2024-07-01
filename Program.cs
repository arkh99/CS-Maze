using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define maze rooms with randomized layouts
        List<List<int>> rooms = GenerateRandomMaze(10);

        // Direction indexes
        List<string> indexes = new List<string> { "ROOM", "NORTH", "EAST", "SOUTH", "WEST" };

        // Game variables
        int currentRoom = 1;
        int stepsTaken = 0;
        bool isActive = true;

        // Introduction
        Console.WriteLine("Welcome to the Maze Game!");
        Console.WriteLine("Try to find your way through the maze to Room 10.");

        // Main game loop
        while (isActive)
        {
            DisplayRoomInformation(currentRoom, rooms, indexes);

            // Player input
            Console.Write("Choose a direction (NORTH, EAST, SOUTH, WEST): ");
            string directionInput = Console.ReadLine()?.ToUpper();

            if (IsValidDirection(directionInput, indexes))
            {
                int directionIndex = indexes.IndexOf(directionInput);
                int nextRoom = rooms[currentRoom - 1][directionIndex];

                if (nextRoom != 0)
                {
                    currentRoom = nextRoom;
                    stepsTaken++;
                }
                else
                {
                    Console.WriteLine("There is no door in that direction. Choose another direction.");
                }

                if (currentRoom == 10)
                {
                    Console.WriteLine("Congratulations! You have escaped the maze!");
                    isActive = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid direction. Please choose a valid direction.");
            }
        }

        // Game summary
        Console.WriteLine($"\nGame over! You escaped in {stepsTaken} steps.");
        Console.WriteLine("Thank you for playing the Maze Game!");
    }

    // Method to generate a random maze layout
    static List<List<int>> GenerateRandomMaze(int numRooms)
    {
        Random random = new Random();
        List<List<int>> maze = new List<List<int>>();

        for (int i = 0; i < numRooms; i++)
        {
            List<int> room = new List<int>();
            room.Add(i + 1); // Room number

            for (int j = 1; j <= 4; j++)
            {
                int randomRoom = random.Next(0, numRooms + 1);
                room.Add(randomRoom);
            }

            maze.Add(room);
        }

        return maze;
    }

    // Method to display current room information
    static void DisplayRoomInformation(int currentRoom, List<List<int>> rooms, List<string> indexes)
    {
        List<int> room = rooms[currentRoom - 1];
        Console.WriteLine($"\nYou are in Room {currentRoom}");

        for (int i = 1; i < indexes.Count; i++)
        {
            if (room[i] != 0)
            {
                Console.WriteLine($"{indexes[i]}: Room {room[i]}");
            }
            else
            {
                Console.WriteLine($"{indexes[i]}: No door");
            }
        }
    }

    // Method to validate player direction input
    static bool IsValidDirection(string directionInput, List<string> indexes)
    {
        return indexes.Contains(directionInput);
    }
}



