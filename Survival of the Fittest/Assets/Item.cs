using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public float playerWood;
    public float playerRocks;
    public Player _player;

    public GameObject campfirePrefab;

    public Button buy;
    public Text buyText;

    void Start()
    {
        _player.GetComponent<Player>();
    }
    public void Purchase()
    {
        if(playerWood >= 7f && playerRocks >= 2f)
        { 
            Instantiate(campfirePrefab, _player.transform.position, Quaternion.identity);
            playerWood = playerWood - 7;
            playerRocks = playerRocks - 2;
            _player.wood = _player.wood - 7;
            _player.rock = _player.rock - 2;

            buy.enabled = false;
            buyText.text = "Unavailable";
        }
    }
    void Update()
    {
        playerWood = _player.wood;
        playerRocks = _player.rock;
    }
}
