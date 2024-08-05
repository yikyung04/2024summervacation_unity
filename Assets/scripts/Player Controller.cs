using JetBrains.Annotations;
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
    
    private void Start() //�����ϰ� �� ���� ����ȴ�.
    {

    }

    private void Update() //�������� ��� ��ȭ�ϴ� ���̱� ������ Update �ۼ��ؾ߰ڴ�.
    {
        // PlayerMove(); �ּ�ó���� �����Ƿ�
        PlayerMove();
        PlayerCameraMove();
    }


    // Start is called before the first frame update
    private void PlayerMove()
    {
        //�÷��̾��� �Է��� �ް� �ʹ�.
        float hoizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log($"horizontalInput : {horizontalInput}, verticalInput : {verticalInut}");

        Vecter3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime������ ���������� ó���Ǿ� �ֱ� ������ �߰������൵ �ȴ�.
        CharacterController.SimpleMove(moveVector * speed); // ����� �ӵ� speed Vector
    }
    
    // Update is called once per frame
    private void UPlayerCameraMove()
    {
        //�÷��̾��� �Է�. Movse �Է��� �޾ƾ߰���
        float MouseX = Input.GetAxis("Mouse X");

        Debug.Log($"MouseX {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");

        //transform ����, Y���� MouseX����ŭ �������ָ� �ȴ�.

        transform.rotation = Ouaternion.Euler(MouseX, MouseY, 0);
    }
}
