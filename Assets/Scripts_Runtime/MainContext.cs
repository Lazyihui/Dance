using System;
using UnityEngine;

public class MainContext {

    public GameEntity gameEntity;
    public ModuleInput moduleInput;

    public UIContext uiContext;
    // inject
    public Canvas canvas;
    public MainContext() {
        gameEntity = new GameEntity();
        
        moduleInput = new ModuleInput();
        uiContext = new UIContext();
    }

    public void Inject(Canvas canvas) {
        uiContext.Inject(moduleInput);
        this.canvas = canvas;
    }


}