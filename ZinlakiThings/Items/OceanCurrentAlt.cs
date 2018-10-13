using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class OceanCurrentAlt : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ocean's Current");
			Tooltip.SetDefault("Some say it was bound for the stars.");
		}
		
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
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
			recipe.AddIngredient(mod, "OceanCurrent");
			recipe.AddIngredient(ItemID.RedDye);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
