using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items.Placeable
{
	public class NightShiftMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Night Shift)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("NightShiftMusicBox");
			item.width = 24;
			item.height = 24;
			item.rare = 1;
			item.value = 1930;
			item.accessory = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "TheLaconic");
			recipe.AddIngredient(ItemID.MusicBox);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}