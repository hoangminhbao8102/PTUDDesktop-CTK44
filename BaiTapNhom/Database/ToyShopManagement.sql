USE [ToyShopManagement]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 13-Jan-25 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 13-Jan-25 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[InvoiceDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 13-Jan-25 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[InvoiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ToyID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toy]    Script Date: 13-Jan-25 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toy](
	[ToyID] [int] IDENTITY(1,1) NOT NULL,
	[ToyName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[StockQuantity] [int] NOT NULL,
	[Discount] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ToyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ToyCategory]    Script Date: 13-Jan-25 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToyCategory](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber]) VALUES (1, N'Nguyễn Văn A', N'0987654321')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber]) VALUES (2, N'Trần Thị B', N'0981234567')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNumber]) VALUES (3, N'Lê Hoàng C', N'0912345678')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceID], [CustomerID], [InvoiceDate]) VALUES (1, 1, CAST(N'2025-01-13T15:00:16.130' AS DateTime))
INSERT [dbo].[Invoice] ([InvoiceID], [CustomerID], [InvoiceDate]) VALUES (2, 2, CAST(N'2025-01-13T15:00:16.130' AS DateTime))
INSERT [dbo].[Invoice] ([InvoiceID], [CustomerID], [InvoiceDate]) VALUES (3, 3, CAST(N'2025-01-13T15:00:16.130' AS DateTime))
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[InvoiceDetail] ON 

INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (1, 1, 1, 2, CAST(200000.00 AS Decimal(10, 2)))
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (2, 1, 3, 1, CAST(500000.00 AS Decimal(10, 2)))
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (3, 2, 4, 3, CAST(150000.00 AS Decimal(10, 2)))
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (4, 2, 6, 1, CAST(700000.00 AS Decimal(10, 2)))
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (5, 3, 7, 1, CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailID], [InvoiceID], [ToyID], [Quantity], [Price]) VALUES (6, 3, 8, 1, CAST(1000000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[InvoiceDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Toy] ON 

INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (1, N'Bộ ghép hình ABC', 1, CAST(200000.00 AS Decimal(10, 2)), 50, CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (2, N'Bảng chữ cái thông minh', 1, CAST(300000.00 AS Decimal(10, 2)), 30, CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (3, N'Bộ lắp ráp xe hơi', 2, CAST(500000.00 AS Decimal(10, 2)), 20, CAST(15.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (4, N'Bộ màu vẽ sáng tạo', 2, CAST(150000.00 AS Decimal(10, 2)), 100, CAST(0.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (5, N'Bóng đá trẻ em', 3, CAST(100000.00 AS Decimal(10, 2)), 200, CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (6, N'Xe scooter mini', 3, CAST(700000.00 AS Decimal(10, 2)), 15, CAST(20.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (7, N'Mô hình máy bay chiến đấu', 4, CAST(600000.00 AS Decimal(10, 2)), 10, CAST(0.00 AS Decimal(5, 2)))
INSERT [dbo].[Toy] ([ToyID], [ToyName], [CategoryID], [Price], [StockQuantity], [Discount]) VALUES (8, N'Mô hình tàu Titanic', 4, CAST(1000000.00 AS Decimal(10, 2)), 5, CAST(10.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Toy] OFF
GO
SET IDENTITY_INSERT [dbo].[ToyCategory] ON 

INSERT [dbo].[ToyCategory] ([CategoryID], [CategoryName]) VALUES (1, N'Đồ chơi giáo dục')
INSERT [dbo].[ToyCategory] ([CategoryID], [CategoryName]) VALUES (2, N'Đồ chơi sáng tạo')
INSERT [dbo].[ToyCategory] ([CategoryID], [CategoryName]) VALUES (3, N'Đồ chơi vận động')
INSERT [dbo].[ToyCategory] ([CategoryID], [CategoryName]) VALUES (4, N'Đồ chơi mô hình')
SET IDENTITY_INSERT [dbo].[ToyCategory] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Customer__85FB4E381D6FC256]    Script Date: 13-Jan-25 15:01:42 ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT (getdate()) FOR [InvoiceDate]
GO
ALTER TABLE [dbo].[Toy] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD FOREIGN KEY([ToyID])
REFERENCES [dbo].[Toy] ([ToyID])
GO
ALTER TABLE [dbo].[Toy]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[ToyCategory] ([CategoryID])
GO
