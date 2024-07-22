using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class GameManager : MonoBehaviour
{

    // 싱글턴 패턴으로 구현(Singletone)
    public static GameManager gm;
    //public GameObject scoreObject;
    public Text scoreText;  // Legacy 방식의 텍스트 컴포넌트
    public TMP_Text scoreTextTmp;   // Text mesh pro 방식의 텍스트 컴포넌트
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
        // 현재 점수 텍스트 컴포넌트를 캐싱하기
        //scoreText = scoreObject.GetComponent<Text>();

        // 현재 점수 텍스트의 값을 "0"으로 초기화한다.
        //scoreText.text = "0";
        scoreTextTmp.text = "0";

        // 만일, "BestScore" 키로 저장된 데이터가 있다면...
        if (PlayerPrefs.HasKey("BestScore"))
        {
            // 최고 점수 텍스트에 저장된 최고 점수를 읽어와서 표시한다.
            bestScore = PlayerPrefs.GetInt("BestScore");
            bestScoreText.text = bestScore.ToString();
        }
    }

    void Update()
    {
        
    }

    // 포인트를 받아서 현재 점수 변수의 값을 증감하는 함수
    public void AddScore(int point)
    {
        currentScore += point;
        //print(currentScore);
        // 현재 점수(숫자)를 문자열로 변경해서 UI의 scoreText에다가 전달한다.
        //scoreText.text = currentScore.ToString();
        scoreTextTmp.text = currentScore.ToString();

        // 만일, 추가된 현재 점수가 기록중인 최고 점수보다 더 높다면
        if (currentScore > bestScore)
        {
            // 최고 점수를 현재 점수로 갱신한다.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }

    public int GetBestScore()
    {
        return bestScore;
    }

    // 게임 오버 UI를 활성화 또는 비활성화를 해주는 함수
    public void ShowGameOverUI(bool activation)
    {
        // 패널 오브젝트를 활성화한다.
        gameOverUI.SetActive(activation);

        // 앱의 시간 흐름을 0배율로 변경한다.
        Time.timeScale = 0;
    }

    // 게임 재시작 함수
    public void Restart()
    {
        //print("재시작 버튼이 클릭되었습니다!");

        // 현재 씬을 다시 시작(Load)한다.
        SceneManager.LoadScene(1);

        // 앱의 시간 흐름을 1배율로 변경한다.
        Time.timeScale = 1;
    }

    // 앱 종료 함수
    public void AppQuit()
    {
#if UNITY_EDITOR
        // 유니티 에디터의 플레이 모드를 종료한다.
        //EditorApplication.ExitPlaymode();

#elif UNITY_STANDALONE
        // 어플리케이션을 종료한다(유니티 에디터에서 플레이 중일 때에는 사용이 불가능)
        Application.Quit();
#endif
    }
}
