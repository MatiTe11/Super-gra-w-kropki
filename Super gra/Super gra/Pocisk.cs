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
       //public Vector2 predkosc;
       public int predkość;
       public Texture2D pocisk;


       public Pocisk(Gracz gracz)
       {
           this.gracz = gracz;
       }


  

        public void LoadContent(ContentManager Content)
        {
            pocisk = Content.Load<Texture2D>("Pocisk");
        }

        ///koment
        ///

        

    }
}
