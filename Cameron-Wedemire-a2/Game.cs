// Include the namespaces (code libraries) you need below.
using Raylib_cs;
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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Cavern Tavern");
            Window.SetSize(600, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(100, 100, 100);

            //draw the top of cave
            Draw.SetLineSize(3);

            //draw the fill of the top of the cave
            Draw.SetFillColor(50, 50, 50);
            Draw.SetLineColor(50, 50, 50);
            Draw.Triangle(0, 25, 50, 100, 125, 75);
            Draw.Triangle(125, 75, 175, 90, 250, 70);
            Draw.Triangle(250, 70, 300, 100, 430, 87);
            Draw.Triangle(430, 87, 500, 130, 530, 100);
            Draw.Triangle(560,80,600,40,600,0);

            Draw.Triangle(0, 25, 125, 76, 250, 70);
            Draw.Triangle(0, 25, 250, 70, 530, 100);
            Draw.Triangle(530, 100, 560, 80, 600, 0);
            Draw.Triangle(0, 25, 530, 100, 600, 0);
            Draw.Triangle(0, 0, 0, 25, 600, 0);
            
            //draw the outline of the top of the cave
            Draw.SetLineColor(187, 160, 130);
            Draw.Line(0, 25, 50, 100);
            Draw.Line(50, 100, 125, 75);
            Draw.Line(125, 75, 175, 90);
            Draw.Line(175, 90, 250, 70);
            Draw.Line(250, 70, 300, 100);
            Draw.Line(300, 100, 430, 87);
            Draw.Line(430, 87, 500, 130);
            Draw.Line(500, 130, 530, 100);
            Draw.Line(530, 100, 560, 80);
            Draw.Line(560, 80, 600, 40);


            //draw the tavern
            //base shape
            Draw.SetFillColor(139, 69, 19);
            Draw.SetLineColor(50,0,0);
            Draw.Rectangle(200, 150, 200, 150);
            Draw.SetFillColor(100, 70, 70);
            Draw.Triangle(180, 150, 300, 120, 420, 150);

            //door
            Draw.Rectangle(325, 200, 50, 100);
            Draw.SetFillColor(100, 100, 10);
            Draw.Circle(365, 260, 5);

            //window light and door light
            if (Input.IsMouseButtonUp(MouseButton.Left))
            {
                Draw.SetFillColor(60, 60, 50); // grey
            }
            else
            {
                Draw.SetFillColor(230, 230, 10); // Yellow
            }
            Draw.Rectangle(220, 200, 70, 50);
            Draw.Circle(350, 230, 10);

            //window frame
            Draw.SetFillColor(100, 70, 70);
            Draw.Rectangle(250, 200, 7, 50);
            Draw.Rectangle(220, 222, 35, 7);
            Draw.Rectangle(253, 222, 36, 7);

            //Draw Foreground //Draw.Triangle();
            Draw.SetLineSize(3);

            //draw the fill of the foreground
            Draw.SetFillColor(50, 50, 50);
            Draw.SetLineColor(50, 50, 50);
            Draw.Rectangle(0, 300, 600, 100);
            Draw.Triangle(0, 200, 75, 220, 130, 270);
            Draw.Triangle(0, 300, 0, 200, 180, 300);

            Draw.Triangle(180, 300, 210, 280, 290, 270);
            Draw.Triangle(290, 270, 360, 300, 290, 300);
            Draw.Triangle(180,300,290,270,290,300);


            Draw.Triangle(340, 290, 415, 270, 360, 300);
            Draw.Triangle(415, 270, 470, 230, 550, 280);
            Draw.Triangle(550, 280, 600, 240, 600, 300);
            Draw.Quad(340, 300, 415, 270, 550, 280, 600, 300);

            //draw the outline of the top of foreground
            Draw.SetLineColor(187, 160, 130);
            Draw.Line(0, 200, 75, 220);
            Draw.Line(75, 220, 130, 270);
            Draw.Line(130, 270, 180, 300);
            Draw.Line(180, 300, 210, 280);
            Draw.Line(210, 280, 290, 270);
            Draw.Line(290, 270, 340, 290);
            Draw.Line(340, 290, 415, 270);
            Draw.Line(415, 270, 470, 230);
            Draw.Line(470, 230, 550, 280);
            Draw.Line(550, 280, 600, 240);
        }
    }

}
