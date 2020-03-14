using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public static void UpdatePosition(string keyPressed, out int xCoordinate, out int yCoordinate)
        {
            switch (keyPressed)
            {
                case "LeftArrow":
                    out xCoordinate -= 1;
                    break;
                case "RightArrow":
                    out xCoordinate += 1;
                    break;
                case "UpArrow":
                    out yCoordinate -= 1;
                    break;
                case "DownArrow":
                    out yCoordinate += 1;
                    break;
                case "Spacebar":
                    break;
                default:
                    // xCoordinate = 0;
                    // yCoordinate = 0;
                    break;
            }
        }
    }
}