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
       MouseState mysz;
       MouseState prevMysz;
       int predkosc = 300;
       int iloscPrzeszkod;
       public Texture2D tekstura;
       //List<Przeszkoda> listaPrzeszkod;


       public Gracz(Vector2 pozycja)
       {
           //this.listaPrzeszkod = listaPrzeszkod;
           this.pozycjaGracza = pozycja;
           iloscPrzeszkod = 10;
       }

       public void LoadContent(ContentManager Content)
       {
           tekstura = Content.Load<Texture2D>("Gracz");
       }

       public void Update(GameTime gameTime, List<Przeszkoda> listaPrzeszkod)
       {
           klawiatura = Keyboard.GetState();
           prevMysz = mysz;
           mysz = Mouse.GetState();

           if (klawiatura.IsKeyDown(Keys.D))
               pozycjaGracza.X += predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           else if (klawiatura.IsKeyDown(Keys.A))
               pozycjaGracza.X -= predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           if (klawiatura.IsKeyDown(Keys.S))
               pozycjaGracza.Y += predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;
           else if (klawiatura.IsKeyDown(Keys.W))
               pozycjaGracza.Y -= predkosc * (float)gameTime.ElapsedGameTime.TotalSeconds;

           if(mysz.RightButton == ButtonState.Pressed && prevMysz.RightButton == ButtonState.Released && iloscPrzeszkod != 0)
           {
               listaPrzeszkod.Add(new Przeszkoda(new Vector2(mysz.X,mysz.Y)));
               iloscPrzeszkod--;
           }
           
       }


    }
}
