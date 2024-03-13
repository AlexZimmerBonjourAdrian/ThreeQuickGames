using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Jobs;

public class CArmShooter : MonoBehaviour
{
    [SerializeField]private Transform _ArmWeaponTrasnform;
    [SerializeField] private Transform _AimTrasnform;
    [SerializeField]private Vector2 _LookRotation;

    [SerializeField] private float _Speed = 3f;

     
   

    void Update()
    {
        RotationArmLookAim();
    }
    public void RotationArmLookAim()
    {
      
        //_ArmWeaponTrasnform.rotation = Quaternion.Slerp(_ArmWeaponTrasnform.rotation, _AimTrasnform.position, _Speed * Time.deltaTime);
    }

}
