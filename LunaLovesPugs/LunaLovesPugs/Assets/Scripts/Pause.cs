using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public bool paused;
    public Sprite pauseSprite;
    public Sprite playSprite;

    private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
        paused = false;
	}

    public void Paused()
    {
        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;
            
        }
        else if (!paused)
        {
            Time.timeScale = 1;
           
        }
    }

    
}
