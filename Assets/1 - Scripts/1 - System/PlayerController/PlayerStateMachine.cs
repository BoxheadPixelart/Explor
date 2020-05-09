using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public enum PlayerState { NavigationState, CombatState,Invalid }
//
public class PlayerStateMachine : MonoBehaviour
{
    PlayerState currentState;
    public ObjectRef _objectRef; 

    // Start is called before the first frame update
    void Start()
    {
        SetState("NavigationState"); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateState(string state)
    {

    }
    public void SetState(string newStateName)
    {
        PlayerState stateToPassToEnum;

        switch (newStateName)
        {
            case "NavigationState":
                stateToPassToEnum = PlayerState.NavigationState;
                break;
            case "Start":
                stateToPassToEnum = PlayerState.CombatState ;
                break;

            default:
                // debug.log("incorrect state name given: " + newStateName);
                stateToPassToEnum = PlayerState.Invalid;
                break;
        }
        UpdateState(stateToPassToEnum); 
    }
    public void UpdateState(PlayerState newState)
    {
        switch (newState)
        {
            case PlayerState.NavigationState:
                _objectRef.debugState.text = "NavigationState";
                break;

            case PlayerState.CombatState:
                _objectRef.debugState.text = "CombatState";
                break;

            case PlayerState.Invalid:
                _objectRef.debugState.text = "Invalad";
                break; 
        }
    }

}