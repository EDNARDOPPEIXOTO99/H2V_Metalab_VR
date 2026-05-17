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

O laboratório simula um **galpão industrial** de 20m × 10m × 5m com paredes de textura de tijolo, equipamentos reais de uma planta de H₂ verde, modelos 3D importados (cadeira e laptop) e **4 interações funcionais** implementadas em C#, testadas com **Meta XR Simulator** (Meta Quest 3 simulado).

---

## 🎯 Contexto e Objetivos

O **H2V_Metalab_VR** representa um ambiente industrial de monitoramento de H₂ verde no **Metaverso**:

- **Treinamento técnico industrial** — simular procedimentos de segurança em plantas de H₂
- **Educação imersiva** — demonstrar o sistema H2VSENSE de forma interativa
- **Comunicação técnica** — apresentar o projeto a parceiros e investidores no metaverso
- **Prototipagem digital** — gêmea digital simplificada da planta H₂ da Peixoto Energy

---

## 🎮 Interações Implementadas em C#

**4 interações funcionais testadas e confirmadas** — ativadas por teclado (TesteInteracoes.cs) ou pelo Meta XR Simulator:

| Tecla | Script | Objeto | Console Output |
|---|---|---|---|
| **[0]** | `TesteInteracoes.cs` | GameManager | Status ✅ de todos os scripts |
| **[1]** | `AlertaLedController.cs` | Alerta_Led | `[H2VSENSE] ALERTA ATIVADO — Vazamento detectado!` |
| **[2]** | `TanqueH2Controller.cs` | Tanque H2 | `[H2VSENSE] Tanque H₂ ativado — verificando pressão...` |
| **[3]** | `PainelInfoController.cs` | Painel_Info | `[H2VSENSE] Temp: 32,4°C \| Pressão: 1,12bar \| H₂: 3,02%LEL` |
| **[4]** | `SensorProximidade.cs` | Sensor_MQ8 | `[H2VSENSE] Sensor MQ-8 ativado — H₂ detectado!` |

---

## 🏭 Ambiente — Galpão Industrial

```
Galpão: 20m largura × 10m profundidade × 5m altura
Textura: Tijolo industrial em todas as paredes
├── Piso_Principal     — chão navegável (textura clara)
├── Parede_Fundo       — textura tijolo
├── Parede_Frente_L/R  — com abertura para Porta_Entrada
├── Parede_Esquerda    — textura tijolo
├── Parede_Direita     — textura tijolo
├── Cobertura_Telhado  — teto metálico
└── Porta_Entrada      — acesso ao laboratório
```

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão / Detalhes |
|---|---|
| **Unity** | 6.3 LTS (6000.3.15f1) |
| **Meta XR All-in-One SDK** | Instalado via Package Manager |
| **Meta XR Simulator** | Meta Quest 3 simulado — 72fps — Ativo ✅ |
| **BuildingBlock Camera Rig** | Substituiu XR Origin (VR) |
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

### Testar com Meta XR Simulator

1. **Meta XR Tools → Meta XR Simulator → Enable**
2. Pressionar **Play (▶)**
3. O Simulator abre com visão do Meta Quest 3
4. Navegar com mouse + teclado simulando o headset

### Testar Interações por Teclado

| Tecla | Interação |
|---|---|
| **[0]** | Status de todos os scripts no Console |
| **[1]** | Alerta_Led — alterna normal/alerta |
| **[2]** | Tanque H2 — pulsação + leitura de pressão |
| **[3]** | Painel_Info — abre/fecha dashboard |
| **[4]** | Sensor_MQ8 — simula detecção de H₂ |

---

## 🧱 Estrutura do Projeto

