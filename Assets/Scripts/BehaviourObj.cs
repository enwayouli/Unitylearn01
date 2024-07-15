using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BehaviourObj : MonoBehaviour
{
    private void OnEnable()
    {
        //获取对象位置信息
        print(this.transform.position);     //位置
        print(this.transform.eulerAngles);  //角度
        print(this.transform.lossyScale);   //缩放大小

        //1.得到自己挂载的单个脚本
        VideoPlayer vp = this.GetComponent<VideoPlayer>();      //1.
        vp = GetComponent("VideoPlayer") as VideoPlayer;        //2.
        vp = GetComponent(typeof(VideoPlayer)) as VideoPlayer;  //3.

        //2.得到自己挂载的多个脚本
        List<VideoPlayer> list = new List<VideoPlayer>();
        GetComponents<VideoPlayer>(list);//自动装载到list中

        //3.得到子对象挂载的脚本 (它默认也会找自己身上是否挂载该脚本)
        GetComponentInChildren<VideoPlayer>();  //()默认为false,填入(true)后, 对象失活也能找到

        //4.得到父对象挂载的脚本 (它默认也会找自己身上是否挂载该脚本)
        GetComponentInParent<VideoPlayer>();
        GetComponentsInParent<VideoPlayer>();   //会找到所有树状父对象

        //5.尝试获取对象
        VideoPlayer vp1;
        if(TryGetComponent<VideoPlayer>(out vp1))
        {

        }
        //GetComponentInParent<VideoPlayer>()?.Play(); 语法糖

    }
}
