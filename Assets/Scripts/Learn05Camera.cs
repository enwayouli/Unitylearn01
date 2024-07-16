using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn05Camera : MonoBehaviour
{
    void Start()
    {
        #region 重要静态成员
        //1. 获取摄像机
        //主摄像机
        print(Camera.main.name);
        //获取摄像机的数量
        print(Camera.allCamerasCount);
        //得到所有摄像机
        Camera[] cameras = Camera.allCameras;
        print(cameras.Length);

        //2. 渲染相关委托
        //摄像机提出前处理的委托函数
        Camera.onPreCull += (c) =>{ };
        //摄像机渲染前处理的委托
        Camera.onPreRender += (c) => { };
        //摄像机渲染后处理的委托
        Camera.onPostRender += (c) => { };
        #endregion

        #region 重要成员
        //1. 界面上的参数 都可以在Camera中获取到
        Camera.main.depth = -1;
        //2. 世界坐标转屏幕坐标
        Vector3 v = Camera.main.WorldToScreenPoint(transform.position);
        print(v);
        //3. 屏幕坐标转世界坐标
        Vector3 v1 = Camera.main.ScreenToWorldPoint(v);
        print(v1);
        #endregion
    }

    void Update()
    {
        
    }
}
