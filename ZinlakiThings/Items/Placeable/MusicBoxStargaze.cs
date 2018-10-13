using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items.Placeable
{
	public class MusicBoxStargaze : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Stargaze)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("MusicBoxStargaze");
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
			recipe.AddIngredient(ItemID.FallenStar, 14);
			recipe.AddIngredient(ItemID.MusicBoxNight);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}