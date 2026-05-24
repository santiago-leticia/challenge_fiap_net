<h1 align="center"> ADVANCED BUSINESS DEVELOPMENT WITH .NET </h1>
<h3 align="center">Challenge - FIAP - CYLVO</h3>

<h2 align="center" > Integrante </h2>

- EDUARDO BATISTA LOCASPI - RM5651713
- LIANA LYUMI MORISITA FUJISIMA - RM565698
- LETICIA SANTIAGO E SILVA - RM565799
- VICTOR ALVES LOPES - RM561833

<h2>Descrição sobre projeto: </h2>

<p>
	Como visto no tema do challenge, o objetivo da CLYVO é acompanhar a jornada contínua de saúde do pet, combatendo o problema da baixa recorrência nas clínicas. Como os animais não conseguem expressar o que sentem, é comum que os responsáveis só busquem auxílio veterinário em situações graves ou emergências.
	Essa cultura de atendimento reativo gera complicações no tratamento, uma vez que a ausência de um banco de dados unificado — com histórico de consultas e prontuários — pode levar a diagnósticos tardios.
	Diante desse cenário, nossa solução é um aplicativo que centraliza todas as informações essenciais para o veterinário, como idade, peso, espécie, raça, carteira de vacinação, histórico de consultas e dados do responsável. Além disso, o app permite o rastreamento da localização do pet, caso este não habite o mesmo domicílio que o responsável. A plataforma também disponibiliza uma agenda completa para o acompanhamento de consultas, permitindo que o usuário visualize marcações, cancelamentos ou alterações de data.
	Para estimular o fluxo de retorno e aumentar a frequência dos check-ups, o projeto prevê uma integração entre a clínica e o responsável por meio do WhatsApp. O sistema funcionará da seguinte forma: após um período determinado desde a última consulta, o responsável receberá uma mensagem automática com um convite para agendar o próximo check-up. Essa lógica também se aplica aos protocolos de vacinação. Em todos os casos, a mensagem oferecerá opções diretas para confirmar o agendamento ou optar por não realizá-lo no momento.
</p>

<h2>Sobre a parte de Dot .NET</h2>

<p>Função do projeto de .NET é servir como um sistema de backend CRUD, em que ele vai gerenciar os dados do projeto e suas funcionalidades presentes no banco de dados Mas também vai oferecer as APIS que possam fazer o frontend interagir com o banco de dados.</p>

<h2>Rotas Presente no Projeto: </h2>

<h4>Rota principal</h4>

- api/[controller]

<h4>Animal</h4>

- GET - All: relatorio/animal
- GET - ID: relatorio/animal/{id_animal:int}
- POST: criar/animal
- PUT: atualizar/animal/{id_animal:int}
- DELETE: deleta/animal/{id_animal:int}

<h4>Veterinário</h4>

- GET - ALL: relatorio/veterinario
- GET - ID: relatorio/veterinario/{id_vet:int}
- POST: criar/veterinario
- PUT: atualizar/veterinario/{id_vet:int}
- DELETE: deleta/veterinario/{id_vet:int}

<h4>Responsável</h4>

- GET - ALL: relatorio/responsavel
- GET - ID: relatorio/responsavel/{id_responsavel:int}
- POST: criar/responsavel
- PUT: atualizar/responsavel/{id_responsavel:int}
- DELETE: deleta/responsavel/{id_responsavel:int}

<h4>Consulta</h4>

- GET - ALL: relatorio/consulta
- GET - ID: relatorio/consulta/{id_consulta:int}
- POST: criar/consulta
- PUT: atualizar/consulta/{id_consulta:int}
- DELETE: deleta/consulta/{id_consulta:int}

<h4>Prescrição</h4>

- GET - ALL: relatorio/prescricao
- GET - ID: relatorio/prescricao/{id_prescricao:int}
- POST: criar/prescricao
- PUT: atualizar/prescricao/{id_prescricao:int}
- DELETE: deleta/prescricao/{id_prescricao:int}


<h4>Medicamento</h4>

- GET - All: relatorio/medicamento
- GET - ID: relatorio/medicamento/{id_medicamento:int}
- POST: criar/medicamento
- PUT: atualizar/medicamento/{id_medicamento:int}
- DELETE: deleta/medicamento/{id_medicamento:int}

<h4>Endereço Animal</h4>

- GET - ALL: relatorio/enderecoanimal
- GET - ID: relatorio/enderecoanimal/{id_endereco_animal:int}
- PUT: atualizar/enderecoanimal/{id_endereco_animal:int}
- POST: criar/enderecoanimal
- DELETE: deleta/enderecoanimal/{id_endereco_animal:int}

<h4>Endereço Clínica</h4>

- GET - ALL: relatorio/enderecoclinica
- GET - ID: relatorio/enderecoclinica/{id_endereco_clinica:int}
- POST: criar/enderecoclinica
- PUT: atualizar/enderecoclinica/{id_endereco_clinica:int}
- DELETE: deleta/enderecoclinica/{id_endereco_clinica:int}

<h4>Endereço Responsável</h4>

- GET - ALL: relatorio/enderecoresponsavel
- GET - ID: relatorio/enderecoresponsavel/{id_endereco_responsavel:int}
- POST: criar/enderecoresponsavel
- PUT: atualizar/enderecoresponsavel/{id_endereco_responsavel:int}
- DELETE: deleta/enderecoresponsavel/{id_endereco_responsavel:int}

<h4>VetClinica</h4>

- GET - ALL: relatorio/vetclinica
- GET - ID: relatorio/vetclinica/{id_clinica_vet:int}
- POST: criar/vetclinica
- PUT: atualizar/vetclinica/{id_clinica_vet:int}
- DELETE: deleta/vetclinica/{id_clinica_vet:int}

<h2>Instruções de instalação e execução: </h2>

<h4>Pre-requisitos: </h4>

- Versão necessaria .Net SDK: 10.0 (10.0.300)
- Oracle DataBase
- Instalar Microsoft.EntityFrameworkCore.Tools em pacote

<h4>Link do GitHub para Clonar: </h4>

- git clone https://github.com/santiago-leticia/challenge_fiap_net.git

<h4>Para acessar o projeto: </h4>

- Selecionar -> challengeFiap.slnx

<h4>Depdendência do Projeto: </h4>

- dotnet restore

<h4>Para configurar o Banco de Dados - Oracle</h4>

- "OracleConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=SEU_SERVIDOR"

<h4>Migrantions: </h4>

- dotnet ef database update

<h4>Para executar o projeto: </h4>

- play(http)

<h5 align="center">OU</h5>

- dotnet run

<h4>Quando iniciar</h4>

-  Quando iniciar, o programa vai abrir o terminal e, logo após, vai para a parte web. Para você ir para o Swagger, precisa ir a https://localhost:xxxx.


