using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn08Audio : MonoBehaviour
{
     AudioSource audioSource;
    public AudioClip audioClip;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        #region 播放相关
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //播放
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //停止
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //暂停
            audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //停止暂停
            audioSource.UnPause();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            //延迟播放
            audioSource.PlayDelayed(2);
        }
        #endregion

        #region 检测播放完毕
        if (audioSource.isPlaying)
        {
            print("播放中");
        }
        else
        {
            print("播放结束");
        }

        #endregion

        #region 动态控制音效播放
        //1. 在要播放对象上挂载脚本 控制播放

        //2. 实例化挂载了脚本的对象 控制播放  使用很少
        //Instantiate(audioGameObj);
        //3. 一个AudioSource控制不同切片
        //audioSource.clip = audioClip;
        #endregion
    }
}
