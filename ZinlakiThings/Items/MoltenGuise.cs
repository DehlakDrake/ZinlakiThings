using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class MoltenGuise : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Deep Guise");
			Tooltip.SetDefault("Clack clack clack!");
		}
		
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 3;
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
			recipe.AddIngredient(ItemID.None);
			recipe.AddTile(TileID.Dressers);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
