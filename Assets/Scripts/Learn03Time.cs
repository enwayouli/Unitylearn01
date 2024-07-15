using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03Time : MonoBehaviour
{

    void Update()
    {
        float time;
        time = Time.deltaTime;
        time = Time.time;
        time = Time.frameCount;
        time = Time.fixedDeltaTime;
        #region 时间缩放比例  Time.timeScale
        //时间停止
        Time.timeScale = 0;
        //二倍速
        Time.timeScale = 2;
        //回复正常
        Time.timeScale = 1;
        #endregion

        #region 帧间隔时间   Time.deltaTime
        //一帧用了多少时间
        //受到scale影响
        print("帧间隔时间:" + Time.deltaTime);

        //不受scale影响
        print("帧间隔时间不受scale影响:" + Time.unscaledDeltaTime);
        #endregion

        #region 游戏开始到现在的时间 Time.time
        //受scale影响
        print("游戏开始到现在的时间:" + Time.time);
        //不受scale影响
        print("游戏开始到现在的时间不受scale影响:" + Time.unscaledTime);
        #endregion

        #region 帧数
        //开始到现在跑了多少帧
        print("开始到现在跑了多少帧:" + Time.frameCount);
        #endregion
    }

    private void FixedUpdate()
    {
        #region 物理帧间隔时间 Time.fixedDeltaTime
        float time =    Time.fixedDeltaTime;
        time =          Time.fixedUnscaledDeltaTime;
        #endregion
    }
}
