using System;
using UnityEngine;

public class ModuleInput {



    public int PressedKey;

    public int index;

    public ModuleInput() {
        PressedKey = -1;
        index = 0;
    }

    public void ProcessInput(MainContext ctx) {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            PressedKey = 1;
            UIApp.Panel_ArrowElementUpdate(ctx.uiContext, ctx.gameEntity.arrowCount);

        } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            PressedKey = 2;
            UIApp.Panel_ArrowElementUpdate(ctx.uiContext, ctx.gameEntity.arrowCount);

        } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            PressedKey = 3;
            UIApp.Panel_ArrowElementUpdate(ctx.uiContext, ctx.gameEntity.arrowCount);

        } else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            PressedKey = 4;

            UIApp.Panel_ArrowElementUpdate(ctx.uiContext, ctx.gameEntity.arrowCount);
        } else if (Input.GetKeyDown(KeyCode.Space)) {
            UIApp.Panel_Arrow_Close(ctx.uiContext);
            ctx.gameEntity.arrowCount += 1;

            UIApp.Panel_Arrow_Open(ctx.uiContext);
            UIApp.Panel_ArrowElementAdd(ctx.uiContext, ctx.gameEntity.arrowCount);
        }

    }




}
