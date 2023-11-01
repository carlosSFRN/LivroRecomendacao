# LivroRecomendacao

## Projeto
LivroRecomendacao faz recomendações de livros de acordo com as preferências do usuario.
	
## Tecnologias
Project is created with:
* Visual Studio Comunity 2022
* NET CORE: 6.0
* Entity FrameworkCore: 6.0.23
* Identity: 6.0.23
	
## Setup
Para iniciar o projeto, devemos rodar primeirament.

```
$ dotnet ef update-database
```

Caso não consiga executar o update database, precisamos instalar EF Core CLI.

```
$ dotnet tool install --global dotnet-ef
```

Para verificar a versão utlizada, execute no seu PowerShell

```
$ dotnet ef
```

## Perfis do sistema
* Adm
* Membro

## User Default Admin
* admin@outlook.com
* Livro@123

## Pagina Registar
Todos os usuarios criados na tela de 'registrar' serão da role de 'Membro'