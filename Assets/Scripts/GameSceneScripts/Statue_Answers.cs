using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statue_Answers : MonoBehaviour
{
    //changing Buttons_Script
    public SwitchButtons switchButtons;

    //Wrong/ Correct Light_Script
    public Lights lights;

    //BridgeMovement_Script
    public Bridge_Movement bridge;

    //StatueSound_Script
    public StatueSound sound;

    //Current Level display (UI)
    public Text level_text;

    //"hinterlistig" list made of LevelDating class because of the ints list
    public List<LevelDating> ChonkerList = new List<LevelDating>();
    public int LevelIndex = 0;

    //Camera movement
    private Animator anim;


    //states of the level
    public enum LevelState
    {
    PLAYING_MELODY, // melody is playing + animation
    PLAYER_INPUT, // player is inputting notes
    CHECK_ANSWER, // check answer + right/ wrong light
    RICK_UNLEASHED, // enter his dungeon
    };

    //setting it as PLAYING_MELODY to start with
    public LevelState state = LevelState.PLAYING_MELODY;
    public Camera MAINCAMERA;

    //timing
    public float stateLifetime = 0.0f;
    public float melody_timeUntilNote = 0.0f;
    public float melody_index = 0.0f;   

    public float delayBetweenNotes = 1.5f; // Control delay between notes


    private void Awake()
    {
        anim = MAINCAMERA.GetComponent<Animator>();
        anim.SetBool("ISDONE?", false);
    }


    //in this level code i had my friend help and explain to me how to code the sequence of actions of the game
    //my problem where i got stuck was how to incorporate the statue playing the melody that needs to be repeated
    //therefor the game is divided into 4 parts: statue playing the melody, player input, check answer, and final part
    void Update()
    {
        level_text.text = "Level:" + (LevelIndex + 1);

        stateLifetime += Time.deltaTime; //Time.delta: time between each update function call (seconds)

        switch (state)
        {
            //play melody to be repeated by player
            case LevelState.PLAYING_MELODY:                     //Step1
                 melody_timeUntilNote -= Time.deltaTime;

                if (melody_timeUntilNote <= 0.0f)
                {
                    if (melody_index > 3)   
                    {
                        // Finished playing melody.
                        SetState(LevelState.PLAYER_INPUT);
                    }
                    else
                    {
                        // Play melody
                        switch (melody_index)
                        {
                            case 0:
                                sound.PlayNote(ChonkerList[LevelIndex].a);

                                break;

                            case 1:
                                sound.PlayNote(ChonkerList[LevelIndex].b);

                                break;

                            case 2:
                                sound.PlayNote(ChonkerList[LevelIndex].c);

                                break;

                            case 3:
                                sound.PlayNote(ChonkerList[LevelIndex].d);

                                break;
                        }
                        melody_timeUntilNote = delayBetweenNotes;
                        melody_index++;
                    }
                }

                break;

            //press enter
            case LevelState.PLAYER_INPUT:       //Step2

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    Debug.Log("You may enter");
                    SetState(LevelState.CHECK_ANSWER);
                }

                break;

            //call function CheckAnswer
            case LevelState.CHECK_ANSWER:       //Step3

                if (stateLifetime > 2.0f)   //how long a state is 
                { // After 2 seconds, check the answer.
                    TestAnswer();
                }


                break;

            //finished all levels
            case LevelState.RICK_UNLEASHED:     //Step4
                
                break;

        }
    }

    //SetState into another switch case state
    void SetState(LevelState newState)  
    {
        state = newState;
        stateLifetime = 0.0f;
        melody_index = 0;
        melody_timeUntilNote = delayBetweenNotes;
        
        lights.ResetLights();

        //Switch for camera movements + turning on/ off lights
        switch(state)
        {
            case LevelState.PLAYING_MELODY:
            Debug.Log("State: Play melody");
                // Code for starting the camera animation to move up to the gate.
                //anim.Play("LookUpCamera");

            break;
            
            case LevelState.PLAYER_INPUT:
            Debug.Log("State: Player input");
                // Code to start playing animation to move camera down to the board.
                //anim.Play("LookDownCamera");

                break;

            case LevelState.CHECK_ANSWER:
            Debug.Log("State: Check answers");
                if(IsAnswerCorrect())
                {
                    lights.CorrectEyes();
                }
                // Code for starting the camera animation to move up to the gate.
                else
                {
                    lights.WrongEyes();
                }
            
            break;

            case LevelState.RICK_UNLEASHED:
            Debug.Log("State: incomprehensible");
                // Code for starting rick animation
                    anim.SetBool("ISDONE?", true);
     
            break;
        }
    }

    //CorrectAnswer
    void CorrectAnswer()
    {
       
       bridge.MoveBridge();
       LevelIndex++;

       if (LevelIndex < ChonkerList.Count)
       {
            SetState(LevelState.PLAYING_MELODY);
       }
       else
       {
            SetState(LevelState.RICK_UNLEASHED);
       }
    }

    //WrongAnswer
    void WrongAnswer()
    {
        
        Debug.Log("Loser");
        SetState(LevelState.PLAYING_MELODY);
    }

    //list of levels + button sequence
    //function to input index number (position) of each button (which note must be played)
    bool CompareWithButtons(int a, int b, int c, int d)
    {
        return switchButtons.buttons[0].VerticalSteps == a
            && switchButtons.buttons[1].VerticalSteps == b
            && switchButtons.buttons[2].VerticalSteps == c
            && switchButtons.buttons[3].VerticalSteps == d;
    }

    //check answer giving answers to bool made for lights system turning them on/ off
    bool IsAnswerCorrect()
    {
        LevelDating currentLevel = ChonkerList[LevelIndex];

        if (CompareWithButtons(currentLevel.a, currentLevel.b, currentLevel.c, currentLevel.d))   //template
        {
            return true;
        }
        else
        {
            //DIE (I guess)
            return false;
        }
    }



    //check answers and use functions
    void TestAnswer()
    { 
        LevelDating currentLevel = ChonkerList[LevelIndex];

        if(CompareWithButtons(currentLevel.a,currentLevel.b,currentLevel.c,currentLevel.d))   //template
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }


        //All Level melodies
        //did not implement a function that switches between three and four button answers so i will leave the last button the same not as in the melody before
        //manually typing it in the object...aaaaaaaaah

        //Lvl 1
        //if (CompareWithButtons(1, 2, 4, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////Lvl 2
        //if (CompareWithButtons(6, 6, 5, 2))   
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 3
        //if (CompareWithButtons(1, 2, 4, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 4
        //if (CompareWithButtons(5, 5, 4, 3))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 5 
        //if (CompareWithButtons(1, 2, 4, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 6
        //if (CompareWithButtons(4, 5, 3, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 7
        //if (CompareWithButtons(1, 2, 5, 4))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 8
        //if (CompareWithButtons(1, 2, 4, 1))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 9
        //if (CompareWithButtons(6, 6, 5, 1))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 10
        //if (CompareWithButtons(1, 2, 4, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 11
        //if (CompareWithButtons(8, 3, 4, 3))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 12
        //if (CompareWithButtons(1, 2, 4, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////play 13
        //if (CompareWithButtons(4, 5, 3, 2))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}

        ////lvl 14
        //if (CompareWithButtons(1, 5, 4, 4))
        //{
        //    CorrectAnswer();
        //}
        //else
        //{
        //    WrongAnswer();
        //}


        //old level design over and over again... now i am using a function instead of setting up 4 conditions

        ////level14
        //if (switchbuttons.buttons[0].verticalsteps == 1
        //    && switchbuttons.buttons[0].verticalsteps == 5
        //    && switchbuttons.buttons[0].verticalsteps == 4
        //    && switchbuttons.buttons[0].verticalsteps == 4)
        //{
        //    correctanswer();
        //}
        //else
        //{
        //    //die (i guess)
        //    wronganswer();
        //}
    }
}
