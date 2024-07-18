using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ���콺�� ���� ��ư�� ������ �Ѿ��� �߻�(����)�ǰ� �ϰ� �ʹ�.
    // 1. �Ѿ��� �������� �ȴ�.
    public GameObject bulletPrefab;
    public GameObject[] firePosition = new GameObject[3];
    public AudioClip[] sounds = new AudioClip[2];

    AudioSource fireSound;



    void Start()
    {
        // 1. AudioSource ������Ʈ�� �����´�.(ĳ��)
        fireSound = gameObject.GetComponent<AudioSource>();

        // ������ 0.1�� �����Ѵ�.
        if (fireSound != null)
        {
            fireSound.volume = 0.1f;
        }
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

            for (int i = 0; i < firePosition.Length; i++)
            {
                // 4. �Ѿ� ������(����)�� ���� ����(�޸�)�Ѵ�.
                GameObject bulletInstance = Instantiate(bulletPrefab);

                // 5. ������ �Ѿ� �ν��Ͻ��� ��ġ�� �ռ� ������ ��ġ�� �����Ѵ�.(�Ѿ��� �ѱ� ��ġ�� ������ ���´�.)
                //bulletInstance.transform.position = firePosition;
                bulletInstance.transform.position = firePosition[i].transform.position;

                // 5-1. ������ �Ѿ��� ������ �ѱ��� ������ ȸ���Ѵ�.
                bulletInstance.transform.rotation = firePosition[i].transform.rotation;
            }
            // �Ѿ��� �߻��� ������ �ݹ� ���尡 ��µǰ� �ϰ� �ʹ�.

            // 2. AudioSource�� ���� Ŭ���� �÷����Ѵ�.
            if(fireSound != null)
            {
                fireSound.Play();
                //fireSound.Stop();
                //fireSound.Pause();
            }
        }

        // Ű������ ���� Ű 1���� ������ �ݹ� ���尡 sound1 Ŭ������ ��µǰ� �ϰ�,
        // 1. ������� �Է�(����Ű 1)�� �޴´�.
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            fireSound.clip = sounds[0];
        }
        // Ű������ ���� Ű 2���� ������ �ݹ� ���尡 sound2 Ŭ������ ��µǰ� �Ѵ�.
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            fireSound.clip = sounds[1];
        }
    }
}
