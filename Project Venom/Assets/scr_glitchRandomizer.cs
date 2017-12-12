using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Kino;

public class scr_glitchRandomizer : MonoBehaviour {

    public float minGitchTimer;
    public float maxGlitchTimer;
    float glitchTimer;

	// Use this for initialization
	void Start () {

        gameObject.GetComponent<Datamosh>().Glitch();
        glitchTimer = Random.Range(minGitchTimer,maxGlitchTimer);

	}
	
	// Update is called once per frame
	void Update () {
		
        if (glitchTimer > 0)
        {

            glitchTimer -= 1;

        }
        else if (glitchTimer <= 0)
        {

            glitchTimer = Random.Range(minGitchTimer, maxGlitchTimer);
            gameObject.GetComponent<Datamosh>().Glitch();

        }

	}
}
