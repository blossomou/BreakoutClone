using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text ballsText;
    [SerializeField] private Text levelText;

    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelPlay;
    [SerializeField] private GameObject panelLevelCompleted;
    [SerializeField] private GameObject panelGameOver;
    public enum State {MENU, INIT, PLAY, LEVELCOMPLETED, LOADLEVEL, GAMEOVER}

    State _state;

    public void PlayClicked(){
        SwitchState(State.INIT);
    }

    // Start is called before the first frame update
    void Start()
    {
        SwitchState(State.MENU);
    }

    public void SwitchState(State newState){
        EndState();
        BeginState(newState);
    }

    void BeginState(State newState){
        switch (newState)
        {
            case State.MENU:
                panelMenu.SetActive(true);
            break;
            case State.INIT:
                panelPlay.SetActive(true);
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
                panelLevelCompleted.SetActive(true);
            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
                panelGameOver.SetActive(true);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
         switch (_state)
        {
            case State.MENU:
            break;
            case State.INIT:
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
            break;
        }
    }

    void EndState(){
        switch (_state)
        {
            case State.MENU:
                panelMenu.SetActive(false);
            break;
            case State.INIT:
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
                panelLevelCompleted.SetActive(false);

            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
                panelPlay.SetActive(false);
                panelGameOver.SetActive(false);
            break;
        }
    }
   
}
