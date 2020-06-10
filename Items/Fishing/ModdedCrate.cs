/*
using Terraria.ObjectData;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;


namespace NekoTweakMod.Items.Fishing
// In this .cs file we are making a modded item,tile,placeable item & adding it to a fishing spot in a specific biome
// if you want/need something specific from here just check where the classes start/end
{
    public class ModdedCrate : ModTile // Here we are setting up everything for the tile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true; // if the player can stand ontop of the tile
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true; // if the tile counts as a table inside for a npc house
            Main.tileLavaDeath[Type] = true; // if the tile will break when it comes in contact with lava
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1); // copies data for how wide/tall the tile will
            TileObjectData.newTile.CoordinateHeights = new[] { 18 }; // sets how high up the tile will appear
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName(); // creates a "name" for the modded tile
            name.SetDefault("ExampleCrate"); // Sets the name to "ExampleCrate"
            // AddMapEntry(new Color(200, 200, 200), name); 
            // adds a new color with the rbg values 0-255,0-255,0-255 to the tile with the "name"
            // dustType = DustType<Sparkle>(); // mehh fk dust for now~
            disableSmartCursor = true; // disables smartcursor from targeting this tile
            adjTiles = new int[] { TileID.FishingCrate };
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) // makes it possible to set/change what happens when a tile break
        {
            //Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Items.Fishing.ModdedCrate.PlacableCrate.>());
        }
    }
    public class PlaceableModdedCrate : ModItem
    {
        public override void SetStaticDefaults() // Allows us to set/change a modded items name/translations
        {
            Tooltip.SetDefault("ExampleCrate");
        }
    }
}

// WIP CODE
*/