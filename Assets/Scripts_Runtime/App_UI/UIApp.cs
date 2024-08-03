using System;
using System.Collections;
using System.Collections.Generic;
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


    public static void Panel_Arrow_Close(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;
        if (panel == null) {
            return;
        }
        panel.Close();
        Panel_ArrowElementClear(ctx);
    }

    public static void Panel_ArrowElementClear(UIContext ctx) {

        Panel_Arrow panel = ctx.panelArrow;
        if (panel == null) {
            return;
        }

        int len = ctx.panelEleRespository.TakeAll(out Panel_ArrowElement[] elements);
        for (int i = 0; i < len; i++) {
            Panel_ArrowElement ele = elements[i];

            ctx.panelEleRespository.Remove(ele);
            GameObject.Destroy(ele.gameObject);

        }

    }

    public static void Panel_ArrowElementAdd(UIContext ctx, int count) {

        Panel_Arrow panel = ctx.panelArrow;

        for (int i = 0; i < count; i++) {

            int randomDir = UnityEngine.Random.Range(1, 5);
            panel.AddElement(ctx, randomDir);
            ctx.arrowElementArray.Add(randomDir);

        }


    }

    public static void Panel_ArrowElementUpdate(UIContext ctx, int count) {

        Panel_Arrow panel = ctx.panelArrow;

        int index = ctx.moduleInput.index;

        if (ctx.moduleInput.PressedKey == ctx.arrowElementArray[index]) {
            Debug.Log("相同");

            ctx.panelEleRespository.TryGet(index, out Panel_ArrowElement ele);
            ele.SetFinishColor(Color.green);

            ctx.moduleInput.index++;
        } else {

            UIApp.Panel_Arrow_Close(ctx);

            UIApp.Panel_Arrow_Open(ctx);
            UIApp.Panel_ArrowElementAdd(ctx, count);

        }

    }
}