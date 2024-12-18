USE [RestaurantManagement]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalSalesByDate]    Script Date: 18-Dec-24 08:54:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalSalesByDate]
    (@Date DATE)
RETURNS FLOAT
AS
BEGIN
    DECLARE @TotalSales FLOAT;

    SELECT @TotalSales = SUM(bd.Quantity * f.Price)
    FROM [BillDetails] bd
    JOIN [Bills] b ON bd.InvoiceID = b.ID
    JOIN [Food] f ON bd.FoodID = f.ID
    WHERE CAST(b.CheckoutDate AS DATE) = @Date;

    RETURN ISNULL(@TotalSales, 0);
END;
GO
/****** Object:  Table [dbo].[Food]    Script Date: 18-Dec-24 08:54:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFoodQuantityByDate]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetFoodQuantityByDate]
    (@Date DATE)
RETURNS TABLE
AS
RETURN
(
    SELECT f.Name AS FoodName, SUM(bd.Quantity) AS TotalQuantity
    FROM [BillDetails] bd
    JOIN [Bills] b ON bd.InvoiceID = b.ID
    JOIN [Food] f ON bd.FoodID = f.ID
    WHERE CAST(b.CheckoutDate AS DATE) = @Date
    GROUP BY f.Name
);
GO
/****** Object:  Table [dbo].[Account]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'admin', N'123456', N'Admin', N'admin@example.com', N'0123456789', CAST(N'2024-11-18T09:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'staff1', N'password1', N'Staff One', N'staff1@example.com', N'0987654321', CAST(N'2024-11-18T10:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'user1', N'newpass123', N'Nguyễn Văn A', N'a.nguyen@email.com', N'0246813579', CAST(N'2024-06-01T09:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'user2', N'pass5678', N'Trần Thị B', N'b.tran@email.com', N'0135792468', CAST(N'2024-06-01T10:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'user3', N'123456', N'Phạm Minh C', NULL, NULL, CAST(N'2024-12-17T17:42:00' AS SmallDateTime))
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 1, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 3)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (3, 2, 3, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (4, 2, 5, 5)
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Hóa đơn 1', 1, 500000, 0, 5, 1, CAST(N'2024-11-18T12:00:00' AS SmallDateTime), N'user1')
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (2, N'Hóa đơn 2', 2, 800000, 50, 8, 1, CAST(N'2024-11-18T14:00:00' AS SmallDateTime), N'user2')
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai vị', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Hải sản', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Gà', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Cơm', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Thịt', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (7, N'Canh', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Lẩu', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'Bia', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Nước ngọt', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'Cà phê', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'Trà đá', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (13, N'Trà sữa', 0)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Gà hấp', N'Dĩa', 3, 100000, N'')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Cơm chiên hải sản', N'Phần', 4, 150000, N'')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Lẩu thái', N'Nồi', 8, 250000, N'Cay')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Nước ngọt lon', N'Lon', 10, 20000, N'Lạnh')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Bia tươi', N'Ly', 9, 50000, N'Chilled')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Cà phê sữa', N'Ly', 11, 25000, N'Ðá')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Admin', N'/admin', N'Full access')
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Staff', N'/staff', N'Limited access')
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'admin', 1, N'Quản trị viên')
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'staff1', 1, N'Nhân viên phục vụ')
GO
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([Name], [Status], [Capacity], [ID]) VALUES (N'Bàn 1', 1, 4, 1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [ID]) VALUES (N'Bàn 2', 1, 4, 2)
SET IDENTITY_INSERT [dbo].[Table] OFF
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills1] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills1]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Food] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Food]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_Category] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_Category]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_Delete]
    @TableName NVARCHAR(100),
    @ID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'DELETE FROM ' + QUOTENAME(@TableName) + ' WHERE ID = @ID';
    EXEC sp_executesql @SQL, N'@ID INT', @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[_GetAll]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_GetAll]
    @TableName NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'SELECT * FROM ' + QUOTENAME(@TableName);
    EXEC sp_executesql @SQL;
END;
GO
/****** Object:  StoredProcedure [dbo].[_GetByID]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_GetByID]
    @TableName NVARCHAR(100),
    @ID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'SELECT * FROM ' + QUOTENAME(@TableName) + ' WHERE ID = @ID';
    EXEC sp_executesql @SQL, N'@ID INT', @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Account_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Account_Delete]
    @AccountName NVARCHAR(100)
AS
BEGIN
    DELETE FROM [Account]
    WHERE AccountName = @AccountName;
END;
GO
/****** Object:  StoredProcedure [dbo].[Account_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Account_Insert]
    @AccountName NVARCHAR(100),
    @Password NVARCHAR(100),
    @FullName NVARCHAR(100),
    @Email NVARCHAR(200),
    @Tell NVARCHAR(50),
    @DateCreated DATETIME
AS
BEGIN
    INSERT INTO [Account] (AccountName, Password, FullName, Email, Tell, DateCreated)
    VALUES (@AccountName, @Password, @FullName, @Email, @Tell, @DateCreated);
END;
GO
/****** Object:  StoredProcedure [dbo].[Account_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Account_Update]
    @AccountName NVARCHAR(100),
    @Password NVARCHAR(100),
    @FullName NVARCHAR(100),
    @Email NVARCHAR(200),
    @Tell NVARCHAR(50),
    @DateCreated DATETIME
AS
BEGIN
    UPDATE [Account]
    SET Password = @Password, FullName = @FullName, Email = @Email,
        Tell = @Tell, DateCreated = @DateCreated
    WHERE AccountName = @AccountName;
END;
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillDetails_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [BillDetails]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillDetails_Insert]
    @InvoiceID INT,
    @FoodID INT,
    @Quantity INT
AS
BEGIN
    INSERT INTO [BillDetails] (InvoiceID, FoodID, Quantity)
    VALUES (@InvoiceID, @FoodID, @Quantity);
END;
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillDetails_Update]
    @ID INT,
    @InvoiceID INT,
    @FoodID INT,
    @Quantity INT
AS
BEGIN
    UPDATE [BillDetails]
    SET InvoiceID = @InvoiceID, FoodID = @FoodID, Quantity = @Quantity
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Bills_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bills_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [Bills]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Bills_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bills_Insert]
    @Name NVARCHAR(100),
    @TableID INT,
    @Amount FLOAT,
    @Discount FLOAT,
    @Tax FLOAT,
    @Status INT,
    @CheckoutDate DATETIME,
    @Account NVARCHAR(100)
AS
BEGIN
    INSERT INTO [Bills] (Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account)
    VALUES (@Name, @TableID, @Amount, @Discount, @Tax, @Status, @CheckoutDate, @Account);
END;
GO
/****** Object:  StoredProcedure [dbo].[Bills_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bills_Update]
    @ID INT,
    @Name NVARCHAR(100),
    @TableID INT,
    @Amount FLOAT,
    @Discount FLOAT,
    @Tax FLOAT,
    @Status INT,
    @CheckoutDate DATETIME,
    @Account NVARCHAR(100)
AS
BEGIN
    UPDATE [Bills]
    SET Name = @Name, TableID = @TableID, Amount = @Amount, Discount = @Discount,
        Tax = @Tax, Status = @Status, CheckoutDate = @CheckoutDate, Account = @Account
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Category_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [Category]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_Insert]
    @Name NVARCHAR(1000),
    @Type INT
AS
BEGIN
    INSERT INTO [Category] (Name, Type)
    VALUES (@Name, @Type);
END;
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_Update]
    @ID INT,
    @Name NVARCHAR(1000),
    @Type INT
AS
BEGIN
    UPDATE [Category]
    SET Name = @Name, Type = @Type
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Food_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Food_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [Food]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Food_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Food_Insert]
    @Name NVARCHAR(1000),
    @Unit NVARCHAR(100),
    @FoodCategoryID INT,
    @Price FLOAT,
    @Notes NVARCHAR(2000)
AS
BEGIN
    INSERT INTO [Food] (Name, Unit, FoodCategoryID, Price, Notes)
    VALUES (@Name, @Unit, @FoodCategoryID, @Price, @Notes);
END;
GO
/****** Object:  StoredProcedure [dbo].[Food_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Food_Update]
    @ID INT,
    @Name NVARCHAR(1000),
    @Unit NVARCHAR(100),
    @FoodCategoryID INT,
    @Price FLOAT,
    @Notes NVARCHAR(2000)
AS
BEGIN
    UPDATE [Food]
    SET Name = @Name, Unit = @Unit, FoodCategoryID = @FoodCategoryID, 
        Price = @Price, Notes = @Notes
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[MergeTables]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MergeTables]
    @TableID1 INT,
    @TableID2 INT
AS
BEGIN
    UPDATE [Bills]
    SET TableID = @TableID1
    WHERE TableID = @TableID2;

    DELETE FROM [Table] WHERE ID = @TableID2;
END;
GO
/****** Object:  StoredProcedure [dbo].[Role_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Role_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [Role]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Role_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Role_Insert]
    @RoleName NVARCHAR(100),
    @Path NVARCHAR(200),
    @Notes NVARCHAR(200)
AS
BEGIN
    INSERT INTO [Role] (RoleName, Path, Notes)
    VALUES (@RoleName, @Path, @Notes);
END;
GO
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Role_Update]
    @ID INT,
    @RoleName NVARCHAR(100),
    @Path NVARCHAR(200),
    @Notes NVARCHAR(200)
AS
BEGIN
    UPDATE [Role]
    SET RoleName = @RoleName, Path = @Path, Notes = @Notes
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RoleAccount_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [RoleAccount]
    WHERE RoleID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RoleAccount_Insert]
    @RoleID INT,
    @AccountName NVARCHAR(100),
    @Actived BIT,
    @Notes NVARCHAR(200)
AS
BEGIN
    INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
    VALUES (@RoleID, @AccountName, @Actived, @Notes);
END;
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RoleAccount_Update]
    @ID INT,
    @RoleID INT,
    @AccountName NVARCHAR(100),
    @Actived BIT,
    @Notes NVARCHAR(200)
AS
BEGIN
    UPDATE [RoleAccount]
    SET RoleID = @RoleID, AccountName = @AccountName,
        Actived = @Actived, Notes = @Notes
    WHERE RoleID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SalesReport_ByCategory]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalesReport_ByCategory]
    @Date DATE
AS
BEGIN
    SELECT c.Name AS CategoryName, SUM(bd.Quantity * f.Price) AS TotalSales
    FROM [BillDetails] bd
    JOIN [Food] f ON bd.FoodID = f.ID
    JOIN [Category] c ON f.FoodCategoryID = c.ID
    JOIN [Bills] b ON bd.InvoiceID = b.ID
    WHERE CAST(b.CheckoutDate AS DATE) = @Date
    GROUP BY c.Name;
END;
GO
/****** Object:  StoredProcedure [dbo].[SplitTable]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SplitTable]
    @OldTableID INT,
    @NewTableName NVARCHAR(100),
    @Capacity INT
AS
BEGIN
    INSERT INTO [Table] (Name, Status, Capacity)
    VALUES (@NewTableName, 0, @Capacity);

    DECLARE @NewTableID INT = SCOPE_IDENTITY();

    UPDATE [Bills]
    SET TableID = @NewTableID
    WHERE TableID = @OldTableID AND Status = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[Table_Delete]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Table_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [Table]
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Table_Insert]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Table_Insert]
    @Name NVARCHAR(100),
    @Status INT,
    @Capacity INT
AS
BEGIN
    INSERT INTO [Table] (Name, Status, Capacity)
    VALUES (@Name, @Status, @Capacity);
END;
GO
/****** Object:  StoredProcedure [dbo].[Table_Update]    Script Date: 18-Dec-24 08:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Table_Update]
    @ID INT,
    @Name NVARCHAR(100),
    @Status INT,
    @Capacity INT
AS
BEGIN
    UPDATE [Table]
    SET Name = @Name, Status = @Status, Capacity = @Capacity
    WHERE ID = @ID;
END;
GO
