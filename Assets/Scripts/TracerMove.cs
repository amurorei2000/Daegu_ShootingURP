using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerMove : MonoBehaviour
{
    // ���� ����ؼ� �÷��̾ �Ѿư��ڴ�.
    // �ʿ� ���: �÷��̾ ���� ����, �̵� �ӷ�
    // ���� ����� �ӷ´�� �̵��Ѵ�.(p = p0 + vt)

    public GameObject target;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // ���� �÷��̾ �ٶ󺸴� ���� ���͸� ���Ѵ�.
        Vector3 dir = target.transform.position - transform.position;

        // ���� ���͸� ����ȭ�Ѵ�.
        dir.Normalize();

        // �� ����� �ӷ´�� �̵��Ѵ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
