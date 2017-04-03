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
            //GraphicsWindow.DrawRectangle(10, 25, 625, 500);
            int x = rnd.Next(10, 625);
            int y = rnd.Next(50, 450);
            TextWindow.WriteLine(x + "    " + y);
            Shapes.Move(eat, x, y);
            int s = 5;
            Turtle.Speed = s;
            Turtle.PenUp();
            while(true)
            {
               
                //TextWindow.Write(Turtle.X + "    ");
                //TextWindow.WriteLine(Turtle.Y);
                Turtle.Move(5);


                if (Turtle.X > x - 10 && Turtle.X < x + 10 && Turtle.Y > y - 10 && Turtle.Y < y + 10)
                {
                    x = rnd.Next(10, 625);
                    y = rnd.Next(50, 500);
                    Shapes.Move(eat, x, y);
                    TextWindow.WriteLine(x + "    " + y);
                    //s = s + 3;
                    //Turtle.Speed = s;
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
