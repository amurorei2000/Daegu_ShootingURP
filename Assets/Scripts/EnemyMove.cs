using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // ������ Ȯ���� ���� �̵� ����� �ٸ��� �ϵ��� �ϰ� �ʹ�.
    // �ʿ� ���: ���� ����, Ȯ�� ����
    //public int traceRate = 30;
    public float traceRate = 0.3f;

    // 1. ����ؼ� �Ʒ��� �������� �ϰ� �ʹ�.
    // �ӷ�, ����
    public float moveSpeed = 6;

    // 2. �÷��̾ �ִ� �������� �̵��ϰ� �ϰ� �ʹ�.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // ���� �ִ� ���� ������Ʈ �߿� "Player"��� �̸��� ������Ʈ�� ã�´�.
        // ã�� ������Ʈ�� �ִٸ�, �� ������Ʈ�� target ������ �ִ´�.
        target = GameObject.Find("Player");

        // ����, Ÿ�� ������ ���� null�̶��
        if (target == null)
        {
            // dir ������ ������ �Ʒ��� �����Ѵ�.
            dir = Vector3.down;

            // start�Լ��� ������.
            return;
        }

        // 1. 1 ~ 100 ���� �ȿ��� �����ϰ� ���� �ϳ��� ��÷�Ѵ�.
        // ������ ����(Deprecate) : �� ����� ���
        //int number = Random.Range(1, 101);
        float number = Random.Range(0.0f, 1.0f);

        // 2. ����, ��÷�� ���ڰ� Ȯ�� ���� �� ���϶��...
        if (number <= traceRate)
        {
            // 2-1. �÷��̾ �ִ� �������� dir ������ �����Ѵ�.
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 3. �׷��� �ʴٸ�...
        else
        {
            // 3-1. dir ������ ���� �Ʒ� �������� �����Ѵ�.
            dir = new Vector3(0, -1, 0);
        }


    }

    void Update()
    {
        //transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        // ���� ����(dir)���� �̵��Ѵ�.
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("DestroyZone"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
