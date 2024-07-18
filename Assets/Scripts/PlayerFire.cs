using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 마우스의 왼쪽 버튼을 누르면 총알이 발사(생성)되게 하고 싶다.
    // 1. 총알의 프리팹을 안다.
    public GameObject bulletPrefab;
    public GameObject[] firePosition = new GameObject[3];
    public AudioClip[] sounds = new AudioClip[2];

    AudioSource fireSound;



    void Start()
    {
        // 1. AudioSource 컴포넌트를 가져온다.(캐싱)
        fireSound = gameObject.GetComponent<AudioSource>();

        // 볼륨을 0.1로 변경한다.
        if (fireSound != null)
        {
            fireSound.volume = 0.1f;
        }
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

            for (int i = 0; i < firePosition.Length; i++)
            {
                // 4. 총알 프리팹(파일)을 씬에 생성(메모리)한다.
                GameObject bulletInstance = Instantiate(bulletPrefab);

                // 5. 생성된 총알 인스턴스의 위치를 앞서 설정한 위치로 변경한다.(총알을 총구 위치에 가져다 놓는다.)
                //bulletInstance.transform.position = firePosition;
                bulletInstance.transform.position = firePosition[i].transform.position;

                // 5-1. 생성된 총알의 방향이 총구의 방향대로 회전한다.
                bulletInstance.transform.rotation = firePosition[i].transform.rotation;
            }
            // 총알을 발사할 때마다 격발 사운드가 출력되게 하고 싶다.

            // 2. AudioSource의 사운드 클립을 플레이한다.
            if(fireSound != null)
            {
                fireSound.Play();
                //fireSound.Stop();
                //fireSound.Pause();
            }
        }

        // 키보드의 숫자 키 1번을 누르면 격발 사운드가 sound1 클립으로 출력되게 하고,
        // 1. 사용자의 입력(숫자키 1)을 받는다.
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            fireSound.clip = sounds[0];
        }
        // 키보드의 숫자 키 2번을 누르면 격발 사운드가 sound2 클립으로 출력되게 한다.
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            fireSound.clip = sounds[1];
        }
    }
}
