using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 마우스의 왼쪽 버튼을 누르면 총알이 발사(생성)되게 하고 싶다.
    // 1. 총알의 프리팹을 안다.
    public GameObject bulletPrefab;
    public GameObject firePosition;

    void Start()
    {
        
    }

    void Update()
    {
        // 2. 마우스 왼쪽 버튼의 입력(마우스 왼쪽 버튼을 누른 순간 1회)을 받는다.
        bool mouseInput = Input.GetButtonDown("Fire1");

        if(mouseInput)
        {
            //print("마우스 왼쪽 버튼 클릭!");

            // 3. 총알의 생성 위치를 지정한다.
            //Vector3 firePosition = transform.position + new Vector3(0, 1, 0);

            // 4. 총알 프리팹(파일)을 씬에 생성(메모리)한다.
            GameObject bulletInstance = Instantiate(bulletPrefab);

            // 5. 생성된 총알 인스턴스의 위치를 앞서 설정한 위치로 변경한다.(총알을 총구 위치에 가져다 놓는다.)
            //bulletInstance.transform.position = firePosition;
            bulletInstance.transform.position = firePosition.transform.position;

        }

    }
}
