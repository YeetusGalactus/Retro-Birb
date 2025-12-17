using Unity.VisualScripting;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D birdbody;
    public float jumpForce;
    public LogicScript logic;
    public bool ballActive = true;
    public float maxHeight = 1.15f;
    public float minHeight = -1.15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && ballActive)
        {
            birdbody.linearVelocity = Vector2.up * jumpForce;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        ballActive = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
            logic.gameOver();
            ballActive = false;
    }

}
