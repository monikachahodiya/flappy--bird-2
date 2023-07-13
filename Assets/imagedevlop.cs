using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagedevlop : MonoBehaviour
{
   public  GameObject Image;
    int i = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("imagespawner",1f,3f);
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
    public void imagespawner()
    {
        Instantiate(Image, new Vector2(16f*i,0.02f),Quaternion.identity);
        i++;
    }
}
