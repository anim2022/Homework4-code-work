using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookGen : MonoBehaviour
{
    public GameObject HookPrefab;
    float span = 1.0f; //1.0f마다 바늘을 생성한다.
    float delta = 0;//이때 델타값은 0으로 시작한다(delta는 초보다 더 작은 시간단위라고 생각하면 될것같아)

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)//델타값이 span시간보다 많거나 같다면 다음의 작업을 수행한다.
        { 
            this.delta = 0;//delta값은 0으로 되면서
            GameObject go = Instantiate(HookPrefab) as GameObject;//HookPrefab을 게임 오브젝트로 내보낸다.
            int px = Random.Range(-6, 7);//바늘의 x좌표는 -6부터6까지 랜덤으로 위치하라
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
