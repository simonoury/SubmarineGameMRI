using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Player Movement Variables/....
   public static int movespeed = 1;
   public Vector3 userDirection = Vector3.right;

   public void Update()
   {
       transform.Translate(userDirection * movespeed * Time.deltaTime);
   }
}
