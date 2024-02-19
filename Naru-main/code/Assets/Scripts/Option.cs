using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    bool ispossible2;
    int success;
    int failed;
    Istrue istrue; // 시도의 판정 결과
    User user;

    // Start is called before the first frame update
    void Start()
    {
        result_try = GameObject.Find("tryresult").GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        if (istrue.ispossible1)
        {
            result_try.text = "성공";
            // user에서 특징 가져와서 success에 관련 수식 (변화치)
        }
        else
        {
            result_try.text = "실패";
            // user에서 특징 가져와서 failed에 관련 수식 (변화치)
        }
    }
}
