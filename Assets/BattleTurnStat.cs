using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BattleTurnStat : MonoBehaviour
{

    public bool MagicSlime_janken;
    public bool AttackCat_janken;
    public bool DefendHuman_janken;
    // Use this for initialization
    void Start()
    {
    }
    //1 MyCharacter先行 0 EnemyCharacter 先行
    //1 ぐー　2 チョキ 3 パー janken_status
    int JudgeJanken_Character(string MyCharacter, string EnemyCharacter)
    {
        //ジャンケン用乱数の設定
        int r = Random.Range(0, 2);
        if (GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status)
        {   //あいこのとき
            return r;
        }
        else if ((GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == 1) && (GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status == 3))
        {
            //自分がグー、相手がパー
            return 1;
        }
        else if ((GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status == 2) && (GameObject.Find(EnemyCharacter).GetComponent<CharacterStat>().janken_status == 3))
        {
            //自分がチョキ、相手がパー
            return 1;
        }
        else
        {
            return 0;
        }
    }
    void SetCharacterJankenStat(int MyJanken, string MyCharacter, int EnemyJanken, string EnemyCharacter)
    {
        GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status = MyJanken;
        GameObject.Find(MyCharacter).GetComponent<CharacterStat>().janken_status = EnemyJanken;
    }


    //ダメージを与える。引数として被撃するキャラクター名、および受けるダメージが必要
    void AttackDamaged(string DamagedCharacter,int damage) {
        (GameObject.Find(DamagedCharacter).GetComponent<CharacterStat>().HP) = (GameObject.Find(DamagedCharacter).GetComponent<CharacterStat>().HP) - (damage);
    }

    // Update is called once per frame
    void Update()
    {
        //1のときグー、2のときチョキ、3のときパー
        //SetCharacterJankenStat(r, "MagicSlime", r, "AttackCat");
        //JudgeJanken_Character("MagicSlime", "AttackCat");
    }
}