using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CompatibilityPlusPlus.Content
{
    public class CompatibilityPlusPlusRecipes : ModSystem
    {
        private static RecipeGroup AquaticDepthsBannersGroup;
        private static RecipeGroup CorruptionBannersGroup;
        private static RecipeGroup CrimsonBannersGroup;
        private static RecipeGroup DesertBannersGroup;
        private static RecipeGroup HallowedBannersGroup;
        private static RecipeGroup JungleBannersGroup;
        private static RecipeGroup SnowBannersGroup;
        private static RecipeGroup UnderworldBannersGroup;

        public override void Unload()
        {
            AquaticDepthsBannersGroup = null;
            CorruptionBannersGroup = null;
            CrimsonBannersGroup = null;
            DesertBannersGroup = null;
            HallowedBannersGroup = null;
            JungleBannersGroup = null;
            SnowBannersGroup = null;
            UnderworldBannersGroup = null;
        }

        public override void AddRecipes()
        {
            #region Fargo's Mutant Mod
            if (CompatibilityPlusPlus.FargosMutantMod != null)
            {
                #region Vanilla
                Recipe.Create(ItemID.CorruptionKey)
                    .AddRecipeGroup(CorruptionBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();

                Recipe.Create(ItemID.CrimsonKey)
                    .AddRecipeGroup(CrimsonBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();

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

                Recipe.Create(ItemID.HallowedKey)
                    .AddRecipeGroup(HallowedBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();

                Recipe.Create(ItemID.JungleKey)
                    .AddRecipeGroup(JungleBannersGroup, 10)
                    .AddTile(TileID.Solidifier)
                    .AddCondition(Condition.Hardmode)
                    .Register();
                #endregion
                #region Thorium Mod
                if (CompatibilityPlusPlus.ThoriumMod != null)
                {
                    Mod thoriumMod = CompatibilityPlusPlus.ThoriumMod;
                    if (thoriumMod.TryFind("AquaticDepthsBiomeKey", out ModItem aquaticDepthsBiomeKey)) {
                        Recipe.Create(aquaticDepthsBiomeKey.Type)
                            .AddRecipeGroup(AquaticDepthsBannersGroup, 10)
                            .AddTile(TileID.Solidifier)
                            .AddCondition(Condition.Hardmode)
                            .Register();

                        if (thoriumMod.TryFind("Fishbone", out ModItem fishbone)) {
                            Recipe.Create(fishbone.Type)
                                .AddIngredient(aquaticDepthsBiomeKey)
                                .AddTile(TileID.MythrilAnvil)
                                .AddCondition(Condition.DownedPlantera)
                                .Register();
                        }
                    }

                    if (thoriumMod.TryFind("UnderworldBiomeKey", out ModItem underworldBiomeKey))
                    {
                        Recipe.Create(underworldBiomeKey.Type)
                            .AddRecipeGroup(UnderworldBannersGroup, 10)
                            .AddTile(TileID.Solidifier)
                            .AddCondition(Condition.Hardmode)
                            .Register();

                        if (thoriumMod.TryFind("PhoenixStaff", out ModItem phoenixStaff)) {
                            Recipe.Create(phoenixStaff.Type)
                                .AddIngredient(underworldBiomeKey)
                                .AddTile(TileID.MythrilAnvil)
                                .AddCondition(Condition.DownedPlantera)
                                .Register();
                        }
                    }
                }
                #endregion
            }
            #endregion
        }

        public override void AddRecipeGroups()
        {
            List<int> aquaticDepthsBanners = [];
            List<int> corruptionBanners = [];
            List<int> crimsonBanners = [];
            List<int> desertBanners = [];
            List<int> hallowedBanners = [];
            List<int> jungleBanners = [];
            List<int> snowBanners = [];
            List<int> underworldBanners = [];

            #region Thorium Mod
            #region Aquatic Depths Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ManofWarBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SharptoothBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BarracudaBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BlowfishBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "HammerHeadBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "GigaClamBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "OctopusBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "MorayBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FeedingFrenzyBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "VampireSquidBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "CrownofThornsBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "KrakenBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BlobfishBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "PutridSerpendBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "AbyssalAnglerBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "VoltEelBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SubmergedMimicBanner", aquaticDepthsBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "HallucinationBanner", aquaticDepthsBanners);
            #endregion
            #region Corruption Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "TheInnocentBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrostWurmBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowEaterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "TheStarvedBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "HorrificChargerBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "VileFloaterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ChilledSpitterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FreezerBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SoulCorrupterBanner", corruptionBanners);
            #endregion
            #region Crimson Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "LivingHemorrhageBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "CoolmeraBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrozenFaceBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BlisterPodBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ColdlingBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrozenGrossBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "EpidermonBanner", crimsonBanners);
            #endregion
            #region Hallowed Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "DissonanceSeerBanner", hallowedBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "GlitteringGolemBanner", hallowedBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SpectrumiteBanner", hallowedBanners);
            #endregion
            #region Jungle Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ArmyAntBanner", jungleBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "StrangeBulbBanner", jungleBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "MahoganyEntBanner", jungleBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "MossWaspBanner", jungleBanners);
            #endregion
            #region Snow Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowballBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowyOwlBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BlizzardBatBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrostBurntBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowElementalBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowFlinxMatriarchBanner", snowBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrostWurmBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SnowEaterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ChilledSpitterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FreezerBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "CoolmeraBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrozenFaceBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "ColdlingBanner", crimsonBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "FrozenGrossBanner", crimsonBanners);
            #endregion
            #region Underworld Banners
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "BoneFlyerBanner", underworldBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "UnderworldPotBanner", underworldBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "InfernalHoundBanner", underworldBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "MoltenMortarBanner", underworldBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "HellBringerMimicBanner", underworldBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "SoulCorrupterBanner", corruptionBanners);
            AddItemFromExternalModToGroup(CompatibilityPlusPlus.ThoriumMod, "EpidermonBanner", crimsonBanners);
            #endregion
            #endregion

            RegisterGroup(ref AquaticDepthsBannersGroup, "CompatibilityPlusPlus:AquaticDepthsBanners", "Mods.CompatibilityPlusPlus.Biomes.ThoriumMod.AquaticDepths",
                [
                    .. aquaticDepthsBanners
                ]);
            RegisterGroup(ref CorruptionBannersGroup, "CompatibilityPlusPlus:CorruptionBanners", "CLI.Corrupt",
                [
                    ItemID.EaterofSoulsBanner,
                    ItemID.CorruptGoldfishBanner,
                    ItemID.DevourerBanner,
                    ItemID.CorruptorBanner,
                    ItemID.CorruptSlimeBanner,
                    ItemID.SlimerBanner,
                    ItemID.WorldFeederBanner,
                    ItemID.DarkMummyBanner,
                    ItemID.CursedHammerBanner,
                    ItemID.ClingerBanner,
                    ItemID.BigMimicCorruptionBanner,
                    .. corruptionBanners
                ]);
            RegisterGroup(ref CrimsonBannersGroup, "CompatibilityPlusPlus:CrimsonBanners", "CLI.Crimson",
                [
                    ItemID.BloodCrawlerBanner,
                    ItemID.CrimsonGoldfishBanner,
                    ItemID.FaceMonsterBanner,
                    ItemID.CrimeraBanner,
                    ItemID.HerplingBanner,
                    ItemID.CrimslimeBanner,
                    ItemID.BloodJellyBanner,
                    ItemID.BloodFeederBanner,
                    ItemID.BloodMummyBanner,
                    ItemID.CrimsonAxeBanner,
                    ItemID.IchorStickerBanner,
                    ItemID.FloatyGrossBanner,
                    ItemID.BigMimicCrimsonBanner,
                    .. crimsonBanners
                ]);
            RegisterGroup(ref DesertBannersGroup, "CompatibilityPlusPlus:DesertBanners", "RandomWorldName_Location.Desert",
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
                ]);
            RegisterGroup(ref HallowedBannersGroup, "CompatibilityPlusPlus:HallowedBanners", "RandomWorldName_Adjective.Hallowed",
                [
                    ItemID.PixieBanner,
                    ItemID.UnicornBanner,
                    ItemID.RainbowSlimeBanner,
                    ItemID.GastropodBanner,
                    ItemID.LightMummyBanner,
                    ItemID.IlluminantSlimeBanner,
                    ItemID.IlluminantBatBanner,
                    ItemID.ChaosElementalBanner,
                    ItemID.EnchantedSwordBanner,
                    ItemID.BigMimicHallowBanner,
                    .. hallowedBanners
                ]);
            RegisterGroup(ref JungleBannersGroup, "CompatibilityPlusPlus:JungleBanners", "RandomWorldName_Location.Jungle",
                [
                    ItemID.JungleSlimeBanner,
                    ItemID.JungleBatBanner,
                    ItemID.PiranhaBanner,
                    ItemID.SnatcherBanner,
                    ItemID.DoctorBonesBanner,
                    ItemID.DerplingBanner,
                    ItemID.TortoiseBanner,
                    ItemID.GiantFlyingFoxBanner,
                    ItemID.AnglerFishBanner,
                    ItemID.ArapaimaBanner,
                    ItemID.AngryTrapperBanner,
                    ItemID.HornetBanner,
                    ItemID.ManEaterBanner,
                    ItemID.SpikedJungleSlimeBanner,
                    ItemID.LacBeetleBanner,
                    ItemID.JungleCreeperBanner,
                    ItemID.MossHornetBanner,
                    ItemID.MothBanner,
                    .. jungleBanners
                ]);
            RegisterGroup(ref SnowBannersGroup, "CompatibilityPlusPlus:SnowBanners", "RandomWorldName_Noun.Snow",
                [
                    ItemID.IceSlimeBanner,
                    ItemID.ZombieEskimoBanner,
                    ItemID.CorruptPenguinBanner,
                    ItemID.CrimsonPenguinBanner,
                    ItemID.IceElementalBanner,
                    ItemID.WolfBanner,
                    ItemID.IceGolemBanner,
                    ItemID.IceBatBanner,
                    ItemID.SnowFlinxBanner,
                    ItemID.SpikedIceSlimeBanner,
                    ItemID.UndeadVikingBanner,
                    ItemID.CyanBeetleBanner,
                    ItemID.ArmoredVikingBanner,
                    ItemID.IceTortoiseBanner,
                    ItemID.IcyMermanBanner,
                    ItemID.MimicBanner,
                    ItemID.PigronBanner,
                    .. snowBanners
                ]);
            RegisterGroup(ref UnderworldBannersGroup, "CompatibilityPlusPlus:UnderworldBanners", "Mods.CompatibilityPlusPlus.Biomes.Vanilla.Underworld",
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
                ]);
        }

        private static void AddItemFromExternalModToGroup(Mod mod, string itemName, List<int> group)
        {
            if (mod != null)
            {
                if (mod.TryFind(itemName, out ModItem modItem))
                {
                    group.Add(modItem.Type);
                }
            }
        }

        private static void RegisterGroup(ref RecipeGroup group, string groupName, string text, int[] items)
        {
            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue(text)} {Language.GetTextValue("MapObject.Banner")}", items);
            RecipeGroup.RegisterGroup(groupName, group);
        }

        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                #region Fargo's Mutant Mod
                if (CompatibilityPlusPlus.FargosMutantMod != null)
                {
                    // Corruption Key
                    if (recipe.HasResult(ItemID.CorruptionKey) && !recipe.HasRecipeGroup(CorruptionBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }

                    // Crimson Key
                    if (recipe.HasResult(ItemID.CrimsonKey) && !recipe.HasRecipeGroup(CrimsonBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }

                    // Desert key
                    if (recipe.HasResult(ItemID.DungeonDesertKey) && !recipe.HasRecipeGroup(DesertBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }

                    // Frozen Key
                    if (recipe.HasResult(ItemID.FrozenKey) && !recipe.HasRecipeGroup(SnowBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }

                    // Hallowed Key
                    if (recipe.HasResult(ItemID.HallowedKey) && !recipe.HasRecipeGroup(HallowedBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }

                    // Jungle Key
                    if (recipe.HasResult(ItemID.JungleKey) && !recipe.HasRecipeGroup(JungleBannersGroup))
                    {
                        recipe.DisableRecipe();
                    }
                }
                #endregion
            }
        }
    }
}
