using System.Security.Principal;
using Microsoft.Xna.Framework;
using Nez;

namespace ProjectTemplate
{
    public class Game1 : Nez.Core 
    {
        protected override void Initialize()
        {
            base.Initialize();
            
            Window.AllowUserResizing = true;
            PauseOnFocusLost = false;

            Scene = new DefaultScene();
            Batcher.UseFnaHalfPixelMatrix = true;
        }
    }
}