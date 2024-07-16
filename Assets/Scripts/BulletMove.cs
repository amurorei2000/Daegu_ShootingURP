using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // 총알을 위로 계속 이동하게 하고 싶다.
    // 방향(위), 크기(이동 속력)
    public float moveSpeed = 10;


    void Start()
    {
        
    }
    
    void Update()
    {
        // 총알을 위로 계속 이동하게 하고 싶다.
        //Vector3 dir = Vector3.up;
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
