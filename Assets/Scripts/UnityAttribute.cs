using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAttribute : MonoBehaviour
{
    
    [Header("Header����")]                           //Header             ����
    public int header1;
    public int header2;

    [Space()]                                        //Space              ���
    [Tooltip("Tooltip˵������")]                     //Tooltip            ˵������
    public string tooltip = "��������鿴˵������";

    [Range(0,1)]                                     //Range              ���Ʒ�Χ
    public float range;

    [Multiline(3)]                                   //Multiline          �����ַ���
    public string multiline;

    [ContextMenuItem("����", "SetContextMenuItem")]  //ContextMenuItem    �Ҽ�����
    public string contextMenuItem = "�Ҽ�������";
    private void SetContextMenuItem() { contextMenuItem = ""; }

    [TextArea(3, 4)]                                 //TextArea           ��Χ�����ַ���
    public string textArea;

    [ContextMenu("����ContextMenu")]                 //ContextMenu        Inspector�ű�������չ
    private void ContextMenu()
    {
        Debug.Log("ContextMenu run complete");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
