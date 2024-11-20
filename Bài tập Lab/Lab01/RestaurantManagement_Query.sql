--1. Lấy hết thông tin từ các bảng
-- Lấy toàn bộ thông tin từ bảng Category
SELECT * FROM Category;

-- Lấy toàn bộ thông tin từ bảng Table
SELECT * FROM [Table];

-- Lấy toàn bộ thông tin từ bảng Role
SELECT * FROM [Role];

-- Lấy toàn bộ thông tin từ bảng Account
SELECT * FROM Account;

-- Lấy toàn bộ thông tin từ bảng Food
SELECT * FROM Food;

-- Lấy toàn bộ thông tin từ bảng Bills
SELECT * FROM Bills;

-- Lấy toàn bộ thông tin từ bảng BillDetails
SELECT * FROM BillDetails;

-- Lấy toàn bộ thông tin từ bảng RoleAccount
SELECT * FROM RoleAccount;

--2. Lấy thông tin có điều kiện
-- Lấy danh mục có ID = 1 từ bảng Category
SELECT * FROM Category WHERE ID = 1;

-- Lấy thông tin bàn có sức chứa từ 4 trở lên từ bảng Table
SELECT * FROM [Table] WHERE Capacity >= 4;

-- Lấy vai trò có tên là 'Admin' từ bảng Role
SELECT * FROM [Role] WHERE RoleName = 'Admin';

-- Lấy tài khoản có tên đăng nhập 'admin' từ bảng Account
SELECT * FROM Account WHERE AccountName = 'admin';

-- Lấy món ăn có giá trên 20,000 từ bảng Food
SELECT * FROM Food WHERE Price > 20000;

-- Lấy hóa đơn đã thanh toán từ bảng Bills (Status = 1)
SELECT * FROM Bills WHERE Status = 1;

-- Lấy chi tiết hóa đơn có InvoiceID = 1 từ bảng BillDetails
SELECT * FROM BillDetails WHERE InvoiceID = 1;

-- Lấy thông tin từ RoleAccount cho RoleID = 1
SELECT * FROM RoleAccount WHERE RoleID = 1;

--3. Thêm dữ liệu vào các bảng
-- Thêm dữ liệu vào bảng Category
INSERT INTO Category (ID, Name, Type)
VALUES (4, 'Khai vị', 4);

-- Thêm dữ liệu vào bảng Table
INSERT INTO [Table] (ID, Name, Status, Capacity)
VALUES (4, 'Bàn 4', 1, 8);

-- Thêm dữ liệu vào bảng Role
INSERT INTO [Role] (ID, RoleName, Path, Notes)
VALUES (3, 'Quản lý', '/manager', 'Quản lý nhà hàng');

-- Thêm dữ liệu vào bảng Account
INSERT INTO Account (AccountName, Password, FullName, Email, Tell, DateCreated)
VALUES ('manager01', 'pass123', 'Phạm Văn C', 'manager@example.com', '0123456789', GETDATE());

-- Thêm dữ liệu vào bảng Food
INSERT INTO Food (ID, Name, Unit, FoodCategoryID, Price, Notes)
VALUES (4, 'Soup cua', 'Tô', 4, 30000, 'Món khai vị phổ biến');

-- Thêm dữ liệu vào bảng Bills
INSERT INTO Bills (ID, Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account)
VALUES (3, 'Hóa đơn 3', 3, 90000, 5, 5, 0, NULL, 'manager01');

-- Thêm dữ liệu vào bảng BillDetails
INSERT INTO BillDetails (ID, InvoiceID, FoodID, Quantity)
VALUES (4, 3, 4, 2);

-- Thêm dữ liệu vào bảng RoleAccount
INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
VALUES (3, 'manager01', 1, 'Vai trò quản lý');

--4. Cập nhật dữ liệu
-- Cập nhật tên danh mục có ID = 1 trong bảng Category
UPDATE Category 
SET Name = 'Đồ uống có cồn'
WHERE ID = 1;

-- Cập nhật sức chứa của bàn có ID = 2 trong bảng Table
UPDATE [Table] 
SET Capacity = 10
WHERE ID = 2;

-- Cập nhật tên vai trò có ID = 2 trong bảng Role
UPDATE [Role] 
SET RoleName = 'Nhân viên phục vụ'
WHERE ID = 2;

-- Cập nhật email cho tài khoản 'admin' trong bảng Account
UPDATE Account 
SET Email = 'newadmin@example.com'
WHERE AccountName = 'admin';

-- Cập nhật giá món ăn có ID = 3 trong bảng Food
UPDATE Food 
SET Price = 25000
WHERE ID = 3;

-- Cập nhật trạng thái hóa đơn có ID = 2 trong bảng Bills
UPDATE Bills 
SET Status = 1, CheckoutDate = GETDATE()
WHERE ID = 2;

-- Cập nhật số lượng trong chi tiết hóa đơn có ID = 3 trong bảng BillDetails
UPDATE BillDetails 
SET Quantity = 3
WHERE ID = 3;

-- Cập nhật trạng thái kích hoạt trong RoleAccount
UPDATE RoleAccount 
SET Actived = 0
WHERE RoleID = 1 AND AccountName = 'admin';

--5. Xóa dữ liệu
-- Xóa danh mục có ID = 4 trong bảng Category
DELETE FROM Category WHERE ID = 4;

-- Xóa bàn có ID = 4 trong bảng Table
DELETE FROM [Table] WHERE ID = 4;

-- Xóa vai trò có ID = 3 trong bảng Role
DELETE FROM [Role] WHERE ID = 3;

-- Xóa tài khoản có tên đăng nhập 'manager01' trong bảng Account
DELETE FROM Account WHERE AccountName = 'manager01';

-- Xóa món ăn có ID = 4 trong bảng Food
DELETE FROM Food WHERE ID = 4;

-- Xóa hóa đơn có ID = 3 trong bảng Bills
DELETE FROM Bills WHERE ID = 3;

-- Xóa chi tiết hóa đơn có ID = 4 trong bảng BillDetails
DELETE FROM BillDetails WHERE ID = 4;

-- Xóa vai trò gán trong RoleAccount với RoleID = 3
DELETE FROM RoleAccount WHERE RoleID = 3 AND AccountName = 'manager01';
