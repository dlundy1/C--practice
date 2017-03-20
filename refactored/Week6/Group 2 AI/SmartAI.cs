using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6
{
    class SmartAI : IPlayer
    {
        private int _index;
        private int _gridSize;
        public string Name { get; }
        public int Index => _index;
        private static readonly Random Random = new Random();

        List<Position> hitSpots = new List<Position>();
        List<Position> prevGuesses = new List<Position>();
        AttackResultType LastAttackResult;
        Position LastAttack = null;

        public SmartAI(string name)
        {
            Name = name;
        }

        public void StartNewGame(int playerIndex, int gridSize, Ships ships)
        {
            _gridSize = gridSize;
            _index = playerIndex;
            bool shipsPlaced = false;
            do
            {
                PrepShips(ships);
                shipsPlaced = ShipsCheck(ships);
            } while (!shipsPlaced);

        }

        public Position GetAttackPosition()
        {
            Position pos = AttackRandom();
            return pos;
        }

        private Position AttackRandom()
        {
            Position pos = null;
            do
            {
                pos = new Position(Random.Next(_gridSize), Random.Next(_gridSize));
                if (prevGuesses == null)
                {
                    return pos;
                }
                foreach (var guess in prevGuesses)
                {
                    if (pos == null) { }
                    else if (PosEqual(pos, guess))
                    {
                        pos = null;
                    }
                }
            } while (pos == null);
            return pos;
        }

        public void SetAttackResults(List<AttackResult> results)
        {
            // Add current guess to list of already made guesses.
            prevGuesses.Add(results[0].Position);

            // Check to see if the lastAttack was our attack.
            if (LastAttack != null)
            {
                if (PosEqual(LastAttack, results[0].Position))
                {
                    // Assume attack result is a miss until checked.
                    LastAttackResult = AttackResultType.Miss;
                    // If any of the attacks were a hit, set last result to hit.
                    foreach (var item in results)
                    {
                        if (item.ResultType == AttackResultType.Hit)
                        {
                            LastAttackResult = AttackResultType.Hit;
                            break;
                        }
                    }
                    // If the attack wasn't a hit, check to see if any ships were sunk.
                    if (LastAttackResult != AttackResultType.Hit)
                    {
                        foreach (var item in results)
                        {
                            if (item.ResultType == AttackResultType.Sank)
                            {
                                LastAttackResult = AttackResultType.Sank;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var item in results)
            {
                // If there was a successful hit that didn't sink a ship, add it to the hit list for chaining purposes
                if (item.ResultType == AttackResultType.Hit && item.PlayerIndex != _index)
                {
                    // Log the hit if hit spots list is empty
                    if (hitSpots == null)
                    {
                        hitSpots.Add(item.Position);
                    }
                    // If not empty, make sure we arent logging the same hit spot twice.
                    else
                    {
                        bool alreadyLogged = false;
                        foreach (var pos in hitSpots)
                        {
                            if (PosEqual(pos, item.Position))
                            {
                                alreadyLogged = true;
                            }
                        }
                        if (!alreadyLogged)
                        {
                            hitSpots.Add(item.Position);
                        }
                    }
                }
            }
        }

        private void PrepShips (Ships ships)
        {
            // Order the ships from largest to smallest and then send the list to have them placed.
            var SortedShips = ships._ships.OrderByDescending(a => a.Length);
            foreach (var ship in SortedShips)
            {
                CountSpaces(ships, ship);
            }
        }

        private void CountSpaces(Ships ships, Ship activeShip)
        {
            // Create list of used spots each time attempting to place a new ship
            List<Position> usedSpots = new List<Position>();
            foreach (var ship in ships._ships)
            {
                if (ship.Positions != null)
                {
                    foreach (var position in ship.Positions)
                    {
                        usedSpots.Add(position);
                    }
                }
            }

            // Create a list of all positions that exist in the grid based on the grid size
            List<Position> virtualGird = new List<Position>();

            for (int i = 0; i < _gridSize; i++)
            {
                for (int j = 0; j < _gridSize; j++)
                {
                    virtualGird.Add(new Position(i, j));
                }
            }


            Position newPos = null;
            Direction direction = Direction.Vertical;
            while (newPos == null)
            {
                // Randomly choose the direction the ship will face and search for a position available to fit that ship
                switch (Random.Next(2))
                {
                    case 0:
                        newPos = SearchHorizontal(virtualGird, usedSpots, activeShip.Length);
                        direction = Direction.Horizontal;
                        break;
                    case 1:
                        newPos = SearchVertical(virtualGird, usedSpots, activeShip.Length);
                        direction = Direction.Vertical;
                        break;
                }

                // Double check that the selected position of the ship will not overextend the grid when placed
                if (newPos != null)
                {
                    if (newPos.X < 0 || (newPos.X + (activeShip.Length - 1)) >= _gridSize || newPos.Y < 0 || (newPos.Y + (activeShip.Length - 1)) >= _gridSize)
                    {
                        newPos = null;
                    }
                }
                
            }

            // Once a valid position is found, place the ship
            activeShip.Place(newPos, direction);
        }

        private Position SearchVertical(List<Position> blankGrid, List<Position> usedSpots, int shipLength)
        {
            int counter = 0;

            // Create a temporary list that orders all the spots available in the grid by vertical occurance.
            List<Position> allSpots = blankGrid.OrderBy(pos => pos.X).ThenBy(pos => pos.Y).ToList();

            Position startPos = null;

            // Pick a random starting point in the grid to place the ship so not all ships are beside each other.
            allSpots.RemoveRange(0, Random.Next(((_gridSize * _gridSize) - shipLength)));

            for (int i = 0; i < allSpots.Count; i++)
            {
                // Set the position we'll be returning to the spot we'll be counting off of.
                if (counter == 0)
                {
                    startPos = new Position(allSpots[i].X, allSpots[i].Y);
                }

                bool foundMatch = false;

                // Check the list of usedSpots to see if the current looked at position (allSpots[i]) already exists in the usedSpots list.
                foreach (var usedSpot in usedSpots)
                {
                    if (PosEqual(usedSpot, allSpots[i]))
                    {
                        foundMatch = true;
                        break;
                    }
                }

                // If the counter says the amount of spaces counted is the size of the ship, return the starting position.
                if (counter >= shipLength)
                {
                    return startPos;
                }
                // If the current looked at position is in use and the counter isn't up to ship size yet, reset the counter.
                else if (foundMatch)
                {
                    counter = 0;
                }
                else if (!foundMatch)
                {
                    // Check to make sure we aren't about to exceed the amount of spots available on the grid.
                    if (i + 1 != allSpots.Count)
                    {
                        // Increment the count so long as the next position is still on the same line as the current looked at position.
                        if (allSpots[i].X == allSpots[i + 1].X)
                        {
                            counter++;
                        }
                        // If the next position changes line and this spot won't make the spot large enough for the ship, reset the counter.
                        else if (counter + 1 < shipLength)
                        {
                            counter = 0;
                        }
                        // If it will fit the ship, return the starting position.
                        else
                        {
                            return startPos;
                        }
                    }
                    // If we're at the last possible spot on the grid and it won't make the ship fit, return a null position.
                    else if (counter + 1 < shipLength)
                    {
                        return null;
                    }
                    // If it does fit, return the starting position.
                    else
                    {
                        return startPos;
                    }
                }
            }
            // If the loop breaks or if the loops successfully ends it means the ship counting didn't occur correctly; return a null position.
            return null;
        }
        private Position SearchHorizontal(List<Position> blankGrid, List<Position> usedSpots, int shipLength)
        {
            int counter = 0;
            // Create a temporary list that orders all the spots available in the grid by horizontal occurance.
            List<Position> allSpots = blankGrid.OrderBy(pos => pos.Y).ThenBy(pos => pos.X).ToList();

            Position startPos = null;

            // Pick a random starting point in the grid to place the ship so not all ships are beside each other.
            allSpots.RemoveRange(0, Random.Next(((_gridSize * _gridSize) - shipLength)));

            for (int i = 0; i < allSpots.Count; i++)
            {
                // Set the position we'll be returning to the spot we'll be counting off of.
                if (counter == 0)
                {
                    startPos = new Position(allSpots[i].X, allSpots[i].Y);
                }

                bool foundMatch = false;
                
                // Check the list of usedSpots to see if the current looked at position (allSpots[i]) already exists in the usedSpots list.
                foreach (var usedSpot in usedSpots)
                {
                    if (PosEqual(usedSpot, allSpots[i]))
                    {
                        foundMatch = true;
                        break;
                    }
                }

                // If the counter says the amount of spaces counted is the size of the ship, return the starting position.
                if (counter >= shipLength)
                {
                    return startPos;
                }
                // If the current looked at position is in use and the counter isn't up to ship size yet, reset the counter.
                else if (foundMatch)
                {
                    counter = 0;
                }
                else if (!foundMatch)
                {
                    // Check to make sure we aren't about to exceed the amount of spots available on the grid.
                    if (i + 1 != allSpots.Count)
                    {
                        // Increment the count so long as the next position is still on the same line as the current looked at position.
                        if (allSpots[i].Y == allSpots[i + 1].Y)
                        {
                            counter++;
                        }
                        // If the next position changes line and this spot won't make the spot large enough for the ship, reset the counter.
                        else if (counter + 2 < shipLength)
                        {
                            counter = 0;
                        }
                        // If it will fit the ship, return the starting position.
                        else
                        {
                            return startPos;
                        }
                    }
                    // If we're at the last possible spot on the grid and it won't make the ship fit, return a null position.
                    else if (counter + 2 < shipLength)
                    {
                        return null;
                    }
                    // If it does fit, return the starting position.
                    else
                    {
                        return startPos;
                    }
                }
            }
            // If the loop breaks or if the loops successfully ends it means the ship counting didn't occur correctly; return a null position.
            return null;
        }
        private bool PosEqual(Position pos1, Position pos2)
        {
            // Check to see if the positions have the same (X,Y) coordinates.
            if (pos1.X == pos2.X && pos1.Y == pos2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ShipsCheck(Ships ships)
        {
            // Create a list of all the used positions that the AI current set of ships use.
            List<Position> usedPositions = new List<Position>();
            foreach (var ship in ships._ships)
            {
                foreach (var position in ship.Positions)
                {
                    usedPositions.Add(position);
                }
            }
            // Check to make sure no position appears twice in the used positions list.
            foreach (var posA in usedPositions)
            {
                int i = 0;
                foreach (var posB in usedPositions)
                {
                    if (PosEqual(posA, posB))
                    {
                        i++;
                    }
                    if (i > 1)
                    {
                        return false;
                    }
                }
            }
            // Check to be sure none of the positions are off of the grid.
            foreach (var pos in usedPositions)
            {
                if (pos.X < 0 || pos.X >= _gridSize || pos.Y < 0 || pos.Y >= _gridSize)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
