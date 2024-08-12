using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ּ�
    // �ʽ��ڰ� �Ǽ��ϱ� �ÿ� ���� ���� �༮ ù��°, ��ҹ��� ��Ż��
    public CharacterController characterController; //�ʷϻ� �̸� : Ÿ��, ��� : ����
    //������Ʈ - �ڽ����·�
    public float speed = 10f; //�ʱ�ӵ��� 10���� �����մϴ�
    public float itemAddSpeed = 5f;
    public Camera cam; //�÷��̾ �ڽ����� ������ �ִ� ī�޶� ����Ѵ�.
    public float jumpPower = 7.5f; //�÷��̾ �����ϴ� ũ��
    public float gravityModifier = 2; //���ڰ� ũ�� Ŭ���� �÷��̾ �޴� �߷��� ũ�Ⱑ Ŀ����.
    public float groundcheck; //���� �˻��ϴ� ���� ����
    public bool isGround = true; //���� �÷��̾ ���� ��� ������ true, �ƴϸ� false
    public LayerMask groundLayer; //���� �ش��ϴ� Layer�� �����ϴ� ����

    
    private void Start() //�����ϰ� �� ���� ����ȴ�.
    {
        cam = GetComponentInChildren<Camera>(true);
    }

    private void Update() //�������� ��� ��ȭ�ϴ� ���̱� ������ Update �ۼ��ؾ߰ڴ�.
    {
        // PlayerMove(); �ּ�ó���� �����Ƿ�
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
        //�÷��̾��� �Է��� �ް� �ʹ�.
        float horizontalInput = Input.GetAxis("Horizontal");  // Ű���� a,d ȭ��ǥ <-, -> �����ؼ� ���� ��ȯ
        float verticalInput = Input.GetAxis("Vertical");  // Ű���� w, s ȭ��ǥ ���Ʒ� �����ؼ� ���� ��ȯ

        //Debug.Log($"horizontalInput : {horizontalInput}, verticalInput : {verticalInput}"); //����� �α� �� ����� �ż� ����

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput); // Vecter3(-1, 0 ,0) ���̸� ��ȯ�ϴ� ����

        Vector3 moveDirection = cam.transform.forward * moveVector.z + cam.transform.right * moveVector.x; //ī�޶� �ٶ󺸰� �ִ� �������� �Է� ���� ��ȯ��

        if(isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //�����̽��ٸ� ������ �� �� ���� �۵�
            {
                moveDirection.y = jumpPower;
            }
        }

        moveDirection +=  Physics.gravity * gravityModifier * Time.deltaTime;

        // Time.deltaTime������ ���������� ó���Ǿ� �ֱ� ������ �߰������൵ �ȴ�.
        characterController.Move(moveDirection * speed * Time.deltaTime); // ����� �ӵ� speed Vector
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundcheck);
    }

    // Update is called once per frame
    private void PlayerCameraMove()
    {
        //�÷��̾��� �Է�. Movse �Է��� �޾ƾ߰���
        float MouseX = Input.GetAxis("Mouse X");

        Debug.Log($"MouseX {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");

        //transform ����, Y���� MouseX����ŭ �������ָ� �ȴ�.

        transform.rotation = Quaternion.Euler(MouseX, MouseY, 0);
    }
}
