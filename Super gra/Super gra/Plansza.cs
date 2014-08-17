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
        List<Przeszkoda> listaPrzeszkod;
        List<Pocisk> listaPociskow;
        Gracz gracz = new Gracz(Vector2.Zero);

        public void LoadContent(ContentManager Content)
        {
            gracz.LoadContent(Content);
        }

        public void Update(GameTime gameTime)
        {
            gracz.Update(gameTime, listaPrzeszkod);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(gracz.tekstura, gracz.pozycjaGracza, Color.White);
            spriteBatch.End();
            

        }


    }
}
