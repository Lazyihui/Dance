using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIContext {
    // inject
    public ModuleInput moduleInput;

    public TemplateContext templateContext;

    public AssetsContext assetsContext;

    public Canvas canvas;


    // panel
    public Panel_Arrow panelArrow;

    public Queue<int> arrowElementQueue;

    public int currentarrowElement;

    public UIContext() {
        arrowElementQueue = new Queue<int>();
        currentarrowElement = 0;
    }

    public void Inject(Canvas canvas,ModuleInput moduleInput, TemplateContext templateContext, AssetsContext assetsContext) {
        this.moduleInput = moduleInput;
        this.templateContext = templateContext;
        this.assetsContext = assetsContext;
        this.canvas = canvas;
    }


}