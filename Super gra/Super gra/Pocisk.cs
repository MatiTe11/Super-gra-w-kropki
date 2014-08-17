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
       public int predkosc = 1150;
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

           wynikNaX = gracz.X - mysz.X;
           wynikNaY = gracz.Y - mysz.Y;

       
           pozycja.X = gracz.X;
           pozycja.Y = gracz.Y;

           //if(mysz. X > gracz.X)
               predkoscP.X = -(wynikNaX / (Math.Abs(wynikNaX) + Math.Abs(wynikNaY))) * predkosc;
          // else
               //predkoscP.X = 0 - ((wynikNaX / (wynikNaX + wynikNaY)) * predkosc);


           //if(mysz.Y > gracz.Y)
                predkoscP.Y = -(wynikNaY / (Math.Abs(wynikNaY) + Math.Abs(wynikNaX))) * predkosc;
           //else
              // predkoscP.Y = 0 - ((wynikNaY / (wynikNaX + wynikNaY)) * predkosc);

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
