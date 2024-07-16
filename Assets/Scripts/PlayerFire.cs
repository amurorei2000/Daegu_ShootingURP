using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ���콺�� ���� ��ư�� ������ �Ѿ��� �߻�(����)�ǰ� �ϰ� �ʹ�.
    // 1. �Ѿ��� �������� �ȴ�.
    public GameObject bulletPrefab;
    public GameObject firePosition;

    void Start()
    {
        
    }

    void Update()
    {
        // 2. ���콺 ���� ��ư�� �Է�(���콺 ���� ��ư�� ���� ���� 1ȸ)�� �޴´�.
        bool mouseInput = Input.GetButtonDown("Fire1");

        if(mouseInput)
        {
            //print("���콺 ���� ��ư Ŭ��!");

            // 3. �Ѿ��� ���� ��ġ�� �����Ѵ�.
            //Vector3 firePosition = transform.position + new Vector3(0, 1, 0);

            // 4. �Ѿ� ������(����)�� ���� ����(�޸�)�Ѵ�.
            GameObject bulletInstance = Instantiate(bulletPrefab);

            // 5. ������ �Ѿ� �ν��Ͻ��� ��ġ�� �ռ� ������ ��ġ�� �����Ѵ�.(�Ѿ��� �ѱ� ��ġ�� ������ ���´�.)
            //bulletInstance.transform.position = firePosition;
            bulletInstance.transform.position = firePosition.transform.position;

        }

    }
}
