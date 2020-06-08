using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.NPCs
{
    public class NPCshops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) // Allows you to add items to NPC shops
        {
            if(type == NPCID.Merchant) // Specifies the npc we are changing
            {
                shop.item[nextSlot].SetDefaults(ItemID.MiningShirt); // Add an item with the itemid to the next available slot in the NPCs shop
                shop.item[nextSlot].shopCustomPrice = 40000; // sets the purchase cost,  40000 = 4 gold
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.MiningPants);
                shop.item[nextSlot].shopCustomPrice = 40000; 
                nextSlot++;
            }
        }
    }
}