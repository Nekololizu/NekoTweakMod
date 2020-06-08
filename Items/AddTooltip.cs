using Terraria.ID;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class AddTooltip : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) // Allows you to modify tooltip properties for items
        {
            if (item.type == ItemID.Shackle) // Specifies what item
            {
                // This code allows you to add new tooltips lines to items if they don't have one them
                TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Enemies are more likely to target you");
                // Creates a new TooltipLine for your mod with the name Tooltip0
                // "Tooltip#" - A tooltip line of the item. # will be 0 for the first line, 1 for the second, etc.
                tooltips.Add(newTooltip);
                // Adds the Tooltip to the list
            }
            {
                if (item.type == ItemID.TitanGlove)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "12% increased melee speed");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if (item.type == ItemID.PowerGlove)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Enables auto swing for melee weapons");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if (item.type == ItemID.MechanicalGlove)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Enables auto swing for melee weapons");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if (item.type == ItemID.FireGauntlet)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Enables auto swing for melee weapons");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if(item.type == ItemID.ObsidianHelm)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Increases minion damage by 5%");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if(item.type == ItemID.ObsidianShirt)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Increases minion damage by 10%");
                    tooltips.Add(newTooltip);
                }
            }
            {
                if(item.type == ItemID.ObsidianPants)
                {
                    TooltipLine newTooltip = new TooltipLine(mod, "Tooltip0", "Increases minion damage by 5%");
                    tooltips.Add(newTooltip);
                }
            }
        }
    }
}