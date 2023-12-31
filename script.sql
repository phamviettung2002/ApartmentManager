USE [DA_PTUD]
GO
/****** Object:  Table [dbo].[CanHo]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanHo](
	[MaCH] [nchar](10) NOT NULL,
	[TangLau] [int] NOT NULL,
	[GiaCH] [int] NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_CanHo] PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanCu]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanCu](
	[MaDC] [char](5) NOT NULL,
	[TenDC] [nvarchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[NgaySinh] [date] NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[MaCH] [nchar](10) NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_DanCu] PRIMARY KEY CLUSTERED 
(
	[MaDC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanCu_DichVu]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanCu_DichVu](
	[MaDC] [char](5) NOT NULL,
	[MaDV] [char](5) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_DanCu_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDC] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [char](5) NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DienThoai] [nvarchar](50) NULL,
	[ChucVu] [nchar](10) NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 28/06/2023 9:26:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nchar](10) NOT NULL,
	[MatKhau] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH101     ', 1, 100000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH102     ', 1, 150000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH103     ', 1, 100000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH104     ', 1, 90000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH201     ', 2, 200000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH202     ', 2, 200000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH203     ', 2, 150000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH204     ', 2, 230000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH301     ', 3, 250000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH302     ', 3, 300000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH303     ', 3, 320000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH304     ', 3, 300000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH401     ', 4, 420000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH402     ', 4, 400000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH403     ', 4, 450000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH404     ', 4, 410000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH501     ', 5, 540000000, 0)
INSERT [dbo].[CanHo] ([MaCH], [TangLau], [GiaCH], [TrangThai]) VALUES (N'CH502     ', 5, 520000000, 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC001', N'Trần Đạt', N'Nam       ', CAST(N'1965-11-10' AS Date), N'Hà Tĩnh', N'CH101     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC002', N'Phạm Tuân', N'Nam       ', CAST(N'1988-09-25' AS Date), N'Quảng Nam', N'CH103     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC003', N'Võ Hậu', N'Nam       ', CAST(N'1975-06-22' AS Date), N'Bình Phước', N'CH104     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC004', N'Nguyễn Chín', N'Nữ        ', CAST(N'1988-03-07' AS Date), N'TP.HCM', N'CH201     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC005', N'Trần An', N'Nữ        ', CAST(N'1968-07-16' AS Date), N'TP.HCM', N'CH202     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC006', N'Lưu Tư', N'Nữ        ', CAST(N'1970-07-18' AS Date), N'Long An', N'CH203     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC007', N'Lý Nam', N'Nam       ', CAST(N'1965-12-25' AS Date), N'Khánh Hòa', N'CH204     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC008', N'Võ Nhân', N'Nam       ', CAST(N'1965-09-25' AS Date), N'TP.HCM', N'CH301     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC009', N'Nguyễn Sáng', N'Nam       ', CAST(N'1988-10-07' AS Date), N'Vĩnh Phúc', N'CH302     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC010', N'Hồ Sang', N'Nam       ', CAST(N'1965-01-10' AS Date), N'Hà Tĩnh', N'CH304     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC011', N'Duy Khánh', N'Nam       ', CAST(N'1965-03-25' AS Date), N'Bình Phước', N'CH401     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC012', N'Phạm Tùng', N'Nam       ', CAST(N'1975-05-22' AS Date), N'Quảng Nam', N'CH402     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC013', N'Nguyễn Tuyết', N'Nữ        ', CAST(N'1980-11-10' AS Date), N'TP.HCM', N'CH403     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC014', N'Nguyễn Trí', N'Nam       ', CAST(N'1975-03-22' AS Date), N'TP.HCM', N'CH404     ', 0)
INSERT [dbo].[DanCu] ([MaDC], [TenDC], [GioiTinh], [NgaySinh], [QueQuan], [MaCH], [TrangThai]) VALUES (N'DC015', N'Hoàng Sơn', N'Nam       ', CAST(N'1965-08-10' AS Date), N'Tây Ninh', N'CH501     ', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC001', N'DV001', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC001', N'DV002', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC001', N'DV003', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC002', N'DV001', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC002', N'DV009', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC002', N'DV010', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC002', N'DV015', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC003', N'DV004', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC003', N'DV005', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC003', N'DV007', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC004', N'DV005', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC004', N'DV007', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC004', N'DV011', 1)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC005', N'DV006', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC005', N'DV008', 1)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC005', N'DV014', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC006', N'DV012', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC006', N'DV015', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC007', N'DV004', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC007', N'DV008', 1)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC008', N'DV001', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC008', N'DV011', 1)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC008', N'DV013', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC009', N'DV002', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC010', N'DV003', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC011', N'DV009', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC011', N'DV010', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC012', N'DV006', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC013', N'DV001', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC014', N'DV004', 0)
INSERT [dbo].[DanCu_DichVu] ([MaDC], [MaDV], [TrangThai]) VALUES (N'DC015', N'DV008', 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV001', N'Gửi xe', 100000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV002', N'Hồ bơi', 200000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV003', N'Phòng gym', 200000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV004', N'Đổ rác', 50000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV005', N'Nhận hàng giúp', 30000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV006', N'An ninh', 50000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV007', N'Bảo trì căn hộ', 300000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV008', N'Internet', 220000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV009', N'Điện', 300000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV010', N'Nuôi thú cưng', 300000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV011', N'Vệ sinh hành lang', 40000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV012', N'Phòng cháy chữa cháy', 100000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV013', N'Chăm sóc và trồng cây', 80000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV014', N'Nước', 300000, 0)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [TrangThai]) VALUES (N'DV015', N'Thuê xe đạp', 300000, 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV001     ', N'Nguyễn Sơn', N'Nữ        ', CAST(N'1968-11-10' AS Date), N'0964735901', N'Giám Đốc  ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV002     ', N'Trần Nam', N'Nam       ', CAST(N'1989-09-25' AS Date), N'0758352157', N'Quản đốc  ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV003     ', N'Phạm Tâm', N'Nam       ', CAST(N'1985-06-22' AS Date), N'0987594455', N'Tổ trưởng ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV004     ', N'Nguyễn Thảo', N'Nam       ', CAST(N'1988-03-07' AS Date), N'0788994512', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV005     ', N'Nguyễn Khoa', N'Nam       ', CAST(N'1978-07-16' AS Date), N'0987612345', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV006     ', N'Lê Tấn', N'Nam       ', CAST(N'1990-07-18' AS Date), N'0874443125', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV007     ', N'Trần Tài', N'Nam       ', CAST(N'1995-09-25' AS Date), N'0983521563', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV008     ', N'Trần Khoa', N'Nam       ', CAST(N'1988-11-07' AS Date), N'0984531579', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV009     ', N'Nguyễn Minh', N'Nam       ', CAST(N'1965-01-10' AS Date), N'0657894312', N'Bảo vệ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV010     ', N'Nguyễn Phượng', N'Nữ        ', CAST(N'1965-03-25' AS Date), N'0568245682', N'Tạp vụ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV011     ', N'Lê Lệ', N'Nữ        ', CAST(N'1985-05-22' AS Date), N'0784455612', N'Tạp vụ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV012     ', N'Lê Trúc', N'Nữ        ', CAST(N'1980-01-10' AS Date), N'0854742567', N'Tạp vụ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV013     ', N'Trần Ly', N'Nữ        ', CAST(N'1975-03-12' AS Date), N'0965472452', N'Tạp vụ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV014     ', N'Nguyễn Phương', N'Nữ        ', CAST(N'1985-08-10' AS Date), N'0978357357', N'Tạp vụ    ', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [ChucVu], [TrangThai]) VALUES (N'NV015     ', N'Nguyễn Xinh', N'Nữ        ', CAST(N'1988-10-07' AS Date), N'0754745735', N'Tạp vụ    ', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC001     ', N'DC001     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC002     ', N'DC002     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC003     ', N'DC003     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC004     ', N'DC004     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC005     ', N'DC005     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC006     ', N'DC006     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC007     ', N'DC007     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC008     ', N'DC008     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC009     ', N'DC009     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC010     ', N'DC010     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC011     ', N'DC011     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC012     ', N'DC012     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC013     ', N'DC013     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC014     ', N'DC014     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'DC015     ', N'DC015     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV001     ', N'NV001     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV002     ', N'NV002     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV003     ', N'NV003     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV004     ', N'NV004     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV005     ', N'NV005     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV006     ', N'NV006     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV007     ', N'NV007     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV008     ', N'NV008     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV009     ', N'NV009     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV010     ', N'NV010     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV011     ', N'NV011     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV012     ', N'NV012     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV013     ', N'NV013     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV014     ', N'NV014     ')
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'NV015     ', N'NV015     ')
ALTER TABLE [dbo].[DanCu]  WITH CHECK ADD  CONSTRAINT [FK_DanCu_CanHo1] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CanHo] ([MaCH])
GO
ALTER TABLE [dbo].[DanCu] CHECK CONSTRAINT [FK_DanCu_CanHo1]
GO
ALTER TABLE [dbo].[DanCu_DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DanCu_DichVu_DanCu1] FOREIGN KEY([MaDC])
REFERENCES [dbo].[DanCu] ([MaDC])
GO
ALTER TABLE [dbo].[DanCu_DichVu] CHECK CONSTRAINT [FK_DanCu_DichVu_DanCu1]
GO
ALTER TABLE [dbo].[DanCu_DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DanCu_DichVu_DichVu1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[DanCu_DichVu] CHECK CONSTRAINT [FK_DanCu_DichVu_DichVu1]
GO
