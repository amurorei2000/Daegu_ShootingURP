using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class GameManager : MonoBehaviour
{

    // �̱��� �������� ����(Singletone)
    public static GameManager gm;
    //public GameObject scoreObject;
    public Text scoreText;  // Legacy ����� �ؽ�Ʈ ������Ʈ
    public TMP_Text scoreTextTmp;   // Text mesh pro ����� �ؽ�Ʈ ������Ʈ
    public Text bestScoreText;
    public GameObject gameOverUI;

    int currentScore = 0;
    int bestScore = 0;

    void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

    void Start()
    {
        // ���� ���� �ؽ�Ʈ ������Ʈ�� ĳ���ϱ�
        //scoreText = scoreObject.GetComponent<Text>();

        // ���� ���� �ؽ�Ʈ�� ���� "0"���� �ʱ�ȭ�Ѵ�.
        //scoreText.text = "0";
        scoreTextTmp.text = "0";

        // ����, "BestScore" Ű�� ����� �����Ͱ� �ִٸ�...
        if (PlayerPrefs.HasKey("BestScore"))
        {
            // �ְ� ���� �ؽ�Ʈ�� ����� �ְ� ������ �о�ͼ� ǥ���Ѵ�.
            bestScore = PlayerPrefs.GetInt("BestScore");
            bestScoreText.text = bestScore.ToString();
        }
    }

    void Update()
    {
        
    }

    // ����Ʈ�� �޾Ƽ� ���� ���� ������ ���� �����ϴ� �Լ�
    public void AddScore(int point)
    {
        currentScore += point;
        //print(currentScore);
        // ���� ����(����)�� ���ڿ��� �����ؼ� UI�� scoreText���ٰ� �����Ѵ�.
        //scoreText.text = currentScore.ToString();
        scoreTextTmp.text = currentScore.ToString();

        // ����, �߰��� ���� ������ ������� �ְ� �������� �� ���ٸ�
        if (currentScore > bestScore)
        {
            // �ְ� ������ ���� ������ �����Ѵ�.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }

    public int GetBestScore()
    {
        return bestScore;
    }

    // ���� ���� UI�� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ�� ���ִ� �Լ�
    public void ShowGameOverUI(bool activation)
    {
        // �г� ������Ʈ�� Ȱ��ȭ�Ѵ�.
        gameOverUI.SetActive(activation);

        // ���� �ð� �帧�� 0������ �����Ѵ�.
        Time.timeScale = 0;
    }

    // ���� ����� �Լ�
    public void Restart()
    {
        //print("����� ��ư�� Ŭ���Ǿ����ϴ�!");

        // ���� ���� �ٽ� ����(Load)�Ѵ�.
        SceneManager.LoadScene(1);

        // ���� �ð� �帧�� 1������ �����Ѵ�.
        Time.timeScale = 1;
    }

    // �� ���� �Լ�
    public void AppQuit()
    {
#if UNITY_EDITOR
        // ����Ƽ �������� �÷��� ��带 �����Ѵ�.
        //EditorApplication.ExitPlaymode();

#elif UNITY_STANDALONE
        // ���ø����̼��� �����Ѵ�(����Ƽ �����Ϳ��� �÷��� ���� ������ ����� �Ұ���)
        Application.Quit();
#endif
    }
}
