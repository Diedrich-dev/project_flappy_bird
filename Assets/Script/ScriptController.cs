using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptController : MonoBehaviour
{
    public float flyForce;
    private Rigidbody2D rigidbody2D;

    public GameOver game;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        fly();
    }

    void fly(){
        if(Input.GetMouseButtonDown(0)){
            rigidbody2D.velocity = Vector2.up * flyForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        game.gameOverActive();
    }
}
