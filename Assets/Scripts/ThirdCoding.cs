using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCoding : MonoBehaviour
{
    // ���� ����
    public string firstName = "�̼���";
    

    void Start()
    {
        // ���� ����
        string firstName = "�ڿ���";
        print(firstName);
    }

    // Update is called once per frame
    void Update()
    {
        string firstName = "����â";

        print(this.firstName);
    }

    void TestFunc()
    {
        print(firstName);
    }
}
