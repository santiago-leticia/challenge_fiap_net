<h1 align="center"> ADVANCED BUSINESS DEVELOPMENT WITH .NET </h1>
<h3 align="center">Challenge - FIAP - CYLVO</h3>

<h2 align="center" > Integrante </h2>

- EDUARDO BATISTA LOCASPI - RM5651713
- LIANA LYUMI MORISITA FUJISIMA - RM565698
- LETICIA SANTIAGO E SILVA - RM565799
- VICTOR ALVES LOPES - RM561833

<h2>Descrição sobre projeto: </h2>

<p>Como visto no tema do challenge, o objetivo da CLYVO é acompanhar a jornada contínua de saúde do pet, que infelizmente causa a falta de recorrências. Bem, como os animais não conseguem falar o que estão sentindo, infelizmente é normal só levar o animal de estimação quando está realmente mal ou em casos de emergência.
	Por causa disso, pode resultar uma grande complicação ao tratamento, pois não existe um banco de dados sobre a saúde do animal ou um histórico de check, que pode resultar em um diagnóstico tardio.
	Olhando a essa situação, a solução do grupo é entregar um app com todas as funcionalidades que um veterinário precisa em um único lugar para buscar informações importantes sobre os seus pacientes, como idade, peso, espécie, raça, carteira de vacinação, histórico de consultas, quem é o responsável pelo pet e, claro, informações sobre a localização dele, caso o paciente morasse em um ambiente diferente do dono.
	Mas também, opção de ver quais serão as suas próximas consultas, se houve um cancelamento ou alteração na data e entre outros.
	Sobre a relação de aumentar o fluxo de retorno, ou melhor, aumentar a frequência de check-up, dentro do projeto haverá uma interação entre o responsável e a clínica por meio do WhatsApp. Bem, iria funcionar assim: depois de uma quantidade de dias que passaram após a consulta, o responsável pelo animal vai receber uma mensagem gerada perguntando sobre questão de agendamento de consulta. Isso também funciona em relação à vacinação. Mas, claro, dentro da mensagem tem a opção de reagendar ou a opção de não.
</p>

<h2>Sobre a parte de Dot .NET</h2>

<p>Função do projeto de dot .net, é servir como um sistema de backend CRUD, aonde ele vai gerenciar os dados do projeto e suas funcionalidade presente no Banco de Dados. Mas também, vai oferecer as APIS que possa fazer o Frontend interagir com o Banco de Dados.</p>

<h2>Rotas Presente no Projeto: </h2>

<h4>Routa principal</h4>

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

h4>Endereço Clínica</h4>

- GET - ALL: relatorio/enderecoclinica
- GET - ID: relatorio/enderecoclinica/{id_endereco_clinica:int}
- POST: criar/enderecoclinica
- PUT: atualizar/enderecoclinica/{id_endereco_clinica:int}
- DELETE: deleta/enderecoclinica/{id_endereco_clinica:int}

h4>Endereço Responsável</h4>

- GET - ALL: relatorio/enderecoresponsavel
- GET - ID: relatorio/enderecoresponsavel/{id_endereco_responsavel:int}
- POST: criar/enderecoresponsavel
- PUT: atualizar/enderecoresponsavel/{id_endereco_responsavel:int}
- DELETE: deleta/enderecoresponsavel/{id_endereco_responsavel:int}

h4>VetClinica</h4>

- GET - ALL: relatorio/vetclinica
- GET - ID: relatorio/vetclinica/{id_clinica_vet:int}
- POST: criar/vetclinica
- PUT: atualizar/vetclinica/{id_clinica_vet:int}
- DELETE: deleta/vetclinica/{id_clinica_vet:int}

<h2>Instruções de instalação e execução: </h2>

<h4>Pre-requisitos: </h4>

- Versão necessaria .Net: 10.0
- Oracle DataBase
- EF Core Tools

<h4>Link do GitHub para Clonar: </h4>

- git clone https://github.com/santiago-leticia/challenge_fiap_net.git

<h4>Para acessar o projeto: </h4>

- Selecionar -> challengeFiap.slnx

<h4>Depdendência do Projeto: </h4>

- dotnet restore

<h4>Para configurar o Banco de Dados - Oracle</h4>

- "OracleConnection": "User Id=USUARIO;Password=SENHA;Data Source=SEU_SERVIDOR"

<h4>Para executar o projeto: </h4>

- Vai play(http)
      OU
- dotnet run
