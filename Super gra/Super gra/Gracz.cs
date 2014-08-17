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
   public class Gracz
    {
        //
       public Vector2 pozycjaGracza;
       public Vector2 wymiaryGracza = new Vector2(70);
       KeyboardState klawiatura;
       int predkosc = 300;
       int iloscPrzeszkod;


       public Gracz(Vector2 pozycja)
       {
           this.pozycjaGracza = pozycja;
       }


       public void Update(GameTime gameTime)
       {
           klawiatura = Keyboard.GetState();

           if (klawiatura.IsKeyDown(Keys.D))
               pozycjaGracza.X += predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           else if (klawiatura.IsKeyDown(Keys.A))
               pozycjaGracza.X -= predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           if (klawiatura.IsKeyDown(Keys.S))
               pozycjaGracza.Y += predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           else if (klawiatura.IsKeyDown(Keys.W))
               pozycjaGracza.Y -= predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;


       }


    }
}
