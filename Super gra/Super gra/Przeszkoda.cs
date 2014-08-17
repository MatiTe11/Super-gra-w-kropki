using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Super_gra
{
    class Przeszkoda
    {
        Vector2 pozycjaPrzeszkody;
        Vector2 wymiaryPrzeszkody = new Vector2(100);
        MouseState mysz;
        MouseState prevMysz;

        public Przeszkoda(Vector2 pozycja)
        {
            this.pozycjaPrzeszkody = pozycja;
        }


        public void StawianiePrzeszkody()
        {
            prevMysz = mysz;
            mysz = Mouse.GetState();
            if (mysz.RightButton == ButtonState.Pressed && prevMysz.RightButton == ButtonState.Released)
            {
                pozycjaPrzeszkody.X = mysz.X;
                pozycjaPrzeszkody.Y = mysz.Y;
            }

        }

        public float PrzeszkodaGora
        {
            get { return pozycjaPrzeszkody.Y; }
        }
        public float PrzeszkodaDol
        {
            get { return pozycjaPrzeszkody.Y + wymiaryPrzeszkody.Y; }
        }
        public float PrzeszkodaLewo
        {
            get { return pozycjaPrzeszkody.X; }
        }
        public float PrzeszkodaPrawo
        {
            get { return pozycjaPrzeszkody.X + wymiaryPrzeszkody.X; }
        }
        
    }
}
