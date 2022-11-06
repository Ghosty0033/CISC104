using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject RedBall;
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        //Red Ball decreases in size
        RedBall.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        
    }
}

