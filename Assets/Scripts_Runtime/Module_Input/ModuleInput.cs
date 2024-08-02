using System;
using UnityEngine;

public class ModuleInput {



    public int PressedKey;

    public int index;

    public ModuleInput() {
        PressedKey = -1;
        index = 0;
    }

    public void ProcessInput(UIContext ctx) {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            PressedKey = 1;
            Debug.Log("PressedKey: " + PressedKey);
            UIApp.Panel_ArrowElementUpdate(ctx);

        } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            PressedKey = 2;
            Debug.Log("PressedKey: " + PressedKey);
            UIApp.Panel_ArrowElementUpdate(ctx);

        } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            PressedKey = 3;
            Debug.Log("PressedKey: " + PressedKey);
            UIApp.Panel_ArrowElementUpdate(ctx);

        } else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            PressedKey = 4;

            UIApp.Panel_ArrowElementUpdate(ctx);
            Debug.Log("PressedKey: " + PressedKey);
        } else if (Input.GetKeyDown(KeyCode.Space)) {
            PressedKey = 15;
        }

    }




}
