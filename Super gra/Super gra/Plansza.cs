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
    class Plansza
    {
        List<Przeszkoda> listaPrzeszkod = new List<Przeszkoda>();
        //List<Pocisk> listaPociskow;
        Gracz gracz = new Gracz(Vector2.Zero);
        Texture2D przeszkoda, pocisk;


        public void LoadContent(ContentManager Content)
        {
            gracz.LoadContent(Content);
            przeszkoda = Content.Load<Texture2D>("Przeszkoda");
            pocisk = Content.Load<Texture2D>("Pocisk");
        }

        public void Update(GameTime gameTime)
        {
            gracz.Update(gameTime, listaPrzeszkod);
            //listaPrzeszkod.Add(new Przeszkoda(Vector2.Zero));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(gracz.tekstura, gracz.pozycjaGracza, Color.White);
            if (listaPrzeszkod.Count > 0)
            {
                for (int i = 0; i < listaPrzeszkod.Count; i++)
                {
                    spriteBatch.Draw(przeszkoda, new Vector2(listaPrzeszkod[i].pozycjaPrzeszkody.X, listaPrzeszkod[i].pozycjaPrzeszkody.Y), Color.White);
                }

                for (int i = 0; i < gracz.listaPociskow.Count; i++)
                {
                    spriteBatch.Draw(pocisk, gracz.listaPociskow[i].pozycja, Color.White);
                }
            }
            spriteBatch.End();
            

        }


    }
}
