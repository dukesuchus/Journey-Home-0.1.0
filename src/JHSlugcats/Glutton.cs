using System;
using BepInEx;
using UnityEngine;
using SlugBase.Features;
using static SlugBase.Features.FeatureTypes;
using IL.Menu.Remix;

namespace Glutton
{
    [BepInPlugin(MOD_ID, "Slugcat Template", "0.1.0")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "duke.glutton";

        public static readonly PlayerFeature<float> PlayerGraphics = PlayerFloat("size");


        // Add hooks
        public void OnEnable()
        {
            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);
            On.PlayerGraphics.DrawSprites += PlayerGraphics_DrawSprites;

        }

        // Make the Glutton fat

        private void PlayerGraphics_DrawSprites(On.PlayerGraphics.orig_DrawSprites orig, PlayerGraphics self, RoomCamera.SpriteLeaser sLeaser, RoomCamera rCam, float timeStacker, Vector2 camPos)
        {
            orig(self, sLeaser, rCam, timeStacker, camPos);

            if (SlugcatStats.Name == "duke.glutton")
            {
                sLeaser.sprites[0].scaleX = 1.4f + Mathf.Lerp(Mathf.Lerp(Mathf.Lerp(-0.05f, -0.15f, this.malnourished), 0.05f, num) * num2, 0.15f, this.player.sleepCurlUp);
            }
        }

    }
}
}