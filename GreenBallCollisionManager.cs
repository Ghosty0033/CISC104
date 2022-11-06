using System;
using JetBrains.Annotations;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject GreenBall;
    public override void CollideWithBall(GameObject OtherBall)
    { 
        Debug.Log("Green Ball Collision Manager Function");

        

        // Green Ball turns white
        var GreenBallRenderer = GreenBall.GetComponent<Renderer>();
         GreenBallRenderer.material.SetColor("_Color", Color.white);
    }
}

