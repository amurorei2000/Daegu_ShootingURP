using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
    // ����(��), ũ��(�̵� �ӷ�)
    public float moveSpeed = 10;


    void Start()
    {
        
    }
    
    void Update()
    {
        // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
        //Vector3 dir = Vector3.up;
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}