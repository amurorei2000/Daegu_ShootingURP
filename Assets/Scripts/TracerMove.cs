using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerMove : MonoBehaviour
{
    // 나는 계속해서 플레이어를 쫓아가겠다.
    // 필요 요소: 플레이어를 향한 방향, 이동 속력
    // 계산된 방향과 속력대로 이동한다.(p = p0 + vt)

    public GameObject target;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // 내가 플레이어를 바라보는 방향 벡터를 구한다.
        Vector3 dir = target.transform.position - transform.position;

        // 방향 벡터를 정규화한다.
        dir.Normalize();

        // 그 방향과 속력대로 이동한다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
