using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ZinlakiThings.Tiles;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;

namespace ZinlakiThings
{
	class ZinlakiThings : Mod
	{
		public ZinlakiThings()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
		public override void Load()
		{
			if (!Main.dedServ) // do not run this code on the server
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Test"), ItemType("TestMusicBox"), TileType("TestMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Stargaze"), ItemType("MusicBoxStargaze"), TileType("MusicBoxStargaze"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/NightShift"), ItemType("MusicBoxNightShift"), TileType("MusicBoxNightShift"));
			}
		}
	}
}
