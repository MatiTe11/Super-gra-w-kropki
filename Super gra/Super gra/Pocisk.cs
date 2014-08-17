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
       //Vector2 gracz;
       public Vector2 pozycja;
       public Vector2 predkoscP;
       public int predkosc = 450;
       public Texture2D pocisk;
       MouseState mysz;
       public float wynikNaX;
       public float wynikNaY;
       


       public Pocisk()
       {
           //this.gracz = gracz;
       }


       public void Init(Vector2 gracz)
       {
           mysz = Mouse.GetState();

           if (gracz.X > mysz.X)
           {

               wynikNaX = (int)gracz.X - (int)mysz.X;

           }

           else
           {
               wynikNaX = (int)mysz.X - (int)gracz.X;
           }

           if (gracz.Y > mysz.Y)
           {

               wynikNaY = (int)gracz.Y - (int)mysz.Y;

           }

           else
           {
               wynikNaY = mysz.Y - gracz.Y;
           }
           pozycja.X = gracz.X;
           pozycja.Y = gracz.Y;
           predkoscP.X = (wynikNaX / wynikNaY) * predkosc;
           predkoscP.Y = (wynikNaY / wynikNaX) * predkosc;
       }

        public void Update(GameTime gameTime)

       {

           pozycja.X += predkoscP.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
           pozycja.Y += predkoscP.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;

       }
       


        public void LoadContent(ContentManager Content)
        {
            pocisk = Content.Load<Texture2D>("Pocisk");
        }

        ///koment
        ///

        

    }
}
