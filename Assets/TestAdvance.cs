using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25;       // 攻撃力
    private int mp = 53;          // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    public void Magic()
    {
        if(mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}

public class TestAdvance : MonoBehaviour
{
    Boss lastboss = new Boss();
    void Start()
    {
       for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();//１１回目
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastboss.Magic();
        }
    }
}
