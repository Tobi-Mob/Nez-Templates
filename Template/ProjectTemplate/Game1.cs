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
            
#if (exclude_from_template)
//My template-Engine just removed the "if NEZ" part, even if the documentation says
//that only if with () should be considered by the template engine.
//This cnd:noEmit forces the engine to not do that.
//https://github.com/dotnet/templating/issues/3085#issuecomment-838435886
#endif
//-:cnd:noEmit
#if NEZ
            // If you observe render artifacts, try switching this flag.
            Batcher.UseFnaHalfPixelMatrix = true;
#endif
//+:cnd:noEmit

        }
    }
}