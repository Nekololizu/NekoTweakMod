using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Tiles
//Namespace is where the code start and end with { & }
{
public class NearbyEffect : GlobalTile // class name & vanilla tiles
//Class
    {
        public override void NearbyEffects(int i, int j, int type, bool closer) //Apply something if nearby specified tile
        //Methods inside the Class
        {
            base.NearbyEffects(i, j, type, closer); 
            if (type == TileID.WorkBenches)//Gives this specific tile a NearbyEffect
                Main.LocalPlayer.AddBuff(BuffID.Regeneration, 35999); // (BuffID.BuffName, duration); 
           //NearbyEffect give a buff to player nearby players.     Duration is set in ticks not seconds. 60ticks = 1second. 36000 = 10 minutes
            { // seperation between each "if" statement so syntax stay organized

            if (type == TileID.Torches)// Second Tile that will get changed
                Main.LocalPlayer.AddBuff(BuffID.Ironskin, 35999);// the buff that will apply to the second tile
            }
        }
    }
}
// Thanks to jopojelly for explaining the full code & syntax
// & absoluteAquarian for explaing how to add the timing parameter to AddBuff