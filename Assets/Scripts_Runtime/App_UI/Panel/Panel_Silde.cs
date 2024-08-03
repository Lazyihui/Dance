using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Silde : MonoBehaviour {

    [SerializeField] Text LevelText;

    [SerializeField] Transform startPos;

    [SerializeField] Transform endPos;


    public void Ctor() { }




    public void Show() {
        gameObject.SetActive(true);
    }

    public void TearDown() {
        gameObject.SetActive(false);
    }



}
