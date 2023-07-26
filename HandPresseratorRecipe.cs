using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HandPresserator;

public class HandPresseratorRecipe : ModSystem
{
    public override void PostAddRecipes()
    {
        for (int i = 0; i < Recipe.numRecipes; i++)
        {
            Recipe recipe = Main.recipe[i];
            if (recipe.HasResult(ItemID.HandOfCreation))
            {
                recipe.AddIngredient(ItemID.ActuationAccessory);
            }
        }
    }
}
