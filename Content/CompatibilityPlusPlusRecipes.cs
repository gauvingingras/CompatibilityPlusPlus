using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CompatibilityPlusPlus.Content
{
    public class CompatibilityPlusPlusRecipes : ModSystem
    {
        private const string DesertBannersGroup = "CompatibilityPlusPlus:DesertBanners";
        private const string SnowBannersGroup = "CompatibilityPlusPlus:SnowBanners";
        private const string UnderworldBannersGroup = "CompatibilityPlusPlus:UnderworldBanners";

        public override void AddRecipes()
        {
            #region Fargo's Mutant Mod
            if (CompatibilityPlusPlus.fargosMutantMod != null)
            {
                #region Vanilla
                Recipe.Create(ItemID.DungeonDesertKey)
                    .AddRecipeGroup(DesertBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();

                Recipe.Create(ItemID.FrozenKey)
                    .AddRecipeGroup(SnowBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();
                #endregion

                #region Thorium Mod
                if (CompatibilityPlusPlus.thoriumMod != null)
                {
                    Mod thoriumMod = CompatibilityPlusPlus.thoriumMod;
                    if (thoriumMod.TryFind("UnderworldBiomeKey", out ModItem underworldBiomeKey))
                    {
                        Recipe.Create(underworldBiomeKey.Type)
                            .AddRecipeGroup(UnderworldBannersGroup, 10)
                            .AddTile(TileID.Solidifier)
                            .AddCondition(Condition.Hardmode)
                            .Register();
                    }
                }
                #endregion
            }
            #endregion
        }

        public override void AddRecipeGroups()
        {
            List<int> desertBanners = [];
            List<int> snowBanners = [];
            List<int> underworldBanners = [];

            #region Thorium Mod
            if (CompatibilityPlusPlus.thoriumMod != null)
            {
                Mod thoriumMod = CompatibilityPlusPlus.thoriumMod;
                #region Snow Banners
                if (thoriumMod.TryFind("SnowballBanner", out ModItem snowballBanner))
                {
                    snowBanners.Add(snowballBanner.Type);
                }

                if (thoriumMod.TryFind("SnowyOwlBanner", out ModItem snowyOwlBanner))
                {
                    snowBanners.Add(snowyOwlBanner.Type);
                }

                if (thoriumMod.TryFind("BlizzardBatBanner", out ModItem blizzardBatBanner))
                {
                    snowBanners.Add(blizzardBatBanner.Type);
                }

                if (thoriumMod.TryFind("FrostBurntBanner", out ModItem frostBurntBanner))
                {
                    snowBanners.Add(frostBurntBanner.Type);
                }

                if (thoriumMod.TryFind("SnowElementalBanner", out ModItem snowElementalBanner))
                {
                    snowBanners.Add(snowElementalBanner.Type);
                }
                #endregion
                #region Underworld Banners
                if (thoriumMod.TryFind("BoneFlyerBanner", out ModItem boneFlyerBanner))
                {
                    underworldBanners.Add(boneFlyerBanner.Type);
                }

                if (thoriumMod.TryFind("UnderworldPotBanner", out ModItem underworldPotBanner))
                {
                    underworldBanners.Add(underworldPotBanner.Type);
                }

                if (thoriumMod.TryFind("InfernalHoundBanner", out ModItem infernalHoundBanner))
                {
                    underworldBanners.Add(infernalHoundBanner.Type);
                }

                if (thoriumMod.TryFind("MoltenMortarBanner", out ModItem moltenMortarBanner))
                {
                    underworldBanners.Add(moltenMortarBanner.Type);
                }

                if (thoriumMod.TryFind("HellBringerMimicBanner", out ModItem hellBringerMimicBanner))
                {
                    underworldBanners.Add(hellBringerMimicBanner.Type);
                }
                #endregion
            }
            #endregion

            RecipeGroup.RegisterGroup(DesertBannersGroup, new RecipeGroup(() => Language.GetTextValue("Mods.CompatibilityPlusPlus.Recipes.Groups.DesertBanners"),
                [
                    ItemID.VultureBanner,
                    ItemID.AntlionBanner,
                    ItemID.MummyBanner,
                    ItemID.LightMummyBanner,
                    ItemID.DarkMummyBanner,
                    ItemID.BloodMummyBanner,
                    ItemID.WalkingAntlionBanner,
                    ItemID.LarvaeAntlionBanner,
                    ItemID.FlyingAntlionBanner,
                    ItemID.SandSlimeBanner,
                    ItemID.TombCrawlerBanner,
                    ItemID.DesertBasiliskBanner,
                    ItemID.RavagerScorpionBanner,
                    ItemID.DesertLamiaBanner,
                    ItemID.DuneSplicerBanner,
                    ItemID.DesertGhoulBanner,
                    ItemID.DesertDjinnBanner,
                    ItemID.TumbleweedBanner,
                    ItemID.SandElementalBanner,
                    ItemID.SandsharkBanner,
                    ItemID.SandsharkHallowedBanner,
                    ItemID.SandsharkCorruptBanner,
                    ItemID.SandsharkCrimsonBanner,
                    ..desertBanners
                ]));

            RecipeGroup.RegisterGroup(SnowBannersGroup, new RecipeGroup(() => Language.GetTextValue("Mods.CompatibilityPlusPlus.Recipes.Groups.SnowBanners"),
                [
                    ItemID.IceSlimeBanner,
                    ItemID.ZombieEskimoBanner,
                    ItemID.CorruptPenguinBanner,
                    ItemID.CrimsonPenguinBanner,
                    ItemID.IceElementalBanner,
                    ItemID.WolfBanner,
                    ItemID.IceGolemBanner,
                    .. snowBanners
                ]));

            RecipeGroup.RegisterGroup(UnderworldBannersGroup, new RecipeGroup(() => Language.GetTextValue("Mods.CompatibilityPlusPlus.Recipes.Groups.UnderworldBanners"),
                [
                    ItemID.HellbatBanner,
                    ItemID.LavaSlimeBanner,
                    ItemID.FireImpBanner,
                    ItemID.DemonBanner,
                    ItemID.BoneSerpentBanner,
                    ItemID.MimicBanner,
                    ItemID.LavaBatBanner,
                    ItemID.RedDevilBanner,
                    .. underworldBanners
                ]));
        }

        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.HasResult(ItemID.DungeonDesertKey) && !recipe.HasRecipeGroup(DesertBannersGroup))
                {
                    recipe.DisableRecipe();
                }

                if (recipe.HasResult(ItemID.FrozenKey) && !recipe.HasRecipeGroup(SnowBannersGroup))
                {
                    recipe.DisableRecipe();
                }
            }
        }
    }
}
