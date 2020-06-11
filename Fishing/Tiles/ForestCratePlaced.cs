using Terraria.ObjectData;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;


namespace NekoTweakMod.Fishing.Tiles // // where this file is located in the mods folders
{
    public class ForestCratePlaced : ModTile // Here we are setting up everything for the tile while the item is placed
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true; // if the player can stand ontop of the tile
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true; // if the tile counts as a table inside for a npc house
            Main.tileLavaDeath[Type] = true; // if the tile will break when it comes in contact with lava
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2); // 2wide x 2tall
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 }; // absoluteAquarian: each number is how tall each "ROW OF TILES" in the "SPRITESHEET" is
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName(); // creates a "name" for the modded tile
            name.SetDefault("Forest Crate"); // Sets the item name to "Forest Crate"
            // AddMapEntry(new Color(200, 200, 200), name); 
            // adds a new color with the rbg values 0-255,0-255,0-255 to the tile with the "name"
            // dustType = DustType<Sparkle>(); // mehh fk dust for now~
            disableSmartCursor = true; // disables smartcursor from targeting this tile
            adjTiles = new int[] { TileID.FishingCrate };
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) // makes it possible to set/change what happens when a tile break
        {
            Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Fishing.Items.ForestCrate>()); // where the class is located in the namespace, where file is located in the mod folders~
        }
    }
}
