using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn01UnityAttribute : MonoBehaviour
{
    
    [Header("Header分组")]                           //Header             分组
    public int header1;
    public int header2;

    [Space()]                                        //Space              间隔
    [Tooltip("Tooltip说明内容")]                     //Tooltip            说明内容
    public string tooltip = "鼠标悬浮查看说明内容";

    [Range(0,1)]                                     //Range              限制范围
    public float range;

    [Multiline(3)]                                   //Multiline          多行字符串
    public string multiline;

    [ContextMenuItem("重置", "SetContextMenuItem")]  //ContextMenuItem    右键功能
    public string contextMenuItem = "右键变量名";
    private void SetContextMenuItem() { contextMenuItem = ""; }

    [TextArea(3, 4)]                                 //TextArea           范围多行字符串
    public string textArea;

    [ContextMenu("测试ContextMenu")]                 //ContextMenu        Inspector脚本功能拓展
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
