using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // ���� ��� �̹����� �Ʒ������� ��� ��ũ�ѵǵ��� �ϰ� �ʹ�.
    public float scrollSpeed = 0.2f;

    Material mat;

    void Start()
    {
        // 1. �� ���� ������Ʈ�� MeshRenderer ������Ʈ�� �����´�.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();

        // 2. ������ ��� MeshRenderer�� Material �ν��Ͻ��� �����´�.
        mat = mr.materials[0];
        
    }

    void Update()
    {
        // 3. Material�� offset ����(Vector2)�� y���� ��� ������Ų��.
        // p = p0 + vt
        mat.mainTextureOffset += new Vector2(0, 1) * scrollSpeed * Time.deltaTime;

    }
}
