﻿using UnityEngine;
using System.Collections;

public class World3 : MonoBehaviour {

    private TextMesh mainText;
    private string str;
    private bool flag;
	// Use this for initialization
	void Start () {

        flag = true;
        mainText = GameObject.Find("MainText").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        //str = Input.acceleration.ToString();
        //mainText.text = str;
    }

    public void turnGame()
    {
        if (flag)
        {
            Physics2D.gravity = new Vector2(9.81f, 0);
            PlayerScr.instance.transform.rotation = new Quaternion(0, 0, 1, 1);
        }
        else
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
            PlayerScr.instance.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        flag = !flag;
    }

    void OnDestroy()
    {
        Physics2D.gravity = new Vector2(0, -9.81f);
    }


}