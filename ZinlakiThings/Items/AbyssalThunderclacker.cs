using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class AbyssalThunderclacker : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Abyssal Thunderclacker");
			Tooltip.SetDefault("An unfathomable combination of rumbles and clacks from the deep.");
		}
		
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = -1;
            item.vanity = true;
        }
		
        public override bool DrawHead()
        {
            return false;
        }
		
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AbyssalThunderclapper");
			recipe.AddIngredient(mod, "MoltenGuise");
			recipe.AddTile(TileID.Workbenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
