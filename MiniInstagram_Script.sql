USE [master]
GO
/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 14/05/2020 07:53:40 p. m. ******/
CREATE USER [##MS_PolicyEventProcessingLogin##] FOR LOGIN [##MS_PolicyEventProcessingLogin##] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 14/05/2020 07:53:40 p. m. ******/
CREATE USER [##MS_AgentSigningCertificate##] FOR LOGIN [##MS_AgentSigningCertificate##]
GO
/****** Object:  Table [dbo].[Carlos_0_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_0_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_0_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_0_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_0_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_0_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_GUARDADO](
	[nombre_usuario] [varchar](50) NULL,
	[id_foto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_PERFIL]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_PERFIL](
	[foto] [varchar](50) NULL,
	[biografia] [varchar](160) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_POSTS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_POSTS](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](50) NULL,
	[titulo_foto] [varchar](30) NULL,
	[descripcion_foto] [varchar](80) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_SEGUIDORES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_SEGUIDORES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_SEGUIDOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_SEGUIDOS](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carlos_STORIES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carlos_STORIES](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](40) NULL,
	[times] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_0_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_0_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_0_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_0_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_0_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_0_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_GUARDADO](
	[nombre_usuario] [varchar](50) NULL,
	[id_foto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_PERFIL]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_PERFIL](
	[foto] [varchar](50) NULL,
	[biografia] [varchar](160) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_POSTS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_POSTS](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](max) NULL,
	[titulo_foto] [varchar](30) NULL,
	[descripcion_foto] [varchar](80) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_SEGUIDORES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_SEGUIDORES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_SEGUIDOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_SEGUIDOS](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feresaul_STORIES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feresaul_STORIES](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](max) NULL,
	[times] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_0_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_0_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_0_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_0_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_0_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_0_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_GUARDADO](
	[nombre_usuario] [varchar](50) NULL,
	[id_foto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_PERFIL]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_PERFIL](
	[foto] [varchar](50) NULL,
	[biografia] [varchar](160) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_POSTS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_POSTS](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](max) NULL,
	[titulo_foto] [varchar](30) NULL,
	[descripcion_foto] [varchar](80) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_SEGUIDORES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_SEGUIDORES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_SEGUIDOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_SEGUIDOS](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[juanito_STORIES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juanito_STORIES](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](max) NULL,
	[times] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_0_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_0_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_0_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_0_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_0_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_0_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_1_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_1_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_1_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_1_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_1_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_1_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_2_COMENTARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_2_COMENTARIOS](
	[id_comentario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[texto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_2_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_2_GUARDADO](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_2_LIKES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_2_LIKES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_GUARDADO]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_GUARDADO](
	[nombre_usuario] [varchar](50) NULL,
	[id_foto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_PERFIL]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_PERFIL](
	[foto] [varchar](50) NULL,
	[biografia] [varchar](160) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_POSTS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_POSTS](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](50) NULL,
	[titulo_foto] [varchar](30) NULL,
	[descripcion_foto] [varchar](80) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_SEGUIDORES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_SEGUIDORES](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_SEGUIDOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_SEGUIDOS](
	[nombre_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paco_STORIES]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paco_STORIES](
	[id_foto] [int] NOT NULL,
	[archivo] [varchar](40) NULL,
	[times] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_foto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 14/05/2020 07:53:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[id_usuario] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[nombre_completo] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Carlos_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Paco', N'Hola')
INSERT [dbo].[Carlos_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (4, N'Feresaul', N'WOW')
INSERT [dbo].[Carlos_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (5, N'Paco', N'Buen dibujo')
INSERT [dbo].[Carlos_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (6, N'Paco', N'Los colores llamativos :p')
GO
INSERT [dbo].[Carlos_0_GUARDADO] ([nombre_usuario]) VALUES (N'Feresaul')
INSERT [dbo].[Carlos_0_GUARDADO] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Carlos_0_GUARDADO] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Carlos_0_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Carlos_0_LIKES] ([nombre_usuario]) VALUES (N'Feresaul')
INSERT [dbo].[Carlos_0_LIKES] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Carlos_0_LIKES] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Carlos_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Paco', 0)
INSERT [dbo].[Carlos_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Paco', 2)
INSERT [dbo].[Carlos_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'juanito', 0)
INSERT [dbo].[Carlos_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Feresaul', 0)
GO
INSERT [dbo].[Carlos_PERFIL] ([foto], [biografia]) VALUES (N'\Imagenes\images.jpg', N'Esta es una prueba del programa!! :)')
GO
INSERT [dbo].[Carlos_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (0, N'Imagenes\Prueba.jpg', N'Prueba', N'Porbando...', CAST(N'2020-05-01T12:35:22.000' AS DateTime))
GO
INSERT [dbo].[Carlos_SEGUIDORES] ([nombre_usuario]) VALUES (N'Feresaul')
INSERT [dbo].[Carlos_SEGUIDORES] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Carlos_SEGUIDORES] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Carlos_SEGUIDOS] ([nombre_usuario]) VALUES (N'Feresaul')
INSERT [dbo].[Carlos_SEGUIDOS] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Carlos_SEGUIDOS] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Feresaul_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Paco', N'Impresionante el paisaje')
INSERT [dbo].[Feresaul_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (1, N'Carlos', N'Genial :O')
GO
INSERT [dbo].[Feresaul_0_GUARDADO] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Feresaul_0_GUARDADO] ([nombre_usuario]) VALUES (N'juanito')
GO
INSERT [dbo].[Feresaul_0_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Feresaul_0_LIKES] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Feresaul_0_LIKES] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Feresaul_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Paco', 0)
INSERT [dbo].[Feresaul_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Carlos', 0)
INSERT [dbo].[Feresaul_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'juanito', 0)
GO
INSERT [dbo].[Feresaul_PERFIL] ([foto], [biografia]) VALUES (N'\Imagenes\gatos.jpg', N'Hola MUNDO!!!')
GO
INSERT [dbo].[Feresaul_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (0, N'Imagenes\bavaria-1617529_1920-683x1024.jpg', N'PARAISO', N'Que paz! este lugar es magnifico...', CAST(N'2020-05-08T01:30:08.000' AS DateTime))
GO
INSERT [dbo].[Feresaul_SEGUIDORES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Feresaul_SEGUIDORES] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Feresaul_SEGUIDORES] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[Feresaul_SEGUIDOS] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Feresaul_SEGUIDOS] ([nombre_usuario]) VALUES (N'juanito')
INSERT [dbo].[Feresaul_SEGUIDOS] ([nombre_usuario]) VALUES (N'Paco')
GO
INSERT [dbo].[juanito_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Carlos', N'Maul !!!')
GO
INSERT [dbo].[juanito_0_GUARDADO] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[juanito_0_GUARDADO] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[juanito_0_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[juanito_0_LIKES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[juanito_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Feresaul', 0)
INSERT [dbo].[juanito_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Carlos', 0)
GO
INSERT [dbo].[juanito_PERFIL] ([foto], [biografia]) VALUES (N'\Imagenes\FotoPerfil.jpg', N'')
GO
INSERT [dbo].[juanito_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (0, N'Imagenes\661e93d06b92dbf1175ed44f09e459fb.jpg', N'', N'', CAST(N'2020-05-13T01:25:29.000' AS DateTime))
GO
INSERT [dbo].[juanito_SEGUIDORES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[juanito_SEGUIDORES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[juanito_SEGUIDOS] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[juanito_SEGUIDOS] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Carlos', N'fscvdsvsdv')
INSERT [dbo].[Paco_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (2, N'Carlos', N'vdsvsdvdsd')
INSERT [dbo].[Paco_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (3, N'Carlos', N'csdcdscsdc')
INSERT [dbo].[Paco_0_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (4, N'Feresaul', N'Hello!!')
GO
INSERT [dbo].[Paco_0_GUARDADO] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_0_GUARDADO] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_0_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_0_LIKES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_1_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Paco', N'Estas imagenes estan pesadas :(')
GO
INSERT [dbo].[Paco_1_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_1_LIKES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_2_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (0, N'Carlos', N'Hola mundo...')
INSERT [dbo].[Paco_2_COMENTARIOS] ([id_comentario], [nombre_usuario], [texto]) VALUES (1, N'Paco', N'Carga lento por la resolucion de la imagen, es una lastima !! T.T')
GO
INSERT [dbo].[Paco_2_GUARDADO] ([nombre_usuario]) VALUES (N'Carlos')
GO
INSERT [dbo].[Paco_2_LIKES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_2_LIKES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_GUARDADO] ([nombre_usuario], [id_foto]) VALUES (N'Carlos', 0)
GO
INSERT [dbo].[Paco_PERFIL] ([foto], [biografia]) VALUES (N'\Imagenes\Essential.jpg', N'Hola Mundo!!')
GO
INSERT [dbo].[Paco_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (0, N'Imagenes\JOKER (1).png', N'EL BROMAS', N'HA HA HA !! ', CAST(N'2020-05-02T12:36:35.000' AS DateTime))
INSERT [dbo].[Paco_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (1, N'Imagenes\italy-mountains-clouds.jpg', N'', N'', CAST(N'2020-05-13T01:24:48.000' AS DateTime))
INSERT [dbo].[Paco_POSTS] ([id_foto], [archivo], [titulo_foto], [descripcion_foto], [fecha]) VALUES (2, N'Imagenes\djoajdosa.jpg', N'Pruebas', N'Hola!!', CAST(N'2020-05-13T01:26:22.000' AS DateTime))
GO
INSERT [dbo].[Paco_SEGUIDORES] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_SEGUIDORES] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_SEGUIDOS] ([nombre_usuario]) VALUES (N'Carlos')
INSERT [dbo].[Paco_SEGUIDOS] ([nombre_usuario]) VALUES (N'Feresaul')
GO
INSERT [dbo].[Paco_STORIES] ([id_foto], [archivo], [times]) VALUES (0, N'Imagenes\est.jpg', CAST(N'2020-05-13T17:02:31.000' AS DateTime))
INSERT [dbo].[Paco_STORIES] ([id_foto], [archivo], [times]) VALUES (1, N'Imagenes\italy-mountains-clouds.jpg', CAST(N'2020-05-13T17:02:55.000' AS DateTime))
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre_usuario], [nombre_completo], [correo], [contrasenia]) VALUES (0, N'Carlos', N'Carlos Moreno', N'WEDEWDWE', N'76746E80117EBDE34CD97121FA1B757AC5F812D3')
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre_usuario], [nombre_completo], [correo], [contrasenia]) VALUES (1, N'Paco', N'Paco Lopez', N'indinwdinwe', N'76746E80117EBDE34CD97121FA1B757AC5F812D3')
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre_usuario], [nombre_completo], [correo], [contrasenia]) VALUES (2, N'Feresaul', N'Esaul Franco', N'ccdscdscsdc', N'76746E80117EBDE34CD97121FA1B757AC5F812D3')
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre_usuario], [nombre_completo], [correo], [contrasenia]) VALUES (3, N'juanito', N'Juan perez', N'ddsadasda', N'76746E80117EBDE34CD97121FA1B757AC5F812D3')
GO
