using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public enum GameState
{
    Start,
    TriggerOne,
    TriggerTwo,
    TriggerThree,
    TriggerFour,
    TriggerFive,
    TriggerSix,
    TriggerSeven,
    TriggerEight,
    TriggerNine,
    TriggerTen,
    TriggerEleven,
    TriggerTwelve,
    TriggerThirteen,
    TriggerFourteen,
    TriggerFifteen,
    TriggerSixteen,
    Restart,
    None
};

[System.Serializable]
public class GameController : MonoBehaviour
{

    public GameState myGameState = GameState.None;

	public static GameController control;

    public void ChangeGameState()
    {
        switch (myGameState)
        {
            case GameState.None:

                //so far do nothing
				

                break;
			//DONE
            case GameState.Start://inside study with door locked and lights ON

                //study lights ON
                //door locked
				

                break;
			//DONE
            case GameState.TriggerOne://if tries to open study door
			
                //Audio(Fax Machine)
                //Animation(Fax Machine)
                //Activate GameObject(Fax Note(1))
				

                break;
			//DONE
            case GameState.TriggerTwo://if inspect fax note 1

                //Activate GameObjects(Mail in study)
                //Audio(door open)
                //Animation(Open study door)

                break;
			//DONE
            case GameState.TriggerThree://if inspect cups, plant and plant book

                //Audio(door open)
                //Animation(open laundry door)

                //Laundry lights ON

                break;
			//DONE
            case GameState.TriggerFour://if inspect mail in laundry

                //Audio(Fax Machine)
                //Animation(Fax Machine)
                //Activate GameObject(Fax Note(2))

                break;
			//DONE
            case GameState.TriggerFive://pick up note 2

               //Audio(transition to scene two)
               //SceneManager.LoadScene("SceneTwo"); 

                break;

			//DONE
            case GameState.TriggerSix://if inspect family photo

                //Activate GameObject(Torch)
				//Audio.Play(radio)

                break;

			//DONE
            case GameState.TriggerSeven://if radio = off & inspect bills in study

                //Audio.Stop(radio)
                //Audio(door open)
                //Animation(open front door)

                break;
			//DONE
            case GameState.TriggerEight://if inspect lawn toy, bloodstain & driveway toy

                //Audio(new atmosphere)
                //Activate GameObjects(Newspaper + Mail)

                break;

			//DONE
            case GameState.TriggerNine://if inspect newspaper & mail at front door

                //Audio(Fax Machine)
                //Animation(Fax Machine)
                //Activate GameObject(Fax Note(3))

                break;
			//DONE
            case GameState.TriggerTen://if inspect fax note 3

                //Audio(portrait smash)
                //Activate GameObject(fallen portrait)

                break;
			//DONE
            case GameState.TriggerEleven://if inspect portrait

                //Audio(upstairs noise)
                //Activate GameObject(Passport, Page from plants book)

                break;
            case GameState.TriggerTwelve://if inspect passport & page from plant book

                //lights ON in sisters room
                //Activate GameObjects(sisters toys + Journal)

                break;
            case GameState.TriggerThirteen://if inspect sisters journal

                //Audio(Fax Machine)
                //Animation(Fax Machine)
                //Activate GameObject(Fax Note(4))

                break;
            case GameState.TriggerFourteen://if inspect fax note 4

                //Audio(radio)
                //Activate GameObjects(Glass Cups with Poison)

                break;
            case GameState.TriggerFifteen://if player drinks poison

                //Screen fade to black
                //Audio(Phone Ringing)
                //Screen fade in

                break;
            case GameState.TriggerSixteen://if player picks up phone

                //Audio(000Call)
                //Screen fade to black
                //GameOver

                break;
            case GameState.Restart://if lightOn = false

                //Audio(gameOver)
                //Screen fade to black
                //SceneManager.LoadScene(currentScene)

                break;
        }
        myGameState = GameState.None;
    }
		

};

