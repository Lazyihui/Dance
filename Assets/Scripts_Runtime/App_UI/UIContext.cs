using System;

using UnityEngine;

public class UIContext {
    // inject
    public ModuleInput moduleInput;
    // panel
    public Panel_Arrow panelArrow;

    public UIContext() {
        panelArrow = new Panel_Arrow();
    }

    public void Inject(ModuleInput moduleInput) {
        this.moduleInput = moduleInput;
    }


}