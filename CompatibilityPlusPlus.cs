using Terraria.ModLoader;

namespace CompatibilityPlusPlus
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class CompatibilityPlusPlus : Mod
	{
        public static Mod fargosMutantMod;
        public static Mod thoriumMod;

        public override void Load()
        {
            ModLoader.TryGetMod("Fargowiltas", out fargosMutantMod);
            ModLoader.TryGetMod("ThoriumMod", out thoriumMod);
        }

        public override void Unload()
        {
            fargosMutantMod = null;
            thoriumMod = null;
        }
    }
}
