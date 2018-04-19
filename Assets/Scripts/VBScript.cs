using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler {

    //private GameObject vbButtonObject;
    private GameObject pokemon;
    private Animator animator;
    private AudioSource audio;
    public string pokemonName;

    // Use this for initialization
    void Start () {
        //vbButtonObject = GameObject.Find("actionButton");
        pokemon = GameObject.Find(pokemonName);
        animator = pokemon.GetComponent<Animator>();
        audio = pokemon.GetComponent<AudioSource>();
        this.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button pressed");
        animator.Play("Anim001", -1, 0F);
        audio.Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button released");
    }

}
