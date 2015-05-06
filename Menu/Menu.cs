using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using Microsoft.Xna.Framework.Storage;

namespace GameProject.Menu
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    /// Optionally takes a GameLoop argument, when the menu must be able to
    /// resume the current GameLoop. Otherwise, the reference would be lost
    /// and the gameLoop garbage collected.
    public class Menu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        public Menu(Game game)
            : base(game)
        { }

       
        public override void Initialize()
        {
            
            base.Initialize();
        }

        
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
        }

        
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

        }

        void menuAction()
        {
        }
    }
}