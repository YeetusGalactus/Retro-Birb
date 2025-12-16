using Unity.VisualScripting;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D birdbody;
    public float jumpForce;
    public LogicScript logic;
    public bool ballActive = true;
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

}
