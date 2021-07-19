SET IDENTITY_INSERT [dbo].[Aulas] ON
INSERT INTO [dbo].[Aulas] ([Codcred], [Data], [Turma]) VALUES (1, N'2021-06-30 18:32:00', N'393')
INSERT INTO [dbo].[Aulas] ([Codcred], [Data], [Turma]) VALUES (2, N'2021-06-30 18:32:00', N'553')
SET IDENTITY_INSERT [dbo].[Aulas] OFF

SET IDENTITY_INSERT [dbo].[AulaAluno] ON
INSERT INTO [dbo].[AulaAluno] ([key], [Aluno], [Codcred]) VALUES (1, N'joao', 1)
SET IDENTITY_INSERT [dbo].[AulaAluno] OFF
