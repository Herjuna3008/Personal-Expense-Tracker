/* ============================================================
   ExpenseTracker — setup database untuk Personal Expense Tracker
   Jalankan di SSMS atau:
       sqlcmd -S .\SQLEXPRESS -E -i ExpenseTracker.sql
   Aman dijalankan berulang (idempotent).
   Connection string aplikasi (DbHelper.cs):
       Server=.\SQLEXPRESS;Database=ExpenseTracker;Integrated Security=True;
   ============================================================ */

IF DB_ID(N'ExpenseTracker') IS NULL
    CREATE DATABASE ExpenseTracker;
GO

USE ExpenseTracker;
GO

/* ── Tabel ──────────────────────────────────────────────────── */

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        UserID    INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
        Username  NVARCHAR(50)      NOT NULL CONSTRAINT UQ_Users_Username UNIQUE,
        Email     NVARCHAR(100)     NOT NULL CONSTRAINT UQ_Users_Email    UNIQUE,
        Password  VARCHAR(64)       NOT NULL,  -- SHA-256 hex lowercase (lihat DbHelper.HashPassword)
        CreatedAt DATETIME          NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT GETDATE()
    );
END
GO

IF OBJECT_ID(N'dbo.Categories', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Categories (
        CategoryID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Categories PRIMARY KEY,
        Name       NVARCHAR(50)      NOT NULL CONSTRAINT UQ_Categories_Name UNIQUE
    );
END
GO

IF OBJECT_ID(N'dbo.Expenses', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Expenses (
        ExpenseID   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Expenses PRIMARY KEY,
        [Date]      DATE              NOT NULL,
        Description NVARCHAR(255)     NULL,
        CategoryID  INT               NOT NULL
            CONSTRAINT FK_Expenses_Categories REFERENCES dbo.Categories (CategoryID),
        Amount      DECIMAL(18,2)     NOT NULL,
        UserID      INT               NOT NULL
            CONSTRAINT FK_Expenses_Users REFERENCES dbo.Users (UserID)
    );

    CREATE INDEX IX_Expenses_UserID_Date ON dbo.Expenses (UserID, [Date]);
END
GO

/* ── Seed: kategori ─────────────────────────────────────────── */

INSERT INTO dbo.Categories (Name)
SELECT v.Name
FROM (VALUES (N'Makanan'), (N'Transport'), (N'Belanja'), (N'Hiburan'), (N'Lainnya')) AS v(Name)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Categories c WHERE c.Name = v.Name);
GO

/* ── Seed: akun test ────────────────────────────────────────────
   Login aplikasi:  email = test@mail.com   password = 123456
   Hash dihitung sama persis dengan DbHelper.HashPassword
   (SHA-256, hex lowercase). */

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Email = N'test@mail.com')
BEGIN
    INSERT INTO dbo.Users (Username, Email, Password)
    VALUES (N'tester', N'test@mail.com',
            LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '123456'), 2)));
END
GO

/* ── Seed: contoh pengeluaran bulan berjalan ────────────────────
   Tanggal dibuat dengan DATEFROMPARTS bulan ini supaya langsung
   muncul di Form Laporan / Crystal Report tanpa ganti filter. */

DECLARE @UserID INT = (SELECT UserID FROM dbo.Users WHERE Email = N'test@mail.com');

IF @UserID IS NOT NULL AND NOT EXISTS (SELECT 1 FROM dbo.Expenses WHERE UserID = @UserID)
BEGIN
    DECLARE @Y INT = YEAR(GETDATE()), @M INT = MONTH(GETDATE());

    INSERT INTO dbo.Expenses ([Date], Description, CategoryID, Amount, UserID)
    SELECT DATEFROMPARTS(@Y, @M, v.Hari), v.Description, c.CategoryID, v.Amount, @UserID
    FROM (VALUES
        ( 1, N'Sarapan bubur ayam',      N'Makanan',   15000),
        ( 2, N'Bensin motor',            N'Transport', 25000),
        ( 3, N'Makan siang warteg',      N'Makanan',   18000),
        ( 5, N'Pulsa internet',          N'Lainnya',   50000),
        ( 7, N'Nonton bioskop',          N'Hiburan',   45000),
        ( 8, N'Belanja mingguan',        N'Belanja',  120000),
        (10, N'Kopi',                    N'Makanan',   22000),
        (12, N'Ojek online',             N'Transport', 14000),
        (14, N'Makan malam ayam geprek', N'Makanan',   20000),
        (15, N'Top up game',             N'Hiburan',   65000)
    ) AS v(Hari, Description, Kategori, Amount)
    INNER JOIN dbo.Categories c ON c.Name = v.Kategori;
END
GO

PRINT 'ExpenseTracker siap. Login test: test@mail.com / 123456';
GO
