using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public static class CaracterStatus
{


    //저장할때는, 딱 이것만 저장되어도 되도록 할 것
    //2019.01.21 찾아보니 XML데이터를 수정할 수 있는 것 같은데, 이걸 저장할 수 있다면 이걸로 합시다.

    //임시로 과제 여부를 체크하는 변수
    public static string AssignmentValue = "00000000";

    //시간을 나타내는 변수입니다. 2019.01.28 일단 초기변수를 설정합니다
    public static int Week = 0;
    public static int Day = 0;

    //Time 0 = 아침, 1 = 점심, 2 = 저녘, 3 = 새벽
    public static int Time = 0; 

    //변수를 담당하는 스크립트입니다. 전역변수로써 'CaracterStatus.변수명'으로 호출 가능합니다.
    public static string caracterName = "김쭈글이";

    // 캐릭터의 정신적인 능력치 입니다. (상호작용에 관여합니다)
    public static int caracterWill = 0;
    public static int caracterSociability = 0;
    public static int caracterSelfego = 0;

    // 캐릭터의 생산적인 능력치 입니다. (수업과 과제에 관여합니다)
    public static int caracterMaking = 0;
    public static int caracterLogic = 0;
    public static int caracterIdea = 0;


    // 주 전공입니다, 반드시 100% 수강하게 됩니다
    public static string MainMajor;
    
    // 보조 전공입니다, MainMajor와 겹치지 않는 선에서 모두 수강할 수 있습니다
    public static string SubMajor;

    // 보조 보조 전공입니다. 위의 두 전공과 겹치지 않는 과목만 수강할 수 있습니다.
    public static string SubSubMajor;
       
    //02_CaracterRoom에 사용됨, 이 변수를 건드리면(0이 아니면) 각 번호에 맞는 bubble이 true가 됨
    public static int[] condition = new int[6];

    /* 
        0, Sleep
        1, Stress
        2, Relationship
        3, Love
        4, Health
        5, Grade
    */
    public static int NowScene;
}