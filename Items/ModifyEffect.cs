using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifyEffect : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if(item.type == ItemID.SpiderMask) // Also changes the tooltip in Modifytooltip.cs for this item
            {
                player.maxMinions -= 1; // reduces the max minion cap by 1
            }
        }
    }
}