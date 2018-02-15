using Terraria.ID;
using Terraria.ModLoader;

namespace ConvenientConversions.FragmentRecipes
{
    public static class Solar
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe N3S = new ModRecipe(mod);
            N3S.AddIngredient(ItemID.FragmentNebula, 3);
            N3S.AddTile(TileID.LunarCraftingStation);
            N3S.SetResult(ItemID.FragmentSolar);
            N3S.AddRecipe();

            ModRecipe St3S = new ModRecipe(mod);
            St3S.AddIngredient(ItemID.FragmentStardust, 3);
            St3S.AddTile(TileID.LunarCraftingStation);
            St3S.SetResult(ItemID.FragmentSolar);
            St3S.AddRecipe();

            ModRecipe V3S = new ModRecipe(mod);
            V3S.AddIngredient(ItemID.FragmentVortex, 3);
            V3S.AddTile(TileID.LunarCraftingStation);
            V3S.SetResult(ItemID.FragmentSolar);
            V3S.AddRecipe();

            ModRecipe N2StS = new ModRecipe(mod);
            N2StS.AddIngredient(ItemID.FragmentNebula, 2);
            N2StS.AddIngredient(ItemID.FragmentStardust, 1);
            N2StS.AddTile(TileID.LunarCraftingStation);
            N2StS.SetResult(ItemID.FragmentSolar);
            N2StS.AddRecipe();

            ModRecipe N2VS = new ModRecipe(mod);
            N2VS.AddIngredient(ItemID.FragmentNebula, 2);
            N2VS.AddIngredient(ItemID.FragmentVortex, 1);
            N2VS.AddTile(TileID.LunarCraftingStation);
            N2VS.SetResult(ItemID.FragmentSolar);
            N2VS.AddRecipe();

            ModRecipe St2NS = new ModRecipe(mod);
            St2NS.AddIngredient(ItemID.FragmentStardust, 2);
            St2NS.AddIngredient(ItemID.FragmentNebula, 1);
            St2NS.AddTile(TileID.LunarCraftingStation);
            St2NS.SetResult(ItemID.FragmentSolar);
            St2NS.AddRecipe();

            ModRecipe St2VS = new ModRecipe(mod);
            St2VS.AddIngredient(ItemID.FragmentStardust, 2);
            St2VS.AddIngredient(ItemID.FragmentVortex, 1);
            St2VS.AddTile(TileID.LunarCraftingStation);
            St2VS.SetResult(ItemID.FragmentSolar);
            St2VS.AddRecipe();

            ModRecipe V2StS = new ModRecipe(mod);
            V2StS.AddIngredient(ItemID.FragmentVortex, 2);
            V2StS.AddIngredient(ItemID.FragmentStardust, 1);
            V2StS.AddTile(TileID.LunarCraftingStation);
            V2StS.SetResult(ItemID.FragmentSolar);
            V2StS.AddRecipe();

            ModRecipe V2NS = new ModRecipe(mod);
            V2NS.AddIngredient(ItemID.FragmentVortex, 2);
            V2NS.AddIngredient(ItemID.FragmentNebula, 1);
            V2NS.AddTile(TileID.LunarCraftingStation);
            V2NS.SetResult(ItemID.FragmentSolar);
            V2NS.AddRecipe();
        }
    }
}
