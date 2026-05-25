H2V_Metalab_VR — Laboratorio VR Interativo de Hidrogenio Verde
==============================================================
Autor      : Ednardo Pinheiro Peixoto
Residencia : Web 3.0 - Residencia em TIC 29
Instituicao: IREDE / SOFTEX / MCTI
Data       : Maio de 2026
Repositorio: https://github.com/EDNARDOPPEIXOTO99/H2V_Metalab_VR


==============================================================
  PARTE 1 — ATIVIDADE BASICA
  Projeto Final: Meu Primeiro Ambiente VR
==============================================================

DESCRICAO
---------
Ambiente de Realidade Virtual desenvolvido em Unity 6.3 LTS,
simulando um galpao industrial de monitoramento de H2 verde.
Contem skybox de ceu aberto, objetos 3D primitivos e importados
e 3 interacoes funcionais via ISDK_HandGrabInteraction.


COMO ABRIR O PROJETO
--------------------
1. Abrir o Unity Hub
2. Clicar em Open (Abrir projeto existente)
3. Navegar ate a pasta H2V_Metalab_VR/
4. Abrir a cena: Assets/Scenes/SampleScene.unity
5. Pressionar Play (triangulo) no Unity Editor


NAVEGACAO NO EDITOR (PC)
------------------------
- Mover camera   : Botao direito + W A S D
- Subir / Descer : Botao direito + E (sobe) / Q (desce)
- Rotacionar     : Alt + botao esquerdo + arrastar
- Zoom           : Scroll do mouse
- Focar objeto   : Selecionar na Hierarchy + tecla F


OBJETOS DA CENA (minimo 5 exigido — 11 presentes)
--------------------------------------------------
- Piso_Principal   : Chao navegavel do galpao (Plane)
- Paredes (5x)     : Estrutura do galpao com textura de tijolo
- Porta_Entrada    : Acesso ao laboratorio (Cube)
- Tanque_H2        : Tanque de armazenamento de H2 (Cylinder)
- Sensor_MQ8       : Sensor portatil de gas H2 (Sphere)
- Painel_Info      : Painel de monitoramento (Cube)
- Alerta_Led       : Indicador visual de alerta (Sphere)
- Mesa_Controle    : Estacao central de controle (Cube)
- Mesa Central     : Mesa auxiliar do operador (Cube)
- Cadeira_Controle : Posto do operador (modelo 3D importado)
- Laptop           : Interface do dashboard (modelo 3D importado)


INTERACOES (3 — Atividade Basica)
----------------------------------
1. Sensor_MQ8   — ISDK_HandGrabInteraction (grab no sensor)
2. Alerta_Led   — ISDK_HandGrabInteraction (grab no indicador)
3. Laptop/Screen— ISDK_HandGrabInteraction (grab na tela)


CONFIGURACAO TECNICA
--------------------
- Unity 6.3 LTS (6000.3.15f1)
- Meta XR All-in-One SDK instalado via Package Manager
- [BuildingBlock] Camera Rig (Meta XR SDK)
- Build Settings: Android / API Min 32 / Target 34 / ASTC
- XR Plugin Management: Oculus (Android) + OpenXR (PC)
- Meta XR Simulator: Quest 3 virtual (sem hardware fisico)
- Project Setup Tool: 0 erros criticos / 97+ itens verificados
- Render Pipeline: URP (Universal Render Pipeline)


ORGANIZACAO
-----------
Hierarquia organizada em grupos logicos:
  [BuildingBlock] Camera Rig
  XR Interaction Manager
  CENARIO > GALPAO (Piso, Paredes, Porta)
  LAB_OBJETOS (Tanque, Sensor, Painel, Led, Mesas, Cadeira, Laptop)
  XR_SYSTEM > XR Origin (VR)
  LIGHTING > Directional Light


==============================================================
  PARTE 2 — ATIVIDADE AVANCADA
  Unidade 1, Capitulo 3: Fundamentos do Metaverso
  Criando sua Primeira Experiencia VR Interativa
==============================================================

DESCRICAO
---------
Mesmo ambiente da atividade basica, expandido com contexto
tematico explicito no Metaverso e 5 interacoes funcionais.
Representa um laboratorio industrial de monitoramento de H2
verde no metaverso industrial e educacional.


CONTEXTO E OBJETIVOS NO METAVERSO
----------------------------------
O H2V_Metalab_VR e um ambiente de metaverso industrial com
quatro objetivos:

1. Treinamento tecnico — simular procedimentos de seguranca
   em plantas de H2 sem risco fisico real

2. Educacao imersiva — demonstrar o sistema H2VSENSE de forma
   interativa para estudantes e tecnicos

3. Comunicacao tecnica — apresentar o projeto a parceiros e
   investidores no metaverso como demonstracao viva

4. Prototipagem digital — gemea digital simplificada da planta
   H2 da Peixoto Energy (base para expansao com IoT/MQTT)


INTERACOES (5 — Atividade Avancada)
-------------------------------------
1. Sensor_MQ8    — grab → inspecao do sensor portatil de H2
2. Alerta_Led    — grab → verificacao do indicador de alerta
3. Laptop/Screen — grab → acesso ao dashboard H2VSENSE
4. Painel_Info   — grab → painel de status do sistema
5. Tanque_H2     — grab → inspecao visual do tanque industrial

Todas as interacoes usam ISDK_HandGrabInteraction do Meta XR SDK
e sao coerentes com o contexto de um laboratorio real de H2.


PROCESSO DE CRIACAO E DIFICULDADES
------------------------------------
Fase 1 — Configuracao:
  Maior desafio: Meta XR SDK sem suporte oficial para Unity 6.
  Solucao: Meta XR All-in-One SDK + 97 correcoes via Project
  Setup Tool. Resultado: 0 erros criticos em runtime.

Fase 2 — Ambiente:
  Galpao construido com primitivos Unity + texturas URP.
  Modelos 3D (cadeira, laptop) importados da Asset Store.
  Hierarquia planejada previamente para manter organizacao.

Fase 3 — Interacoes:
  5 interacoes ISDK configuradas e testadas individualmente.
  Cada objeto exigiu Rigidbody (Is Kinematic=true) para o
  ISDK_HandGrabInteraction funcionar corretamente.

Desafios especificos:
  - SDK/Unity 6 incompativel: resolvido com Project Setup Tool
  - Sem Quest fisico: uso do Meta XR Simulator (Quest 3 virtual)
  - Erro NaN no Sensor_MQ8: corrigido com Rigidbody Is Kinematic
  - Materiais Legacy incompativeis com URP: convertidos via
    Edit > Rendering > Convert Materials


DOCUMENTACAO
------------
README.md                      : documentacao principal (GitHub)
README.txt                     : este arquivo (instrucoes basicas)
Relatorio_Tecnico_Basico.docx  : relatorio da atividade basica
Relatorio_Tecnico_Avancado.docx: relatorio da atividade avancada
link_repositorio.txt           : link para entrega no Homero


REPOSITORIO
-----------
https://github.com/EDNARDOPPEIXOTO99/H2V_Metalab_VR