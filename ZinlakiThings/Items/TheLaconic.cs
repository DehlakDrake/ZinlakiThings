using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZinlakiThings.Items   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class TheLaconic : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Laconic Dragon");
			Tooltip.SetDefault("Putting it briefly: Dehlak");
		}
		
        public override void SetDefaults()
        {
            item.width = 18; //The size in width of the sprite in pixels.
            item.height = 18;   //The size in height of the sprite in pixels.
            item.rare = 1;    //The color the title of your item when hovering over it ingame 
            item.vanity = true; //this defines if this item is vanity or not.
        }
		
        public override bool DrawHead()
        {
            return false;     //this makes it so the player head does not disappear when the vanity mask is equipped.  return false if you want it to not show the player head.
        }
		
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;  //this makes it so the player hair does not show when the vanity mask is equipped.  add true if you want it to show the player hair.
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.None);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
