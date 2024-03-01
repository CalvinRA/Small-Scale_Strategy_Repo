using UnityEngine;

[CreateAssetMenu]
public class UnitID : ScriptableObject
{
    public MovementID MovementType;
    public WeaponID PrimaryDamageType;
    public WeaponID SecondaryDamageType;
    public float PrimaryWeaponDamage;
    public float SecondaryWeaponDamage;
    public int MoveRange;
    public int PrimaryAmmoTotal;
    public int PrimaryAmmoCount;
    public int FuelTotal;
    public int FuelCount;
    public float Health;
}
