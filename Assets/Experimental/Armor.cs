using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    enum ArmorType
    {
        None,
        Ablative,
        Thermal,
        Reflective

    };

    ArmorType armorType = ArmorType.None;

    void ChangeArmor()
    {
        switch (armorType)
        {
            case ArmorType.None:
                {
                    armorType++;
                    print(armorType);
                    break;
                }
            case ArmorType.Ablative:
                {
                    armorType++;
                    print(armorType);
                    break;
                }
            case ArmorType.Thermal:
                {
                    armorType++;
                    print(armorType);
                    break;
                }
            case ArmorType.Reflective:
                {
                    armorType = ArmorType.Ablative;
                    print(armorType);
                    break;
                }
        }
    }
}

