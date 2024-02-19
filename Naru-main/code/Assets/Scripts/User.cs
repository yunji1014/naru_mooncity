using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class User : MonoBehaviour
{
    string name='?'; // 이름
    int hp; // 체력
    int mental; //정신

    // 스탯들
    int animal_ability1 = 5; // 신속
    int animal_ability2 = 5; // 직감
    int animal_ability3 = 5; //본능
    int human_ability1 = 5; // 부속
    int human_ability2 = 5; // 공감
    int human_ability3 = 5; // 지능

    public Button ability_btn;

    static int b_cycle = 0; // 주기
    static int s_cycle = 0; // 소주기
    public Button button; // 소주기 선택 버튼

    // Start is called before the first frame update
    void Start()
    {
       ability_btn.onClick.AddListener(ability); // 버튼 클릭 시 함수 동작
       button.onClick.AddListener(cycle_controll); // 버튼 클릭 시 함수 동작
    }
    public string GetButtonName()
    {
        // 버튼 이름 가져오기
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
            print("본능+");
        }
        else if (GetButtonName() == "animal_ability2") {
            animal_ability2++;
            print("직감+");

        }
        else if (GetButtonName() == "animal_ability3")
        {
            animal_ability3++;
            print("신속+");

        }
        else if (GetButtonName() == "human_ability1")
        {
            human_ability1++;
            print("부속+");

        }
        else if (GetButtonName() == "human_ability2")
        {
            human_ability2++;
            print("공감+");

        }
        else if (GetButtonName() == "human_ability3")
        {
            human_ability3++;
            print("지능+");

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
        s_cycle++; // 소주기 증가
        if (s_cycle % 10 == 0)
        { // 소주기 10으로 나누고 나머지가 0이면
            b_cycle++; // 주기 증가
        }
        print("next");

    }
}
