# KPI Employee Management System

Ứng dụng quản lý KPI nhân viên xây dựng bằng **Blazor Web** với **Microsoft Fluent UI**.

## Tính Năng

- ✅ Hiển thị danh sách KPI nhân viên
- ✅ Thêm mới KPI nhân viên
- ✅ Chỉnh sửa thông tin KPI
- ✅ Xóa KPI nhân viên
- ✅ Làm mới dữ liệu
- ✅ Tìm kiếm và lọc

## Công Nghệ

- **Frontend**: Blazor Web (ASP.NET Core 8+)
- **UI Framework**: Microsoft Fluent UI
- **Database**: Oracle 26c (Local)
- **ORM**: Entity Framework Core 8
- **IDE**: Visual Studio 2022+

## Yêu Cầu Hệ Thống

- .NET 8.0 SDK trở lên
- Oracle 26c
- Visual Studio 2022 / VS Code
- Git

## Cài Đặt

### 1. Clone Repository
```bash
git clone https://github.com/mrhuynhbathanh/KPI-Employee-Management.git
cd KPI-Employee-Management
```

### 2. Cấu Hình Database
- Tạo tablespace trong Oracle
- Chạy script SQL để tạo bảng
- Cập nhật connection string trong `appsettings.json`

### 3. Restore Dependencies
```bash
dotnet restore
```

### 4. Chạy Migration
```bash
dotnet ef database update
```

### 5. Chạy Ứng Dụng
```bash
cd src/KPIEmployeeManagement.Web
dotnet run
```

Truy cập: http://localhost:5000

## Cấu Trúc Project

```
src/
├── KPIEmployeeManagement.Web/       # Blazor Web App (Main)
├── KPIEmployeeManagement.Core/      # Business Logic & Models
└── KPIEmployeeManagement.Data/      # Database & EF Core
```

## Database Schema

### Table: KPI_EMP2

```sql
CREATE TABLE KPI_EMP2 (
    SEQ         NUMBER PRIMARY KEY,
    BRCD        CHAR(4 BYTE),
    TRCTCD      VARCHAR2(2 BYTE),
    CUST_ID     VARCHAR2(50 BYTE),
    EMPNO       VARCHAR2(50 BYTE),
    GRPNO       VARCHAR2(20 BYTE),
    USER_ID     VARCHAR2(20 BYTE),
    EMPLOYEE    VARCHAR2(100 BYTE),
    EMAIL       VARCHAR2(100 BYTE),
    DEPARTMENT  VARCHAR2(100 BYTE),
    STATUS      CHAR(1 BYTE),
    TRDT        VARCHAR2(10 BYTE)
);
```

## Hướng Dẫn Sử Dụng

### Thêm KPI Mới
1. Click nút "Thêm"
2. Điền thông tin nhân viên
3. Click "Lưu"

### Chỉnh Sửa
1. Click nút "Sửa" trên hàng cần chỉnh sửa
2. Cập nhật thông tin
3. Click "Lưu"

### Xóa
1. Click nút "Xóa" trên hàng cần xóa
2. Xác nhận xóa

### Làm Mới
- Click nút "Làm Mới" để tải lại dữ liệu từ database

## Author

**Huỳnh Bá Thạnh**

## License

MIT
