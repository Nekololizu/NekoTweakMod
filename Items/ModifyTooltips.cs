using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace NekoTweakMod.Items
{
    public class WoodenSword : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.WoodenSword)
            {
                //remove the tooltip
             //   tooltips.RemoveAll(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                //actually, the hood's old statics is increased damage and crit chance by 10%.
             
                TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                if (line != null)
                {
                    line.text = "10% increased magic damage and critical strike chance.";
                }
             
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.WoodenSword)
            {
    //here you add stats

            }
        }
    }
}