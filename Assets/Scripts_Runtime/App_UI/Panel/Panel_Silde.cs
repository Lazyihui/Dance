using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Silde : MonoBehaviour {

    [SerializeField] Text LevelText;

    [SerializeField] public Image startPos;

    [SerializeField] public Image endPos;


    public float negativewidth;

    public float positivewidth;


    public void Ctor() {
        negativewidth = Mathf.Abs(startPos.transform.localPosition.x);
        positivewidth = Mathf.Abs(endPos.transform.localPosition.x);
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

        Vector2 pos = startPos.transform.localPosition;
        Debug.Log("pos" + pos);
        t += dt;
        if ((t / SumTime) >= 1) {
            {
                return;
            }
        }
        if (pos.x < 0) {
            pos.x = (t / SumTime) * negativewidth;

        } else {
            pos.x = (t / SumTime) * positivewidth;
        }

        Debug.Log("t" + t + "t / SumTime: " + t / SumTime);

        startPos.transform.localPosition = pos;


    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void TearDown() {
        gameObject.SetActive(false);
    }



}
