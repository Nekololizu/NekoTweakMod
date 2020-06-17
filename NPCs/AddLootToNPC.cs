using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class AddLootToNPC : GlobalNPC // class name & global npc hook, allows us to change properties of NPCs/Mobs
    {
        public override void NPCLoot(NPC npc) // allows you to change what happens when an npc dies, in this case we are adding loot
        {
            if (npc.type == NPCID.BigMimicJungle)// if the npc type is this specific npc 
            {
                // "number/100" or 1 = 1% chance &  Itemid Specifies the item to give to the player
                if (Main.rand.NextBool(33, 100)) // 33% or 33/100 chance to drop 
                {
                    Item.NewItem(npc.getRect(), ItemID.SpikyBallTrap, Main.rand.Next(1, 21));
                    // adds the specified itemid as a new loot/drop for the npc and 
                    // "Main.rand.Next(1, 21));" gives a random amount between 1-20
                }
                if (Main.rand.NextBool(33, 100))
                {
                    Item.NewItem(npc.getRect(), ItemID.FlameTrap, Main.rand.Next(1, 21));
                }
                if (Main.rand.NextBool(33, 100))
                {
                    Item.NewItem(npc.getRect(), ItemID.SpearTrap, Main.rand.Next(1, 21));
                }
                if (Main.rand.NextBool(33, 100))
                {
                    Item.NewItem(npc.getRect(), ItemID.SuperDartTrap, Main.rand.Next(1, 21));
                }
            }
        }
    }
}