USE [QLMonAn]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 13-Jan-25 08:46:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[Nhom] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomMonAn]    Script Date: 13-Jan-25 08:46:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomMonAn](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON 

INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (1, N'Gỏi thập cẩm', N'Dĩa', 120000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (2, N'Gỏi sứa', N'Dĩa', 140000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (3, N'Gỏi tai heo', N'Dĩa', 110000, 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (4, N'Tôm nướng muối ớt', N'Kg', 250000, 2)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (5, N'Mực nướng muối ớt', N'Kg', 290000, 2)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (6, N'Tôm hấp bia', N'Kg', 230000, 2)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (7, N'Sò nướng mỡ hành', N'Kg', 300000, 2)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (8, N'Bia Heniken', N'Chai', 18000, 3)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (9, N'Bia tiger bạc', N'Chai', 16000, 3)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (10, N'Coca', N'Lon', 16000, 3)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (11, N'Lẩu hải sản', N'Nồi', 220000, 4)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (12, N'Lẩu cá tầm', N'Nồi', 270000, 4)
SET IDENTITY_INSERT [dbo].[MonAn] OFF
GO
SET IDENTITY_INSERT [dbo].[NhomMonAn] ON 

INSERT [dbo].[NhomMonAn] ([MaNhom], [TenNhom]) VALUES (1, N'Khai vị')
INSERT [dbo].[NhomMonAn] ([MaNhom], [TenNhom]) VALUES (2, N'Hải sản')
INSERT [dbo].[NhomMonAn] ([MaNhom], [TenNhom]) VALUES (3, N'Bia - Nước ngọt')
INSERT [dbo].[NhomMonAn] ([MaNhom], [TenNhom]) VALUES (4, N'Lẩu')
SET IDENTITY_INSERT [dbo].[NhomMonAn] OFF
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_NhomMonAn] FOREIGN KEY([Nhom])
REFERENCES [dbo].[NhomMonAn] ([MaNhom])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_NhomMonAn]
GO
