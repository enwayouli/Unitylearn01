using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Learn09ChangeScene : MonoBehaviour
{
    void Update()
    {
        #region �����л�
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //�л�������2
            //��Ҫ�ѳ������ص������б��� BuildSettings�����Scene
            SceneManager.LoadScene("Learn09Scene01");
        }
        #endregion

        #region �˳�
        if (Input.GetKeyDown(KeyCode.W))
        {
            //������Ϸ�������
            Application.Quit();
        }
        #endregion

    }
}
