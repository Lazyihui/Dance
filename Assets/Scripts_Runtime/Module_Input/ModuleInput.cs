using System;
using UnityEngine;

public class ModuleInput {



    public int PressedKey;


    public void ProcessInput() {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            PressedKey = 1;
        } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            PressedKey = 2;
        } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            PressedKey = 3;
        } else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            PressedKey = 4;
        } else {
            PressedKey = 0;
        }
    }




}
