﻿using UnityEngine;
using System.Collections;

public class QuestLog : MonoBehaviour {
    public string[] questLog = new string[1] { "Welcome: \n F for Ice \n V for Fire \n G For earth \n R for lightning" };
    public int questIndex;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/10, Screen.height/10, 100, 100), questLog[questIndex]);
    }
	void Update () {
	
	}
    public void updateQuest(int targetQuest)
    {

    }
    public int getQuestState()
    {
        return 1;
    }
}