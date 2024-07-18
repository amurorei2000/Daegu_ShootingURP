using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
    // ����(��), ũ��(�̵� �ӷ�)
    public float moveSpeed = 10;
    public GameObject explosionPrefab;

    void Start()
    {
        
    }
    
    void Update()
    {
        // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
        //Vector3 dir = Vector3.up;

        // �Ѿ��� �̵� ������ ���� ���� �������� �̵��ϰ� �����Ѵ�.
        //Vector3 dir = new Vector3(0, 1, 0);
        Vector3 dir = transform.up;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // ����, �浹�� �߻��Ѵٸ�...
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // ���� ������Ʈ�� �����Ѵ�.
    //    Destroy(collision.gameObject);

    //    // ���� �����Ѵ�.
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        // ����, �浹�� ����� ���� ������Ʈ�� �̸��� "Enemy"��� ���ڿ��� �����ϰ� �ִٸ�...
        if (other.gameObject.name.Contains("Enemy"))
        {
            // ���� ����Ʈ ������Ʈ�� �����Ѵ�.
            GameObject go = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);
            
            if(go != null)
            {
                // ���� ����Ʈ ������Ʈ�� ParticleSystem ������Ʈ�� �����´�.
                ParticleSystem explosionFX = go.GetComponent<ParticleSystem>();

                // ParticleSystem�� �÷����Ѵ�.
                explosionFX.Play();
            }

            // ���� ������Ʈ�� �����Ѵ�.
            Destroy(other.gameObject);
        }
        // ���� �����Ѵ�.
        Destroy(gameObject);
    }
}
