using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Physics")]
    public Rigidbody2D rb;
    public Animator anim;

    public float speed;
    private float movement;

    private bool movementModified;

    [Header("Materials")]
    public float wood;
    public Text woodNum;

    public float rock;
    public Text rockNum;

    public float stick;
    public Text stickNum;

    [Header("Insanity")]
    public float maxInsanity;
    public float currentInsanity = 0f;

    public Bar insanityBar;

    public bool inLight;


    public Light light;

    [Header("Hunger")]
    public float maxHunger;
    public float currentHunger = 0f;

    public Bar hungerBar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        insanityBar.SetMaxInsanity(maxInsanity);

        light.player = this;
    }
    void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);
    }
    void Update()
    {
        if (movement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (movement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (movement == -1)
        {
            movement = 1;
            movementModified = true;
        }
        anim.SetFloat("horizontal", movement);
        if (movementModified == true)
        {
            movement = -1;
            movementModified = false;
        }

        if (!inLight)
        {
            IncreaseInsanity(0.003f);
        }
        else
        {
            IncreaseInsanity(-0.004f);
        }

        IncreaseHunger(0.001f);

        if (currentInsanity >= maxInsanity)
        {
            Destroy(this.gameObject);
        }
        if (currentHunger >= maxHunger)
        {
            Destroy(this.gameObject);
        }
    }

    public void AddWood()
    {
        wood++;
        woodNum.text = "" + wood;
    }
    public void AddRock()
    {
        rock++;
        rockNum.text = "" + rock;
    }
    public void AddStick()
    {
        stick++;
        stickNum.text = "" + stick;
    }

    void IncreaseInsanity(float insanity)
    {
        currentInsanity += insanity;
        insanityBar.SetInsanity(currentInsanity);
    }
    void IncreaseHunger(float hunger)
    {
        currentHunger += hunger;
        hungerBar.SetHunger(currentHunger);
    }
}
