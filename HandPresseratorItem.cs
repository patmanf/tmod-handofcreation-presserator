using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HandPresserator;

public class HandPresseratorItem : GlobalItem
{
    public override void UpdateAccessory(Item item, Player player, bool hideVisual)
    {
        if (item.type == ItemID.HandOfCreation)
        {
            player.autoActuator = true;
        }
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ItemID.HandOfCreation)
        {
            int i = tooltips.FindIndex(line => line.Name == "Tooltip4");
            if (i != -1)
            {
                TooltipLine line = new(Mod, "ActuationAccessory", Language.GetTextValue("ItemTooltip.ActuationAccessory"));
                tooltips.Insert(i, line);
            }
        }
    }
}