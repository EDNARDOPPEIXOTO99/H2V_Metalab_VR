// ============================================================
// H2V_Metalab_VR — Avançado
// Script: PainelInfoController.cs
// Objeto: Painel_Info
// Função: Ao clicar no painel, exibe/oculta um painel UI com
//         dados simulados do sistema H2VSENSE em tempo real
//         (temperatura, pressão, nível de H₂ e status).
// Autor: Ednardo Pinheiro Peixoto
// Residência TIC 29 — Web 3.0 | Maio 2026
// ============================================================

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PainelInfoController : MonoBehaviour
{
    // ── CONFIGURAÇÕES PÚBLICAS (editáveis no Inspector) ──────
    [Header("UI — Painel de Dados")]
    public GameObject painelDados;           // Painel UI com os dados
    public Text       textoTemperatura;      // Campo temperatura
    public Text       textoPressao;          // Campo pressão
    public Text       textoNivelH2;          // Campo nível H₂
    public Text       textoStatus;           // Campo status geral
    public Text       textoTitulo;           // Título do painel

    [Header("Simulação de Dados")]
    public float intervaloAtualizacao = 1.5f; // Segundos entre atualizações

    [Header("Cor do Painel")]
    public Color corAtivo   = new Color(0f, 0.7f, 0.6f); // Teal ativo
    public Color corInativo = Color.white;

    // ── VARIÁVEIS PRIVADAS ───────────────────────────────────
    private bool      painelAberto  = false;
    private Renderer  rend;
    private Material  mat;
    private Coroutine coroutineAtualizacao;

    // ─────────────────────────────────────────────────────────
    void Start()
    {
        rend = GetComponent<Renderer>();
        mat  = rend.material;

        // Painel começa fechado
        if (painelDados != null)
            painelDados.SetActive(false);

        // Define título do painel
        if (textoTitulo != null)
            textoTitulo.text = "═══ H2VSENSE MONITOR ═══";
    }

    // ─────────────────────────────────────────────────────────
    // MÉTODO PÚBLICO — chamado pelo OnSelect do XR Interactable
    // ou pelo clique do mouse no Editor
    // ─────────────────────────────────────────────────────────
    public void AlternarPainel()
    {
        painelAberto = !painelAberto;

        if (painelAberto)
            AbrirPainel();
        else
            FecharPainel();
    }

    // ─────────────────────────────────────────────────────────
    // Abre o painel e inicia atualização dos dados
    // ─────────────────────────────────────────────────────────
    private void AbrirPainel()
    {
        Debug.Log("[H2VSENSE] 📊 Painel de dados aberto.");
        mat.color = corAtivo;

        if (painelDados != null)
            painelDados.SetActive(true);

        // Atualiza dados imediatamente e inicia ciclo
        AtualizarDados();
        coroutineAtualizacao = StartCoroutine(CicloAtualizacao());
    }

    // ─────────────────────────────────────────────────────────
    // Fecha o painel e para a atualização
    // ─────────────────────────────────────────────────────────
    private void FecharPainel()
    {
        Debug.Log("[H2VSENSE] 📊 Painel de dados fechado.");
        mat.color = corInativo;

        if (painelDados != null)
            painelDados.SetActive(false);

        // Para o ciclo de atualização
        if (coroutineAtualizacao != null)
            StopCoroutine(coroutineAtualizacao);
    }

    // ─────────────────────────────────────────────────────────
    // Coroutine: atualiza dados a cada X segundos
    // ─────────────────────────────────────────────────────────
    private IEnumerator CicloAtualizacao()
    {
        while (painelAberto)
        {
            yield return new WaitForSeconds(intervaloAtualizacao);
            AtualizarDados();
        }
    }

    // ─────────────────────────────────────────────────────────
    // Gera dados simulados do H2VSENSE e atualiza a UI
    // ─────────────────────────────────────────────────────────
    private void AtualizarDados()
    {
        // Simulação de leituras do sensor (valores aleatórios realistas)
        float temperatura = Random.Range(18f, 35f);
        float pressao     = Random.Range(0.8f, 1.4f);
        float nivelH2     = Random.Range(0f, 4f);       // % LEL (Lower Explosive Limit)

        // Determina status baseado no nível de H₂
        string status;
        Color  corStatus;

        if (nivelH2 < 1f)
        {
            status    = "✅ NORMAL";
            corStatus = Color.green;
        }
        else if (nivelH2 < 2.5f)
        {
            status    = "⚠️ ATENÇÃO";
            corStatus = Color.yellow;
        }
        else
        {
            status    = "🔴 ALERTA CRÍTICO";
            corStatus = Color.red;
        }

        // Atualiza os campos de texto na UI
        if (textoTemperatura != null)
            textoTemperatura.text = $"🌡  Temperatura:  {temperatura:F1} °C";

        if (textoPressao != null)
            textoPressao.text = $"💨  Pressão:      {pressao:F2} bar";

        if (textoNivelH2 != null)
            textoNivelH2.text = $"⚗️  Nível H₂:    {nivelH2:F2}% LEL";

        if (textoStatus != null)
        {
            textoStatus.text  = $"Status: {status}";
            textoStatus.color = corStatus;
        }

        Debug.Log($"[H2VSENSE] Temp: {temperatura:F1}°C | Pressão: {pressao:F2}bar | " +
                  $"H₂: {nivelH2:F2}%LEL | Status: {status}");
    }

    // ─────────────────────────────────────────────────────────
    // Clique do mouse no Editor (testes sem VR)
    // ─────────────────────────────────────────────────────────
    private void OnMouseDown()
    {
        AlternarPainel();
    }
}
