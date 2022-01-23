using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private int hits = 1;
    [SerializeField] private int points = 100;
    [SerializeField] Vector3 rotator;
    [SerializeField] Material hitMaterial;
    Material _originalMaterial;
    Renderer _renderer; //access current material, responsible to render what's on the screen

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotator * (transform.position.x + transform.position.y) * 0.1f);
        _renderer = GetComponent<Renderer>();
        _originalMaterial = _renderer.sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime); //deltatime helps rotate the speed at the same regardless of your computer refreshrate
    }

    private void OnCollisionEnter(Collision collision) {
        hits--;
        //Score points
        if(hits <= 0){
            Destroy(gameObject);
        }

        _renderer.sharedMaterial = hitMaterial;

        Invoke("RestoreMaterial", 0.05f); //return to its original color after 5 seconds
        
    }

    void RestoreMaterial(){
        _renderer.sharedMaterial = _originalMaterial;
    }
}
