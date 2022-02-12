using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Hp;
    // Start is called before the first frame update
    void Start()
    {
        this.Hp = GameObject.Find("Hp");
    }
    public void DecreaseHp()
    {
        this.Hp.GetComponent<Image>().fillAmount -= 0.1f;//바늘과 충돌할 시 발동할 Hp이미지를 10% 깎는 명령
    }
    public void IncreaseHp()
    {
        this.Hp.GetComponent<Image>().fillAmount += 0.2f;//적십자와 충돌할 시 발동할 Hp이미지를 20% 더하는 명령

        void Update()
        {

        }
    }
}
