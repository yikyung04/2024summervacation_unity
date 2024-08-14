using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    [Header("Manager")]
    public static MainUI Instance; // ���� �ڵ� ����
    public GameObject gameOverPanel;
    public Camera gameOverCamera; //���� ����� Ȱ��ȭ �Ǵ� ī�޶�
    [Header("Clear")]
    public GameObject gameClearPanel; //���� Ŭ���� �� Ȱ��ȭ �Ǵ� UI
    public Camera gameClearCamera; //���� Ŭ���� �� Ȱ��ȭ �Ǵ� ī�޶�

    private void Start()
    {
        gameOverPanel.SetActive(false);
        gameOverCamera.gameObject.SetActive(false);
        gameClearPanel.SetActive(false);
        gameClearCamera.gameObject.SetActive(false);
    }

    private void Awake() //Start ���� ���� �� �� ���۵Ǵ� �Լ�
                        //Start�� ������ �� �� ��
    {
        if (Instance == null)
            Instance = this;
    }                               //���� �ڵ� ���� �̱��� ����

    public void GameQuit() //������ �����ϴ� �Լ�
    {
        Application.Quit(); //������ ���� �ؾ����� ������ �˴ϴ�.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(1); //1���� ��ϵ� scene
    }

    public void NextLevel(int select) //������ ������ �̵��ϱ�
    {
        SceneManager.LoadScene(select);
    }

    public void ReturnMainLobby()
    {
        SceneManager.LoadScene(0);
    }
}
