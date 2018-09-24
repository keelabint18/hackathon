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


    //攻撃を開始する。ジャンケンの判定で勝ったほうが実行する。引数として現在経過しているターン数と、勝ったほうのキャラクター名を持ってくる。
    int AttackStart(string Character,int CountTurn) {
        //キャラクターの移動、ダメージを与える、受けるなどの処理
        return CountTurn + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //1のときグー、2のときチョキ、3のときパー
        //SetCharacterJankenStat(r, "MagicSlime", r, "AttackCat");
        //JudgeJanken_Character("MagicSlime", "AttackCat");
    }
}