using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    // 조건문(만일 ~라면 ~하겠다)
    public int number1 = 50;
    public int number2 = 20;

    public bool isMan = true;

    void Start()
    {
        #region 조건문
        //// 만일, number1의 값이 number2의 값보다 크면
        //if (number1 > number2)
        //{
        //    // "number1의 값이 더 큽니다!"라고 출력한다.
        //    print("number1의 값이 더 큽니다!");
        //}
        //// 그렇지 않고 만일 number1의 값이 number2의 값보다 작으면
        //else if (number1 < number2)
        //{
        //    // "number2의 값이 더 작습니다!"라고 출력한다.
        //    print("number2의 값이 더 작습니다!");
        //}
        //// 그렇지 않다면...
        //else
        //{
        //    // "number2의 값이 number1과 같습니다."라고 출력한다.
        //    print("number2의 값이 number1과 같습니다.");
        //}

        //// 만일, isMan 변수의 값이 true라면 "남자"라고 출력하고,
        //if (isMan)
        //{
        //    print("남자");
        //}
        //// 그렇지 않다면, "여자"라고 출력한다.
        //else
        //{
        //    print("여자");
        //}
        #endregion

        #region 반복문
        // 1. "안녕하세요"라는 문자열을 10회 출력한다.
        //for(int i = 0; i < 10; i = i+1)
        //{
        //    print("안녕하세요");
        //}

        // 2. 1부터 10까지 출력하고 싶다.
        //for(int i = 0; i < 10; i = i + 1)
        //{
        //    print(i + 1);
        //}

        //for(int i = 0; i < 10; i++)
        //{
        //    print(i + 1);
        //}

        // 반복문을 이용해서 구구단 7단을 출력해보자.
        //for(int i = 1; i < 10; i++)
        //{
        //    print(i * 7);
        //}

        //for(int i = 7; i <= 7 * 9; i = i + 7)
        //{
        //    print(i);
        //}
        #endregion

        #region 클래스
        // 클래스 변수의 선언과 새 클래스 인스턴스의 생성
        //FirstCoding myInstance = new FirstCoding();
        //myInstance.number2 = 3.5f;
        //int result = myInstance.AddInteger(10, 20);
        #endregion
    }

    void Update()
    {
        
    }
}
