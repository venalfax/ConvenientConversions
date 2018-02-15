using Terraria.ID;
using Terraria.ModLoader;

namespace ConvenientConversions.FragmentRecipes
{
    public static class Stardust
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe N3St = new ModRecipe(mod);
            N3St.AddIngredient(ItemID.FragmentNebula, 3);
            N3St.AddTile(TileID.LunarCraftingStation);
            N3St.SetResult(ItemID.FragmentStardust);
            N3St.AddRecipe();

            ModRecipe S3St = new ModRecipe(mod);
            S3St.AddIngredient(ItemID.FragmentSolar, 3);
            S3St.AddTile(TileID.LunarCraftingStation);
            S3St.SetResult(ItemID.FragmentStardust);
            S3St.AddRecipe();

            ModRecipe V3St = new ModRecipe(mod);
            V3St.AddIngredient(ItemID.FragmentVortex, 3);
            V3St.AddTile(TileID.LunarCraftingStation);
            V3St.SetResult(ItemID.FragmentStardust);
            V3St.AddRecipe();

            ModRecipe N2SSt = new ModRecipe(mod);
            N2SSt.AddIngredient(ItemID.FragmentNebula, 2);
            N2SSt.AddIngredient(ItemID.FragmentSolar, 1);
            N2SSt.AddTile(TileID.LunarCraftingStation);
            N2SSt.SetResult(ItemID.FragmentStardust);
            N2SSt.AddRecipe();

            ModRecipe N2VSt = new ModRecipe(mod);
            N2VSt.AddIngredient(ItemID.FragmentNebula, 2);
            N2VSt.AddIngredient(ItemID.FragmentVortex, 1);
            N2VSt.AddTile(TileID.LunarCraftingStation);
            N2VSt.SetResult(ItemID.FragmentStardust);
            N2VSt.AddRecipe();

            ModRecipe S2NSt = new ModRecipe(mod);
            S2NSt.AddIngredient(ItemID.FragmentSolar, 2);
            S2NSt.AddIngredient(ItemID.FragmentNebula, 1);
            S2NSt.AddTile(TileID.LunarCraftingStation);
            S2NSt.SetResult(ItemID.FragmentStardust);
            S2NSt.AddRecipe();

            ModRecipe S2VSt = new ModRecipe(mod);
            S2VSt.AddIngredient(ItemID.FragmentSolar, 2);
            S2VSt.AddIngredient(ItemID.FragmentVortex, 1);
            S2VSt.AddTile(TileID.LunarCraftingStation);
            S2VSt.SetResult(ItemID.FragmentStardust);
            S2VSt.AddRecipe();

            ModRecipe V2SSt = new ModRecipe(mod);
            V2SSt.AddIngredient(ItemID.FragmentVortex, 2);
            V2SSt.AddIngredient(ItemID.FragmentSolar, 1);
            V2SSt.AddTile(TileID.LunarCraftingStation);
            V2SSt.SetResult(ItemID.FragmentStardust);
            V2SSt.AddRecipe();

            ModRecipe V2NSt = new ModRecipe(mod);
            V2NSt.AddIngredient(ItemID.FragmentVortex, 2);
            V2NSt.AddIngredient(ItemID.FragmentNebula, 1);
            V2NSt.AddTile(TileID.LunarCraftingStation);
            V2NSt.SetResult(ItemID.FragmentStardust);
            V2NSt.AddRecipe();
        }
    }
}
