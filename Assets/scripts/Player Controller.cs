using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ּ�
    public CharacterController characterController; //�ʷϻ� �̸� : Ÿ��, ��� : ����
    //������Ʈ - �ڽ����·�
    public float speed = 10f; //�ʱ�ӵ��� 10���� �����մϴ�.


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
