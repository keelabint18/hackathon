using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTurnStat : MonoBehaviour {
    
    //ジャンケン用乱数の設定
    System.Random r = new System.Random();

    public bool MagicSlime_janken;
    public bool AttackCat_janken;
    public bool DefendHuman_janken;
	// Use this for initialization
	void Start () {
	}

    bool JudgeJanken_Character(int flag, string MyCharacter,string EnemyCharacter)
    {
        if (GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status)
        {   //あいこのとき
            continue;
        }
        else if ((GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == 1) && (GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status == 3))
        {
            //自分がグー、相手がパー
            return true;
        }
        else if ((GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == 2) && (GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status == 3))
        {
            //自分がチョキ、相手がパー
            return true;
        }
        else {
            return false;
        }
    }

    int SetCharacterJunkenStat(int Myjunken,string MyCharacter,int EnemyJanken,string EnemyCharacter) {

    }

    // Update is called once per frame
    void Update () {
        //1のときグー、2のときチョキ、3のときパー

        int jankenSet = r.Next(1, 4);



        GameObject.Find("MagicSlime").GetComponent<CharacterStat>().janken_status = r.Next(1, 4);
        GameObject.Find("AttackCat").GetComponent<CharacterStat>().janken_status = r.Next(1, 4);
        GameObject.Find("DefendHuman").GetComponent<CharacterStat>().janken_status = r.Next(1, 4);

        //あいこのとき
        if (GameObject.Find("MagicSlime").GetComponent<CharacterStat>().janken_status == GameObject.Find("AttackCat").GetComponent<CharacterStat>().janken_status) {
            return;
        }

        //まほうスライムがじゃんけんでかつとき
        if ( (GameObject.Find("MagicSlime").GetComponent<CharacterStat>().janken_status < GameObject.Find("AttackCat").GetComponent<CharacterStat>().janken_status)
             || (GameObject.Find("MagicSlime").GetComponent<CharacterStat>().janken_status < GameObject.Find("DefendHuman").GetComponent<CharacterStat>().janken_status) 
           )
        {
            GameObject.Find("MagicSlime").GetComponent<CharacterStat>().attack_stat = true;
        }
        //まけるとき
        else {
            GameObject.Find("AttackCat").GetComponent<CharacterStat>().attack_stat = true;
        }




	}
}
