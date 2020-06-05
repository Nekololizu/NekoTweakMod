using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Tiles // "}" has to end in the namespace after everything is done aka Syntax
{
public class Workbenches : GlobalTile // class name & vanilla tiles
    {
        public override void NearbyEffects(int i, int j, int type, bool closer) //Apply something if nearby specified tile
        {
            base.NearbyEffects(i, j, type, closer); 
            if (type == TileID.WorkBenches)//Use NearbyEffect if tileid is specific tile
                Main.LocalPlayer.AddBuff(BuffID.Regeneration, 240); // (BuffID.BuffName, duration);
                    //add buff to player                           // 60ticks = 1 second. 240=4seconds

        }
    }
}
// Thanks to jopojelly for explaining the full code & syntax
//& absoluteAquarian for explaing how to add the timing parameter to AddBuff