using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    // 특정 씬(번호)으로 이동하게 하는 함수
    public int sceneNum = 1;
    public void Change()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
