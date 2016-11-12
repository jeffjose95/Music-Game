using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class noteHandler : MonoBehaviour
{
    private Color myColor;
    public KeyCode inputToBeTrue;
    private bool isInputOn;
    public static int score;
    public Text Score;
    // Use this for initialization
    void Start()
    {
        myColor = GetComponent<SpriteRenderer>().color;
        isInputOn = false;

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(inputToBeTrue))
        {
            isInputOn = true;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            isInputOn = false;
            GetComponent<SpriteRenderer>().color = myColor;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Note" && isInputOn == true)
        {
            Destroy(other.gameObject);
            score++;
           
            Score.text = "SCORE: " + score;
        }
        

    }
}
