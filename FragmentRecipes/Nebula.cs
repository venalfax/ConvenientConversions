using Terraria.ID;
using Terraria.ModLoader;

namespace ConvenientConversions.FragmentRecipes
{
    public static class Nebula
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe S3N = new ModRecipe(mod);
            S3N.AddIngredient(ItemID.FragmentSolar, 3);
            S3N.AddTile(TileID.LunarCraftingStation);
            S3N.SetResult(ItemID.FragmentNebula);
            S3N.AddRecipe();

            ModRecipe St3N = new ModRecipe(mod);
            St3N.AddIngredient(ItemID.FragmentStardust, 3);
            St3N.AddTile(TileID.LunarCraftingStation);
            St3N.SetResult(ItemID.FragmentNebula);
            St3N.AddRecipe();

            ModRecipe V3N = new ModRecipe(mod);
            V3N.AddIngredient(ItemID.FragmentVortex, 3);
            V3N.AddTile(TileID.LunarCraftingStation);
            V3N.SetResult(ItemID.FragmentNebula);
            V3N.AddRecipe();

            ModRecipe S2StN = new ModRecipe(mod);
            S2StN.AddIngredient(ItemID.FragmentSolar, 2);
            S2StN.AddIngredient(ItemID.FragmentStardust, 1);
            S2StN.AddTile(TileID.LunarCraftingStation);
            S2StN.SetResult(ItemID.FragmentNebula);
            S2StN.AddRecipe();

            ModRecipe S2VN = new ModRecipe(mod);
            S2VN.AddIngredient(ItemID.FragmentSolar, 2);
            S2VN.AddIngredient(ItemID.FragmentVortex, 1);
            S2VN.AddTile(TileID.LunarCraftingStation);
            S2VN.SetResult(ItemID.FragmentNebula);
            S2VN.AddRecipe();

            ModRecipe St2SN = new ModRecipe(mod);
            St2SN.AddIngredient(ItemID.FragmentStardust, 2);
            St2SN.AddIngredient(ItemID.FragmentSolar, 1);
            St2SN.AddTile(TileID.LunarCraftingStation);
            St2SN.SetResult(ItemID.FragmentNebula);
            St2SN.AddRecipe();

            ModRecipe St2VN = new ModRecipe(mod);
            St2VN.AddIngredient(ItemID.FragmentStardust, 2);
            St2VN.AddIngredient(ItemID.FragmentVortex, 1);
            St2VN.AddTile(TileID.LunarCraftingStation);
            St2VN.SetResult(ItemID.FragmentNebula);
            St2VN.AddRecipe();

            ModRecipe V2StN = new ModRecipe(mod);
            V2StN.AddIngredient(ItemID.FragmentVortex, 2);
            V2StN.AddIngredient(ItemID.FragmentStardust, 1);
            V2StN.AddTile(TileID.LunarCraftingStation);
            V2StN.SetResult(ItemID.FragmentNebula);
            V2StN.AddRecipe();

            ModRecipe V2SN = new ModRecipe(mod);
            V2SN.AddIngredient(ItemID.FragmentVortex, 2);
            V2SN.AddIngredient(ItemID.FragmentSolar, 1);
            V2SN.AddTile(TileID.LunarCraftingStation);
            V2SN.SetResult(ItemID.FragmentNebula);
            V2SN.AddRecipe();
        }
    }
}
