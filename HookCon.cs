using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookCon : MonoBehaviour //낚시바늘, Hook의 이동명령을 내리는 스크립트
{
    GameObject player;//GameObject로 player를 설정하라.
    
    void Start()
    {
        this.player = GameObject.Find("PlayerFish");
        //이때 player로 GameObject인 PlayerFish오브젝트로 설정한다
    }

    void Update()
    {
        transform.Translate(0, -0.008f, 0);// 바늘은 -0.008f의 등속으로 낙하하라

        if(transform.position.y < -3.20f)//만일 -3.20f의 y좌표에 도달한다면...
        {
            Destroy(gameObject);//이 오브젝트(Hook)를 파괴하라
        }

        Vector2 p1 = transform.position;//화살 중심의 좌표
        Vector2 p2 = this.player.transform.position;//플레이어 중심의 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.08f;//낚시바늘의 반경
        float r2 = 1.6f;//플레이어의 반경
        if (d < r1 + r2) //만일 바늘과 플레이어가 서로 충돌한다면...
        {
            Destroy(gameObject);//바늘을 지워라

            GameObject director = GameObject.Find("GameDirector");//"GameDirector"오브젝트를 찾고
            director.GetComponent<GameDirector>().DecreaseHp();//거기의 DecreaseHp명령을 발동하라
        }
    }
}
