using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue_Answers : MonoBehaviour
{
    //Answer Correct
    //Answer Wrong

    public SwitchButtons switchButtons;
    public bool answerCorrect;

    public Lights lights;

    //Array
    /*public int[] Level = new int[14];

    //check if current level is completed
    void LevelComplete(int n)
    {
        Level[n] = 1;
    }

    public bool CheckLevelComplete(int n)
    {
        return Level[n] == 1;
    }
    */

    //Level number in array



    //list of levels
    void LevelSequence()
    {
         ButtonsSequence(3, 5, 6, 1); // Level 1
    }


    //enum plus list for each level
    //function to input index number (position) of each button
    void ButtonsSequence(int a, int b, int c, int d)
    {
        switchButtons.buttons[0].VerticalSteps = a;
        switchButtons.buttons[1].VerticalSteps = b;
        switchButtons.buttons[2].VerticalSteps = c;
        switchButtons.buttons[3].VerticalSteps = d;
    }


    //test if button sequence is correct
    //bool proof if level is completed (if lvl3 should be started it will be checked if lvl2 is complete)
    void CheckAnswer()
    {
        //if (PlayerInput == ButtonSequence)
        bool answerCorrect = true;
        //CorrectAnswer();

        //else
        //WrongAnswer();
    }

    //Compare index numbers for each items out of both lists and compare


    //CorrectAnswer
    void CorrectAnswer()
    {
        //next level
        //Green eyes
        lights.CorrectEyes();
        //bridge move
        //if (lvl 14) then play animation
    }

    //WrongAnswer
    void WrongAnswer()
    {
        //repeat level
        //red eyes
        lights.WrongEyes();
    }





    void TestAnswer()
    { //Levels

        






        //hard gecoded
        //Level1
        if(switchButtons.buttons[0].VerticalSteps == 1 
            && switchButtons.buttons[1].VerticalSteps == 2 
            && switchButtons.buttons[2].VerticalSteps == 4
            && switchButtons.buttons[3].VerticalSteps == 2)
        {
            CorrectAnswer();
            answerCorrect = true;
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level2
        if (switchButtons.buttons[0].VerticalSteps == 6
            && switchButtons.buttons[0].VerticalSteps == 6
            && switchButtons.buttons[0].VerticalSteps == 5)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level3
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level4
        if (switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 3)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level5
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level6
        if (switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 3
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level7
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 4)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level8
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 1)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level9
        if (switchButtons.buttons[0].VerticalSteps == 6
            && switchButtons.buttons[0].VerticalSteps == 6
            && switchButtons.buttons[0].VerticalSteps == 5)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level10
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level11
        if (switchButtons.buttons[0].VerticalSteps == 8
            && switchButtons.buttons[0].VerticalSteps == 3
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 3)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level12
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 2
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level13
        if (switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 3
            && switchButtons.buttons[0].VerticalSteps == 2)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }

        //Level14
        if (switchButtons.buttons[0].VerticalSteps == 1
            && switchButtons.buttons[0].VerticalSteps == 5
            && switchButtons.buttons[0].VerticalSteps == 4
            && switchButtons.buttons[0].VerticalSteps == 4)
        {
            CorrectAnswer();
        }
        else
        {
            //DIE (I guess)
            WrongAnswer();
        }
    }

    //play melody

    void CorrectAnswer()
    {
        //next level
        //Eyes lighten
        //connect with glowing eyes
    }

    void WrongAnswer()
    {
        //repeat
        //red eyes

    }
    
}