```
H2V_Metalab_VR/
├── Assets/
│   ├── Materials/           ← 10 materiais coloridos + Mat_Cadeira
│   ├── Modelos 3D/          ← cadeira e laptop (assets importados)
│   │   ├── cadeira/
│   │   └── laptop/
│   ├── Oculus/              ← Meta XR SDK assets
│   ├── Prints/              ← Screenshots do projeto
│   ├── Scenes/
│   │   └── H2V_Metalab_VR.unity
│   ├── Scripts/             ← 5 scripts C# comentados
│   │   ├── AlertaLedController.cs
│   │   ├── TanqueH2Controller.cs
│   │   ├── PainelInfoController.cs
│   │   ├── SensorProximidade.cs
│   │   └── TesteInteracoes.cs
│   ├── Textures/            ← Texturas das paredes (tijolo)
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
├── [BuildingBlock] Camera Rig   ← Meta XR Building Block
├── XR Interaction Manager
├── CENARIO
│   └── GALPAO
│       ├── Piso_Principal
│       ├── Parede_Fundo         ← textura tijolo
│       ├── Parede_Frente_L / R
│       ├── Parede_Esquerda / Direita
│       ├── Cobertura_Telhado
│       └── Porta_Entrada
├── LAB_OBJETOS
│   ├── Tanque H2       ← TanqueH2Controller.cs
│   ├── Sensor_MQ8      ← SensorProximidade.cs
│   ├── Painel_Info     ← PainelInfoController.cs
│   ├── Alerta_Led      ← AlertaLedController.cs
│   ├── Mesa_Controle
│   ├── Cadeira_Controle  ← modelo 3D importado
│   └── Laptop            ← modelo 3D importado
├── XR_SYSTEM
├── LIGHTING
│   └── Directional Light
├── UI
└── GameManager         ← TesteInteracoes.cs
```

---

## 🔨 Processo de Criação e Dificuldades

### Como o projeto foi desenvolvido

1. Configuração Unity 6.3 LTS + Meta XR All-in-One SDK + XR Plugin Management
2. Build Settings Android: API Min 32, Target 34, ASTC — 0 erros no Project Setup Tool
3. Substituição do XR Origin por **BuildingBlock Camera Rig** (Meta Building Block)
4. Construção do galpão industrial com texturas de tijolo nas paredes
5. Inserção dos 5 objetos do laboratório com materiais coloridos
6. Importação de modelos 3D externos (cadeira e laptop) para a Mesa_Controle
7. Desenvolvimento dos 4 scripts C# de interação comentados
8. Ativação e configuração do **Meta XR Simulator** (Meta Quest 3, 72fps)
9. Testes funcionais — logs [H2VSENSE] confirmados no Console
10. Organização da hierarquia em CENARIO/GALPAO, LAB_OBJETOS, XR_SYSTEM, LIGHTING

### Principais dificuldades e soluções

- **Conflito Input System** → resolvido com `Keyboard.current` do `UnityEngine.InputSystem`
- **Objetos abaixo do piso** → ajuste de Position Y para (Scale Y / 2) + altura do piso
- **Modelos 3D importados sem textura** → criação de Mat_Cadeira e aplicação manual
- **API Level 29 rejeitado** → corrigido para Min 32 / Target 34
- **Meta XR Simulator** — sessão interrompida → normal ao fechar o Play no Editor

---

## 🚀 Melhorias Futuras

- [ ] Build APK e testes no Meta Quest 2/3 físico
- [ ] Integração com dados IoT reais do H2VSENSE via MQTT
- [ ] Animação da Porta_Entrada por proximidade
- [ ] Canvas/UI World Space com dashboard no galpão
- [ ] Multiplayer colaborativo com Photon PUN2
- [ ] Narração em áudio ao se aproximar dos equipamentos

---

## 📚 Contexto Acadêmico

> Projeto desenvolvido como **Projeto Final — Meu Primeiro Ambiente VR**
> Trilha de Metaverso – Web 3.0 | Residência em TIC 29
>
> ⚠️ Desenvolvido e testado no Unity Editor (PC) com Meta XR Simulator,
> sem dispositivo VR físico, conforme permitido pela proposta da atividade.

---

## 📎 Licença

Uso acadêmico e educacional.
