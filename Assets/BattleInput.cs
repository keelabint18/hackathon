using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class BattleInput : MonoBehaviour {
    private float m_power = 0.0f;
    private Vector3 m_powerDir = Vector3.zero;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)) {
        //            Rigidbody rigidbody = GetComponent<Rigidbody>();
        //            rigidbody.AddForce(Vector3.forward * 1.5f);
        //       }
        if (Input.GetKeyDown(KeyCode.W)) {
                  Rigidbody rigidbody 
        }
	}
}
