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
   public class Pocisk
    {

       const int zasieg = 500;

       public bool Visible = false;
       Gracz gracz;
       public Vector2 pozycja;
       public Vector2 predkoscP;
       public int predkosc;
       public Texture2D pocisk;
       MouseState mysz;
       public int wynikNaX;
       public int wynikNaY;
       


       public Pocisk(Gracz gracz)
       {
           this.gracz = gracz;
       }

        public void Update(GameTime gameTime)

       {
            mysz = Mouse.GetState();

           if(gracz.pozycjaGracza.X > mysz.X)
           {

               wynikNaX = (int)gracz.pozycjaGracza.X - (int)mysz.X;

           }

           else
           {
               wynikNaX = (int)mysz.X - (int)gracz.pozycjaGracza.X;
           }

           if (gracz.pozycjaGracza.Y > mysz.Y)
           {

               wynikNaY = (int)gracz.pozycjaGracza.Y - (int)mysz.Y;

           }

           else
           {
               wynikNaY = (int)mysz.Y - (int)gracz.pozycjaGracza.Y;
           }

       }
       


        public void LoadContent(ContentManager Content)
        {
            pocisk = Content.Load<Texture2D>("Pocisk");
        }

        ///koment
        ///

        

    }
}
