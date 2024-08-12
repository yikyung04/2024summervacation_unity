using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void GameQuit() //������ �����ϴ� �Լ�
    {
        Application.Quit(); //������ ���� �ؾ����� ������ �˴ϴ�.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(1); //1��
    }

    public void Game()
    {
        SceneManager.LoadScene(0);
    }
}
