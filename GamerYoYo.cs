using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using GamerSupps.Items.Projectiles;

namespace GamerSupps.Items
{
    public class GamerYoyo : ModItem

    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 16;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;


        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(30, 30);

            item.noMelee = true;
            item.noUseGraphic = true;
            item.channel = true;
            // Damage Stats
            item.melee = true;
            item.damage = 32;
            item.knockBack = 3.5f;
            item.crit = 4;

            // Use Stats
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item43;

            item.shoot = ModContent.ProjectileType<GamerYoYoProjectile>();

            item.value = Item.buyPrice(gold: 10);

            item.rare = ItemRarityID.Pink;
        
        }
    }
}
