using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Istrue : MonoBehaviour
{
    private Result result; // fudge system�� �����Ͽ� ���� ���
    private User user; // Ư�� ĳ������ �ɷ� ����Ʈ ���� ���� ���� ��ü ����
    private float point; // ������� �ɷ�
    private float other; // ������� �� ���� �͵�

    private MainScript cycle; // �ֱ�

    private float result_all = 0; // �� ���� �� float�� ������ ���� �� 0���� �ʱ�ȭ

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
       // float point = user.getPoint(); // ������� �ɷ� ��ġȭ
       // float other = user.getOther(); // ������� �� ���� �͵�
    }

    bool istrue() {
        result_all = 1 + 2 + 3; // �� ���� �� �־��ֱ�(result,point,other)

        if (result_all > cycle.getB_cycle()) // cycle
        {
            return true;
        }
        else {
            return false;
        }
    }
    
}
