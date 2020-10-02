using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingStateHeroine : IHeroineState
{
    public Rigidbody rbPlayer;
    public void Enter(Heroine player)
    {
        rbPlayer = player.rb;
        rbPlayer.transform.localScale *= 0.5f;
        player.GetComponent<MeshFilter>().mesh = player.duckingMesh;
    }

    public void Execute(Heroine player)
    {
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {//Exiting this state
            rbPlayer.transform.localScale = Vector3.one;

            player.GetComponent<MeshFilter>().mesh = player.standingMesh;

            player.heroineState = new StandingStateHeroine();
            player.heroineState.Enter(player);
        }
    }
}
