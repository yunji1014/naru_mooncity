using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    bool ispossible2;
    int success;
    int failed;
    Istrue istrue; // �õ��� ���� ���
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
            result_try.text = "����";
            // user���� Ư¡ �����ͼ� success�� ���� ���� (��ȭġ)
        }
        else
        {
            result_try.text = "����";
            // user���� Ư¡ �����ͼ� failed�� ���� ���� (��ȭġ)
        }
    }
}
