using UnityEngine;
/// <summary>
/// Permite el comportamiento de movimiento del jugador.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// Fuerza aplicada para aplicar el moivimiento.
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Representa el tiempo que a transcurrido desde la ultima aplicación de fuerzas
    /// </summary>
    private float tiempoDesdeLaUltimaFuerza;
    /// <summary>
    /// Indica cuanto tiempo debe aplicarse la fuerza.
    /// </summary>
    private float intervaloTiempo;
    #endregion

    #region Ciclo de vida del Script       
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300);
        tiempoDesdeLaUltimaFuerza = 0f;
        intervaloTiempo = 2f;

    }

    // Update is called once per frame
   private void FixedUpdate()
    {
       tiempoDesdeLaUltimaFuerza += Time.fixedDeltaTime;
         if (tiempoDesdeLaUltimaFuerza >= intervaloTiempo)
         {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeLaUltimaFuerza = 0f;
        }
    }

    #endregion
}
