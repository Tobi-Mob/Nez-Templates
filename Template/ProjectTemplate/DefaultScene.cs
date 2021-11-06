using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace ProjectTemplate
{
    public class DefaultScene : Scene
    {
        private Entity entity = null;
        
        public override void Initialize()
        {
            SetDesignResolution(Screen.Width, Screen.Height, SceneResolutionPolicy.ShowAllPixelPerfect);
            
            var texture = Content.LoadTexture(Nez.Content.Sprites.Nezlogoblack);
            
            entity = CreateEntity("logo", new Vector2(Screen.Width / 2, Screen.Height / 2));
            entity.AddComponent(new SpriteRenderer(texture));
        }

        public override void Update()
        {
            base.Update();
            entity.Transform.RotationDegrees += 30 * Time.DeltaTime;
        }
    }
}