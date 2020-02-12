using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    Left,
    Right,
}

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public ePlayer player;

    // Update is called once per frame
    void Update()
    {
        float inputspeed = 0f;
        if (player == ePlayer.Left)
        {
            inputspeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if(player == ePlayer.Right)
        {
            inputspeed = Input.GetAxisRaw("PlayerRight");
        }
        transform.position += new Vector3(0f, 0f, inputspeed * speed * Time.deltaTime);
    }
}

