using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Silde : MonoBehaviour {

    [SerializeField] Text LevelText;

    [SerializeField] public Image startPos;

    [SerializeField] public Image endPos;


    public float negativewidth;



    public void Ctor() {
        // negativewidth = Mathf.Abs(startPos.transform.localPosition.x - endPos.transform.localPosition.x);
        negativewidth = Mathf.Abs(startPos.rectTransform.anchoredPosition.x - endPos.rectTransform.anchoredPosition.x);
    }

    public void SetLevelText(int text) {
        LevelText.text = text.ToString();
    }

    public void Move_StartPos(float dt, ref float t, float SumTime) {
        // startPos.rectTransform.anchoredPosition = new Vector2(startPos.rectTransform.anchoredPosition.x + dt, startPos.rectTransform.anchoredPosition.y);
        // Vector2 pos = startPos.rectTransform.anchoredPosition;
        // pos.x += dt*10;
        // startPos.rectTransform.anchoredPosition = pos;

        // Debug.Log("startPos.rectTransform.anchoredPosition.x: " + startPos.rectTransform.anchoredPosition.x);

        // Vector2 pos = startPos.transform.localPosition;
        Vector2 pos = startPos.rectTransform.anchoredPosition;

        if(pos.x >= endPos.rectTransform.anchoredPosition.x) {
            pos = endPos.rectTransform.anchoredPosition;
            Debug.Log("pos.x >= endPos.rectTransform.anchoredPosition.x"+ pos.x + " " + endPos.rectTransform.anchoredPosition.x);
            return;
        }

        t += dt;
        
        pos.x = (t / SumTime) * negativewidth;

        Debug.Log("t" + t + "t / SumTime: " + t / SumTime);


        // startPos.transform.localPosition = pos;
        startPos.rectTransform.anchoredPosition = pos;


    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void TearDown() {
        gameObject.SetActive(false);
    }



}
