using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichoMovement : MonoBehaviour
{
    private bool up = true;
    private int speed = 30;
    
    
    private GameObject leftArm;
    private GameObject rightArm;
    // Start is called before the first frame update
    void Start()
    {
        leftArm = GameObject.Find("Left arm");
        rightArm = GameObject.Find("Right arm");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime);
            if (up)
            {
                leftArm.transform.Rotate(0,0,1 * Time.deltaTime * speed);
                rightArm.transform.Rotate(0,0,-1 * Time.deltaTime * speed);
                if (leftArm.transform.rotation.z * Mathf.Rad2Deg >= 30)
                {
                    up = false;
                }
            }
            else
            {
                leftArm.transform.Rotate(0, 0, -1 * Time.deltaTime * speed);
                rightArm.transform.Rotate(0,0,1 * Time.deltaTime * speed);
                if (leftArm.transform.rotation.z * Mathf.Rad2Deg <= -25)
                {
                    up = true;
                }
            }
        }
        
        
    }
}
