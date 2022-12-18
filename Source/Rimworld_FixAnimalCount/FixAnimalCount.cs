using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using System.Reflection;
using HarmonyLib;
using System;

namespace Rimworld_FixAnimalCount
{

    [StaticConstructorOnStartup]
    public static class FixAnimalCountMod
    {
        public static Harmony harmonyInstance;



        static FixAnimalCountMod()
        {
            Log.Message("loaded");
            harmonyInstance = new Harmony("arl85.FixAnimalCount");
#if DEBUG
            Harmony.DEBUG = true;
#endif
            harmonyInstance.PatchAll();

        }


        [HarmonyPatch(typeof(Dialog_AutoSlaughter), "CountPlayerAnimals")] // new Type[] { typeof(Map), typeof(AutoSlaughterConfig), typeof(ThingDef), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }, new ArgumentType[] { ArgumentType.Normal, ArgumentType.Normal, ArgumentType.Normal, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out, ArgumentType.Out })]
        public static class Dialog_AutoSlaughter_CountPlayerAnimals
        {
            static void Postfix(int currentMales, int currentMalesYoung, int currentFemales, int currentFemalesYoung, ref int currentTotal)
            {
                currentTotal = currentMales + -currentMalesYoung + currentFemales + currentFemalesYoung;
            }

        }

    }
}

