using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LButtonDown() 
    {
        transform.Translate(-1.2f, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(1.2f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))//왼쪽 화살표가 눌린다면
        {
            transform.Translate(-1.2f, 0, 0);//왼쪽으로 1.2f움직인다.
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) //우측 화살표가 눌린다면
        {
            transform.Translate(1.2f, 0, 0);//우측으로 1.2f움직인다.
        }
    }
}
