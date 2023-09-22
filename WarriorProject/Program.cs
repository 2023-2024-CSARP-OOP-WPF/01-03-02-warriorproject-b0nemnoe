/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    public class Position
    {
        private int _x;
        private int _y;


        public int X { get => _x; }

        public int Y { get => _y; }


        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine($"({_x},{_y})");
        }


        public class Warrior
        {
            private string _name;
            private Position _position;


            public Warrior(string name, Position position)
            {
                this._name = name;
                this._position = position;
            }

            public void MoveHorizontal(int distance)
            {
                this._position._x += distance;
            }
            public void MoveVertical(int distance)
            {
                this._position._y += distance;
            }


            public void ToConsole()
            {
                Console.WriteLine($"{_name}, position ({this._position.X},{this._position.Y})");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Position position = new Position(2, -1);
                position.ToConsole();
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.ToConsole();
                warrior.MoveHorizontal(3);
                warrior.MoveVertical(-2);
                warrior.ToConsole();
            }
        }
    }
}