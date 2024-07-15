using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn04Screen : MonoBehaviour
{
    void Start()
    {
        #region 静态属性
        #region 常用
        //当前屏幕分辨率
        Resolution r = Screen.currentResolution;
        print("当前屏幕的宽:" + r.width + " 高:" + r.height);
        //当前game窗口分辨率
        print("当前game窗口的宽:" + Screen.width + " 高:" + Screen.height);

        //屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        #endregion

        #region 不常用
        //全屏
        Screen.fullScreen = true;
        //窗口模式 FullScreenMode.
        //独占全屏                ExclusiveFullScreen
        //全屏窗口                FullScreenWindow
        //最大化窗口              MaximizedWindow
        //窗口模式                Windowed
        Screen.fullScreenMode = FullScreenMode.Windowed;

        //移动设备屏幕转向相关
        Screen.autorotateToLandscapeLeft = true;        //左横向
        Screen.autorotateToLandscapeRight = true;       //右横向
        Screen.autorotateToPortrait = true;             //纵向
        Screen.autorotateToPortraitUpsideDown = true;   //纵向翻转

        //指定屏幕显示方向
        Screen.orientation = ScreenOrientation.LandscapeLeft; //enum ScreenOrientation
        #endregion
        #endregion

        #region 静态方法
        //设置分辨率 移动设备不使用
        Screen.SetResolution(1920, 1080, false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
