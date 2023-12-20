using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementUpDownGravity : MonoBehaviour
{
    // Start is called before the first frame update
    public  Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Movement in the direction of Up.
        m_Rigidbody.AddForce(transform.up * m_Thrust);

        // Movement in the direction of Right.
        // m_Rigidbody.AddForce(transform.right * m_Thrust);    
    }
}
