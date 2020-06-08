using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifyTooltip : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) // Allows you to set/change all available tooltips
        {
            if (item.type == ItemID.FeralClaws)
            // Specifies what item to change, If its this specific item the code below will be used
            // This code is for changing a tooltip that an item already has
            // Look at AddTooltip.cs instead if the item don't have the Tooltip you are trying to change
            {
                TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                // Grabs Name(name of the tooltip) from the tooltip "tooltip0" from a mod with the name "Terraria"
                // In this case from vanilla Terraria, and not from a mod
                // And changes the line(string) value from tooltips into the text
                // The Specified item has to have the tooltip that we are trying to grab else nothing will

                if (line != null) // If the line(String) is not empty, do the code below
                // If the item dont have the specified tooltip you are trying to change nothing will change/appear in game
                // you will crash in game without this when you try to check the tooltip of an item
                {
                    line.text = "Enables auto swing for melee weapons"; // This is the Text that appear as your tooltip on the item in game
                }
            }
            {
                if (item.type == ItemID.FireGauntlet)
                {
                    TooltipLine line2 = tooltips.FirstOrDefault(x => x.Name == "Tooltip1" && x.mod == "Terraria");
                    if (line2 != null) line2.text = "12% increased melee damage and speed";
                }
            }
            {
                if (item.type == ItemID.SpiderMask)
                {
                    TooltipLine line3 = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line3 != null) line3.text = ""; // Removes/hide the tooltip from the item
                }
            }
        }
    }
}
/* Other alternatives you can replace "Tooltip0" with if you want something else than the flavor text
 
    "ItemName" - The name of the item
    "Favorite" - Tells if the item is favorited.
    "FavoriteDesc" - Tells what it means when an item is favorited.
    "Social" - Tells if the item is in a social slot.
    "SocialDesc" - Tells what it means for an item to be in a social slot.
    "Damage" - The damage value and type of the weapon.
    "CritChance" - The critical strike chance of the weapon.
    "Speed" - The use speed of the weapon.
    "Knockback" - The knockback of the weapon.
    "FishingPower" - Tells the fishing power of the fishing pole.
    "NeedsBait" - Tells that a fishing pole requires bait.
    "BaitPower" - The bait power of the bait.
    "Equipable" - Tells that an item is equipable.
    "WandConsumes" - Tells what item a tile wand consumes.
    "Quest" - Tells that this is a quest item.
    "Vanity" - Tells that this is a vanity item.
    "Defense" - Tells how much defense the item gives when equipped.
    "PickPower" - The item's pickaxe power.
    "AxePower" - The item's axe power.
    "HammerPower" - The item's hammer power.
    "TileBoost" - How much farther the item can reach than normal items.
    "HealLife" - How much health the item recovers when used.
    "HealMana" - How much mana the item recovers when used.
    "UseMana" - Tells how much mana the item consumes upon usage.
    "Placeable" - Tells if the item is placeable.
    "Ammo" - Tells if the item is ammo.
    "Consumable" - Tells if the item is consumable.
    "Material" - Tells if the item can be used to craft something.
    "Tooltip#" - A tooltip line of the item. # will be 0 for the first line, 1 for the second, etc.
    "EtherianManaWarning" - Warning about how the item can't be used without Etherian Mana until the Eternia Crystal has been defeated.
    "WellFedExpert" - In expert mode, tells that food increases life renegeration.
    "BuffTime" - Tells how long the item's buff lasts.
    "OneDropLogo" - The One Drop logo for yoyos.This is a specially-marked tooltip line that has no text.
    "PrefixDamage" - The damage modifier of the prefix.
    "PrefixSpeed" - The usage speed modifier of the prefix.
    "PrefixCritChance" - The critical strike chance modifier of the prefix.
    "PrefixUseMana" - The mana consumption modifier of the prefix.
    "PrefixSize" - The melee size modifier of the prefix.
    "PrefixShootSpeed" - The shootSpeed modifier of the prefix.
    "PrefixKnockback" - The knockback modifier of the prefix.
    "PrefixAccDefense" - The defense modifier of the accessory prefix.
    "PrefixAccMaxMana" - The maximum mana modifier of the accessory prefix.
    "PrefixAccCritChance" - The critical strike chance modifier of the accessory prefix.
    "PrefixAccDamage" - The damage modifier of the accessory prefix.
    "PrefixAccMoveSpeed" - The movement speed modifier of the accessory prefix.
    "PrefixAccMeleeSpeed" - The melee speed modifier of the accessory prefix.
    "SetBonus" - The set bonus description of the armor set.
    "Expert" - Tells whether the item is from expert-mode.
    "SpecialPrice" - Tells the alternate currency price of an item.
    "Price" - Tells the price of an item.
*/
