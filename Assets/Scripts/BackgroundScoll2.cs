using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScoll2 : MonoBehaviour
{
    // �������ڸ��� Material�� �ִ� Shader ������ ���� (0, 0.2f)�� �����ϰ� �ʹ�.
    public Vector2 scrollSpeed;
    public Texture bgTex;


    void Start()
    {
        // Material �Ӽ��� �����´�.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        Material mat = mr.material;
        
        // scroll offset ������ ���� �����Ѵ�.
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
