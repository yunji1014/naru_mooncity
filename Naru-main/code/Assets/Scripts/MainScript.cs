using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour // 소주기를 넘어가는 스토리 버튼을 누를 때 적용되는 클래스
{
    static int b_cycle = 0; // 주기
    static int s_cycle = 0; // 소주기
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(cycle_controll); // 버튼 클릭 시 함수 동작
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getS_cycle() 
    { 
        return s_cycle;
    }

    public int getB_cycle()
    {
        return b_cycle;
    }

    void cycle_controll()
    {

        s_cycle++; // 소주기 증가
        if (s_cycle%10==0) { // 소주기 10으로 나누고 나머지가 0이면
            b_cycle++; // 주기 증가
        }
        print("next");

    }
}
