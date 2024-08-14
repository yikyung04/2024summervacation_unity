using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    [Header("Manager")]
    public static MainUI Instance; // 현재 코드 부터
    public GameObject gameOverPanel;
    public Camera gameOverCamera; //게임 종료시 활성화 되는 카메라
    [Header("Clear")]
    public GameObject gameClearPanel; //게임 클리어 시 활성화 되는 UI
    public Camera gameClearCamera; //게임 클리어 시 활성화 되는 카메라

    private void Start()
    {
        gameOverPanel.SetActive(false);
        gameOverCamera.gameObject.SetActive(false);
        gameClearPanel.SetActive(false);
        gameClearCamera.gameObject.SetActive(false);
    }

    private void Awake() //Start 보다 먼저 한 번 시작되는 함수
                        //Start는 시작할 때 한 번
    {
        if (Instance == null)
            Instance = this;
    }                               //여기 코드 까지 싱그톤 패턴

    public void GameQuit() //게임을 종료하는 함수
    {
        Application.Quit(); //게임을 빌드 해야지만 적용이 됩니다.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(1); //1번에 등록된 scene
    }

    public void NextLevel(int select) //선택한 레벨로 이동하기
    {
        SceneManager.LoadScene(select);
    }

    public void ReturnMainLobby()
    {
        SceneManager.LoadScene(0);
    }
}
