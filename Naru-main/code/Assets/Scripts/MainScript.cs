using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour // ���ֱ⸦ �Ѿ�� ���丮 ��ư�� ���� �� ����Ǵ� Ŭ����
{
    static int b_cycle = 0; // �ֱ�
    static int s_cycle = 0; // ���ֱ�
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(cycle_controll); // ��ư Ŭ�� �� �Լ� ����
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

        s_cycle++; // ���ֱ� ����
        if (s_cycle%10==0) { // ���ֱ� 10���� ������ �������� 0�̸�
            b_cycle++; // �ֱ� ����
        }
        print("next");

    }
}
