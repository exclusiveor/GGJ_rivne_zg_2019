using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameController gameController;
    public bool isAlive = true;
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    public float speed = 2f;
    public float timer;
    public Vector3 diraction;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        GenerateDiraction();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(diraction * Time.deltaTime * speed);
            if (timer < Time.time)
            {
                GenerateDiraction();
            }
        }
    }

    private void GenerateDiraction()
    {
        timer = Time.time + Random.Range(minSpeed, 20);
        int dir = Random.Range(0, 2);
        if (dir == 0)
            diraction = Vector3.right;
        else
            diraction = Vector3.left;
    }

    private void OnMouseDown()
    {
        gameController.MoveFlea(this);
    }
}
