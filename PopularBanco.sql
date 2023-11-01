USE [aspnet-LivroRecomendacao-85f12473-a629-4821-8f2e-60e59b17a841]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'606ff363-7702-4313-9e21-3cbcdf84961f', N'Adm', N'ADM', N'1464611e-bc86-4091-92c0-4a341138f0c7')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'808c39b0-9b35-44ab-867e-a82d1ceccb0e', N'Membro', N'MEMBRO', N'2e0c77aa-c27b-42f5-92fd-4c35d83b20ea')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1eb4c3ce-b1e6-480c-859e-2c9d73bdfd8b', N'carlos505monks@hotmail.com', N'CARLOS505MONKS@HOTMAIL.COM', N'carlos505monks@hotmail.com', N'CARLOS505MONKS@HOTMAIL.COM', 1, N'AQAAAAEAACcQAAAAEMJg6tHz5Iy0ZbVr3A30CMV2/gphf7ZtT3Wu+mJHA+FCUGHo4yQnaXe06qRBUoZ/hg==', N'F5PMSTG5LPLOPW3BDZ5DD7YYIJWOZ7FG', N'21150ad9-192a-4beb-9e3f-8b54059e864a', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'42694bcd-5447-4809-b054-4354790c3868', N'membro02@hotmail.com', N'MEMBRO02@HOTMAIL.COM', N'membro02@hotmail.com', N'MEMBRO02@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEF/npJ9F1o0hIayM2KstWw74OkxRYd1glchMis3878JBLlmcBkEJPswtjy8EPCDykw==', N'IUYHQUM5VAJRIGVDUQZ6NL3F5WQOU3JY', N'93fbd2be-b978-45fa-8839-42c576198266', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'487bc448-50b7-4973-ba37-ebfb7be5ea35', N'admin@outlook.com', N'ADMIN@OUTLOOK.COM', N'admin@outlook.com', N'ADMIN@OUTLOOK.COM', 0, N'AQAAAAEAACcQAAAAEM9npNSYoVNsn9XxeCaNM/Sxg9eAdWB9p8pUkcygbYAA4vwzmsXg4DnbmbLhcDEV0g==', N'F3752WE7C2LRMI5NDOBXOYERNVH2ZAL3', N'5f694095-ade5-43b2-be7d-6b3380cfa51c', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cfc986ac-13cc-47c1-a1fd-c6e94f39c53f', N'membro01@outlook.com', N'MEMBRO01@OUTLOOK.COM', N'membro01@outlook.com', N'MEMBRO01@OUTLOOK.COM', 0, N'AQAAAAEAACcQAAAAECsBsbqS6QBde3ONXDYyqJcoFeZVEq0DrWn3qkr3kefGjvJFrdFkgHfYYmzHNWJUFQ==', N'FEWSCFUG4XAVOBI3PHVFFYVVQ2XPPRMI', N'b5df0653-77ae-4fd6-b215-319ba2f67aaa', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd02087c1-0fb1-45ae-b050-c8a09893c32f', N'membro03@hotmail.com', N'MEMBRO03@HOTMAIL.COM', N'membro03@hotmail.com', N'MEMBRO03@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEK7AL9vLqS8klJOJGMbMIohmnWitsPkDu3sG3mnQaJfSR9aTxQGD9QtsoqawOqGbmg==', N'W4S2XIQXOQPT4I7EMZD4CTZOKDIBUF77', N'20173367-dcd6-4b51-a6f4-726ff4d40de5', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'487bc448-50b7-4973-ba37-ebfb7be5ea35', N'606ff363-7702-4313-9e21-3cbcdf84961f')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'42694bcd-5447-4809-b054-4354790c3868', N'808c39b0-9b35-44ab-867e-a82d1ceccb0e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cfc986ac-13cc-47c1-a1fd-c6e94f39c53f', N'808c39b0-9b35-44ab-867e-a82d1ceccb0e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd02087c1-0fb1-45ae-b050-c8a09893c32f', N'808c39b0-9b35-44ab-867e-a82d1ceccb0e')
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (1, N'Antoine de Saint-Exupéry')
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (2, N'William Shakespeare')
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (3, N'Machado de Assis')
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (4, N'Graciliano Ramos')
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (5, N'José de Alencar')
GO
INSERT [dbo].[Autor] ([Id], [Nome]) VALUES (6, N'Aluísio Azevedo')
GO
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
SET IDENTITY_INSERT [dbo].[Genero] ON 
GO
INSERT [dbo].[Genero] ([Id], [Nome]) VALUES (1, N'Drama')
GO
INSERT [dbo].[Genero] ([Id], [Nome]) VALUES (2, N'Comedia')
GO
INSERT [dbo].[Genero] ([Id], [Nome]) VALUES (3, N'Romance')
GO
SET IDENTITY_INSERT [dbo].[Genero] OFF
GO
SET IDENTITY_INSERT [dbo].[Livro] ON 
GO
INSERT [dbo].[Livro] ([Id], [Titulo], [AutorId], [GeneroId], [Descrico], [LinkFoto]) VALUES (6, N'Pequeno Principe', 1, 1, N'O pequeno príncipe é um clássico da literatura infantil que narra a amizade entre um menino e um piloto de avião. O principezinho vem do asteroide B 612, e encontra o piloto no deserto do Saara. A obra fala de amor, amizade e sobre a sabedoria infantil.', N'https://m.media-amazon.com/images/I/81fXBeYYxpL._SL1500_.jpg')
GO
INSERT [dbo].[Livro] ([Id], [Titulo], [AutorId], [GeneroId], [Descrico], [LinkFoto]) VALUES (10, N'Dom Casmurro', 3, 3, N'Uma das obras mais aclamadas da literatura brasileira, Dom Casmurro foi escrita por Machado de Assis e publicada em 1899. A história é contada do ponto de vista do personagem principal, Bento Santiago, que é apaixonado por Capitu desde a infância. Dúvidas e os ciúmes são dois dos temas principais do livro.', N'https://m.media-amazon.com/images/I/61x1ZHomWUL._SL1200_.jpg')
GO
INSERT [dbo].[Livro] ([Id], [Titulo], [AutorId], [GeneroId], [Descrico], [LinkFoto]) VALUES (11, N'Vidas Secas', 4, 1, N'Vidas Secas é uma das obras de sucesso do romancista Graciliano Ramos. Publicada em 1938, retrata histórias da infância do autor, que aborda temas como desonestidade, o flagelo humano, a seca e condições sub-humanas de sobrevivência.', N'https://m.media-amazon.com/images/I/71PLoOGQB3L._SL1500_.jpg')
GO
INSERT [dbo].[Livro] ([Id], [Titulo], [AutorId], [GeneroId], [Descrico], [LinkFoto]) VALUES (12, N'Senhora', 5, 3, N'Senhora é outra obra de sucesso de José de Alencar. Publicada em 1875, tem como aspecto principal o romance entre Aurélia Camargo e Fernando Seixas, marcado por amor e ambição. A história mostra como o amor e os bens materiais podem mudar os rumos das vidas das pessoas.', N'https://m.media-amazon.com/images/I/61hPVMxBFCL._SY466_.jpg')
GO
INSERT [dbo].[Livro] ([Id], [Titulo], [AutorId], [GeneroId], [Descrico], [LinkFoto]) VALUES (14, N'O cortiço', 6, 1, N'Aluísio Azevedo retrata as péssimas condições de vida dos moradores dos cortiços cariocas neste romance estrelado por dois imigrantes portugueses. A linguagem rebuscada do autor naturalista do século XIX é traduzida para os dias de hoje por meio das notas comentadas de Fátima Mesquita.', N'https://m.media-amazon.com/images/I/71Kfo7DKf3L._SL1500_.jpg')
GO
SET IDENTITY_INSERT [dbo].[Livro] OFF
GO
SET IDENTITY_INSERT [dbo].[Preferencias] ON 
GO
INSERT [dbo].[Preferencias] ([Id], [UserId], [AutorId], [GeneroId]) VALUES (1, N'42694bcd-5447-4809-b054-4354790c3868', 1, 1)
GO
INSERT [dbo].[Preferencias] ([Id], [UserId], [AutorId], [GeneroId]) VALUES (2, N'd02087c1-0fb1-45ae-b050-c8a09893c32f', 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Preferencias] OFF
GO
SET IDENTITY_INSERT [dbo].[Favorito] ON 
GO
INSERT [dbo].[Favorito] ([Id], [UserId], [LivroId]) VALUES (5, N'1eb4c3ce-b1e6-480c-859e-2c9d73bdfd8b', 6)
GO
INSERT [dbo].[Favorito] ([Id], [UserId], [LivroId]) VALUES (6, N'1eb4c3ce-b1e6-480c-859e-2c9d73bdfd8b', 10)
GO
SET IDENTITY_INSERT [dbo].[Favorito] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231029055235_Inicial', N'6.0.23')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231029060805_Inclusao_de_Autor_Genero', N'6.0.23')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231029212538_id_genero_id_autor', N'6.0.23')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231031001106_favoritos', N'6.0.23')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231031021009_campo_linkfoto', N'6.0.23')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101001432_tabel_preferencias', N'6.0.23')
GO
