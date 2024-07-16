using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // 일정한 시간마다 Enemy를 자신(Enemy Factory Game Obeject)의 위치에서 생성한다.
    // 지정할 시간, 실제 진행된 시간
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    public float generateTime = 2.0f;

    float currentTime = 0;

    void Start()
    {
       
    }

    void Update()
    {
        // 직전 프레임에서 현재 프레임까지 경과된 시간을 누적시킨다(총 경과시간).
        currentTime += Time.deltaTime;

        // 만일, 누적된 시간이 지정한 시간에 도달했다면...
        if (currentTime > generateTime)
        {
            // Enemy를 자신의 위치에서 생성한다.

            // 30% 확률로 1번 프리팹, 20% 확률로 2번 프리팹, 50% 확률로 3번 프리팹이 생성되게 하고 싶다.
            float num = Random.Range(0.0f, 1.0f);
            GameObject selectedObject;
            if(num < 0.3f)
            {
                selectedObject = enemyPrefab1;
            }
            else if(num < 0.5f)
            {
                selectedObject = enemyPrefab2;
            }
            else
            {
                selectedObject = enemyPrefab3;
            }

            GameObject go = Instantiate(selectedObject);
            go.transform.position = transform.position;

            // 누적 시간을 0초로 다시 초기화한다.
            currentTime = 0;
        }
    }
}
