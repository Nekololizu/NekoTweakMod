using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Tiles
{
    public class ModifyTile : GlobalTile
    {
        public override void SetDefaults()
        {
            if (Tile.Type_Solid == TileID.Obsidian)
            {
              //  mineresist = 55;
            }
        }
    }
}