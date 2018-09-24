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

    bool JudgeJanken_Character(string MyCharacter,string EnemyCharacter)
    {
        if (GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status)
        {   //あいこのとき
            return false;
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

    void SetCharacterJankenStat(int MyJanken,string MyCharacter,int EnemyJanken,string EnemyCharacter) {
        GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status = MyJanken;
        GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status = EnemyJanken;
    }

    // Update is called once per frame
    void Update () {
        //1のときグー、2のときチョキ、3のときパー

        SetCharacterJankenStat(r.Next(1, 4), "MagicSlime", r.Next(1, 4), "AttackCat");
        JudgeJanken_Character("MagicSlime", "AttackCat");
	}
}
