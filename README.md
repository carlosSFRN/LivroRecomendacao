# LivroRecomendacao

## Projeto
LivroRecomendacao faz recomenda��es de livros de acordo com as prefer�ncias do usuario.

## Perfis do sistema
* Adm
* Membro
	
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

Caso n�o consiga executar o update database, precisamos instalar EF Core CLI.

```
$ dotnet tool install --global dotnet-ef
```

Para verificar a vers�o utlizada, execute no seu PowerShell

```
$ dotnet ef
```

