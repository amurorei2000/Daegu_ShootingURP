using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // ������ ������ ����
    private int number;
    // �Ǽ��� ������ ����
    public float number2;
    // ���ڿ� ����
    public string myName = "�ڿ���";
    // ���� ����
    public bool isMan;

    void Start()
    {
        // number = 10;
        //number2 = 3.141592f;
        //myName = "������";

        //isMan = true;
        //isMan = false;
        // ������ ���� ����Ѵ�.
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

    // �Լ��� ����
    // �� ����(����)�� ���� �޾Ƽ� �� ������ ���� ��� ������ ��ȯ�ϴ� �Լ�
    // ��ȯ�ڷ��� �Լ��̸� (�Ű�����1, �Ű�����2...)
    // {
    //   �ؾ��� ��
    //   return �����;
    // }

    public int AddInteger(int num1, int num2)
    {
        return num1 + num2;
    }

    // ����(Subtract) -, ����(Multiply) * , ������(Divide) /
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
        // ������ ������ 
        // 1. ��
        // ������ : /
        // 2. ������
        // ������ : %

        //return (float)num1 / (float)num2;
        //return num1 / num2;
        return num1 % num2;
    }

}
