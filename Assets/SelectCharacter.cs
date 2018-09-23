using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour {
    Button Cube1;
    Button Cube2;
    Button Cube3;
    // Use this for initialization
    void Start () {
        Cube1 = GameObject.Find("/Canvas/Button1").GetComponent<Button>();
        Cube2 = GameObject.Find("/Canvas/Button1").GetComponent<Button>();
        Cube3 = GameObject.Find("/Canvas/Button1").GetComponent<Button>();

    }

    // Update is called once per frame
    void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)) {
                transform.Rotate(new Vector3(0, 5, 0));
        }
	}

}
