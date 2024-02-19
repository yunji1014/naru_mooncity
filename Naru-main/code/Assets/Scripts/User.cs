using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class User : MonoBehaviour
{
    string name='?'; // �̸�
    int hp; // ü��
    int mental; //����

    // ���ȵ�
    int animal_ability1 = 5; // �ż�
    int animal_ability2 = 5; // ����
    int animal_ability3 = 5; //����
    int human_ability1 = 5; // �μ�
    int human_ability2 = 5; // ����
    int human_ability3 = 5; // ����

    public Button ability_btn;

    static int b_cycle = 0; // �ֱ�
    static int s_cycle = 0; // ���ֱ�
    public Button button; // ���ֱ� ���� ��ư

    // Start is called before the first frame update
    void Start()
    {
       ability_btn.onClick.AddListener(ability); // ��ư Ŭ�� �� �Լ� ����
       button.onClick.AddListener(cycle_controll); // ��ư Ŭ�� �� �Լ� ����
    }
    public string GetButtonName()
    {
        // ��ư �̸� ��������
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        return ButtonName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ability()
    {
        if (GetButtonName() == "animal_ability1")
        {
            animal_ability1++;
            print("����+");
        }
        else if (GetButtonName() == "animal_ability2") {
            animal_ability2++;
            print("����+");

        }
        else if (GetButtonName() == "animal_ability3")
        {
            animal_ability3++;
            print("�ż�+");

        }
        else if (GetButtonName() == "human_ability1")
        {
            human_ability1++;
            print("�μ�+");

        }
        else if (GetButtonName() == "human_ability2")
        {
            human_ability2++;
            print("����+");

        }
        else if (GetButtonName() == "human_ability3")
        {
            human_ability3++;
            print("����+");

        }

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
        if (s_cycle % 10 == 0)
        { // ���ֱ� 10���� ������ �������� 0�̸�
            b_cycle++; // �ֱ� ����
        }
        print("next");

    }
}
