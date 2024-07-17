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

    // 만일, 충돌이 발생한다면...
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // 상대방 오브젝트를 제거한다.
    //    Destroy(collision.gameObject);

    //    // 나를 제거한다.
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        // 만일, 충돌한 대상의 게임 오브젝트의 이름이 "Enemy"라는 문자열을 포함하고 있다면...
        if (other.gameObject.name.Contains("Enemy"))
        {
            // 상대방 오브젝트를 제거한다.
            Destroy(other.gameObject);
        }
        // 나를 제거한다.
        Destroy(gameObject);
    }
}
