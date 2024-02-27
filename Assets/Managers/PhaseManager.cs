using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Numerics;
using System.Text;


class PhaseManager
{
    public enum Phases
    {
        Selection,
        Activation
    }
    Phases phase;

    public PhaseManager()
    {

        init();
        
    }
    void init()
    {
        phase = Phases.Selection;

    }



    public void NextPhase()
    {
        
        phase++;    
    }

    public void ChangePhase(int targetphase)
    {
        
        phase = (Phases)targetphase;
    }
    public Phases GetCurrentPhase()
    {

        return phase;

    }

    

}



