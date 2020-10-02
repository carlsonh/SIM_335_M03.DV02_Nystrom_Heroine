using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Heroine : MonoBehaviour
{

    public IHeroineState heroineState = new StandingStateHeroine();
    public Rigidbody rb;

    public Mesh duckingMesh;

    public Mesh standingMesh;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        heroineState.Enter(this);
    }

    private void Update()
    {
        heroineState.Execute(this);
    }


}
