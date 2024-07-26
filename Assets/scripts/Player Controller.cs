using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //주석
    public CharacterController characterController; //초록색 이름 : 타입, 흰색 : 변수
    //컴포넌트 - 박스형태로
    public float speed = 10f; //초기속도를 10으로 설정합니다.


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    private void Update()
    {
        characterController.SimpleMove(Vector3.left * speed);
    }
}
