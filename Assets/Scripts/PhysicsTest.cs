using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // ������ �浹�� �Ͼ�� �� 1ȸ ����Ǵ� �ݹ�(�̺�Ʈ) �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
        print("�浹 ����!");
    }


    // ������ �浹�� �߻����� ���� ����Ǵ� �ݹ� �Լ�
    private void OnCollisionStay(Collision collision)
    {
        print("�浹 ��!!");
    }

    // ������ �浹�� ����� �� 1ȸ ����Ǵ� �ݹ� �Լ�
    private void OnCollisionExit(Collision collision)
    {
        print("�浹 ����!");
    }

    // �浹 ������ �Ͼ�� �� 1ȸ ����Ǵ� �ݹ�(�̺�Ʈ) �Լ�
    private void OnTriggerEnter(Collider other)
    {
        print("������ ���Դ�!");
    }

    // �浹 ������ �߻����� ���� ����Ǵ� �ݹ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        print("���� ���� ���� �ִ�!");
    }

    // �浹 ������ ����� �� 1ȸ ����Ǵ� �ݹ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        print("�������� ���� ���Դ�!");
    }

}
