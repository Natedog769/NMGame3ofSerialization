using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour {


    public float needleMoveSpeed;
    public Transform startingPos;
    public enum State {Stop = 0, Pause = 1, Play = 2}
    public State needlesState;
    Rigidbody2D needleBody;

    
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
        else
            NeedleStop();
        
    }
    private void Start()
    {
        needleBody = GetComponent<Rigidbody2D>();
        //needlesState = State.Stop;
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
        
        float playBackSpeed = needleMoveSpeed * Time.deltaTime;

        transform.Translate(Vector2.right * playBackSpeed);

        //if (tranform.position >= )
    }

    public void NeedlePause()
    {


        needleBody.constraints = RigidbodyConstraints2D.FreezePosition;
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

        Debug.Log("I am touching" + contact.gameObject.name);
        
    }

}



