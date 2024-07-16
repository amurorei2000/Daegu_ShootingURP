using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 사용자의 입력을 받아서 그 입력받은 방향으로 이동하게 하고 싶다.
    // 1. 사용자의 입력(Input)을 받는다. -> 상하 좌우 입력을 받는다.
    // 2. 입력받은 방향과 속력을 설정한다.(속도)
    // 3. 그 속도로 이동하게 하고 싶다. -> p = p0 + vt


    public float speed = 10.0f;
    public bool isUpDown = false;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt
        //transform.position += Vector3.left * speed * Time.deltaTime;
        //print(Time.deltaTime);

        if (isUpDown)
        {
            MoveType1();
        }
        else
        {
            MoveType2();
        }
    }

    void MoveType1()
    {
        // 사용자의 상하좌우 입력 값을 출력하기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //print(h);

        // 좌우 입력 값을 벡터로 만들기
        Vector3 direction = new Vector3(h, v, 0);
        //Vector3 direction = new Vector3(h, 0, 0) + new Vector3(0, v, 0);

        // direction 벡터의 길이를 1로 정규화하기
        direction.Normalize();

        // p = p0 + vt 공식을 이용해서 플레이어의 위치를 이동시키기
        transform.position += direction * speed * Time.deltaTime;
        //transform.localScale += direction * speed * Time.deltaTime;
        //transform.eulerAngles += direction * speed * Time.deltaTime;
    }

    void MoveType2()
    {
        // 사용자의 상하좌우 입력 값을 출력하기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //print(h);

        // 좌우 입력 값을 벡터로 만들기
        Vector3 direction = new Vector3(h, 0, v);
        //Vector3 direction = new Vector3(h, 0, 0) + new Vector3(0, v, 0);

        // direction 벡터의 길이를 1로 정규화하기
        direction.Normalize();

        // p = p0 + vt 공식을 이용해서 플레이어의 위치를 이동시키기
        transform.position += direction * speed * Time.deltaTime;
    }



    // 메모리에서 삭제되기 직전에 1회 호출되는 함수(call back function)
    private void OnDestroy()
    {
        
    }
}
