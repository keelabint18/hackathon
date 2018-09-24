using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            ////トリガー押されたら
        //    FadeManager.Instance.LoadScene("StartScene", 2.0f);
            SceneManager.LoadScene("BattleScene");
        }
    }
}
