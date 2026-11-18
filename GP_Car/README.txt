========================================================================
                          PROJETO GP CAR
             Sistema de Gerenciamento e Locação de Veículos
========================================================================

DESENVOLVEDOR:
- Joaquim Morais

------------------------------------------------------------------------
1. PRÉ-REQUISITOS
------------------------------------------------------------------------
Para executar o sistema, você precisará de:
1. Windows 10 ou 11 (64-bit).
2. Servidor MySQL instalado e rodando (Porta padrão 3306).
   - O aplicativo já vem configurado de fábrica para a senha: 1234
   - Usuário: root

------------------------------------------------------------------------
2. PREPARAÇÃO DO BANCO DE DADOS (MYSQL)
------------------------------------------------------------------------
Antes de abrir o aplicativo pela primeira vez:
1. Abra seu gerenciador MySQL (MySQL Workbench, DBeaver ou HeidiSQL).
2. Abra o arquivo 'database.sql' (presente nesta pasta).
3. Execute todo o script.
   -> Ele criará automaticamente o banco 'gp_car_db' e as tabelas:
      - veiculo
      - cliente
      - aluguel
      - vistoria
   -> E já inserirá veículos e clientes de teste com diferentes status.

------------------------------------------------------------------------
3. COMO EXECUTAR O APLICATIVO
------------------------------------------------------------------------
OPÇÃO A - EXECUTÁVEL DIRETO (SEM PRECISAR DE VISUAL STUDIO):
- Basta dar dois cliques no arquivo executável:
  GP_car.exe
  (Ele já contém todas as dependências do C# e .NET embutidas).

OPÇÃO B - PELO VISUAL STUDIO:
1. Abra o arquivo de projeto 'GP_car.csproj' no Visual Studio 2022.
2. Pressione a tecla F5 (ou clique em Iniciar).

------------------------------------------------------------------------
4. FUNCIONALIDADES DO SISTEMA
------------------------------------------------------------------------
- GESTÃO DE VEÍCULOS E STATUS:
  * Exibição visual com cores de status:
    - Verde: Disponível para nova locação.
    - Vermelho: Alugado.
    - Amarelo: Em Manutenção preventiva/corretiva.
  * Filtro instantâneo por placa, marca ou modelo.
  * Ações rápidas: Enviar para manutenção ou disponibilizar veículo.
  * Cadastro e edição com validação de placa duplicada.

- CADASTRO DE CLIENTES:
  * Cadastro de clientes com validação de CNH e telefone.
  * Busca em tempo real e listagem organizada.

- TESTE DE BANCO:
  * Botão 'Testar MySQL' no rodapé do menu lateral para validar a conexão.
========================================================================
