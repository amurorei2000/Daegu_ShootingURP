using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 일정한 확률에 따라서 이동 방식을 다르게 하도록 하고 싶다.
    // 필요 요소: 랜덤 범위, 확률 변수
    //public int traceRate = 30;
    public float traceRate = 0.3f;

    // 1. 계속해서 아래로 내려가게 하고 싶다.
    // 속력, 방향
    public float moveSpeed = 6;

    // 2. 플레이어가 있는 방향으로 이동하게 하고 싶다.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // 씬에 있는 게임 오브젝트 중에 "Player"라는 이름의 오브젝트를 찾는다.
        // 찾은 오브젝트가 있다면, 그 오브젝트를 target 변수에 넣는다.
        target = GameObject.Find("Player");

        // 1. 1 ~ 100 범위 안에서 랜덤하게 숫자 하나를 추첨한다.
        // 사용되지 않음(Deprecate) : 곧 사라질 운명
        //int number = Random.Range(1, 101);
        float number = Random.Range(0.0f, 1.0f);

        // 2. 만일, 추첨된 숫자가 확률 변수 값 이하라면...
        if (number <= traceRate)
        {
            // 2-1. 플레이어가 있는 방향으로 dir 변수를 설정한다.
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 3. 그렇지 않다면...
        else
        {
            // 3-1. dir 변수의 값을 아래 방향으로 설정한다.
            dir = new Vector3(0, -1, 0);
        }


    }

    void Update()
    {
        //transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        // 계산된 방향(dir)으로 이동한다.
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
