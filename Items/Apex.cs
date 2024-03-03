﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items
{
    public class Apex : ModItem//斧镐一体
    {
    public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = Item.sellPrice(60, 0, 0, 0);
            Item.rare = -12;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.pick = 1000; // 1000%的镐力
            Item.axe = 200; // 这个比较特殊，200 * 5 = 1000%的斧力！
            //Item.hammer = 100; // 100%的锤力！
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}
