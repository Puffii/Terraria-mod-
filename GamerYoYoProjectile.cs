using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace GamerSupps.Items.Projectiles
{
    public class GamerYoYoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 400f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 17f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;

        }

        public override void PostAI()
        {
           if(Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 16);
                dust.noGravity = true;
                dust.scale = Main.rand.Next(70, 130) * 0.01f;
                dust.color = Color.Pink;

            }



        }
    }

}
