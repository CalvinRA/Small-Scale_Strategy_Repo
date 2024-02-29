using UnityEngine;

[CreateAssetMenu]
public class Unit : ScriptableObject
{
    public MovementID MovementType;
    public WeaponID PrimaryDamageType;
    public WeaponID SecondaryDamageType;
    public float PrimaryWeaponDamage;
    public float SecondaryWeaponDamage;
    public int MoveRange;
    public int PrimaryAmmo;
    public int Fuel;
    public float Health;

}
