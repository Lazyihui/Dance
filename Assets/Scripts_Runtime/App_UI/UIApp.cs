using System;
using UnityEngine;

public static class UIApp {
    public static void Panel_Arrow_Open(UIContext ctx, ref bool isfinish) {

        Panel_Arrow panel = ctx.panelArrow;
        isfinish = true;
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


    public static void Panel_Arrow_Close(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;
        if (panel == null) {
            return;
        }
        panel.Close();
    }
    public static void Panel_ArrowElementAdd(UIContext ctx, int count, ref bool isfinish) {

        if (isfinish) {
            Panel_Arrow panel = ctx.panelArrow;

            for (int i = 0; i < count; i++) {

                int randomDir = UnityEngine.Random.Range(1, 5);
                panel.AddElement(ctx, randomDir);
                ctx.arrowElementArray[ctx.arrowIndex++] = randomDir;

            }

            isfinish = false;

        }

    }

    public static void Panel_ArrowElementClear(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;
        panel.CloseElement(ctx);
    }
    public static void Panel_ArrowElementUpdate(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;

        int index = ctx.moduleInput.index;
        Debug.Log("index: " + index);
        Debug.Log("input " + ctx.moduleInput.PressedKey + " arrow" + ctx.arrowElementArray[index]);
        if (ctx.moduleInput.PressedKey == ctx.arrowElementArray[index]) {
            Debug.Log("相同");

            ctx.panelEleRespository.TryGet(index, out Panel_ArrowElement ele);
            ele.SetFinishColor(Color.green);

            ctx.moduleInput.index++;
        } else {

            // Panel_ArrowElementClear(ctx);
            // ctx.gameLevelStatus = GameLevelStatus.Level_1_2;

        }

    }
}