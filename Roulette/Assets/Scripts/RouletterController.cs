using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletterController : MonoBehaviour
{
    private float rotationSpeed = 0;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        // Ŭ���� ����
        ////1. ȭ���� ������ ��� ��������?
        //bool isDown = Input.GetMouseButtonDown(0);
        //if (isDown)
        //{
        //    Debug.Log("�������ϴ�");
        //    rotationSpeed = 10;

        //}

        ////2. ȸ���� ���? 
        // this.transform.Rotate(0, 0, rotationSpeed);

        ////3. �ӵ� ���̰�
        //rotationSpeed *= 0.96f;
        //Debug.Log(rotationSpeed);

        // ����Ŭ���� ���� 
        //1. ȭ���� ������ ��� ��������?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);

        if (isLeftDown)
        {
            Debug.Log("���� �������ϴ�");
            rotationSpeed = 20;

        }
        else if (isRightDown)
        {
            Debug.Log("���� �������ϴ�");
            rotationSpeed = -20;
        }

            //2. ȸ���� ���? 
            this.transform.Rotate(0, 0, rotationSpeed);

        //3. �ӵ� ���̰�
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);

    }
}
