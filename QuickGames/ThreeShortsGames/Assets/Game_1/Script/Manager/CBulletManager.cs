using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Game_1;
public class CBulletManager : MonoBehaviour
{
    public List<CGenericBullet> _ListBullets = new List<CGenericBullet>();
    [SerializeField]public CGenericBullet[] _genericBullet;

    //Singleton
    private  static CBulletManager Inst
    {
        get
        {
            if (Inst == null)
            {
                GameObject obj = new GameObject("BulletManager");
                return obj.AddComponent<CBulletManager>();
            }
            return _inst;
        }
    }

    public static CBulletManager _inst;


    public void SpawnBullet(Vector2 Pos)
    {
        GameObject obj = (GameObject)Instantiate(_genericBullet[0], Pos, Quaternion.identity);
        CGenericBullet newBullet = obj.AddComponent<CGenericBullet>();
        _ListBullets.Add(newBullet);

    }
}
