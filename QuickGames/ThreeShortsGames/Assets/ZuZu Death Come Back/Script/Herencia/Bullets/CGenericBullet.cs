using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu
{

    public class CGenericBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static explicit operator GameObject(CGenericBullet v)
    {
        throw new NotImplementedException();
    }
}
}
