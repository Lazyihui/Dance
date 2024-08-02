using System;
using UnityEngine;

public static class UIApp {
    public static void Panel_Arrow_Open(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;

        if (panel == null) {
            bool has = ctx.assetsContext.panels.TryGetValue("Panel_Arrow", out GameObject prefab);
            if (!has) {
                Debug.LogError("Panel_Arrow not found");
                return;
            }
            panel = GameObject.Instantiate(prefab, ctx.canvas.transform).GetComponent<Panel_Arrow>();
            panel.Ctor();
            ctx.panelArrow = panel;
        }

        panel.Show();

    }

    public static void Panel_ArrowElementAdd(UIContext ctx, int count) {

        Panel_Arrow panel = ctx.panelArrow;

        for (int i = 0; i < count; i++) {

            int randomDir = UnityEngine.Random.Range(1, 5);
            panel.AddElement(ctx, randomDir);
            ctx.arrowElementArray[ctx.arrowIndex] = randomDir;
            ctx.arrowIndex++;

        }


        for (int i = 0; i < count; i++) {
            int a = ctx.arrowElementArray[i];
            Debug.Log(a);
        }

    }

    public static void Panel_ArrowElementUpdate(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;
        

    }
}