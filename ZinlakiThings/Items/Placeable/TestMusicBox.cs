using Terraria.ModLoader;

namespace ZinlakiThings.Items.Placeable
{
	public class TestMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Test)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("TestMusicBox");
			item.width = 24;
			item.height = 24;
			item.rare = 5;
			item.value = 69;
			item.accessory = true;
		}
	}
}