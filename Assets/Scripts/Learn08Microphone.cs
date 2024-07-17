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
        #region ��ȡ��˷�
        string[] devices = Microphone.devices;
        foreach (string device in devices)
        {
            print(device);
        }
        #endregion

    }
    private void Update()
    {
        #region ��ʼ¼��
        //����һ:  �豸�� ����ʹ��Ĭ���豸
        //������:  ����¼�Ƴ��Ⱥ� �Ƿ���ͷ¼��
        //������:  ¼��ʱ��
        //������:  ������
        if (Input.GetKeyDown(KeyCode.Q))
        {
            clip = Microphone.Start(null, false, 10, 44100);
        }
        #endregion

        #region ����¼��

        if (Input.GetKeyDown(KeyCode.W))
        {
            Microphone.End(null);
            audioSource.clip = clip;
            audioSource.Play();
        }
        #endregion

        #region ��ȡ��Ƶ�������ڴ洢���ߴ���
        //���� ���ڴ洢�������ݵĳ��� ���� ������ * ��������

        if (Input.GetKeyDown(KeyCode.E))
        {
            float[] f = new float[clip.channels * clip.samples];
            clip.GetData(f, 0);
            print(f.Length);
        }
        #endregion

    }
}
