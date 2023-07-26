using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HandPresserator;

public class HandPresseratorPlayer : ModPlayer
{
    public override void PostUpdateEquips()
    {
        if (Player.HasItemInInventoryOrOpenVoidBag(ItemID.HandOfCreation))
        {
            Player.autoActuator = true;
        }
    }
}
