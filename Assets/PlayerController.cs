using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody Rigidbody;

    private Time jumpTime;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        jumpTime = new Time();
    }

    // Update is called once per frame
    void Update()
    {  
    }

    void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Time now_time = new Time();
        Debug.Log(now_time.ToString());
        Debug.Log(jumpTime.ToString());
        Vector3 movement = new Vector3(movehorizontal, 0, moveVertical);
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("space")){
            
            Rigidbody.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
        }
        
        Rigidbody.AddForce(movement);
    }
}
