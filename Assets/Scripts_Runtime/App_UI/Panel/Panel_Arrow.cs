using System;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Arrow : MonoBehaviour {
    [SerializeField] Image image;

    public Color finishColor;
    public void SetArrow(Sprite sprite) {
        image.sprite = sprite;
    }

    public void SetFinishColor(Color color) {
        image.color = color;
    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void Close() {
        gameObject.SetActive(false);
    }

    public void AddElement(UIContext ctx,int typeID) { }

}