using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public Image energy1;
    public Image energy2;
    public Image energy3;
    public Image energy4;
    public Image energy5;
    public Image energy6;
    public Image energy7;
    public Image energy8;

    int energy;

    public void Start()
    {
        energy1.enabled = false;
        energy2.enabled = false;
        energy3.enabled = false;
        energy4.enabled = true;
        energy5.enabled = false;
        energy6.enabled = false;
        energy7.enabled = false;
        energy8.enabled = false;
    }


    void Update()
    {
        energy = GameManager.energy;

        if (energy == 1)
        {
            energy1.enabled = true;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = false;

        }
        else if(energy == 2)
        {
            energy1.enabled = false;
            energy2.enabled = true;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = false;
        }
        else if(energy == 3)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = true;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = false;
        }
        else if (energy == 4)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = true;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = false;
        }
        else if(energy == 5)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = true;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = false;
        }
        else if(energy == 6)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = true;
            energy7.enabled = false;
            energy8.enabled = false;
        }
        else if(energy == 7)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = true;
            energy8.enabled = false;
        }
        else if(energy == 8)
        {
            energy1.enabled = false;
            energy2.enabled = false;
            energy3.enabled = false;
            energy4.enabled = false;
            energy5.enabled = false;
            energy6.enabled = false;
            energy7.enabled = false;
            energy8.enabled = true;
        }
    }
}
