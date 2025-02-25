USE [QLBanHang]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09-Jan-25 21:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nchar](11) NOT NULL,
	[DiaChiGH] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMatHang]    Script Date: 09-Jan-25 21:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMatHang](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 09-Jan-25 21:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMatHang] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaLoai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 09-Jan-25 21:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [nvarchar](11) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (1, N'Nga', N'0985785745 ', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (2, N'Trần Văn C', N'0842156971 ', N'56/45 Lê Đại Hành')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (3, N'Ngô Mộng Nấm', N'0842147876 ', N'26 Cô Giang')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (4, N'Lê Văn Tú', N'0896135248 ', N'11/1 Chi Lăng')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (5, N'Võ Tuấn', N'0689971324 ', N'52 Tôn Thất Tùng')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (6, N'Phan Uyển Nhi', N'0369974325 ', N'19 Trần Phú')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (7, N'Trần Quốc', N'0364687165 ', N'25 Vạn Kiếp')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai], [DiaChiGH]) VALUES (8, N'Trinh Nhật Trường', N'0985732435 ', NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiMatHang] ON 

INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (1, N'Bia')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (2, N'Dầu ăn')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (3, N'Nước ngọt')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (4, N'Hạt nêm')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (5, N'Bột giặt')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (6, N'Kem đánh răng')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (7, N'Sữa')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (8, N'Nước mắm')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (9, N'Giấy ăn')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (10, N'Mì tôm')
INSERT [dbo].[LoaiMatHang] ([MaLoai], [TenLoai]) VALUES (11, N'Kẹo')
SET IDENTITY_INSERT [dbo].[LoaiMatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[MatHang] ON 

INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (1, N'Bia 333', 20, 330000, 1, 1)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (2, N'Bia saigon', 20, 350000, 1, 1)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (3, N'Bia Heniken', 30, 460000, 1, 1)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (4, N'Bia tiger thường', 20, 390000, 1, 1)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (5, N'Bia tiger bạc', 20, 400000, 1, 1)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (6, N'Dầu Neptune 1l', 20, 33000, 2, 2)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (7, N'Dầu Simply 1l', 30, 38000, 2, 2)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (8, N'Pepsi lon', 30, 2200000, 3, 3)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (9, N'Hạt nêm Knorr 1kg', 24, 270000, 4, 4)
INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (10, N'Omo 1kg', 3, 455000, 5, 5)
SET IDENTITY_INSERT [dbo].[MatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (1, N'Đại lý ABC', N'2 An Dương Vương - P2', N'0263345545', N'Bia Sài Gòn')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (2, N'Đại lý Hoàng Thu', N'16 Phù Đổng Thiên Vương', N'0917465276', N'Bia ken, tiger')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (3, N'Uniliver', N'29 Bùi Thị Xuân', N'02633349878', N'Bột giặt, bột nêm Neptune')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (4, N'Pepsi Co', N'123 Nguyên Tử Lực', N'02633247343', N'Sản phẩm nước ngọt Pepsi, hạt nêm Knorr')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (5, N'Cty Thành Công', N'234 Trần Quý Cáp', N'0983434634', N'Bột giặt Surf')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMatHang] ([MaLoai])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
