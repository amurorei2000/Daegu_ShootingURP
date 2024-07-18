using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScoll2 : MonoBehaviour
{
    // 시작하자마자 Material에 있는 Shader 변수의 값을 (0, 0.2f)로 변경하고 싶다.
    public Vector2 scrollSpeed;
    public Texture bgTex;


    void Start()
    {
        // Material 속성을 가져온다.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        Material mat = mr.material;
        
        // scroll offset 변수의 값을 변경한다.
        if(mat != null)
        {
            mat.SetVector("_ScrollOffset", scrollSpeed);
            mat.SetTexture("_MainTexture", bgTex);
        }
    }

    void Update()
    {
        
    }
}
