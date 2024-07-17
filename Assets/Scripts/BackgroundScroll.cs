using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // 나는 배경 이미지가 아래쪽으로 계속 스크롤되도록 하고 싶다.
    public float scrollSpeed = 0.2f;

    Material mat;

    void Start()
    {
        // 1. 내 게임 오브젝트의 MeshRenderer 컴포넌트를 가져온다.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();

        // 2. 변수에 담긴 MeshRenderer의 Material 인스턴스를 가져온다.
        mat = mr.materials[0];
        
    }

    void Update()
    {
        // 3. Material의 offset 변수(Vector2)의 y값을 계속 증가시킨다.
        // p = p0 + vt
        mat.mainTextureOffset += new Vector2(0, 1) * scrollSpeed * Time.deltaTime;

    }
}
