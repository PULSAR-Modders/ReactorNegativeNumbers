using HarmonyLib;
using UnityEngine;

namespace Reactor_Negative_Numbers
{
    [HarmonyPatch(typeof(PLEngineerReactorScreen), "UpdateCoreTempSection")]
    internal class EngineerReactorScreen
    {
        static void Postfix(PLEngineerReactorScreen __instance, UIWidget ___TempBarOuter, PLReactor ___MyReactor, UILabel ___StabilityBarValueLabel, PLCachedFormatString<int> ___cStabilityBarValueLabel)
        {
            if (___TempBarOuter != null && ___MyReactor != null)
            {
                PLGlobal.SafeLabelSetText(___StabilityBarValueLabel, ___cStabilityBarValueLabel.ToString(Mathf.FloorToInt((1f - __instance.MyScreenHubBase.OptionalShipInfo.CoreInstability) * 100f)));
            }
        }
    }
}
