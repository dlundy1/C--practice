using System;


namespace BattleshipSimple
{
    internal class BattleShipGame
    {
        private Grid grid;

        public BattleShipGame(int gridSize)
        {
            grid = new Grid(gridSize);
            
        }

        internal void Reset()
        {
            Console.Clear();

        }

        internal void Play()
        {
            grid.initializeGrid(grid.grid);
            grid.Draw();

            while (grid.hasShipsLeft()) {

                string hit = grid.getInput();
                grid.DropBomb(hit);
                grid.drawHeader();
                grid.drawGrid(grid.grid);
            }
        }
    }
}
class Grid {
    bool HasShipsLeft = true;
    int gridSize;
    public GridSquare[,] grid;
    public void Draw() {

        // Draw
        //initializeGrid(grid);
        drawHeader();
        setColumn(grid);
        MarkingTargets(grid);
        drawGrid(grid);

    }
    public void drawHeader() {
        // Draw Horizontal Header
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        for (int i = 0; i < gridSize; i++) { Console.Write("#---#"); }
        Console.WriteLine();
        for (int i = 0; i < gridSize; i++) {
            if (i == 0) { Console.Write($"| # |"); }
            else { Console.Write($"| {i} |"); }
        }
        Console.WriteLine();
        for (int i = 0; i < gridSize; i++) { Console.Write("#---#"); }
        Console.WriteLine();
        Console.ResetColor();
    }
    public void setColumn(GridSquare[,] grid) {
        // Set A-J column
        char temp = 'A';
        for (int i = 0; i < gridSize; i++) {
            grid[i, 0].symbol = temp;
            temp++;
        }
    }
    public void drawGrid(GridSquare[,] grid) {
        // Draw Grid
        for (int loop = 0; loop < gridSize; loop++) {
            for (int i = 0; i < gridSize; i++) {
                Console.Write("#---#");
            }
            Console.WriteLine();

            for (int i = 0; i < gridSize; i++) {
                // Console.Write($"| ? |");
                if (i == 0) {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"| {grid[loop, i].symbol} |");
                    Console.ResetColor();
                }
                else {
                    // Write Symbol, but use color codes.
                    grid[loop, i].setSymbol(grid[loop, i].vehicle);
                    char symbol = grid[loop, i].getSymbol();
                    colorize(symbol);
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < gridSize; i++) { Console.Write("#---#"); }
        Console.WriteLine();
    }
    public string getInput() {
        string x;
        //Read input from user
        Console.WriteLine("Please Enter Full Coordinate ( E.G 'B7')");
        x = Console.ReadLine();
        Console.WriteLine($"You entered: {x}");
        return x;
    }
    public void initializeGrid(GridSquare[,] grid) {
        for (int loop = 0; loop < gridSize; loop++) {

            for (int i = 0; i < gridSize; i++) {
                grid[loop, i] = new GridSquare();
            }
        }
    }
    public void DropBomb(string x) {
        // Check Input for Validity
        if (x.Length <= 3) {
            // Everything is Ok
            Coordinate position;
            position = stringToCoordinate(x);
            processHit(position);
        }
        else {
            // Invalid Input.
            Console.Clear();
            Console.WriteLine("*** Sorry, Invalid Input. Please Try Again ***");
        }
        // Redraw Grid, preferably with that spot Marked as "X"
    }
    public void processHit(Coordinate z) {
        int x = z.getX();
        int y = z.getY();

        if(grid[x,y].isOccupied == true) {
        grid[x, y].isOccupied = false;
        grid[x, y].vehicle = GridSquare.battle_type.HIT;
        grid[x, y].symbol = 'X';
        }
        
    }
    private Coordinate stringToCoordinate(string str) {
        // Converts string into Coordinates.
        int x, y;

        if (str.Length == 2) {
            string temp1 = str[0].ToString().ToUpper(); ;
           // Console.WriteLine($"temp1: {temp1}");
            string temp2 = str[1].ToString();
           // Console.WriteLine($"temp2: {temp2}");

            x = stringToX(temp1);
          //  Console.WriteLine($"X is {x}");
            y = Int32.Parse(temp2);
          //  Console.WriteLine($"Y is {y}");
            Console.WriteLine($"Attack Point is ({x},{y})");
        }
        else {
            string temp1 = str[0].ToString().ToUpper() ;
          //  Console.WriteLine($"temp1: {temp1}");
            string temp2 = str.Substring(1, 2).ToString();
          //  Console.WriteLine($"temp2: {temp2}");

            x = stringToX(temp1);
            y = Int32.Parse(str.Substring(1, 2));
            Console.WriteLine($"Attack Point is ({x},{y})");
        }
        Coordinate obj = new Coordinate(x, y);
        return obj;
    }
    private int stringToX(string x) {
        int xValue = 0;
        if(x == "A") { xValue = 0; }
        else if(x == "B") { xValue = 1; }
        else if (x == "C") { xValue = 2; }
        else if (x == "D") { xValue = 3; }
        else if (x == "E") { xValue = 4; }
        else if (x == "F") { xValue = 5; }
        else if (x == "G") { xValue = 6; }
        else if (x == "H") { xValue = 7; }
        else if (x == "I") { xValue = 8; }
        else { xValue = 9; }

        return xValue;
    }
    public void Reset() {
        // Reset Things
        Console.Clear();

    }
    public bool hasShipsLeft() {
        int leftover = 0;
        for(int loop = 0; loop < gridSize; loop++) {
            for(int i = 0; i < gridSize; i++) {
                if(grid[loop,i].isOccupied == true) {
                    leftover = leftover + 1;
                }
            }
        }
        if(leftover == 0) { HasShipsLeft = false; }
        return HasShipsLeft;
    }
    public Grid(int x) {
        gridSize = x+1;
        grid = new GridSquare[gridSize, gridSize];
    }
    public void MarkingTargets(GridSquare[,] grid) {
        // Mark Targets
        // SUBMARINES
        grid[0, 5].setStatus(GridSquare.battle_type.Submarine, true);
        grid[0, 6].setStatus(GridSquare.battle_type.Submarine, true);
        grid[0, 7].setStatus(GridSquare.battle_type.Submarine, true);

        grid[6, 2].setStatus(GridSquare.battle_type.Submarine, true);
        grid[7, 2].setStatus(GridSquare.battle_type.Submarine, true);
        grid[8, 2].setStatus(GridSquare.battle_type.Submarine, true);

        //PATROL BOATS
        grid[1, 1].setStatus(GridSquare.battle_type.Patrol, true);
        grid[1, 2].setStatus(GridSquare.battle_type.Patrol, true);

        grid[2, 10].setStatus(GridSquare.battle_type.Patrol, true);
        grid[3, 10].setStatus(GridSquare.battle_type.Patrol, true);

        grid[7, 9].setStatus(GridSquare.battle_type.Patrol, true);
        grid[7, 10].setStatus(GridSquare.battle_type.Patrol, true);

        // BATTLE SHIPS
        grid[5, 8].setStatus(GridSquare.battle_type.Battleship, true);
        grid[6, 8].setStatus(GridSquare.battle_type.Battleship, true);
        grid[7, 8].setStatus(GridSquare.battle_type.Battleship, true);
        grid[8, 8].setStatus(GridSquare.battle_type.Battleship, true);

        // AIR_PLANE
        grid[4, 3].setStatus(GridSquare.battle_type.Aircraft, true);
        grid[4, 4].setStatus(GridSquare.battle_type.Aircraft, true);
        grid[4, 5].setStatus(GridSquare.battle_type.Aircraft, true);
        grid[4, 6].setStatus(GridSquare.battle_type.Aircraft, true);
        grid[4, 7].setStatus(GridSquare.battle_type.Aircraft, true);

    }

    public void colorize(char obj) {
        // Change Background Color depending on Vehicle Type.
        switch(obj) {
            case 'A':
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            case 'B':
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            case 'D':
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            case 'P':
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            case 'S':
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            case 'X':
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"| {obj} |");
                Console.ResetColor();
                break;
            default:
                Console.Write($"| {obj} |");
                break;
        }
    }
}

class GridSquare {
    public enum battle_type { Aircraft, Battleship, Submarine, Destroyer, Patrol, HIT, NONE }
    public string Location = "N/A";
    public Boolean isOccupied = false;
    public battle_type vehicle = battle_type.NONE;
    public char symbol = '?';

    public void setStatus(battle_type x, Boolean y) {
        vehicle = x;
        isOccupied = y;
    }
    public char getSymbol() { return symbol; }
    public void setSymbol(battle_type type) {

        switch (type) {
            case battle_type.Aircraft:
                symbol = 'A';
                break;
            case battle_type.Battleship:
                symbol = 'B';
                break;
            case battle_type.Submarine:
                symbol = 'S';
                break;
            case battle_type.Destroyer:
                symbol = 'D';
                break;
            case battle_type.Patrol:
                symbol = 'P';
                break;
            case battle_type.HIT:
                symbol = 'X';
                break;
            default:
                symbol = '?';
                break;

        }
    }
}
class Coordinate {
    int x, y;

    public Coordinate(int in1, int in2) {
        x = in1;
        y = in2;
    }
    public int getX() { return x; }
    public int getY() { return y; }
}