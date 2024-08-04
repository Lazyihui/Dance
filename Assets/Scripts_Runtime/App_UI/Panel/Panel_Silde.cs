using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Silde : MonoBehaviour {

    [SerializeField] Text LevelText;

    [SerializeField] public Image startPos;

    [SerializeField] public Image endPos;


    public float negativewidth;

    public bool isMove_StartPos;



    public void Ctor() {
        // negativewidth = Mathf.Abs(startPos.transform.localPosition.x - endPos.transform.localPosition.x);

        negativewidth = Mathf.Abs(startPos.rectTransform.anchoredPosition.x - endPos.rectTransform.anchoredPosition.x);
        isMove_StartPos = false;

    }

    public void SetLevelText(int text) {
        LevelText.text = text.ToString();
    }

    public void Move_StartPos(float dt, ref float t, float SumTime, ref int level) {

        //    用时间的算法

        if (isMove_StartPos) {
            return;
        }

        Vector2 pos = startPos.rectTransform.anchoredPosition;

        float dir = Mathf.Abs(pos.x - endPos.rectTransform.anchoredPosition.x);

        if (dir < 30f) {

            t += dt;
            pos.x = (t / SumTime) * negativewidth;
            dir = Mathf.Abs(pos.x - endPos.rectTransform.anchoredPosition.x);

            if (Input.GetKeyDown(KeyCode.Space)) {
                isMove_StartPos = true;
                startPos.rectTransform.anchoredPosition = new Vector2(0, 0);
                level++;

                return;
            } else {
                isMove_StartPos = false;
                startPos.rectTransform.anchoredPosition = new Vector2(0, 0);

            }


        }


        t += dt;
        pos.x = (t / SumTime) * negativewidth;
        startPos.rectTransform.anchoredPosition = pos;


    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void TearDown() {
        gameObject.SetActive(false);
    }



}
