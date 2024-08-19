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
        // 클릭시 감지
        ////1. 화면을 누르면 어떻게 감지하지?
        //bool isDown = Input.GetMouseButtonDown(0);
        //if (isDown)
        //{
        //    Debug.Log("눌렀습니다");
        //    rotationSpeed = 10;

        //}

        ////2. 회전을 어떻게? 
        // this.transform.Rotate(0, 0, rotationSpeed);

        ////3. 속도 줄이고
        //rotationSpeed *= 0.96f;
        //Debug.Log(rotationSpeed);

        // 왼쪽클릭시 감지 
        //1. 화면을 누르면 어떻게 감지하지?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);

        if (isLeftDown)
        {
            Debug.Log("왼쪽 눌렀습니다");
            rotationSpeed = 20;

        }
        else if (isRightDown)
        {
            Debug.Log("왼쪽 눌렀습니다");
            rotationSpeed = -20;
        }

            //2. 회전을 어떻게? 
            this.transform.Rotate(0, 0, rotationSpeed);

        //3. 속도 줄이고
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);

    }
}
