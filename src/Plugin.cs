using System;
using BepInEx;
using UnityEngine;
using SlugBase.Features;
using static SlugBase.Features.FeatureTypes;
using IL.Menu.Remix;

using Capacitor;
using Firebrand;
using Glutton;
using Protector;

namespace SlugTemplate
{
    [BepInPlugin(MOD_ID, "Slugcat Template", "0.1.0")]
    class JourneyHome : BaseUnityPlugin
    {
        private const string MOD_ID = "duke.journeyhome";

        public static readonly PlayerFeature<float> PlayerGraphics = PlayerFloat("size");


        // Add hooks
        public void OnEnable()
        {
            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);
        }
        
        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
            Capacitor.init();
            Firebrand.init();
            Glutton.init();
            Protector.init();

        }

        // Load the characters into the plugin



        }
    }
}