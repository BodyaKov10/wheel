using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
	private Rigidbody2D rb;
	private Animator anim;
	private bool grounded;
   
    void Start()
    {
    	grounded = true;
    	rb = GetComponent<Rigidbody2D>();  
    	anim = GetComponent<Animator>();
    }

    void FixedUpdate(){

    }

    public void Jump(){                                                  //  Функция вызывается кнопкой
    	if(grounded == true){                                            //  если grounded = true
    		rb.AddForce(Vector2.up * 15f, ForceMode2D.Impulse);


    	}	
    }

    void OnTriggerEnter2D(Collider2D other){
    	if(other.tag == "ground"){
    		grounded = true;
    		anim.SetBool("jump", false);
    	}
    }
    void OnTriggerExit2D(Collider2D other){     
    	if(other.tag == "ground"){
    		grounded = false;
    		anim.SetBool("jump", true);
    	}
    }

}
