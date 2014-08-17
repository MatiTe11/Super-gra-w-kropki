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
    public class Przeszkoda
    {
        Vector2 pozycjaPrzeszkody;
        Vector2 wymiaryPrzeszkody = new Vector2(100);



        public Przeszkoda(Vector2 pozycja)
        {
            this.pozycjaPrzeszkody = pozycja;
        }

        //up
        public float PrzeszkodaGora
        {
            get { return pozycjaPrzeszkody.Y; }
        }
        //down
        public float PrzeszkodaDol
        {
            get { return pozycjaPrzeszkody.Y + wymiaryPrzeszkody.Y; }
        }
        //left
        public float PrzeszkodaLewo
        {
            get { return pozycjaPrzeszkody.X; }
        }
        //right
        public float PrzeszkodaPrawo
        {
            get { return pozycjaPrzeszkody.X + wymiaryPrzeszkody.X; }
        }
        
    }
}
