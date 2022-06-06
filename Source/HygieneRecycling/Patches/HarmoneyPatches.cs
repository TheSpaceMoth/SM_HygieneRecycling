using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DubsBadHygiene;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using UnityEngine;
using Verse;
using Verse.AI;
using Verse.Sound;

namespace HygieneRecycling
{
    /*
    [StaticConstructorOnStartup]
    static public class HarmonyPatches
    {
        public static Harmony harmonyInstance;


        static HarmonyPatches()
        {
            harmonyInstance = new Harmony("rimworld.rwmods.HygieneRecycling");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        }

    }


    [HarmonyPatch(typeof(Building_toilet))]
    [HarmonyPatch("GetUpGraphic")]
    internal static class GetUpGraphicSafe
    {
        public static bool Prefix(ref Building_toilet __instance, ref Graphic __result)
        {
            Log.Message("Start of texture seek");
            try
            {
                Log.Message("Pre get up");
                __result = GraphicDatabase.Get(__instance.def.graphicData.graphicClass, __instance.def.graphicData.texPath + "Up", ShaderDatabase.CutoutComplex, __instance.def.graphicData.drawSize, Color.white, Color.white);

                Log.Message("Post get up");
                if (__result == null)
                {
                    Log.Message("Null get");
                    __result = GraphicDatabase.Get(__instance.def.graphicData.graphicClass, __instance.def.graphicData.texPath, ShaderDatabase.CutoutComplex, __instance.def.graphicData.drawSize, Color.white, Color.white);
                }
            }
            catch(Exception)
            {
                Log.Message("Exception");
                // If no up version. In this case because there isnt for the junk toilets.
                __result = GraphicDatabase.Get(__instance.def.graphicData.graphicClass, __instance.def.graphicData.texPath, ShaderDatabase.CutoutComplex, __instance.def.graphicData.drawSize, Color.white, Color.white);

            }

            Log.Message("Returning");
            return false; // Don't use the old code
        }
    }
    */
}
