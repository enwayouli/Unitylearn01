using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn08Microphone : MonoBehaviour
{
    private AudioClip clip;
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        #region 获取麦克风
        string[] devices = Microphone.devices;
        foreach (string device in devices)
        {
            print(device);
        }
        #endregion

    }
    private void Update()
    {
        #region 开始录制
        //参数一:  设备名 传空使用默认设备
        //参数二:  超过录制长度后 是否重头录制
        //参数三:  录制时长
        //参数四:  采样率
        if (Input.GetKeyDown(KeyCode.Q))
        {
            clip = Microphone.Start(null, false, 10, 44100);
        }
        #endregion

        #region 结束录制

        if (Input.GetKeyDown(KeyCode.W))
        {
            Microphone.End(null);
            audioSource.clip = clip;
            audioSource.Play();
        }
        #endregion

        #region 获取音频数据用于存储或者传输
        //规则 用于存储数组数据的长度 是用 声道数 * 剪辑长度

        if (Input.GetKeyDown(KeyCode.E))
        {
            float[] f = new float[clip.channels * clip.samples];
            clip.GetData(f, 0);
            print(f.Length);
        }
        #endregion

    }
}
