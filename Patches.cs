
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using UseTheWorstFirstAndDropStone;
using MelonLoader;
using Il2CppTLD.Gear;

namespace UseTheWorstFirstAndDropStone
{
    internal class Patches
    {
        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetHighestConditionGearThatMatchesName))]
        internal class Inventory_GetHighestConditionGearThatMatchesName
        {
            internal static void Postfix(Inventory __instance, string name, ref GearItem __result)
            {
                //MelonLogger.Msg("GetHighest : " + name);
                if (name == "GEAR_Torch" && Settings.settings.torch)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Firestriker" && Settings.settings.firestriker)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_PackMatches" && Settings.settings.matches)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_WoodMatches" && Settings.settings.matches)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                /*else if (name == "GEAR_KeroseneLampB")
                {
                     TRY TO GET IT BY LOWEST FUEL
                }*/
                else if (name == "GEAR_Bow" && Settings.settings.bow)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Rifle" && Settings.settings.rifle)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Revolver" && Settings.settings.revolver)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_CookingPot" && Settings.settings.cookingPot)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_RecycledCan" && Settings.settings.recycledCan)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_CanOpener" && Settings.settings.canOpener)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Knife" && Settings.settings.knives)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Hatchet" && Settings.settings.hatchets)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Hammer" && Settings.settings.hammer)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Prybar" && Settings.settings.prybar)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_KnifeImprovised" && Settings.settings.knives)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_HatchetImprovised" && Settings.settings.hatchets)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }
                else if (name == "GEAR_Snare" && Settings.settings.snare)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName(name);
                    return;
                }

                /* ITEMS CONCERNED BY THIS METHOD
                GEAR_KeroseneLampB
                GEAR_FlareGun
                GEAR_Rifle
                GEAR_Bow
                GEAR_Stone
                GEAR_Rifle_Vaughns
                GEAR_BearSpear
                GEAR_BearSpearStory
                GEAR_Revolver
                GEAR_NoiseMaker
                GEAR_Rifle_Barbs
                GEAR_Rifle_Curators
                GEAR_Bow_Woodwrights
                GEAR_RevolverStubNosed
                GEAR_RevolverFancy
                GEAR_RevolverGreen
                GEAR_Bow_Manufactured
                GEAR_Charcoal
                GEAR_HandheldShortwave
                GEAR_CookingPot
                GEAR_Knife
                GEAR_Hatchet
                GEAR_Hammer
                GEAR_Prybar
                GEAR_KnifeImprovised
                GEAR_HatchetImprovised
                GEAR_Snare
                GEAR_RecycledCan
                GEAR_FlareA
                GEAR_Torch
                GEAR_PackMatches*/

            }
        }





        [HarmonyPatch(typeof(Inventory), "GetWarmestBedroll")]
        internal class Inventory_GetWarmestBedroll
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                //MelonLogger.Msg("GetWarmestBedroll : Called");
                if (__result != null && Settings.settings.bedroll)
                {
                    if (__result.name == "GEAR_BearSkinBedRoll")
                    {
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_BearSkinBedRoll");
                        return;
                    }
                    else if (__result.name == "GEAR_BedRoll_Down")
                    {
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_BedRoll_Down");
                        return;
                    }
                    else if (__result.name == "GEAR_BedRoll")
                    {
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_BedRoll");
                        return;
                    }
                }
            }
        }




        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestDecoy))]
        internal class Inventory_GetBestDecoy
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                switch (Settings.settings.decoy)
                {
                    case Decoy.STONE:
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Stone");
                        break;
                    case Decoy.TINDER:
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Tinder");
                        break;
                    case Decoy.CATTAIL:
                        __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_CattailTinder");
                        break;
                    case Decoy.DEFAULT:

                        break;
                }

                if (__result == null) return;
                //MelonLogger.Msg("GetBestDecoy : " + __result.name);
            }
        }

        [HarmonyPatch(typeof(Inventory), "GetBestItemUsingComparison")]
        internal class Inventory_GetBestItemUsingComparison
        {
            internal static void Postfix(Inventory __instance, Predicate<GearItem> match, Comparison<GearItem> comparison, ref GearItem __result)
            {


                if (__result == null) return;
                //MelonLogger.Msg("GetBestItemUsingComparison : " + __result.name + " " + match);
                if (__result.name == "GEAR_Torch" && Settings.settings.torch)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Torch");
                    return;
                }
                else if (__result.name == "GEAR_PackMatches" && Settings.settings.matches)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_PackMatches");
                    return;
                }
                else if (__result.name == "GEAR_WoodMatches" && Settings.settings.matches)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_WoodMatches");
                    return;
                }
                /*else if (__result.name == "GEAR_KeroseneLampB")
                {
                     TRY TO GET IT BY LOWEST FUEL
                }*/
                else if (__result.name == "GEAR_Bow" && Settings.settings.bow)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Bow");
                    return;
                }
                else if (__result.name == "GEAR_Rifle" && Settings.settings.rifle)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Rifle");
                    return;
                }
                else if (__result.name == "GEAR_Revolver" && Settings.settings.revolver)
                {
                    __result = __instance.GetLowestConditionGearThatMatchesName("GEAR_Revolver");
                    return;
                }
            }
        }

        /*
        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestGearItemWithName))]
        internal class Inventory_GetBestGearItemWithName
        {
            internal static void Postfix(Inventory __instance, String name, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestGearItemWithName : " + __result.name);
            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestGun))]
        internal class Inventory_GetBestGun
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestGun : Called");

            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestBed))]
        internal class Inventory_GetBestBed
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestBed : Called");
            }
        }

        // DOESN'T EXIST ANYMORE
        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestBow))]
        internal class Inventory_GetBestBow
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestBow : Called");
            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetHighestConditionGearThatMatchesCanOpeningType))]
        internal class Inventory_GetHighestConditionGearThatMatchesCanOpeningType
        {
            internal static void Postfix(Inventory __instance, CanOpeningItem.CanOpeningType type, ref GearItem __result)
            {
                MelonLogger.Msg("GetCanOpener : Called");

            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestMatches), new Type[0])]
        internal class Inventory_GetBestMatches
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestMatches : Called");

            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestMatches), new Type[] { typeof(MatchesType) })]
        internal class Inventory_GetBestMatchesType
        {
            internal static void Postfix(Inventory __instance, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestMatches : Called");

            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestItemByCurrentHP))]
        internal class Inventory_GetBestItemByCurrentHP
        {
            internal static void Postfix(Inventory __instance, Predicate<GearItem> match, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestItemByCurrentHP : " + __result.name + " " + match);
            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetBestItemByNormalizedCondition))]
        internal class Inventory_GetBestItemByNormalizedCondition
        {
            internal static void Postfix(Inventory __instance, Predicate<GearItem> match, ref GearItem __result)
            {
                MelonLogger.Msg("GetBestItemByNormalizedCondition : " + __result.name + " " + match);
            }
        }

        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetFirstItem))]
        internal class Inventory_GetFirstItem
        {
            internal static void Postfix(Inventory __instance, Predicate<GearItem> match, ref GearItem __result)
            {
                MelonLogger.Msg("GetFirstItem : " + __result + " " + match);
            }
        }


        [HarmonyPatch(typeof(Inventory), nameof(Inventory.GetItems))]
        internal class Inventory_GetItems
        {
            internal static void Postfix(Inventory __instance, String gearName, Il2CppSystem.Collections.Generic.List<GearItem> list)
            {
                MelonLogger.Msg("GetItems : Called");
            }
        }

        [HarmonyPatch(typeof(Inventory), "FilterBestItemToList", new Type[] { typeof(Il2CppSystem.Collections.Generic.List<GearItem>), typeof(Il2CppSystem.Predicate<GearItem>) })]
        internal class Inventory_FilterBestItemToList2
        {
            internal static void Prefix(Inventory __instance, Il2CppSystem.Collections.Generic.List<GearItem> gearItems, Il2CppSystem.Predicate<GearItem> filter)
            {
                MelonLogger.Msg("FilterBestItemToList2 :");
                if (gearItems != null)
                {
                    MelonLogger.Msg(" - gearItems:");
                    foreach (GearItem item in gearItems)
                    {
                        MelonLogger.Msg("   - " + item.name);
                    }
                }
                MelonLogger.Msg(filter.method_info.Name);
                return;
            }
        }

        [HarmonyPatch(typeof(Inventory), "FilterBestItemToList", new Type[] { typeof(Il2CppSystem.Collections.Generic.List<GearItem>), typeof(Il2CppSystem.Predicate<GearItem>), typeof(Il2CppSystem.Comparison<GearItem>) })]
        internal class Inventory_FilterBestItemToList3
        {
            internal static void Prefix(Inventory __instance, Il2CppSystem.Collections.Generic.List<GearItem> gearItems, Il2CppSystem.Predicate<GearItem> filter, Il2CppSystem.Comparison<GearItem> comparison)
            {
                MelonLogger.Msg("FilterBestItemToList3 :");

                if (gearItems != null)
                {
                    MelonLogger.Msg(" - gearItems:");
                    foreach (GearItem item in gearItems)
                    {
                        MelonLogger.Msg("   - " + item.name);
                    }
                }
            }
        }

        [HarmonyPatch(typeof(Inventory), "FilterFPItemsToList", new Type[] { typeof(Il2CppSystem.Collections.Generic.List<GearItem>), typeof(Il2CppSystem.Predicate<GearItem>) })]
        internal class Inventory_FilterFPItemToList2
        {
            internal static void Prefix(Inventory __instance, Il2CppSystem.Collections.Generic.List<GearItem> gearItems, Il2CppSystem.Predicate<GearItem> filter)
            {
                MelonLogger.Msg("FilterFPItemsToList2 :");
                if (gearItems != null)
                {
                    MelonLogger.Msg(" - gearItems:");
                    foreach (GearItem item in gearItems)
                    {
                        MelonLogger.Msg("   - " + item.name);
                    }
                }
                return;
            }
        }

        [HarmonyPatch(typeof(Inventory), "FilterFPItemsToList", new Type[] { typeof(Il2CppSystem.Collections.Generic.List<GearItem>), typeof(Il2CppSystem.Predicate<GearItem>), typeof(Il2CppSystem.Comparison<GearItem>) })]
        internal class Inventory_FilterFPItemToList3
        {
            internal static void Prefix(Inventory __instance, Il2CppSystem.Collections.Generic.List<GearItem> gearItems, Il2CppSystem.Predicate<GearItem> filter, Il2CppSystem.Comparison<GearItem> comparison)
            {
                MelonLogger.Msg("FilterFPItemsToList3 :");

                if (gearItems != null)
                {
                    MelonLogger.Msg(" - gearItems:");
                    foreach (GearItem item in gearItems)
                    {
                        MelonLogger.Msg("   - " + item.name);
                    }
                }
                return;
            }
        }

        [HarmonyPatch(typeof(Inventory), "GetBestFromGearItemData")]
        internal class Inventory_GetBestFromGearItemData
        {
            internal static void Postfix(Inventory __instance, GearItemData gearItemData , ref GearItem __result)
            {
                MelonLogger.Msg("GetBestFromGearItemData : Called");

            }
        }*/

    }
}
