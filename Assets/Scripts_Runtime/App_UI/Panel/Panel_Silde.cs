using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Silde : MonoBehaviour {

    [SerializeField] Text LevelText;

    [SerializeField] Image startPos;

    [SerializeField] Image endPos;


    public void Ctor() { }

    public void SetLevelText(int text) {
        LevelText.text = text.ToString();
    }


    public void Show() {
        gameObject.SetActive(true);
    }

    public void TearDown() {
        gameObject.SetActive(false);
    }



}
