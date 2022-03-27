using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KCMod.Items.Accessories
{
    public class RingOfLife : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Become Unstoppable Today!'");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 28;
            item.value = Item.sellPrice(platinum: 20);
            item.rare = ItemRarityID.Yellow;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 300;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(499, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}