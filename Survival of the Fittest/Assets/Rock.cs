using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public Player _player;

    void Start()
    {
        _player.GetComponent<Player>();
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        _player.AddRock();
    }
}
