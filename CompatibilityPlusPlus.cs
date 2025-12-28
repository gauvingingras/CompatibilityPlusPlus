using Terraria.ModLoader;

namespace CompatibilityPlusPlus
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class CompatibilityPlusPlus : Mod
    {
        private static Mod fargosMutantMod;
        public static Mod FargosMutantMod
        {
            get
            {
                return fargosMutantMod;
            }
        }

        private static Mod thoriumMod;
        public static Mod ThoriumMod
        {
            get
            {
                return thoriumMod;
            }
        }

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
