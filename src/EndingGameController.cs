using System;
using SwinGameSDK;

/// <summary>
/// ''' The EndingGameController is responsible for managing the interactions at the end
/// ''' of a game.
/// ''' </summary>
namespace Battleships
{
    internal class EndingGameController
    {
        /// <summary>
        ///     ''' Draw the end of the game screen, shows the win/lose state
        ///     ''' </summary>
        public void DrawEndOfGame()
        {
            Rectangle toDraw = new Rectangle();
            string whatShouldIPrint;
            DrawField(ComputerPlayer.PlayerGrid, ComputerPlayer, true);
            DrawSmallField(GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);
            toDraw.X = 0;
            toDraw.Y = 250;
            toDraw.Width = SwinGame.ScreenWidth();
            toDraw.Height = SwinGame.ScreenHeight();
            if (GameController.HumanPlayer.IsDestroyed)
            {
                whatShouldIPrint = "YOU LOSE!";
            }
            else
            {
                whatShouldIPrint = "-- WINNER --";
            }
            SwinGame.DrawTextLines(whatShouldIPrint, Color.White, Color.Transparent, GameResources.GameFont("ArialLarge"), FontAlignment.AlignCenter, toDraw);
        }

        /// <summary>
        ///     ''' Handle the input during the end of the game. Any interaction
        ///     ''' will result in it reading in the highsSwinGame.
        ///     ''' </summary>
        public void HandleEndOfGameInput()
        {
            if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.ReturnKey) || SwinGame.KeyTyped(KeyCode.EscapeKey))
            {
                ReadHighScore(GameController.HumanPlayer.Score);
                EndCurrentState();
            }
        }
    }
}