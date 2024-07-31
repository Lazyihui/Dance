using System;
using UnityEngine;

public class MainContext {

    public GameEntity gameEntity;
    public ModuleInput moduleInput;

    public UIContext uiContext;

    public AssetsContext assetsContext;

    public TemplateContext templateContext;
    // inject
    public Canvas canvas;
    public MainContext() {
        gameEntity = new GameEntity();

        moduleInput = new ModuleInput();
        uiContext = new UIContext();

        assetsContext = new AssetsContext();
        templateContext = new TemplateContext();
    }

    public void Inject(Canvas canvas) {
        uiContext.Inject(moduleInput);
        this.canvas = canvas;
    }


}