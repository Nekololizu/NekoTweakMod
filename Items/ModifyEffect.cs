using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifyEffect : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player) // Allows us to modify effects on items
        {
            if(item.type == ItemID.SpiderMask)
            // Tooltip is also removed in ModifyTooltip.cs for this item
            // so we don't keep the max minion tooltip on the item after the effect is removed
            {
                player.maxMinions -= 1; // reduces the max minion cap by 1
            }
            {
                if(item.type == ItemID.ObsidianHelm) player.minionDamage += 0.05f; // gives 5% minion damage
                if (item.type == ItemID.ObsidianShirt) player.minionDamage += 0.10f;
                if (item.type == ItemID.ObsidianShirt) player.minionDamage += 0.05f;
            }
        }
    }
}