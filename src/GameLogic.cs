using System;
using SwinGameSDK;

public class GameLogic
{
	public static void Main()
	{
        //Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

        //Load Resources
        LoadResources();

        SwinGame.PlayMusic(GameMusic("Background"));

        //Game Loop
        while (SwinGame.WindowCloseRequested() != true && CurrentState != GameState.Quitting)
        {
            HandleUserInput();
            DrawScreen();
        }

        SwinGame.StopMusic();

        //Free Resources and Close Audio, to end the program.
        FreeResources();

    }
}
