using System;
using UnityEngine;

public class ModuleInput {



    public int PressedKey;

    public int index;

    public ModuleInput() {
        PressedKey = 0;
        index = 0;
    }

    public void ProcessInput() {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            PressedKey = 1;
            index++;
        } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            PressedKey = 2;
            index++;
        } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            PressedKey = 3;
            index++;
        } else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            PressedKey = 4;
            index++;
        } else {
            PressedKey = 0;
            index++;

        }

    }




}
