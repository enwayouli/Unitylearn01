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
        #region �������
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //����
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //ֹͣ
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //��ͣ
            audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //ֹͣ��ͣ
            audioSource.UnPause();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            //�ӳٲ���
            audioSource.PlayDelayed(2);
        }
        #endregion

        #region ��ⲥ�����
        if (audioSource.isPlaying)
        {
            print("������");
        }
        else
        {
            print("���Ž���");
        }

        #endregion

        #region ��̬������Ч����
        //1. ��Ҫ���Ŷ����Ϲ��ؽű� ���Ʋ���

        //2. ʵ���������˽ű��Ķ��� ���Ʋ���  ʹ�ú���
        //Instantiate(audioGameObj);
        //3. һ��AudioSource���Ʋ�ͬ��Ƭ
        //audioSource.clip = audioClip;
        #endregion
    }
}
