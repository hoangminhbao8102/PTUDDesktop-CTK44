--6. Viết hàm tính số tiền bán được theo ngày
CREATE FUNCTION GetTotalSalesByDate(@Date SMALLDATETIME)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Total FLOAT
    SELECT @Total = SUM(Amount) FROM Bills WHERE CONVERT(DATE, CheckoutDate) = @Date
    RETURN ISNULL(@Total, 0)
END;
GO

--7. Viết hàm đếm số lượng món ăn bán được theo ngày
CREATE FUNCTION GetFoodSoldCountByDate(@Date SMALLDATETIME)
RETURNS INT
AS
BEGIN
    DECLARE @Total INT
    SELECT @Total = SUM(bd.Quantity)
    FROM BillDetails bd
    INNER JOIN Bills b ON bd.InvoiceID = b.ID
    WHERE CONVERT(DATE, b.CheckoutDate) = @Date
    RETURN ISNULL(@Total, 0)
END;
GO


