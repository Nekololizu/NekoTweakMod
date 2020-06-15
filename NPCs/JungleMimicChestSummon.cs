using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.NPCs
// need to add few more explanations for stuffs, don't understand everything in here~
{
    // Code for Spawning/summoning a Jungle Mimic when a Temple Key is placed in a chest
    public class JungleMimicChestSummon : ModPlayer
    {
        public int LastChest; // sets up a integer named "LastChest"

        public override void PreUpdateBuffs() // This is called before buff updates to the player happens
        { // chest check
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                if (player.chest == -1 && LastChest >= 0 && Main.chest[LastChest] != null) // checks if the last chest used was empty when closed
                {
                    int x2 = Main.chest[LastChest].x;
                    int y2 = Main.chest[LastChest].y;
                    ChestItemSummonCheck(x2, y2, mod);
                }
                LastChest = player.chest;
            }
        }

        public override void UpdateAutopause()
        // Allows the mimic to spawn in single player while autopause is on
        {
            LastChest = player.chest;
        }
        // The actuall code for summoning/spawning a npc when an item is left in a chest
        public static bool ChestItemSummonCheck(int x, int y, Mod mod)
        {
            if (Main.netMode == NetmodeID.MultiplayerClient || !Main.hardMode) // if its not hardmode the code will return false and wont spawn the mimic
            {
                return false; // stops the code if the world is not in the hardmode state
            }
            int num = Chest.FindChest(x, y);
            if (num < 0) // checks the number of keys in the chest
            {
                return false; // stops the code if there are no temple keys in the chest
            }
            int numberofKeys = 0; // integer value for checking amount of keys 
            int numberOtherItems = 0; // integer value for checking if there are any other items in the chest
            ushort tileType = Main.tile[Main.chest[num].x, Main.chest[num].y].type;
            int tileStyle = (int)(Main.tile[Main.chest[num].x, Main.chest[num].y].frameX / 36);
            if (TileID.Sets.BasicChest[tileType] && (tileStyle < 5 || tileStyle > 6))
            {
                for (int i = 0; i < 40; i++)
                {
                    if (Main.chest[num].item[i] != null && Main.chest[num].item[i].type > ItemID.None) // if the chest don't have any items in it, there are no temple keys in it
                    {
                        if (Main.chest[num].item[i].type == ItemID.TempleKey) // What item that should be used for this npc spawning/summoning
                        {
                            numberofKeys += Main.chest[num].item[i].stack;
                        }
                        else
                        {
                            numberOtherItems++;  // increases the numberOtherItems value 
                        }
                    }
                }
            }
            if (numberOtherItems == 0 && numberofKeys == 1) // If there are no other items the chest & and there is 1 temple key in it
            {

                if (TileID.Sets.BasicChest[Main.tile[x, y].type]) // checks if the tile is a chest
                {
                    if (Main.tile[x, y].frameX % 36 != 0)
                    {
                        x--;
                    }
                    if (Main.tile[x, y].frameY % 36 != 0)
                    {
                        y--;
                    }
                    int number = Chest.FindChest(x, y);
                    for (int j = x; j <= x + 1; j++)
                    {
                        for (int k = y; k <= y + 1; k++)
                        {
                            if (TileID.Sets.BasicChest[Main.tile[j, k].type]) // Checks if the tile exist ????
                            {
                                Main.tile[j, k].active(false);
                            }
                        }
                    }
                    for (int l = 0; l < 40; l++)
                    {
                        Main.chest[num].item[l] = new Item();
                    }
                    Chest.DestroyChest(x, y); // removes the chest tile without dropping a chest item
                    NetMessage.SendData(MessageID.ChestUpdates, -1, -1, null, 1, (float)x, (float)y, 0f, number, 0, 0);
                    NetMessage.SendTileSquare(-1, x, y, 3);
                }
                int npcToSpawn = NPCID.BigMimicJungle; // What npc to spawn, in this case a Jungle Mimic
                int npcIndex = NPC.NewNPC(x * 16 + 16, y * 16 + 32, npcToSpawn, 0, 0f, 0f, 0f, 0f, 255); // Determine where the npc will spawn 
                Main.npc[npcIndex].whoAmI = npcIndex;
                NetMessage.SendData(MessageID.SyncNPC, -1, -1, null, npcIndex, 0f, 0f, 0f, 0, 0, 0);
                Main.npc[npcIndex].BigMimicSpawnSmoke(); // Does the mimic smoke summoning animation
            }
            return false; // stops the code
        }
    }
}