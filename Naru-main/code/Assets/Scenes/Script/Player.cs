using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private string name;
    private int cycle, minorCycle, fitness, willpower;
    private Characteristic[] evolution = { new Characteristic("head", 0) , new Characteristic("body", 0) ,
                                        new Characteristic("leftLeg", 0), new Characteristic("rightLeg", 0), 
                                        new Characteristic("leftArm", 0), new Characteristic("rightArm", 0)};
   

    //스탯 추가 예정

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetName(string name)
    {
        this.name = name;
    }

    void SetCycle(int cycle)
    {
        //주기 스크립트 작성 후 수정
        this.cycle = cycle;
    }

    void SetMinorCycle(int minorCycle)
    {
        //소주기 스크립트 작성 후 수정
        this.minorCycle = minorCycle;
    }

    bool evoluationIsFull(Characteristic e)
    {
        if (e == ) //진화 관련 내용이 부족
            return true;
        else return false;
    }
}
