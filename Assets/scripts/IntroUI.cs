using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUI : MonoBehaviour
{
    // �Լ� ù��° ���� �����ڸ� ����
    // private vs public
    // private : �ٸ� ������ ������ ���ϰ� �ϴ� ��
    // public : ������, �ٸ� ������ ������ �����ϰ� ���ִ� ��

    // ��ȯ Ÿ�� : ��ȯ�� �ϴ� �� ���ϴ� ��
    // void : ��ȯ Ÿ���� ���� ��
    // int double... : �ش� Ÿ������ ��ȯ�϶�

    // �Լ��� �̸�

    public void GameStart()
    {
        SceneManager.LoadScene(1); //1���� ��ϵ� Scene�� �ҷ��Ͷ�.
    }

    public void GameQuit()
    {
        Application.Quit(); // ������ ���� �ؾ����� ������ �˴ϴ�.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // �����Ϳ��� ���� ��ư�� ��Ȱ�� ��Ű����.
#endif
    }

}
