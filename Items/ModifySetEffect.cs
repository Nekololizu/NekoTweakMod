using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifySetEffect : GlobalItem
    {
        const string NinjaSet = "Ninja Armor"; // We need a string to change for specifying what set to change later on in the code
        const string ObsidianSet = "Obsidian armor";
        public override string IsArmorSet(Item head, Item body, Item legs) // Allows us to specify if these items together is a armor
        {
            if (head.type == ItemID.NinjaHood && body.type == ItemID.NinjaShirt && legs.type == ItemID.NinjaPants)  // helmet,shirt,pants for the armor set 
                return NinjaSet; // sets these items as the NinjaSet string when all of them are worn together
            if (head.type == ItemID.ObsidianHelm && body.type == ItemID.ObsidianShirt && legs.type == ItemID.ObsidianPants)
                return ObsidianSet;
                return ""; // fail safe, has to return something even if its none of the sets above
        }
        public override void UpdateArmorSet(Player player, string set) // allows us to change set effects
        {
            base.UpdateArmorSet(player, set);
            if(set == NinjaSet) // checks if the items in isArmorSet is worn as a set
            {
                // We also have to change or remove the tooltip after doing this in ModifyTooltip.cs
                // so it shows the new effect if we added one, or hide the one we removed
                player.moveSpeed -= 0.20f; // -20% movemept speed so we remove the +20% the ninja set effect already had,so in this case just making it give 0%
                player.minionDamage += 0.20f; // Gives +20% summon damage
                player.setBonus = "Increases minion damage by 20%"; // Changes the set bonus/effect tooltip
                // Only shows the set effect tooltip when all items are equiped together
            }
            {
                if(set == ObsidianSet)
                {
                    player.minionDamage += 0.30f;
                    player.setBonus = "Increases minion damage by 30%";
                }
            }
        }
    }
}