using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class noteScript : MonoBehaviour {

    public Transform note;                                                        // the note to be instantiated

    public MovieTexture movie;                                                    // the movie clip to be played (Remember that it is a texture)
    private AudioSource theSong;                                                  // audiosource to play the audio clip

    private float songTime;                                                       // the time since the song started
    private float printedSongTime;                                                //
    private int printedSongTimeMinutes;
    private int printedSongTimeSeconds;

    private float timeLeft;
    private float printedTimeLeft;
    private int printedTimeLeftMinutes;
    private int printedTimeLeftSeconds;


    public TextMesh songTimer;

    public GameObject note1Producer;
    public GameObject note2Producer;
    public GameObject note3Producer;
    public GameObject note4Producer;

    private int number;
    private int previousnumber;

    public double lagTime;
    
    // Use this for initialization
    void Start () {

        songTime = 0;                                                       // present song time in game
        theSong = GetComponent<AudioSource>();                              // audio source contains song clip
        printedSongTime = (int)songTime;                                    // the whole value of songtime
        printedSongTimeMinutes = (int) printedSongTime / 60;                // minutes of songtime passed
        printedSongTimeSeconds = (int) printedSongTime % 60;                // seconds of songtime passed

        
        timeLeft = theSong.clip.length;                                     // time left in song
        printedTimeLeft = (int)timeLeft;                                    // whole value of time left
        printedTimeLeftMinutes = (int) printedTimeLeft / 60;                // minutes of time left
        printedTimeLeftSeconds = (int) printedTimeLeft % 60;                // seconds of time left
        theSong.Play();                                                     // plays the song
    }

    // Update is called once per frame

    void Update()
    {

    }
	void FixedUpdate () {

        if (timeLeft > 0)                                                   // if there is time left for song
        {
            songTime += Time.deltaTime;                                     // updates the time values
            timeLeft -= Time.deltaTime;
            printedSongTime = (int)songTime;
            printedTimeLeft = (int)timeLeft;
        }

        printedSongTimeMinutes = (int)printedSongTime / 60;                 // song time updates
        printedSongTimeSeconds = (int)printedSongTime % 60;

        printedTimeLeftMinutes = (int)printedTimeLeft / 60;                 // time left updates
        printedTimeLeftSeconds = (int)printedTimeLeft % 60;
                                                                            // decides what time will be printed
        if (printedTimeLeft < 60 && printedSongTime < 60)                   // if both times are lesser than 60 seconds
        {
            if (printedTimeLeft < 10 && printedSongTime < 10)
            {
                songTimer.text = "time = 0" + printedSongTime + "\n" + "time left = 0" + printedTimeLeft;
            }
            else if (printedSongTime < 10)
            {
                songTimer.text = "time = 0" + printedSongTime + "\n" + "time left = " + printedTimeLeft;
            }
            else
            {
                songTimer.text = "time = " + printedSongTime + "\n" + "time left = " + printedTimeLeft;
            }

        }
        else if (printedTimeLeft > 60 && printedSongTime < 60)                // if time left is more than 60 seconds
        {
            if (printedTimeLeftSeconds < 10)
            {
                songTimer.text = "time = " + printedSongTime + "\n" + "time left = " + printedTimeLeftMinutes + " : 0" + printedTimeLeftSeconds;
            }
            else
            {
                if (printedSongTimeSeconds < 10)
                {
                    songTimer.text = "time = 0" + printedSongTime + "\n" + "time left = " + printedTimeLeftMinutes + " : " + printedTimeLeftSeconds;
                }
                else
                {
                    songTimer.text = "time = " + printedSongTime + "\n" + "time left = " + printedTimeLeftMinutes + " : " + printedTimeLeftSeconds;
                }
            }
        }
        else if (printedTimeLeft < 60 && printedSongTime > 60)                  // if song time is more than 60 seconds
        {
            if (printedSongTimeSeconds < 10)
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : 0" + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeft;
            }
            else
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : " + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeft;
            }
        }
        else                                                                   // if both are more than 60 seconds
        {
            if (printedSongTimeSeconds < 10 && printedTimeLeftSeconds < 10)
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : 0" + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeftMinutes + " : 0" + printedTimeLeftSeconds;
            }
            else if (printedSongTimeSeconds < 10)
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : 0" + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeftMinutes + " : " + printedTimeLeftSeconds;

            }
            else if (printedTimeLeftSeconds < 10)
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : " + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeftMinutes + " : 0" + printedTimeLeftSeconds;
            }
            
            else
            {
                songTimer.text = "time = " + printedSongTimeMinutes + " : " + printedSongTimeSeconds + "\n" + "time left = " + printedTimeLeftMinutes + " : " + printedTimeLeftSeconds;
            }

        }



        // Song scripting based on time


        timeOfNoteNormal(5.342);
        timeOfNoteNormal(5.908);      
        timeOfNoteNormal(6.416);
        timeOfNoteNormal(6.893);
        timeOfNoteNormal(7.43);
        timeOfNoteNormal(7.961);
        timeOfNoteNormal(8.396);
        timeOfNoteNormal(8.896);
        timeOfNoteNormal(9.448);
        timeOfNoteNormal(9.912);
        timeOfNoteNormal(10.072);
        timeOfNoteNormal(10.594);
        timeOfNoteNormal(10.986);
        timeOfNoteNormal(11.508);
        timeOfNoteNormal(12.031);
        timeOfNoteNormal(12.466);
        timeOfNoteNormal(12.873);
        timeOfNoteNormal(13.003);
        timeOfNoteNormal(13.569);
        timeOfNoteNormal(13.961);
        timeOfNoteNormal(14.948);
        timeOfNoteNormal(15.514);
        timeOfNoteNormal(15.862);
        timeOfNoteNormal(16.181);
        timeOfNoteNormal(16.515);
        timeOfNoteNormal(17.009);
        timeOfNoteNormal(17.429);
        timeOfNoteNormal(18.054);
        timeOfNoteNormal(18.663);
        timeOfNoteNormal(19.59);
        timeOfNoteNormal(19.747);
        timeOfNoteNormal(19.921);
        timeOfNoteNormal(21.14);
        timeOfNoteNormal(21.49);
        timeOfNoteNormal(22.01);
        timeOfNoteNormal(22.235);
        timeOfNoteNormal(22.368);
        timeOfNoteDouble(22.818);
        timeOfNoteNormal(23.761);
        timeOfNoteNormal(24.008);
        timeOfNoteNormal(24.341);
        timeOfNoteNormal(24.588);
        timeOfNoteNormal(25.082);
        timeOfNoteNormal(25.1);
        timeOfNoteNormal(25.357);
        timeOfNoteDouble(25.618);














    }

    void timeOfNoteNormal(double time)
    {
        double initial = time - 0.009;
        double ending = time + 0.010;

        if (songTime > initial - lagTime && songTime < ending - lagTime)
        {
            previousnumber = number;
            number = Random.Range(1, 5);

            if (number == previousnumber)
            {
                if (number > 1)
                {
                    number = number - 1;
                }
                else
                {
                    number = number + 1;
                }

            }

            createNote(number);
        }
    }

    void timeOfNoteDouble(double time)
    {
        double initial = time - 0.012;
        double ending = time + 0.012;

        if (songTime > initial - lagTime && songTime < ending - lagTime)
        {
            previousnumber = number;
            number = Random.Range(1, 5);

            if (number == previousnumber)
            {
                if (number > 1)
                {
                    number = number - 1;
                }
                else
                {
                    number = number + 1;
                }

            }
            if (number == 1 || number == 3)
            {
                createNote(1);
                createNote(3);
            }
            else
            {
                createNote(2);
                createNote(4);
            }
        }
    }


    void createNote(int position)
    {
        if (position == 1)
        {
            Instantiate(note, note1Producer.transform.position, note1Producer.transform.rotation);
        }
        if (position == 2)
        {
            Instantiate(note, note2Producer.transform.position, note2Producer.transform.rotation);
        }
        if (position == 3)
        {
            Instantiate(note, note3Producer.transform.position, note3Producer.transform.rotation);
        }
        if (position == 4)
        {
            Instantiate(note, note4Producer.transform.position, note4Producer.transform.rotation);
        }

    }
}
