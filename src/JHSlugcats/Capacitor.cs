using System;
using BepInEx;
using UnityEngine;
using SlugBase.Features;
using static SlugBase.Features.FeatureTypes;
using IL.Menu.Remix;

namespace Capacitor
{
    [BepInPlugin(MOD_ID, "Slugcat Template", "0.1.0")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "duke.capacitor";


        // Add hooks
        public void OnEnable()
        {
            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);
            On.PlayerGraphics.DrawSprites += PlayerGraphics_DrawSprites;

        }

        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
        }

        // Make both the ears long like a rabbit's

        // Expend a food pip to gain the speed of the Rivulet for thirty seconds
    }
}
}
