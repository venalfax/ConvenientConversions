using Terraria.ModLoader;
using ConvenientConversions.FragmentRecipes;

namespace ConvenientConversions
{
    class ConvenientConversions : Mod
    {
        public ConvenientConversions()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void AddRecipes()
        {
            Nebula.AddRecipes(this);
            Solar.AddRecipes(this);
            Stardust.AddRecipes(this);
            Vortex.AddRecipes(this);
        }
    }
}