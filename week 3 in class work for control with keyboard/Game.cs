// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //variables
        float x = 200;
        float y = 200;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Move Avatar");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(240);

            //x movement
            if (Input.IsKeyboardKeyDown(KeyboardKey.Right) == true)
            {
                //every frame, add 1/60 * 100px
                x += Time.DeltaTime * 100;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Left) == true)
            {
                //every frame, add 1/60 * 100px
                x -= Time.DeltaTime * 100;
            }

            //y movement
            if (Input.IsKeyboardKeyDown(KeyboardKey.Down) == true)
            {
                //every frame, add 1/60 * 100px
                y += Time.DeltaTime * 100;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Up) == true)
            {
                //every frame, add 1/60 * 100px
                y -= Time.DeltaTime * 100;
            }

            //Draw "avatar"
            Draw.SetFillColor(255, 0, 0);
            Draw.Circle(x, y, 25);
        }
    }

}
