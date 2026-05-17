# 🌐 H2V_Metalab_VR

### Laboratório VR Interativo de Hidrogênio Verde

| | |
|---|---|
| 👨‍💻 **Autor** | Ednardo Pinheiro Peixoto |
| 🎓 **Residência** | Web 3.0 – Residência em TIC 29 |
| 🏫 **Instituição** | IREDE / SOFTEX / MCTI |
| 📅 **Data** | Maio de 2026 |
| 🔗 **Repositório** | https://github.com/EDNARDOPPEIXOTO99/H2V_Metalab_VR |

---

## 📌 Apresentando o Projeto

O **H2V_Metalab_VR** é um ambiente de Realidade Virtual desenvolvido em **Unity 6.3 LTS**, inspirado no projeto **H2VSENSE** da Peixoto Energy — sistema IoT de detecção inteligente de vazamento de hidrogênio verde.

O laboratório simula um **galpão industrial** de 20m × 10m × 5m com equipamentos reais de uma planta de H₂ verde e **4 interações funcionais** implementadas em C#, testadas e confirmadas no Unity Editor.

---

## 🎯 Contexto e Objetivos

O **H2V_Metalab_VR** representa um ambiente industrial de monitoramento de segurança para H₂ verde no **Metaverso**, com objetivos claros:

- **Treinamento técnico industrial** — simular procedimentos de segurança em plantas de hidrogênio para capacitação de operadores
- **Educação imersiva** — demonstrar o funcionamento do sistema H2VSENSE de forma interativa e navegável
- **Comunicação técnica** — apresentar o projeto a parceiros e investidores em formato de metaverso
- **Prototipagem digital** — testar layouts e fluxos de monitoramento antes da implementação física

O projeto conecta o mundo físico (hardware H2VSENSE com sensores MQ-8, ESP32-S3, MQTT) com o metaverso, criando uma **gêmea digital simplificada** da planta de H₂ verde da Peixoto Energy.

---

## 🎮 Interações Implementadas em C#

O projeto contém **4 interações funcionais** testadas e confirmadas no Console do Unity:

| Tecla | Script | Objeto | Console Output |
|---|---|---|---|
| **[1]** | `AlertaLedController.cs` | Alerta_Led | `[H2VSENSE] ⚠️ ALERTA ATIVADO — Vazamento detectado!` |
| **[2]** | `TanqueH2Controller.cs` | Tanque H2 | `[H2VSENSE] 🔵 Tanque H₂ ativado — verificando pressão...` |
| **[3]** | `PainelInfoController.cs` | Painel_Info | `[H2VSENSE] 📊 Painel de dados aberto` |
| **[4]** | `SensorProximidade.cs` | Sensor_MQ8 | `[H2VSENSE] 🔴 Sensor MQ-8 ativado — H₂ detectado!` |
| **[0]** | `TesteInteracoes.cs` | GameManager | Status ✅ ou ❌ de cada script no Console |

### Detalhes de cada interação

#### 🔴 Alerta_Led — AlertaLedController.cs
Clica no LED (tecla **[1]**) → alterna entre **NORMAL** (verde contínuo) e **ALERTA** (vermelho piscando), simulando o comportamento real do sensor H2VSENSE ao detectar vazamento de H₂.

#### 🔵 Tanque H2 — TanqueH2Controller.cs
Clica no tanque (tecla **[2]**) → executa animação de **pulsação de escala** (2 ciclos) com leitura simulada de pressão (120–350 bar) e status exibido no Console.

#### 🟣 Painel_Info — PainelInfoController.cs
Clica no painel (tecla **[3]**) → abre **dashboard em tempo real** com temperatura, pressão, nível de H₂ (%LEL) e status do sistema, atualizando a cada 1.5 segundos via Coroutine.

```
[H2VSENSE] Temp: 32,4°C | Pressão: 1,12bar | H₂: 3,02%LEL | Status: 🔴 ALERTA CRÍTICO
[H2VSENSE] Temp: 29,1°C | Pressão: 1,07bar | H₂: 1,04%LEL | Status: ⚠️ ATENÇÃO
```

#### 🟢 Sensor_MQ8 — SensorProximidade.cs
Aproximar do sensor (tecla **[4]**) → sensor muda para **amarelo** + exibe mensagem de alerta na UI. Ao se afastar, normaliza automaticamente após 2 segundos.

---

## 🏭 Estrutura do Galpão Industrial

```
Galpão: 20m largura × 10m profundidade × 5m altura
├── Piso_Principal     (Plane  — chão navegável)
├── Parede_Fundo       (Cube   — 20×5×0.3)
├── Parede_Frente_L    (Cube   — 8×5×0.3)
├── Parede_Frente_R    (Cube   — 8×5×0.3)
├── Parede_Esquerda    (Cube   — 0.3×5×10)
├── Parede_Direita     (Cube   — 0.3×5×10)
├── Cobertura_Telhado  (Cube   — 20×0.2×10)
└── Porta_Entrada      (Cube   — 4×5×0.1)
```

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão / Detalhes |
|---|---|
| **Unity** | 6.3 LTS (6000.3.15f1) |
| **Meta XR All-in-One SDK** | Instalado via Package Manager |
| **XR Plugin Management** | Oculus (Android) + OpenXR (PC) |
| **Android Build Support** | API Min 32 · Target 34 · ASTC |
| **Render Pipeline** | URP (Universal Render Pipeline) |
| **Linguagem** | C# (5 scripts de interação) |
| **Project Setup Tool** | 0 erros · 97+ itens verificados ✓ |

---

## ▶️ Como Executar o Projeto

