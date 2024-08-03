using System;
using UnityEngine;

public class GameEntity {
    public float restFixTime;


    public int arrowCount;

    public float t;

    public float SumTime;

    public GameEntity() {
        restFixTime = 0;
        arrowCount = 5;
        t = 0;
        SumTime = 2;
    }
}