using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    // ���ǹ�(���� ~��� ~�ϰڴ�)
    public int number1 = 50;
    public int number2 = 20;

    public bool isMan = true;

    void Start()
    {
        #region ���ǹ�
        //// ����, number1�� ���� number2�� ������ ũ��
        //if (number1 > number2)
        //{
        //    // "number1�� ���� �� Ů�ϴ�!"��� ����Ѵ�.
        //    print("number1�� ���� �� Ů�ϴ�!");
        //}
        //// �׷��� �ʰ� ���� number1�� ���� number2�� ������ ������
        //else if (number1 < number2)
        //{
        //    // "number2�� ���� �� �۽��ϴ�!"��� ����Ѵ�.
        //    print("number2�� ���� �� �۽��ϴ�!");
        //}
        //// �׷��� �ʴٸ�...
        //else
        //{
        //    // "number2�� ���� number1�� �����ϴ�."��� ����Ѵ�.
        //    print("number2�� ���� number1�� �����ϴ�.");
        //}

        //// ����, isMan ������ ���� true��� "����"��� ����ϰ�,
        //if (isMan)
        //{
        //    print("����");
        //}
        //// �׷��� �ʴٸ�, "����"��� ����Ѵ�.
        //else
        //{
        //    print("����");
        //}
        #endregion

        #region �ݺ���
        // 1. "�ȳ��ϼ���"��� ���ڿ��� 10ȸ ����Ѵ�.
        //for(int i = 0; i < 10; i = i+1)
        //{
        //    print("�ȳ��ϼ���");
        //}

        // 2. 1���� 10���� ����ϰ� �ʹ�.
        //for(int i = 0; i < 10; i = i + 1)
        //{
        //    print(i + 1);
        //}

        //for(int i = 0; i < 10; i++)
        //{
        //    print(i + 1);
        //}

        // �ݺ����� �̿��ؼ� ������ 7���� ����غ���.
        //for(int i = 1; i < 10; i++)
        //{
        //    print(i * 7);
        //}

        //for(int i = 7; i <= 7 * 9; i = i + 7)
        //{
        //    print(i);
        //}
        #endregion

        #region Ŭ����
        // Ŭ���� ������ ����� �� Ŭ���� �ν��Ͻ��� ����
        //FirstCoding myInstance = new FirstCoding();
        //myInstance.number2 = 3.5f;
        //int result = myInstance.AddInteger(10, 20);
        #endregion
    }

    void Update()
    {
        
    }
}
