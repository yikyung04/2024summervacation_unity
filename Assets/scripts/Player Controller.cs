using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //주석
    // 초심자가 실수하기 시운 가장 많은 녀석 첫번째, 대소문자 오탈자
    public CharacterController characterController; //초록색 이름 : 타입, 흰색 : 변수
    //컴포넌트 - 박스형태로
    public float speed = 10f; //초기속도를 10으로 설정합니다
    
    private void Start() //시작하고 한 번만 실행된다.
    {

    }

    private void Update() //움직임은 계쏙 변화하는 것이기 때문에 Update 작성해야겠다.
    {
        // PlayerMove(); 주석처리가 됐으므로
        PlayerMove();
        PlayerCameraMove();
    }


    // Start is called before the first frame update
    private void PlayerMove()
    {
        //플레이어의 입력을 받고 싶다.
        float hoizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log($"horizontalInput : {horizontalInput}, verticalInput : {verticalInut}");

        Vecter3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime연산이 내부적으로 처리되어 있기 때문에 추가안해줘도 된다.
        CharacterController.SimpleMove(moveVector * speed); // 방향과 속도 speed Vector
    }
    
    // Update is called once per frame
    private void UPlayerCameraMove()
    {
        //플레이어의 입력. Movse 입력을 받아야겠죠
        float MouseX = Input.GetAxis("Mouse X");

        Debug.Log($"MouseX {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");

        //transform 각도, Y축을 MouseX값만큼 변경해주면 된다.

        transform.rotation = Ouaternion.Euler(MouseX, MouseY, 0);
    }
}
