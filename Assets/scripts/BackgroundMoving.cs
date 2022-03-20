using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour
{
	[SerializeField]private float speed;
	[SerializeField]private Transform finishPos;  //Позиция, в которой картинка за камерой
	[SerializeField]private Transform startPos;   //Позиция, в которой респанится картинка

    void Start()
    {
        
    }

    void Update()
    {
       transform.Translate(Vector2.left * Time.deltaTime * speed * 0.8f);
       if(transform.position.x <= finishPos.position.x){
       		transform.position = startPos.position;
       }
    }
}
