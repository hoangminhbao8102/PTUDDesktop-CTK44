-- ================================================
-- Template generated from Template Explorer using:
--1. Viết hết các thủ tục Insert, Update, Delete cho tất cả các bảng nêu trên.
CREATE PROCEDURE InsertCategory
    @Name NVARCHAR(1000),
    @Type INT
AS
BEGIN
    INSERT INTO Category (Name, Type) VALUES (@Name, @Type);
END;
GO

CREATE PROCEDURE UpdateCategory
    @ID INT,
    @Name NVARCHAR(1000),
    @Type INT
AS
BEGIN
    UPDATE Category SET Name = @Name, Type = @Type WHERE ID = @ID;
END;
GO

CREATE PROCEDURE DeleteCategory
    @ID INT
AS
BEGIN
    DELETE FROM Category WHERE ID = @ID;
END;
GO

--2. Viết một thủ tục _GetAll để lấy dữ liệu của tất cả các bảng, truyền vào tên bảng.
CREATE PROCEDURE _GetAll
    @TableName NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N'SELECT * FROM ' + @TableName
    EXEC sp_executesql @SQL
END;
GO

--3. Viết một thủ tục _GetByID để lấy dữ liệu của tất cả các bảng có ID là kiểu int, khóa chính và tự tăng. Tham số truyền vào ID và tên bảng.
CREATE PROCEDURE _GetByID
    @ID INT,
    @TableName NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N'SELECT * FROM ' + @TableName + ' WHERE ID = ' + CAST(@ID AS NVARCHAR)
    EXEC sp_executesql @SQL
END;
GO

--4. Viết thủ tục _Delete để xóa dữ liệu của bất kỳ bảng nào có ID là kiểu int, khóa chính và tự tăng. Tham số truyền vào là ID và tên bảng.
CREATE PROCEDURE _Delete
    @ID INT,
    @TableName NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N'DELETE FROM ' + @TableName + ' WHERE ID = ' + CAST(@ID AS NVARCHAR)
    EXEC sp_executesql @SQL
END;
GO

--5. Viết thủ tục để khi thêm quyền vào bảng Role thì tự động gán hết quyền cho các User (Insert vào bảng UserRole, nhưng để Active = false).
CREATE PROCEDURE AddRoleAndAssignToUsers
    @RoleName NVARCHAR(1000),
    @Path NVARCHAR(3000)
AS
BEGIN
    DECLARE @RoleID INT
    INSERT INTO Role (RoleName, Path) VALUES (@RoleName, @Path)
    SET @RoleID = SCOPE_IDENTITY()
    
    INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
    SELECT @RoleID, AccountName, 0, NULL FROM Account
END;
GO

--6. Viết thủ tục thống kê số tiền bán được theo từng loại món ăn, theo ngày
CREATE PROCEDURE GetSalesByFoodCategoryByDate
    @Date SMALLDATETIME
AS
BEGIN
    SELECT c.Name AS CategoryName, SUM(f.Price * bd.Quantity) AS TotalSales
    FROM BillDetails bd
    INNER JOIN Food f ON bd.FoodID = f.ID
    INNER JOIN Category c ON f.FoodCategoryID = c.ID
    INNER JOIN Bills b ON bd.InvoiceID = b.ID
    WHERE CONVERT(DATE, b.CheckoutDate) = @Date
    GROUP BY c.Name
END;
GO

--7. *Viết thủ tục nhập hai bàn làm một
CREATE PROCEDURE MergeTables
    @TableID1 INT,
    @TableID2 INT
AS
BEGIN
    UPDATE Bills SET TableID = @TableID1 WHERE TableID = @TableID2
    DELETE FROM [Table] WHERE ID = @TableID2
END;
GO

--8. *Viết thủ tục tách bàn
CREATE PROCEDURE SplitTable
    @OldTableID INT,
    @NewTableID INT,
    @BillID INT
AS
BEGIN
    UPDATE Bills SET TableID = @NewTableID WHERE ID = @BillID AND TableID = @OldTableID
END;
GO

