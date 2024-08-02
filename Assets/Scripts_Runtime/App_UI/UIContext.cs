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



    public int[] arrowElementArray;

    public int arrowIndex;

    public UIContext() {
        arrowElementArray = new int[14];
        arrowIndex = 0;
    }

    public void Inject(Canvas canvas, ModuleInput moduleInput, TemplateContext templateContext, AssetsContext assetsContext) {
        this.moduleInput = moduleInput;
        this.templateContext = templateContext;
        this.assetsContext = assetsContext;
        this.canvas = canvas;
    }


}