1. Abrir o **Unity Hub**
2. Clicar em **Open** → navegar até `H2V_Metalab_VR/`
3. Abrir a cena: `Assets/Scenes/H2V_Metalab_VR.unity`
4. Pressionar **Play (▶)** no Unity Editor
5. Clicar na aba **Game**

### Controles de Navegação (PC/Notebook)

| Ação | Controle |
|---|---|
| Mover câmera | Botão direito + **W A S D** |
| Subir / Descer | Botão direito + **E** / **Q** |
| Rotacionar visão | **Alt** + botão esquerdo |
| Zoom | Scroll do mouse |
| Focar em objeto | Selecionar + tecla **F** |

### Testar Interações por Teclado

| Tecla | Interação |
|---|---|
| **[0]** | Mostra status de todos os scripts no Console |
| **[1]** | Alerta_Led — alterna normal/alerta |
| **[2]** | Tanque H2 — pulsação + leitura de pressão |
| **[3]** | Painel_Info — abre/fecha dashboard |
| **[4]** | Sensor_MQ8 — simula detecção de H₂ |

---

## 🧱 Estrutura do Projeto

```
H2V_Metalab_VR/
├── Assets/
│   ├── Materials/           ← 9 materiais coloridos por objeto
│   │   ├── Mat_Tanque_H2.mat      (azul  #1A5276)
│   │   ├── Mat_Sensor_MQ8.mat     (verde #1E8449)
│   │   ├── Mat_Painel_Info.mat    (roxo  #6C3483)
│   │   ├── Mat_Mesa_Controle.mat  (marrom #784212)
│   │   ├── Mat_Alerta_Led.mat     (vermelho #C0392B)
│   │   ├── Mat_Piso.mat           (cinza claro)
│   │   ├── Mat_Parede.mat         (cinza industrial)
│   │   └── Mat_Telhado.mat        (cinza escuro metálico)
│   ├── Oculus/              ← Meta XR SDK assets
│   ├── Scenes/
│   │   └── H2V_Metalab_VR.unity
│   ├── Scripts/             ← 5 scripts C# comentados
│   │   ├── AlertaLedController.cs
│   │   ├── TanqueH2Controller.cs
│   │   ├── PainelInfoController.cs
│   │   ├── SensorProximidade.cs
│   │   └── TesteInteracoes.cs
│   ├── Settings/
│   └── README.txt
├── Packages/                ← Meta XR SDK (manifest.json)
├── ProjectSettings/         ← Build Android, XR Plugin Management
├── README.md
├── .gitignore
└── link_repositorio.txt
```

---

## 🎮 Hierarquia da Cena

```
H2V_Metalab_VR (Scene)
├── Global Volume
├── XR Interaction Manager
├── [GALPAO]
│   ├── Piso_Principal
│   ├── Parede_Fundo
│   ├── Parede_Frente_L / Parede_Frente_R
│   ├── Parede_Esquerda / Parede_Direita
│   ├── Cobertura_Telhado
│   └── Porta_Entrada
├── [LAB_OBJETOS]
│   ├── Tanque H2       ← TanqueH2Controller.cs
│   ├── Sensor_MQ8      ← SensorProximidade.cs
│   ├── Painel_Info     ← PainelInfoController.cs
│   ├── Alerta_Led      ← AlertaLedController.cs
│   └── Mesa_Controle
├── [XR_SYSTEM]
│   └── XR Origin (VR)
│       └── Camera Offset
│           └── Main Camera
├── [LIGHTING]
│   └── Directional Light
├── UI
└── GameManager         ← TesteInteracoes.cs
```

---

## 🔨 Processo de Criação e Dificuldades

### Como o projeto foi desenvolvido

1. Configuração do Unity 6.3 LTS com Meta XR All-in-One SDK e XR Plugin Management
2. Build Settings Android: API Min 32, Target 34, ASTC — confirmado no Project Setup Tool (0 erros)
3. Construção do galpão industrial com 6 Cubes dimensionados (20m × 10m × 5m)
4. Inserção dos 5 objetos do laboratório como primitivos Unity
5. Criação de 9 materiais coloridos distintos para identificação visual
6. Desenvolvimento dos 4 scripts C# de interação com lógica real do H2VSENSE
7. Criação do GameManager com TesteInteracoes.cs para validação por teclado
8. Testes funcionais confirmados — logs [H2VSENSE] no Console para todas as 4 interações
9. Commit e push para GitHub com estrutura completa

### Principais dificuldades e soluções

- **Conflito Input System** — `UnityEngine.Input` incompatível com novo Input System → resolvido usando `Keyboard.current` do `UnityEngine.InputSystem`
- **Câmera duplicada** ao adicionar XR Origin → remoção da Main Camera avulsa
- **Collider deslocado** no Tanque (Center X:5.96, Z:-8.94) → Reset no Inspector
- **API Level 29** rejeitado → corrigido para Min 32 / Target 34
- **Espaço em disco** insuficiente → liberação de ~7 GB

---

## 🚀 Melhorias Futuras

- [ ] Build APK e testes no Meta Quest 2/3
- [ ] Integração com dados IoT reais do H2VSENSE via MQTT
- [ ] Animação da Porta_Entrada por proximidade
- [ ] Sistema de partículas de vapor no Tanque H2
- [ ] Canvas/UI World Space com dashboard visível no galpão
- [ ] Multiplayer colaborativo com Photon PUN2

---

## 📚 Contexto Acadêmico

> Projeto desenvolvido como **Projeto Final — Meu Primeiro Ambiente VR (Nível básico e Avançado)**
> Trilha de Metaverso – Web 3.0 | Residência em TIC 29
>
> ⚠️ Desenvolvido e testado no Unity Editor (PC/notebook), sem dispositivo VR físico,
> conforme permitido pela proposta da atividade.

---

## 📎 Licença

Uso acadêmico e educacional.
