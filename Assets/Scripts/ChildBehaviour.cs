﻿using UnityEngine;
using System.Collections;

public class ChildBehaviour : MonoBehaviour {


    public float timeToEat;
    bool eating;

    float angryness;

    ScoreSystem score;
    TakeControl takeControl;

    float[] DoSomethingCooldown = { 1.5f, 1.5f };

	// Use this for initialization
	void Start () {
        score = (ScoreSystem)FindObjectOfType<ScoreSystem>();
        takeControl = GetComponent<TakeControl>();
	}
	
	// Update is called once per frame
	void Update () {
        if (DoSomethingCooldown[0] > 0.0f)
        { 
            DoSomethingCooldown[0] -= Time.deltaTime;
            makeDecision();
        }
    }

    private void makeDecision()
    {
        Enums.TakeType takeDecision = (Enums.TakeType)Random.Range(1, 5);
        IItem item = takeControl.take(takeDecision);

        if(item != null)
        {
            DoSomethingCooldown[0] = DoSomethingCooldown[1];
        }

    }

    public void eat(IItem holdingItem)
    {
        if(holdingItem.HasNut)
        {
            score.applyDamage(1);
        }
    }
}
