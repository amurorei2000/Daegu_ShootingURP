using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCoding : MonoBehaviour
{
    // 전역 변수
    public string firstName = "이순신";
    

    void Start()
    {
        // 지역 변수
        string firstName = "박원석";
        print(firstName);
    }

    // Update is called once per frame
    void Update()
    {
        string firstName = "서해창";

        print(this.firstName);
    }

    void TestFunc()
    {
        print(firstName);
    }
}
