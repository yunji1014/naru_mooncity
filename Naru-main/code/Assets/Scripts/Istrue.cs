using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Istrue : MonoBehaviour
{
    private Result result; // fudge system을 차용하여 만든 결과
    private User user; // 특정 캐릭터의 능력 포인트 갖고 오기 위한 객체 선언
    private float point; // 사용자의 능력
    private float other; // 사용자의 그 외의 것들

    private MainScript cycle; // 주기

    private float result_all = 0; // 다 합한 값 float형 변수로 선언 후 0으로 초기화

    private Text result_try;

    bool ispossible1;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (istrue() == true)
        {
            ispossible1 = true;
        }
        else
        {
            ispossible1 = false;
        }
       // float point = user.getPoint(); // 사용자의 능력 수치화
       // float other = user.getOther(); // 사용자의 그 외의 것들
    }

    bool istrue() {
        result_all = 1 + 2 + 3; // 다 합한 값 넣어주기(result,point,other)

        if (result_all > cycle.getB_cycle()) // cycle
        {
            return true;
        }
        else {
            return false;
        }
    }
    
}
