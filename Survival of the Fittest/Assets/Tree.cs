using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Player _player;
    public float numOfHits;

    void Start()
    {
        _player.GetComponent<Player>();
    }

    void OnMouseDown()
    {
        numOfHits++;
        _player.AddWood();
    }
    void Update()
    {
        if (numOfHits >= 3)
        {
            Destroy(gameObject);
        }
    }
}
