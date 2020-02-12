﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoarder : MonoBehaviour
{

    public ePlayer player;
    public ScoreUI score;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
            if (player == ePlayer.Right) score.scorePlayerLeft++;
            else if (player == ePlayer.Left) score.scorePlayerRight++;
        }
    }
}
