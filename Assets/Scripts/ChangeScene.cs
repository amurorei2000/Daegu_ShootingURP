using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    // Ư�� ��(��ȣ)���� �̵��ϰ� �ϴ� �Լ�
    public int sceneNum = 1;
    public void Change()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
