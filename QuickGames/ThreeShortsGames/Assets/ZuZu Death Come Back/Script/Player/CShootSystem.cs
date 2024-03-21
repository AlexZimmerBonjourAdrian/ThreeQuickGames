using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu
{

    public class CShootSystem : MonoBehaviour
{

    protected int Ammo;
    protected int AmmoInMag;
    protected bool IsShoot;
    protected bool CanReload;
    protected int MultiplyWeapon;

    //Dispara el arma
    protected virtual void Fire()
    {
        
    }

    //Recarga el arma
    protected virtual void Reload()
    {

    }
    
    //No poseo municion
    protected virtual void IsEmpty()
    {

    }

    //Tengo toda la municion?
    protected virtual void IsFull()
    {

    }

    //Tengo municion de reserva
    protected virtual void IsHaveAmmo()
    {

    }

    //Descueta la municion al momento de recargar y chequea si se puede recargar y si la municion que queda es correcta
    protected virtual void RecalculatedAmmo()
    {

    }
}

}



