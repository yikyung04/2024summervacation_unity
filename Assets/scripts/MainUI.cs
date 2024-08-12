using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void GameQuit() //게임을 종료하는 함수
    {
        Application.Quit(); //게임을 빌드 해야지만 적용이 됩니다.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(1); //1번
    }

    public void Game()
    {
        SceneManager.LoadScene(0);
    }
}
