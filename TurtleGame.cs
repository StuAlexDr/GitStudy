using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame

{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += change_direction;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            Random rnd = new Random();
            
            int x = rnd.Next(0, GraphicsWindow.Width - 10);
            int y = rnd.Next(0, GraphicsWindow.Height - 10);
            
            Shapes.Move(eat, x, y);
            int s = 5;
            Turtle.Speed = s;
            Turtle.PenUp();
            TextWindow.WriteLine("Score = " + s);
            while (true)
            {
               
                Turtle.Move(5);


                if (Turtle.X > x && Turtle.X < x + 10 && Turtle.Y > y && Turtle.Y < y + 10)
                {
                    x = rnd.Next(0, GraphicsWindow.Width - 10);
                    y = rnd.Next(0, GraphicsWindow.Height - 10);
                    Shapes.Move(eat, x, y);

                    s = s + 1;
                    Turtle.Speed = s;
                    TextWindow.WriteLine("Score = " + s);
                    if(s > 10)
                    {
                        x = rnd.Next(0, GraphicsWindow.Width - 10);
                        y = rnd.Next(0, GraphicsWindow.Height - 10);
                        Shapes.Move(eat, x, y);
                    }
                }

            }


        }

        private static void change_direction()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
