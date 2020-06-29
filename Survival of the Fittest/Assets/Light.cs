using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public Player player;

    public bool isTorch;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            switch (isTorch)
            {
                case false:
                    player.inLight = true;
                    break;
                default:
                    break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.inLight = false;
        }
    }
}
