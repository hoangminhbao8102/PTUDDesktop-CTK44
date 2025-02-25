USE [QLBanHang_De3]
GO
/****** Object:  Table [dbo].[LOAIMATHANG]    Script Date: 09-Jan-25 21:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMATHANG](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATHANG]    Script Date: 09-Jan-25 21:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATHANG](
	[MaMatHang] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](1000) NOT NULL,
	[LoaiMatHang] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LOAIMATHANG] ON 

INSERT [dbo].[LOAIMATHANG] ([MaLoai], [TenLoai]) VALUES (1, N'Áo khoác')
INSERT [dbo].[LOAIMATHANG] ([MaLoai], [TenLoai]) VALUES (2, N'Quần jean')
INSERT [dbo].[LOAIMATHANG] ([MaLoai], [TenLoai]) VALUES (3, N'Áo thun')
INSERT [dbo].[LOAIMATHANG] ([MaLoai], [TenLoai]) VALUES (4, N'Áo sơ mi')
INSERT [dbo].[LOAIMATHANG] ([MaLoai], [TenLoai]) VALUES (5, N'Váy')
SET IDENTITY_INSERT [dbo].[LOAIMATHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[MATHANG] ON 

INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (1, N'Áo khoác gió nam', 1, 10, 300000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (2, N'Áo khoác gió nữ', 1, 15, 220000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (3, N'Quần jean nam', 2, 20, 250000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (4, N'Quần jean nữ', 2, 13, 170000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (5, N'Áo thun nam', 3, 23, 120000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (6, N'Áo thun nữ', 3, 45, 100000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (7, N'Áo sơ mi nữ', 4, 35, 100000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (8, N'Váy ngắn', 5, 25, 110000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (9, N'Váy dài', 5, 30, 130000)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [LoaiMatHang], [SoLuongTon], [DonGia]) VALUES (10, N'Set váy', 5, 40, 280000)
SET IDENTITY_INSERT [dbo].[MATHANG] OFF
GO
ALTER TABLE [dbo].[MATHANG] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[MATHANG]  WITH CHECK ADD FOREIGN KEY([LoaiMatHang])
REFERENCES [dbo].[LOAIMATHANG] ([MaLoai])
GO
/****** Object:  StoredProcedure [dbo].[CapNhatMatHang]    Script Date: 09-Jan-25 21:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CapNhatMatHang]
    @MaMatHang INT,
    @TenMatHang NVARCHAR(1000),
    @LoaiMatHang INT,
    @SoLuongTon INT,
    @DonGia INT
AS
BEGIN
    UPDATE MATHANG
    SET TenMatHang = @TenMatHang,
        LoaiMatHang = @LoaiMatHang,
        SoLuongTon = @SoLuongTon,
        DonGia = @DonGia
    WHERE MaMatHang = @MaMatHang;
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemMatHang]    Script Date: 09-Jan-25 21:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemMatHang]
    @TenMatHang NVARCHAR(1000),
    @LoaiMatHang INT,
    @SoLuongTon INT,
    @DonGia INT
AS
BEGIN
    INSERT INTO MATHANG (TenMatHang, LoaiMatHang, SoLuongTon, DonGia)
    VALUES (@TenMatHang, @LoaiMatHang, @SoLuongTon, @DonGia);
END;
GO
