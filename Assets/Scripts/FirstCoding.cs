using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // 정수형 변수를 선언
    private int number;
    // 실수형 변수를 선언
    public float number2;
    // 문자열 변수
    public string myName = "박원석";
    // 논리형 변수
    public bool isMan;

    void Start()
    {
        // number = 10;
        //number2 = 3.141592f;
        //myName = "멋쟁이";

        //isMan = true;
        //isMan = false;
        // 변수의 값을 출력한다.
        //print(isMan);

        int number1 = 5;
        int number2 = 2;
        int result;
        //float result2;

        //result = AddInteger(number1, number2);
        //print(result);
        //result = Subtract(number1, number2);
        //print(result);
        //result = Multiply(number1, number2);
        //print(result);
        result = Divide(number1, number2);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 함수를 선언
    // 두 숫자(정수)를 재료로 받아서 두 정수의 합을 결과 값으로 반환하는 함수
    // 반환자료형 함수이름 (매개변수1, 매개변수2...)
    // {
    //   해야할 일
    //   return 결과값;
    // }

    public int AddInteger(int num1, int num2)
    {
        return num1 + num2;
    }

    // 뺄셈(Subtract) -, 곱셈(Multiply) * , 나눗셈(Divide) /
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    int Divide(int num1, int num2)
    {
        // 나눗셈 연산자 
        // 1. 몫
        // 연산자 : /
        // 2. 나머지
        // 연산자 : %

        //return (float)num1 / (float)num2;
        //return num1 / num2;
        return num1 % num2;
    }

}
