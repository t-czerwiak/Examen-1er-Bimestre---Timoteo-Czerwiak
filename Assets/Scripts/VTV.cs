using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kmRecorridos;
    public int vencimientoVTVAct;
    public int hcPPM;
    float promedio;
    int añoActual = 2025;
    void Start()
    {
        if ((patente == "") || (modelo < 1900 || modelo > añoActual) || (kmRecorridos < 0) ||
            (vencimientoVTVAct > añoActual || vencimientoVTVAct < modelo) || (hcPPM < 5 || hcPPM > 100))
        {
            Debug.Log("Error, VTV no aprobada");
            return;
        }

        promedio = kmRecorridos / (añoActual - modelo);

        if (promedio < 10000)
        {
            Debug.Log("Felicitaciones, VTV otorgada por dos (2) años");
            return;
        }

        else if (promedio >= 10000)
        {
            Debug.Log("Felicitaciones, VTV otorgada por un (1) año");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
