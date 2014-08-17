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
    class Pocisk
    {

        const int zasieg = 500;

        public bool Visible = false;

        Vector2 pozycja_startowa;
        Vector2 predkosc;
        Vector2 kierunek;
        Texture2D pocisk;

        public void LoadContent(ContentManager Content)
        {
            pocisk = Content.Load<Texture2D>("Pocisk");
        }

    }
}
