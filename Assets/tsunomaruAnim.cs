using UnityEngine;
using System.Collections;

public class tsunomaruAnim : MonoBehaviour
{

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 10, 80, 20), "Attack"))
        {
            anim.SetTrigger("Attackfromwalk");
        }
    }

}
