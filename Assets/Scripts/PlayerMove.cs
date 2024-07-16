using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // ������� �Է��� �޾Ƽ� �� �Է¹��� �������� �̵��ϰ� �ϰ� �ʹ�.
    // 1. ������� �Է�(Input)�� �޴´�. -> ���� �¿� �Է��� �޴´�.
    // 2. �Է¹��� ����� �ӷ��� �����Ѵ�.(�ӵ�)
    // 3. �� �ӵ��� �̵��ϰ� �ϰ� �ʹ�. -> p = p0 + vt


    public float speed = 10.0f;
    public bool isUpDown = false;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt
        //transform.position += Vector3.left * speed * Time.deltaTime;
        //print(Time.deltaTime);

        if (isUpDown)
        {
            MoveType1();
        }
        else
        {
            MoveType2();
        }
    }

    void MoveType1()
    {
        // ������� �����¿� �Է� ���� ����ϱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //print(h);

        // �¿� �Է� ���� ���ͷ� �����
        Vector3 direction = new Vector3(h, v, 0);
        //Vector3 direction = new Vector3(h, 0, 0) + new Vector3(0, v, 0);

        // direction ������ ���̸� 1�� ����ȭ�ϱ�
        direction.Normalize();

        // p = p0 + vt ������ �̿��ؼ� �÷��̾��� ��ġ�� �̵���Ű��
        transform.position += direction * speed * Time.deltaTime;
        //transform.localScale += direction * speed * Time.deltaTime;
        //transform.eulerAngles += direction * speed * Time.deltaTime;
    }

    void MoveType2()
    {
        // ������� �����¿� �Է� ���� ����ϱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //print(h);

        // �¿� �Է� ���� ���ͷ� �����
        Vector3 direction = new Vector3(h, 0, v);
        //Vector3 direction = new Vector3(h, 0, 0) + new Vector3(0, v, 0);

        // direction ������ ���̸� 1�� ����ȭ�ϱ�
        direction.Normalize();

        // p = p0 + vt ������ �̿��ؼ� �÷��̾��� ��ġ�� �̵���Ű��
        transform.position += direction * speed * Time.deltaTime;
    }



    // �޸𸮿��� �����Ǳ� ������ 1ȸ ȣ��Ǵ� �Լ�(call back function)
    private void OnDestroy()
    {
        
    }
}
