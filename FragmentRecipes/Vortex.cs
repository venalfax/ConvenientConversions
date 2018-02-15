using Terraria.ID;
using Terraria.ModLoader;

namespace ConvenientConversions.FragmentRecipes
{
    public static class Vortex
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe N3V = new ModRecipe(mod);
            N3V.AddIngredient(ItemID.FragmentNebula, 3);
            N3V.AddTile(TileID.LunarCraftingStation);
            N3V.SetResult(ItemID.FragmentVortex);
            N3V.AddRecipe();

            ModRecipe S3V = new ModRecipe(mod);
            S3V.AddIngredient(ItemID.FragmentSolar, 3);
            S3V.AddTile(TileID.LunarCraftingStation);
            S3V.SetResult(ItemID.FragmentVortex);
            S3V.AddRecipe();

            ModRecipe St3V = new ModRecipe(mod);
            St3V.AddIngredient(ItemID.FragmentStardust, 3);
            St3V.AddTile(TileID.LunarCraftingStation);
            St3V.SetResult(ItemID.FragmentVortex);
            St3V.AddRecipe();

            ModRecipe N2SV = new ModRecipe(mod);
            N2SV.AddIngredient(ItemID.FragmentNebula, 2);
            N2SV.AddIngredient(ItemID.FragmentSolar, 1);
            N2SV.AddTile(TileID.LunarCraftingStation);
            N2SV.SetResult(ItemID.FragmentVortex);
            N2SV.AddRecipe();

            ModRecipe N2StV = new ModRecipe(mod);
            N2StV.AddIngredient(ItemID.FragmentNebula, 2);
            N2StV.AddIngredient(ItemID.FragmentStardust, 1);
            N2StV.AddTile(TileID.LunarCraftingStation);
            N2StV.SetResult(ItemID.FragmentVortex);
            N2StV.AddRecipe();

            ModRecipe S2NV = new ModRecipe(mod);
            S2NV.AddIngredient(ItemID.FragmentSolar, 2);
            S2NV.AddIngredient(ItemID.FragmentNebula, 1);
            S2NV.AddTile(TileID.LunarCraftingStation);
            S2NV.SetResult(ItemID.FragmentVortex);
            S2NV.AddRecipe();

            ModRecipe S2StV = new ModRecipe(mod);
            S2StV.AddIngredient(ItemID.FragmentSolar, 2);
            S2StV.AddIngredient(ItemID.FragmentStardust, 1);
            S2StV.AddTile(TileID.LunarCraftingStation);
            S2StV.SetResult(ItemID.FragmentVortex);
            S2StV.AddRecipe();

            ModRecipe St2NV = new ModRecipe(mod);
            St2NV.AddIngredient(ItemID.FragmentStardust, 2);
            St2NV.AddIngredient(ItemID.FragmentNebula, 1);
            St2NV.AddTile(TileID.LunarCraftingStation);
            St2NV.SetResult(ItemID.FragmentVortex);
            St2NV.AddRecipe();

            ModRecipe St2SV = new ModRecipe(mod);
            St2SV.AddIngredient(ItemID.FragmentStardust, 2);
            St2SV.AddIngredient(ItemID.FragmentSolar, 1);
            St2SV.AddTile(TileID.LunarCraftingStation);
            St2SV.SetResult(ItemID.FragmentVortex);
            St2SV.AddRecipe();
        }
    }
}
