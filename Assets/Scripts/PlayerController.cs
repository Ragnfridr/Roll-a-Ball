using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int speed = 100;
    private Rigidbody rb;

    public Text countText;
    public Text winText;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCounterText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        // hantera fysik efter input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count++;
            SetCounterText();
        }
    }

    void SetCounterText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "Congratulations! You win!";
        }
    }
}
