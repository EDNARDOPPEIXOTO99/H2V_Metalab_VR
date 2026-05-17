// ============================================================
// H2V_Metalab_VR — Avançado
// Script: TesteInteracoes.cs
// Corrigido para usar o novo Input System (Unity 6 + Meta XR)
// Teclas: [1] LED  [2] Tanque  [3] Painel  [4] Sensor  [0] Status
// Autor: Ednardo Pinheiro Peixoto
// Residência TIC 29 — Web 3.0 | Maio 2026
// ============================================================

using UnityEngine;
using UnityEngine.InputSystem;

public class TesteInteracoes : MonoBehaviour
{
    private AlertaLedController  alertaLed;
    private TanqueH2Controller   tanqueH2;
    private PainelInfoController painelInfo;
    private SensorProximidade    sensorMQ8;
    private bool simulandoProximidade = false;

    void Start()
    {
        alertaLed  = FindObjectOfType<AlertaLedController>();
        tanqueH2   = FindObjectOfType<TanqueH2Controller>();
        painelInfo = FindObjectOfType<PainelInfoController>();
        sensorMQ8  = FindObjectOfType<SensorProximidade>();

        Debug.Log("=======================================");
        Debug.Log("[H2VSENSE] MODO DE TESTE ATIVADO");
        Debug.Log("  [1] AlertaLed  -> " + (alertaLed  != null ? "OK" : "NAO ENCONTRADO"));
        Debug.Log("  [2] TanqueH2   -> " + (tanqueH2   != null ? "OK" : "NAO ENCONTRADO"));
        Debug.Log("  [3] PainelInfo -> " + (painelInfo != null ? "OK" : "NAO ENCONTRADO"));
        Debug.Log("  [4] SensorMQ8  -> " + (sensorMQ8  != null ? "OK" : "NAO ENCONTRADO"));
        Debug.Log("=======================================");
    }

    void Update()
    {
        var kb = Keyboard.current;
        if (kb == null) return;

        if (kb.digit1Key.wasPressedThisFrame)
        {
            if (alertaLed != null) { alertaLed.AlternarEstado(); Debug.Log("[TESTE] Tecla 1 -> AlertaLed alternado!"); }
            else Debug.LogWarning("[TESTE] AlertaLedController nao encontrado!");
        }

        if (kb.digit2Key.wasPressedThisFrame)
        {
            if (tanqueH2 != null) { tanqueH2.AtivarTanque(); Debug.Log("[TESTE] Tecla 2 -> TanqueH2 ativado!"); }
            else Debug.LogWarning("[TESTE] TanqueH2Controller nao encontrado!");
        }

        if (kb.digit3Key.wasPressedThisFrame)
        {
            if (painelInfo != null) { painelInfo.AlternarPainel(); Debug.Log("[TESTE] Tecla 3 -> PainelInfo alternado!"); }
            else Debug.LogWarning("[TESTE] PainelInfoController nao encontrado!");
        }

        if (kb.digit4Key.wasPressedThisFrame)
        {
            if (sensorMQ8 != null)
            {
                simulandoProximidade = !simulandoProximidade;
                sensorMQ8.SimularProximidade(simulandoProximidade);
                Debug.Log("[TESTE] Tecla 4 -> Sensor MQ8 " + (simulandoProximidade ? "ATIVO!" : "desativado"));
            }
            else Debug.LogWarning("[TESTE] SensorProximidade nao encontrado!");
        }

        if (kb.digit0Key.wasPressedThisFrame)
        {
            Debug.Log("=== STATUS ===");
            Debug.Log("AlertaLed:  " + (alertaLed  != null ? "OK" : "FALTANDO"));
            Debug.Log("TanqueH2:   " + (tanqueH2   != null ? "OK" : "FALTANDO"));
            Debug.Log("PainelInfo: " + (painelInfo != null ? "OK" : "FALTANDO"));
            Debug.Log("SensorMQ8:  " + (sensorMQ8  != null ? "OK" : "FALTANDO"));
        }
    }
}
