using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2f;
  
   public void Update()
    {
       transform.Rotate(0, 0, 360 * speed * Time.deltaTime); 
    }
}