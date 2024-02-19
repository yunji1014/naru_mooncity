using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Forms.DataVisualization.Charting;
// dotnet add package Newtonsoft.Json;

public class Result : MonoBehaviour

{
    private float a; // 결과(최대 10, 최소 -10)
    private float result_ND = 0; // 정규분포에 기반한 결과값

    public Result(int result1) {
        a = result1;
    } // 생성자 

    public float getresult_ND() {
        return result_ND;
    } // 결과 내보낼 get 함수

    // Start is called before the first frame update
    void Start()
    { 
    // result_ND = NormalDistribution((Mathf.Abs(a) / 10.0))-0.5; // 표준 누적 분포의 값을 계산
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
