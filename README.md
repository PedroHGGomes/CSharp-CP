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

GET	/api/AbrigoApi	Lista todos os abrigos

GET	/api/AbrigoApi/{id}	Busca abrigo por ID

GET	/api/AbrigoApi/search?nome={nome}	Busca abrigo por nome

POST	/api/AbrigoApi	Cadastra um novo abrigo

PUT	/api/AbrigoApi/{id}	Atualiza um abrigo existente

DELETE	/api/AbrigoApi/{id}	Remove um abrigo

<h2>Exemplo de Requisição</h2>

POST /api/AbrigoApi<br>
Content-Type: application/json<br>

{<br>
  "nome": "Abrigo Central",<br>
  "endereco": "Rua das Flores, 123",<br>
  "capacidade": 200,<br>
  "ocupacao_Atual": 150<br>
}<br>

Resposta esperada:<br>

201 Created<br>
{
  "id_ABRIGO": 1,<br>
  "nome": "Abrigo Central",<br>
  "endereco": "Rua das Flores, 123",<br>
  "capacidade": 200,<br>
  "ocupacao_Atual": 150<br>
}<br>



<h2>Informações do código</h2>

- API REST que atenda a boas práticas de programação / arquitetura;
 
![image](https://github.com/user-attachments/assets/4db88b9a-a157-4a62-bbe1-dbc5520a4c52)


- Apresentar um CRUD pelo menos (GET (mais de 3 rotas e devidamente parametrizadas com QueryParams ou 
PathParams), POST, PUT, DELETE)<br>
GET:

![image](https://github.com/user-attachments/assets/5ac622da-5857-4d01-8a1b-d6252f57abb1)


POST:

![image](https://github.com/user-attachments/assets/f0636cfc-88e8-4db6-b741-9cda33619930)


PUT:

![image](https://github.com/user-attachments/assets/f3b14c9d-74a3-41eb-9d18-4129d0fe0b64)

![image](https://github.com/user-attachments/assets/13d8ce65-06e0-49a8-8698-c52ee5491bec)


DELETE:

![image](https://github.com/user-attachments/assets/a35d57f0-7287-4891-ba97-cc1087f172f5)




- Apresentar os retornos HTTP adequados para cada rota (ok, NotFound, BadRequest, NoContent, Created)
OK:

![image](https://github.com/user-attachments/assets/d9443e5e-c7ef-496b-9f56-bf48c988d4ff)


NotFound/BadRequest/No Content:

![image](https://github.com/user-attachments/assets/a7cd36b7-49e6-4f3e-8901-cb3c39a99137)

Created:

![image](https://github.com/user-attachments/assets/47ddbb92-2619-4bc1-a201-bf9958879e22)



 
- Integração do Banco de dados Oracle via EF Core, com utilização de migrations para criação das tabelas
 Alteração feita no .json:
 
![image](https://github.com/user-attachments/assets/650e5c4b-69c5-420e-9eb9-35db1420e1a0)


Criação nos modelos:

![image](https://github.com/user-attachments/assets/521cc096-e2d0-47f3-aa6d-19ef9e496799)


Conexão com Oracle no program.cs:

![image](https://github.com/user-attachments/assets/73c6c941-14f4-42bd-9519-a19ed8ab6ace)




- Swagger - Aplicação

Swagger Brinquedos:





Schemas:

![image](https://github.com/user-attachments/assets/42b93970-ac0b-4e5c-8afe-93c10ccb5f3b)
![image](https://github.com/user-attachments/assets/b0c031e4-83a0-4f36-b0b3-64f848e043a5)

Configuração para um banco de dados relacional:

![image](https://github.com/user-attachments/assets/e947d00b-c839-4f92-ab27-2550e60108c5)

