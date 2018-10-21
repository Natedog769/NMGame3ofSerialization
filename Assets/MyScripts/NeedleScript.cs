using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour {


    public float needleMoveSpeed;
    float currentPlayBackSpeed;
    public Transform startingPos;
    public enum State {Stop = 0, Pause = 1, Play = 2}
    public State needlesState;

    
    void Update()
    {
        if (needlesState == State.Pause)
            {
                NeedlePause();
            }
        if (needlesState == State.Play)
        {
            NeedlePlay();
        
            
        }
        if (needlesState == State.Stop)
        {
            NeedleStop();
        }
    }
    private void Start()
    {
      
    }


    public void PlayButtonPress()
    {
        needlesState = State.Play;
    }

    public void PauseButtonPress()
    {
        needlesState = State.Pause;
    }

    public void StopButtonPress()
    {
        needlesState = State.Stop;
    }

    public void NeedlePlay()
    {
        
        currentPlayBackSpeed = needleMoveSpeed * Time.deltaTime;

        transform.Translate(Vector2.right * currentPlayBackSpeed);

    }

    public void NeedlePause()
    {
        currentPlayBackSpeed = 0;
    
    }

    public void NeedleStop()
    {
        transform.position = startingPos.position;
    }



    private void OnTriggerEnter2D(Collider2D contact)
    {
        if (contact.gameObject.tag == "End")
        {
            transform.position = startingPos.position;
        }
    }

    private void OnTriggerStay2D(Collider2D contact)
    {
        Debug.Log("I am touching" + contact.gameObject.GetComponent<ButtonBehaviour>().numberOfClicks);
        

    }

}



