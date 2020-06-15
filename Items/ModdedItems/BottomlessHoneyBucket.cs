using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items.ModdedItems
{
    public class BottomlessHoneyBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Honey Bucket"); // Changes the item name
            Tooltip.SetDefault("Contains an endless amount of honey"); // Changes items tooltip/s
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BottomlessBucket);
        }
    }
}