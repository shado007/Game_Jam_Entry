using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Player _player;

    void Start()
    {
        _player.GetComponent<Player>();
    }

    void OnMouseDown()
    {
        _player.AddStick();
        Destroy(gameObject);
    }
}
