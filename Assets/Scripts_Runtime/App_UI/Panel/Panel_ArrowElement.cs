using System;
using UnityEngine;
using UnityEngine.UI;


public class Panel_ArrowElement : MonoBehaviour {

    [SerializeField] Image image;

    public void Ctor() {

    }

    public void SetArrow(Sprite sprite) {
        image.sprite = sprite;
        image.SetNativeSize();

    }

    public void SetFinishColor(Color color) {
        image.color = color;
    }
}

