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
       Vector2 prevPozycja;
       public Vector2 wymiaryGracza = new Vector2(70);
       KeyboardState klawiatura;
       MouseState mysz;
       MouseState prevMysz;
       int predkosc = 300;
       int iloscPrzeszkod;
       public Texture2D tekstura;
       //List<Przeszkoda> listaPrzeszkod;
       public List<Pocisk> listaPociskow = new List<Pocisk>();


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
           prevPozycja = pozycjaGracza;

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
               listaPrzeszkod.Add(new Przeszkoda(new Vector2(mysz.X - 50,mysz.Y - 50)));
               iloscPrzeszkod--;
           }

           //strzał

           if(mysz.LeftButton == ButtonState.Pressed && prevMysz.LeftButton == ButtonState.Released)
           {
               listaPociskow.Add(new Pocisk());
               listaPociskow[listaPociskow.Count -  1].Init(pozycjaGracza);
           }

           for (int i = 0; i < listaPociskow.Count; i++)
           {
               listaPociskow[i].Update(gameTime);
           }

           //// kolizja z przeszkoda
           for (int i = 0; i < listaPrzeszkod.Count; i++)
           {
               if (pozycjaGracza.X + wymiaryGracza.X > listaPrzeszkod[i].PrzeszkodaLewo && pozycjaGracza.X < listaPrzeszkod[i].PrzeszkodaPrawo && pozycjaGracza.Y + wymiaryGracza.Y > listaPrzeszkod[i].PrzeszkodaGora && pozycjaGracza.Y < listaPrzeszkod[i].PrzeszkodaDol)
               {
                   //if()
                   //if(pozycjaGracza.X < listaPrzeszkod[i].PrzeszkodaLewo)
                   //{
                   //    pozycjaGracza.X = listaPrzeszkod[i].PrzeszkodaLewo - wymiaryGracza.X;
                   //}
                   //else if (pozycjaGracza.X > listaPrzeszkod[i].PrzeszkodaLewo)
                   //{
                   //    pozycjaGracza.X = listaPrzeszkod[i].PrzeszkodaPrawo;
                   //}

                   //if (pozycjaGracza.Y < listaPrzeszkod[i].PrzeszkodaGora)
                   //{
                   //    pozycjaGracza.Y = listaPrzeszkod[i].PrzeszkodaGora - wymiaryGracza.Y;
                   //}
                   //else if (pozycjaGracza.Y > listaPrzeszkod[i].PrzeszkodaGora)
                   //{
                   //    pozycjaGracza.Y = listaPrzeszkod[i].PrzeszkodaDol;
                   //}
                   




                   //if((prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X < listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol) || (prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y > listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X < listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol))
                   //    pozycjaGracza.X = listaPrzeszkod[i].PrzeszkodaLewo - wymiaryGracza.X;

                   //if ((prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X > listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol) || (prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X < listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol))
                   //    pozycjaGracza.Y = listaPrzeszkod[i].PrzeszkodaDol;

                   //if ((prevPozycja.X > listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X > listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol) || (prevPozycja.X > listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y > listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X > listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol))
                   //    pozycjaGracza.X = listaPrzeszkod[i].PrzeszkodaPrawo;

                   //if ((prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X > listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol) || (prevPozycja.X < listaPrzeszkod[i].PrzeszkodaLewo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaGora && prevPozycja.X < listaPrzeszkod[i].PrzeszkodaPrawo && prevPozycja.Y < listaPrzeszkod[i].PrzeszkodaDol))
                   //    pozycjaGracza.Y = listaPrzeszkod[i].PrzeszkodaGora - wymiaryGracza.Y;



               }
           }
           
       }


    }
}
