using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//This will be used to move the vehicle
public class Movement : MonoBehaviour {
    public int m_speed, m_reverseSpeed, m_turningSpeed;
    public KeyCode ForwardKey;
    public KeyCode BackwardsKey;
    public KeyCode SteerLeftKey;
    public KeyCode SteerRightKey;
    Rigidbody r;
	// Use this for initialization
	void Start () {
        //if there is no Rigidbody attached to the vehicle
        if (this.GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
        }

        r = gameObject.GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {

        inputUpdate();

	}




    #region inputChecks
    void inputUpdate()
    {
        inputSteering();
        inputPower();
    }

    //checks the car's steering
    void inputSteering()
    {
        if (Input.GetKey(SteerLeftKey) && Input.GetKey(ForwardKey))
        {
            r.AddRelativeTorque(new Vector3(0, -m_turningSpeed, 0));
        }
        else if(Input.GetKey(SteerRightKey) && Input.GetKey(ForwardKey))
        {
            r.AddRelativeTorque(new Vector3(0, m_turningSpeed, 0));
        }
        else if (Input.GetKey(SteerLeftKey) && Input.GetKey(BackwardsKey))
        {
            r.AddRelativeTorque(new Vector3(0, m_turningSpeed, 0));
        }
        else if (Input.GetKey(SteerRightKey) && Input.GetKey(BackwardsKey))
        {
            r.AddRelativeTorque(new Vector3(0, -m_turningSpeed, 0));
        }




    }

    //checks the cars throttle / power input
    void inputPower()
    {
        if (Input.GetKey(ForwardKey))
        {
            r.AddRelativeForce(new Vector3(0, 0, 1f * m_speed));
        }
        else if (Input.GetKey(BackwardsKey))
        {
            r.AddRelativeForce(new Vector3(0, 0, -1f * m_reverseSpeed));
        }
    }
    #endregion


    #region MovementStuffs
    void moveLeft()
    {

    }

    void moveRight()
    {

    }

    void moveForward()
    {

    }

    void moveBackwards()
    {

    }

    #endregion
}
