using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Forms.DataVisualization.Charting;
// dotnet add package Newtonsoft.Json;

public class Result : MonoBehaviour

{
    private float a; // ���(�ִ� 10, �ּ� -10)
    private float result_ND = 0; // ���Ժ����� ����� �����

    public Result(int result1) {
        a = result1;
    } // ������ 

    public float getresult_ND() {
        return result_ND;
    } // ��� ������ get �Լ�

    // Start is called before the first frame update
    void Start()
    { 
    // result_ND = NormalDistribution((Mathf.Abs(a) / 10.0))-0.5; // ǥ�� ���� ������ ���� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
