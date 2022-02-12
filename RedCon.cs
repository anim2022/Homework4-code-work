using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCon : MonoBehaviour //적십자. red의 이동명령을 내리는 스크립트
{
    GameObject player;//GameObject로 player를 설정하라.

    void Start()
    {
        this.player = GameObject.Find("PlayerFish");
        //이때 player로 GameObject인 PlayerFish오브젝트로 설정한다
    }

    void Update()
    {
        transform.Translate(0, -0.004f, 0);// 적십자는 -0.004f의 등속으로 낙하하라

        if (transform.position.y < -4.46f)//만일 -4.46f의 y좌표에 도달한다면...
        {
            Destroy(gameObject);//이 오브젝트(Red)를 파괴하라
        }

        Vector2 p1 = transform.position;//적십자 중심의 좌표
        Vector2 p2 = this.player.transform.position;//플레이어 중심의 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.008f;//적십자의 반경
        float r2 = 2.0f;//플레이어의 반경
        if (d < r1 + r2) //만일 적십자와 플레이어가 서로 충돌한다면...
        {
            Destroy(gameObject);//적십자를 지워라

            GameObject director = GameObject.Find("GameDirector");//"GameDirector"오브젝트를 찾고
            director.GetComponent<GameDirector>().IncreaseHp();//거기의 IncreaseHp명령을 발동하라
        }
    }
}
