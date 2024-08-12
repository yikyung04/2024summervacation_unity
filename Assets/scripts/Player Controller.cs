using JetBrains.Annotations;
using System;
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
    public float itemAddSpeed = 5f;
    public Camera cam; //플레이어에 자식으로 가지고 있는 카메라를 사용한다.
    public float jumpPower = 7.5f; //플레이어가 점프하는 크기
    public float gravityModifier = 2; //숫자가 크면 클수록 플레이어가 받는 중력의 크기가 커진다.
    public float groundcheck; //땅을 검색하는 선의 길이
    public bool isGround = true; //현재 플레이어가 땅을 밟고 있으면 true, 아니면 false
    public LayerMask groundLayer; //땅에 해당하는 Layer를 선택하는 변수

    
    private void Start() //시작하고 한 번만 실행된다.
    {
        cam = GetComponentInChildren<Camera>(true);
    }

    private void Update() //움직임은 계쏙 변화하는 것이기 때문에 Update 작성해야겠다.
    {
        // PlayerMove(); 주석처리가 됐으므로
        PlayerMove();
        Groundcheck();
        //PlayerCameraMove();
    }

    private void Groundcheck()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, groundcheck, groundLayer);
    }


    // Start is called before the first frame update
    private void PlayerMove()
    {
        //플레이어의 입력을 받고 싶다.
        float horizontalInput = Input.GetAxis("Horizontal");  // 키보드 a,d 화살표 <-, -> 대응해서 값을 반환
        float verticalInput = Input.GetAxis("Vertical");  // 키보드 w, s 화살표 위아래 대응해서 값을 반환

        //Debug.Log($"horizontalInput : {horizontalInput}, verticalInput : {verticalInput}"); //디버그 로그 안 띄워도 돼서 지움

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput); // Vecter3(-1, 0 ,0) 사이를 반환하는 벡터

        Vector3 moveDirection = cam.transform.forward * moveVector.z + cam.transform.right * moveVector.x; //카메라가 바라보고 있는 방향으로 입력 값을 변환함

        if(isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //스페이스바를 눌렀을 때 한 번만 작동
            {
                moveDirection.y = jumpPower;
            }
        }

        moveDirection +=  Physics.gravity * gravityModifier * Time.deltaTime;

        // Time.deltaTime연산이 내부적으로 처리되어 있기 때문에 추가안해줘도 된다.
        characterController.Move(moveDirection * speed * Time.deltaTime); // 방향과 속도 speed Vector
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundcheck);
    }

    // Update is called once per frame
    private void PlayerCameraMove()
    {
        //플레이어의 입력. Movse 입력을 받아야겠죠
        float MouseX = Input.GetAxis("Mouse X");

        Debug.Log($"MouseX {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");

        //transform 각도, Y축을 MouseX값만큼 변경해주면 된다.

        transform.rotation = Quaternion.Euler(MouseX, MouseY, 0);
    }
}
