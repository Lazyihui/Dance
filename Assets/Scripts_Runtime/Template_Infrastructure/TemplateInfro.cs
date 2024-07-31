using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public static class TemplateInfro {
    public static void Load(TemplateContext ctx) {
        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "ArrowTM";
            var ptr = Addressables.LoadAssetsAsync<ArrowTM>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var go in list) {
                ctx.arrows.Add(go.typeID, go);
            }

        }
    }

    public static void Unload(TemplateContext ctx) {
        if (ctx.arrowPtr.IsValid()) {
            Addressables.Release(ctx.arrowPtr);
        }
    }
}