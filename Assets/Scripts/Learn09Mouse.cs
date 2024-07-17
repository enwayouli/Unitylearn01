using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn09Mouse : MonoBehaviour
{
    public Texture2D cursorImg;
    void Update()
    {
        #region �������
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Cursor.visible = true;
        }
        #endregion

        #region �������

        if (Input.GetKeyDown(KeyCode.E))
        {
            //None: ������
            //Locked: ���� ���ᱻ��������Ļ������, ���ᱻ����
            //Confined �����ڴ��ڷ�Χ
            Cursor.lockState = CursorLockMode.Confined;
        }
        #endregion
        #region �������ͼƬ
        //����1:  ���ͼƬ
        //����2:  ƫ��λ�� �����ͼƬ���Ͻ�
        //����3:  ƽ̨֧�ֵĹ��ģʽ (Ӳ�������)
        Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.Auto);
        #endregion
    }
}
