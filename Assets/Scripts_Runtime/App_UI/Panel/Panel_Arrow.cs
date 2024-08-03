using System;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Arrow : MonoBehaviour {
    [SerializeField] public Panel_ArrowElement ele;

    [SerializeField] Transform Group;

    public Color finishColor;

    public void Ctor() {
    }


    public void Show() {
        gameObject.SetActive(true);
    }

    public void Close() {
        gameObject.SetActive(false);
    }
    public void CloseElement(UIContext ctx) {

        int len = ctx.panelEleRespository.TakeAll(out Panel_ArrowElement[] eles);

        for (int i = 0; i < len; i++) {
            Panel_ArrowElement ele = eles[i];
            ele.Close();
        }

    }

    public Panel_ArrowElement AddElement(UIContext ctx, int typeID) {
        bool has = ctx.templateContext.arrows.TryGetValue(typeID, out ArrowTM tm);

        if (!has) {
            Debug.LogError("Arrow not found");
            return null;
        }

        ctx.assetsContext.panels.TryGetValue("Panel_ArrowElement", out GameObject prefab);

        GameObject go = Instantiate(prefab, Group);
        Panel_ArrowElement element = go.GetComponent<Panel_ArrowElement>();

        element.Ctor();
        element.SetArrow(tm.sprite);
        // element.SetFinishColor(finishColor);
        element.id = ctx.arrowRecordIndex++;
        ctx.panelEleRespository.Add(element);

        return element;
    }

}