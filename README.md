# Pedro Gomes - RM 553907
# Luiz Felipe Abreu - RM 555197



Descrição do Projeto:

________________________________________________________________________________________

<h2>Acesso ao código</h2>

1. Execução Local
   
Para rodar o projeto localmente:

 git clone https://github.com/PedroHGGomes/EcoSafe.git<br>
 dotnet restore<br>
 dotnet ef database update  (verifice o .json para conectar com o seu banco de dados Oracle)<br>
 dotnet run<br>
 
2. URL de Acesso
Após rodar o projeto, acesse:

Documentação da API (Swagger):
https://localhost:5129/swagger

<h2>OBSERVAÇÃO</h2>

Todas as requisições API retornam status HTTP apropriados:

200 OK para sucesso

201 Created para criação

400 BadRequest para dados inválidos

404 NotFound para registros não encontrados

204 NoContent para deleções

<h3>API RESTful</h3>

Método	Endpoint	Descrição

GET	/api/brinquedos	Lista todos os abrigos

GET	/api/brinquedos/{id}	Busca abrigo por ID

GET	/api/brinquedos/search?nome={nome}	Busca abrigo por nome

POST	/api/brinquedos	Cadastra um novo abrigo

PUT	/api/brinquedos/{id}	Atualiza um abrigo existente

DELETE	/api/brinquedos/{id}	Remove um abrigo

<h2>Exemplo de Requisição</h2>

POST /api/brinquedos<br>
Content-Type: application/json<br>

{<br>
  "idBrinquedo": 4,
  "nomeBrinquedo": "Tabuleiro Aventura (Edição 2)",
  "tipoBrinquedo": "Jogo de Tabuleiro",
  "classificacao": "+8",
  "tamanho": "Grande",
  "preco": 149.90
}<br>

Resposta esperada:<br>

201 Created<br>
{
  "idBrinquedo": 4,
  "nomeBrinquedo": "Tabuleiro Aventura (Edição 2)",
  "tipoBrinquedo": "Jogo de Tabuleiro",
  "classificacao": "+8",
  "tamanho": "Grande",
  "preco": 149.90
}<br>



<h2>Informações do código</h2>

- API REST que atenda a boas práticas de programação / arquitetura;
 
<img width="516" height="208" alt="image" src="https://github.com/user-attachments/assets/085ea3c4-06ea-478f-a043-b1bd5d14c30c" />


- Apresentar um CRUD pelo menos (GET (mais de 3 rotas e devidamente parametrizadas com QueryParams ou 
PathParams), POST, PUT, DELETE)<br>
GET:

<img width="1182" height="926" alt="image" src="https://github.com/user-attachments/assets/3f240c23-49f0-4212-9154-361866bbf8d2" />



POST:

<img width="1152" height="926" alt="image" src="https://github.com/user-attachments/assets/d144b4b3-9305-47e6-9c8e-deacf19b02d8" />



DELETE:

<img width="1093" height="638" alt="image" src="https://github.com/user-attachments/assets/70661d0c-ef7f-4dcc-9bb6-235e0971f6df" />


 
- Integração do Banco de dados Oracle via EF Core, com utilização de migrations para criação das tabelas
 Alteração feita no .json:
 
<img width="719" height="65" alt="image" src="https://github.com/user-attachments/assets/b62ff92f-dadb-45ed-af8d-1a5712b68212" />


Criação nos modelos:

<img width="419" height="537" alt="image" src="https://github.com/user-attachments/assets/150573b3-68ec-4542-9ccc-b180837b3b1c" />



Conexão com Oracle no program.cs:

<img width="473" height="47" alt="image" src="https://github.com/user-attachments/assets/2ea705ef-8a28-4aa1-b785-b25f2ea7e5c9" />





- Swagger - Aplicação

Swagger Brinquedos:

<img width="1904" height="660" alt="image" src="https://github.com/user-attachments/assets/876d233c-7bdc-4ec2-b128-16976a6b184d" />




Schemas:

<img width="1116" height="274" alt="image" src="https://github.com/user-attachments/assets/df297352-4dc8-4a53-b745-f9f3ced46ff8" />


Configuração para um banco de dados relacional:

<img width="1059" height="345" alt="image" src="https://github.com/user-attachments/assets/96d9ab50-6de1-430b-ba3a-2d54dcc6520e" />


