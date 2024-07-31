using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public MainContext ctx;

    // bool isTearDown = false;
    void Awake() {

        ctx = new MainContext();

        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        ctx.Inject(canvas);


    }

    // Update is called once per frame
    void Update() {

        float dt = Time.deltaTime;

        PreFixUpdate(ctx);

        ref float restFixTime = ref ctx.gameEntity.restFixTime;

        restFixTime += dt;
        // ref传进去的参数在函数内部可以直接使用，而out不可（除非在函数体内部，out参数在使用之前赋值）
        const float FIX_INTERVAL = 0.020f;

        if (restFixTime <= FIX_INTERVAL) {

            LogicFix(ctx, restFixTime);
            restFixTime = 0;
        } else {
            while (restFixTime >= FIX_INTERVAL) {
                restFixTime -= FIX_INTERVAL;
                LogicFix(ctx, FIX_INTERVAL);
            }
        }

        LateFixUpdate(ctx, dt);
    }

    void PreFixUpdate(MainContext ctx) {
        ctx.moduleInput.ProcessInput();

    }

    void LogicFix(MainContext ctx, float dt) {

    }

    void LateFixUpdate(MainContext ctx, float dt) {

    }


}
