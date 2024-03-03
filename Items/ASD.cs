using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items
{
	public class ASD : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.MIV.hjson file.
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;

        }
        public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 80;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.sellPrice(60,0,0,0);
			Item.rare = -12;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.StarWrath; // 弹幕类型
            Item.shootSpeed = 6f; // 物品发射弹幕的速度，单位：像素/帧，一秒 = 60帧
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			Dust eff = Dust.NewDustDirect(hitbox.TopLeft(),hitbox.Width,hitbox.Height,DustID.MoonBoulder);
			eff.velocity *= 0;
			eff.noGravity= true;
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile p = Projectile.NewProjectileDirect(source, position, -velocity, ProjectileID.FallingStar, damage, knockback, player.whoAmI);
            return base.Shoot(player, source, position, velocity, type, damage, knockback);
        }
    }
}