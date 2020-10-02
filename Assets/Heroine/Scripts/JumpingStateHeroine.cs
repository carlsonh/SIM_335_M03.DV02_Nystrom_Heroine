using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingStateHeroine : IHeroineState
{
    public Rigidbody rbPlayer;

    public void Enter(Heroine player)
    {
        rbPlayer = player.rb;
    }

    public void Execute(Heroine player)
    {
        if (rbPlayer.velocity.magnitude <= 0.01f)
        {//Exiting this state

            player.heroineState = new StandingStateHeroine();
            player.heroineState.Enter(player);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {//Go to diving

            player.heroineState = new DivingStateHeroine();
            player.heroineState.Enter(player);
        }
    }
}
