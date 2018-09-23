using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CharacterStat : MonoBehaviour {

    System.Random r = new System.Random(1000);

    //まほうスライム
    public int slyme_HP = 100;
    public int slyme_MagicA = 50;
    public int slyme_Attack = 34;
    public int slyme_Defend = 34;


    //こうげきネコ
    public int cat_HP = 100;
    public int cat_MagicA = 34;
    public int cat_Attack = 50;
    public int cat_Defend = 34;

    //バリアひと
    public int human_HP = 100;
    public int human_MagicA = 34;
    public int human_Attack = 34;
    public int human_Defend = 50;

    public bool attack_stat;
    public bool defend_stat;

    public int turn_count = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        int janken = r.Next(1, 4);
	}
}
