using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CharacterStat : MonoBehaviour {

    //ジャンケン用ランダム値のシード
    //   System.Random r = new System.Random(1000);

    //まほうスライム
    public int HP;
    public int MagicA;
    public int Attack;
    public int Defend;

    public bool attack_stat;
    public bool defend_stat;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
