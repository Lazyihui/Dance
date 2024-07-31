using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class TemplateContext {
    public Dictionary<int, ArrowTM> arrows;

    public AsyncOperationHandle arrowPtr;

    public TemplateContext() {
        arrows = new Dictionary<int, ArrowTM>();
    }
}