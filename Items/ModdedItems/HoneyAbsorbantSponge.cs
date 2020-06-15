using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items.ModdedItems
{
    public class HoneyAbsorbantSponge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honey Absorbant Sponge"); // Changes the item name
            Tooltip.SetDefault("Capable of soaking up an endless amount of honey"); // Changes items tooltip/s
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuperAbsorbantSponge);
        }
    }
}