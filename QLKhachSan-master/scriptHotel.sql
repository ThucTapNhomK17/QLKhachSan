USE [Hotel_SoftWare]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuThue](
	[MaChiTietPhieuThue] [varchar](8) NOT NULL,
	[NgayVao] [date] NULL,
	[NgayRa] [date] NULL,
	[HinhThucThue] [bit] NULL,
	[SoLuongKhach] [char](1) NULL,
	[MaPhong] [varchar](8) NULL,
	[MaPhieuThuePhong] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [varchar](8) NOT NULL,
	[TenDV] [nvarchar](20) NULL,
	[DonGia] [float] NULL,
	[MaLoaiDV] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HinhThucThanhToan]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HinhThucThanhToan](
	[MaHTTT] [varchar](8) NOT NULL,
	[TenHTTT] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHTTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](8) NOT NULL,
	[TienPhong] [float] NULL,
	[TienDV] [float] NULL,
	[TongTien] [float] NULL,
	[NgayThanhToan] [date] NULL,
	[GhiChu] [nvarchar](500) NULL,
	[MaPhieuThuePhong] [varchar](8) NULL,
	[MaHTTT] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](8) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[SoCMND] [char](12) NULL,
	[DiaChi] [nvarchar](20) NULL,
	[SDT] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[MaLoaiDV] [varchar](8) NOT NULL,
	[TenLoaiDV] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoai] [varchar](8) NOT NULL,
	[TenLoai] [nvarchar](30) NULL,
	[SoNguoi] [char](1) NULL,
	[GhiChu] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](8) NOT NULL,
	[TenTk] [varchar](30) NULL,
	[MatKhau] [varchar](30) NULL,
	[Quyen] [bit] NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuThuePhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThuePhong](
	[MaPhieuThuePhong] [varchar](8) NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[MaKH] [varchar](8) NULL,
	[MaNV] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](8) NOT NULL,
	[TenPhong] [nvarchar](20) NULL,
	[TinhTrang] [bit] NULL,
	[DienTich] [char](3) NULL,
	[GiaThue] [float] NULL,
	[MaLoai] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuDungDichVu]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
//Them Truong gia tien
CREATE TABLE [dbo].[SuDungDichVu](
	[MaSD] [varchar](8) NOT NULL,
	[NgaySD] [date] NULL,
	[SoLuong] [char](4) NULL,
	[GiaTien] [float] NULL,
	[MaChiTietPhieuThue] [varchar](8) NULL,
	[MaDV] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT02', CAST(N'2019-08-03' AS Date), CAST(N'2019-08-30' AS Date), 1, N'1', N'MP07', N'MPTP02')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT03', CAST(N'2019-12-07' AS Date), CAST(N'2019-12-17' AS Date), 1, N'2', N'MP07', N'MPTP03')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT04', CAST(N'2019-01-04' AS Date), CAST(N'2019-01-30' AS Date), 1, N'1', N'MP04', N'MPTP04')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT05', CAST(N'2019-12-06' AS Date), CAST(N'2020-12-18' AS Date), 0, N'2', N'MP05', N'MPTP05')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT06', CAST(N'2019-02-12' AS Date), CAST(N'2019-02-25' AS Date), 1, N'2', N'MP04', N'MPTP06')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT07', CAST(N'2019-01-11' AS Date), CAST(N'2019-01-23' AS Date), 1, N'4', N'MP01', N'MPTP07')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT08', CAST(N'2019-06-08' AS Date), CAST(N'2019-06-29' AS Date), 1, N'3', N'MP08', N'MPTP08')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT09', CAST(N'2019-08-09' AS Date), CAST(N'2020-05-20' AS Date), 0, N'2', N'MP09', N'MPTP09')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT10', CAST(N'2019-01-03' AS Date), CAST(N'2019-01-17' AS Date), 0, N'2', N'MP10', N'MPTP10')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT100', CAST(N'1900-01-01' AS Date), NULL, 0, N'*', N'mp01', N'MPTP05')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT11', CAST(N'2019-08-01' AS Date), CAST(N'2020-05-19' AS Date), 0, N'1', N'MP11', N'MPTP11')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT12', CAST(N'2019-02-13' AS Date), CAST(N'2019-02-25' AS Date), 1, N'1', N'MP12', N'MPTP12')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT13', CAST(N'2019-11-05' AS Date), CAST(N'2019-11-17' AS Date), 1, N'1', N'MP13', N'MPTP13')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT14', CAST(N'2019-12-09' AS Date), CAST(N'2020-05-27' AS Date), 0, N'1', N'MP14', N'MPTP14')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT17', CAST(N'2019-03-10' AS Date), CAST(N'2019-03-30' AS Date), 1, N'3', N'MP01', N'MPTP17')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT18', CAST(N'2019-01-01' AS Date), CAST(N'2019-01-26' AS Date), 1, N'3', N'MP02', N'MPTP18')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT19', CAST(N'2019-05-09' AS Date), CAST(N'2019-05-30' AS Date), 1, N'2', N'MP03', N'MPTP19')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT21', CAST(N'2019-07-12' AS Date), CAST(N'2020-07-26' AS Date), 1, N'3', N'MP05', N'MPTP21')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT22', CAST(N'2019-10-02' AS Date), CAST(N'2019-10-16' AS Date), 1, N'3', N'MP06', N'MPTP22')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT23', CAST(N'2019-09-11' AS Date), CAST(N'2019-09-15' AS Date), 1, N'4', N'MP07', N'MPTP23')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT24', CAST(N'2019-11-03' AS Date), CAST(N'2019-11-18' AS Date), 1, N'1', N'MP08', N'MPTP24')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT26', CAST(N'2019-08-08' AS Date), CAST(N'2019-08-22' AS Date), 0, N'2', N'MP10', N'MPTP26')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT28', CAST(N'2019-01-10' AS Date), CAST(N'2019-01-18' AS Date), 1, N'1', N'MP12', N'MPTP28')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT29', CAST(N'2019-02-11' AS Date), CAST(N'2019-02-18' AS Date), 1, N'1', N'MP13', N'MPTP29')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT30', CAST(N'2019-10-02' AS Date), CAST(N'2020-05-20' AS Date), 1, N'2', N'MP16', N'MPTP30')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT31', CAST(N'2019-01-03' AS Date), CAST(N'2019-01-16' AS Date), 1, N'1', N'MP15', N'MPTP31')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT32', CAST(N'2019-02-02' AS Date), CAST(N'2019-02-18' AS Date), 1, N'2', N'MP16', N'MPTP32')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT33', CAST(N'2019-11-02' AS Date), CAST(N'2019-11-15' AS Date), 1, N'2', N'MP01', N'MPTP33')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT34', CAST(N'2019-05-10' AS Date), CAST(N'2019-05-27' AS Date), 1, N'2', N'MP02', N'MPTP34')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT35', CAST(N'2019-09-11' AS Date), CAST(N'2019-09-30' AS Date), 1, N'3', N'MP03', N'MPTP35')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT36', CAST(N'2019-02-09' AS Date), CAST(N'2019-02-24' AS Date), 1, N'1', N'MP04', N'MPTP36')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT37', CAST(N'2019-02-05' AS Date), CAST(N'2020-05-19' AS Date), 1, N'1', N'MP05', N'MPTP37')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT38', CAST(N'2019-02-12' AS Date), CAST(N'2019-02-26' AS Date), 1, N'1', N'MP06', N'MPTP38')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT39', CAST(N'2019-01-03' AS Date), CAST(N'2019-01-23' AS Date), 1, N'2', N'MP07', N'MPTP39')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT41', CAST(N'2020-05-20' AS Date), CAST(N'2020-05-20' AS Date), 0, N'3', N'MP04', N'MPTP60')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT42', CAST(N'2020-05-20' AS Date), CAST(N'2020-05-20' AS Date), 0, N'2', N'MP07', N'MPTP60')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT44', CAST(N'2020-05-19' AS Date), CAST(N'2020-05-20' AS Date), 1, N'2', N'MP07', N'MPTP62')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT45', CAST(N'2020-05-19' AS Date), CAST(N'2020-05-20' AS Date), 1, N'3', N'MP04', N'MPTP62')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT46', CAST(N'2020-05-19' AS Date), CAST(N'2020-05-27' AS Date), 1, N'1', N'MP04', N'MPTP63')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT47', CAST(N'2020-05-20' AS Date), CAST(N'2020-05-20' AS Date), 0, N'1', N'MP04', N'MPTP64')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT48', CAST(N'2020-05-20' AS Date), NULL, 1, N'1', N'MP04', N'MPTP65')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT49', CAST(N'2020-05-20' AS Date), CAST(N'2020-05-27' AS Date), 1, N'2', N'MP07', N'MPTP66')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT50', CAST(N'2020-05-26' AS Date), CAST(N'2020-05-27' AS Date), 1, N'1', N'MP01', N'MPTP71')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT51', CAST(N'2020-05-26' AS Date), CAST(N'2020-05-27' AS Date), 0, N'2', N'MP07', N'MPTP72')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT52', CAST(N'2020-05-27' AS Date), CAST(N'2020-05-28' AS Date), 1, N'1', N'MP10', N'MPTP73')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT53', CAST(N'2020-05-27' AS Date), CAST(N'2020-05-28' AS Date), 1, N'1', N'MP16', N'MPTP74')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT54', CAST(N'2020-05-27' AS Date), NULL, 1, N'1', N'MP04', N'MPTP75')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT55', CAST(N'2020-05-27' AS Date), CAST(N'2020-05-27' AS Date), 1, N'2', N'MP01', N'MPTP78')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT56', CAST(N'2020-05-27' AS Date), CAST(N'2020-05-27' AS Date), 0, N'2', N'MP14', N'MPTP79')
INSERT [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue], [NgayVao], [NgayRa], [HinhThucThue], [SoLuongKhach], [MaPhong], [MaPhieuThuePhong]) VALUES (N'MCTPT57', CAST(N'2020-05-27' AS Date), CAST(N'2020-05-28' AS Date), 1, N'2', N'MP16', N'MPTP80')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV01', N'mì xào hải sản', 100000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV02', N'tôm hùm hấp bia', 1000000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV03', N'cơm rang hải sản', 70000, N'MLDV01')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV04', N'pepsi', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV05', N'7up', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV06', N'trà đào', 15000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV07', N'cocacola', 10000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV08', N'bia sài gòn', 12000, N'MLDV02')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV09', N'hút mụn', 100000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV10', N'massage mặt', 100000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV11', N'xăm môi', 200000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV12', N'xăm lông mày', 150000, N'MLDV03')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV13', N'giặt đồ', 50000, N'MLDV04')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV14', N'karaoke', 200000, N'MLDV05')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaLoaiDV]) VALUES (N'MDV15', N'trông trẻ', 80000, N'MLDV06')
INSERT [dbo].[HinhThucThanhToan] ([MaHTTT], [TenHTTT]) VALUES (N'MHTTT01', 1)
INSERT [dbo].[HinhThucThanhToan] ([MaHTTT], [TenHTTT]) VALUES (N'MHTTT02', 0)
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD03', 800000, 200000, 100000, CAST(N'2019-12-07' AS Date), N'', N'MPTP03', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD04', 1000000, 234000, 1234000, CAST(N'2019-01-04' AS Date), N'', N'MPTP04', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD05', 2000000, 368000, 2368000, CAST(N'2019-12-06' AS Date), N'', N'MPTP05', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD06', 350000, 100000, 450000, CAST(N'2020-05-09' AS Date), N'', N'MPTP06', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD07', 7200000, 50000, 7250000, CAST(N'2020-05-09' AS Date), N'test', N'MPTP07', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD08', 12600000, 48000, 12648000, CAST(N'2020-05-09' AS Date), N'test2', N'MPTP08', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD09', 8800000, 600000, 9400000, CAST(N'2020-05-09' AS Date), N'test3', N'MPTP09', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD10', 4200000, 500000, 4700000, CAST(N'2020-05-09' AS Date), N'test4', N'MPTP10', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD11', 6800000, 910000, 7710000, CAST(N'2020-05-17' AS Date), N'', N'MPTP34', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD12', 5200000, 300000, 5500000, CAST(N'2020-05-26' AS Date), N'', N'MPTP33', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD13', 187600000, 400000, 188000000, CAST(N'2020-05-26' AS Date), N'', N'MPTP37', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD14', 9000000, 1000000, 10000000, CAST(N'2020-05-26' AS Date), N'', N'MPTP24', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD16', 4200000, 10000, 4210000, CAST(N'2020-05-26' AS Date), N'', N'MPTP26', N'MHTTT02')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD17', 0, 0, 0, CAST(N'2020-05-27' AS Date), N'', N'MPTP73', N'MHTTT01')
INSERT [dbo].[HoaDon] ([MaHoaDon], [TienPhong], [TienDV], [TongTien], [NgayThanhToan], [GhiChu], [MaPhieuThuePhong], [MaHTTT]) VALUES (N'MHD18', 0, 0, 0, CAST(N'2020-05-27' AS Date), N'', N'MPTP73', N'MHTTT01')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH01', N'Nhật Thị Mai', N'152222791   ', N'Nghệ An', N'0320619713  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH02', N'Cao Thái Thuý', N'152222754   ', N'Hà Nội', N'0360016137  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH03', N'Dương Cao Kỳ Hà', N'120746600   ', N'Quảng Bình', N'0450418548  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH04', N'Cao Thái Thảo', N'160336488   ', N'Thanh Hóa', N'0160947417  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH05', N'Đàm Hoài Hà', N'120435879   ', N'Ninh Bình', N'0450780809  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH06', N'Tôn Thanh Linh', N'160491989   ', N'Hà Nam', N'0980375789  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH07', N'Văn Lê Ngọc', N'160703395   ', N'Thái Bình', N'0320943955  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH08', N'Bùi Thương Quyên', N'150797834   ', N'Nghệ An', N'0920905428  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH09', N'Đinh Thu Tám', N'120163489   ', N'Nghệ An', N'0980681788  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH10', N'Lê Hoài Tám', N'120680791   ', N'Nha Trang', N'0820151829  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH11', N'Phùng Xuân Ly', N'160653256   ', N'Lào Cai', N'0160498848  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH12', N'Bùi Hoàng Ý', N'160669526   ', N'Quảng Ninh', N'0960352339  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH13', N'Lương Hoài Hoa', N'160207401   ', N'Quảng Bình', N'0160821009  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH14', N'Phùng Châu Gấm', N'160240401   ', N'Ninh Thuận', N'0920829114  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH15', N'Phùng Cẩm Hương', N'160390157   ', N'Cần Thơ', N'0960594347  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH16', N'Dương Ngọc Ngọc', N'110777750   ', N'Nghệ An', N'0820078078  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH17', N'Phan Khánh Tâm', N'160156537   ', N'Thái Bình', N'0980383812  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH18', N'Hồ Hải Lan', N'180839147   ', N'Hải Phòng', N'0360640798  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH19', N'Đinh Thái Lan', N'150368448   ', N'Nam Định', N'0450025744  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH21', N'Tăng Cẩm Hậu', N'160629087   ', N'Thanh Hóa', N'0910224056  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH22', N'Phùng Minh Nhân', N'120047740   ', N'Cần Thơ', N'0920871778  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH23', N'Phan Thu An', N'120455940   ', N'Ninh Bình', N'0920988999  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH24', N'Trương Thu Nhi', N'160101736   ', N'Cà Mau', N'0160748499  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH25', N'Lê Bình Tâm', N'160492965   ', N'Quảng Nam', N'0160965763  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH26', N'Nhật Thương Quyên', N'120317947   ', N'Nghệ An', N'0160890526  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH27', N'Đoàn Thái Lệ', N'120295460   ', N'Nghệ An', N'0360692144  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH28', N'Trương Bình Ngân', N'110637257   ', N'Quảng Nam', N'0920621453  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH29', N'Ngô Hoàng Bình Thanh', N'160824064   ', N'Cà Mau', N'0360152802  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH30', N'Nhật Khánh Bích', N'160617515   ', N'Thái Bình', N'0980297473  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH31', N'Lê Thương Gấm', N'110229143   ', N'Thanh Hóa', N'0820694992  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH32', N'Trương Như Huyền', N'120575002   ', N'Hà Nội', N'0820274402  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH33', N'Tôn Minh Nhân', N'120664353   ', N'Phú Thọ', N'0960558366  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH34', N'Chu Thương Oanh', N'120402687   ', N'Yên Bái', N'0820279002  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH35', N'Tôn Bình Giang', N'160463059   ', N'Lai Châu', N'0960449641  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH36', N'Nhật Thái Lụa', N'120100324   ', N'Bắc Giang', N'0980657333  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH37', N'Phan Bình Thanh', N'160460277   ', N'Điện Biên', N'0160315853  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH38', N'Trương Bình Hoa', N'110411267   ', N'Hòa Bình', N'0960696834  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH39', N'Tăng Hoài Hồng', N'160451184   ', N'Sóc Trăng', N'0820157866  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH41', N'Vũ Đình Ngữ', N'187655491   ', N'Thái Bình', N'03444545654 ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoCMND], [DiaChi], [SDT]) VALUES (N'MKH42', N'Dương Thị Thanh', N'187655644   ', N'Nghệ An', N'0356656599  ')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV01', N'đồ ăn')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV02', N'đồ uống')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV03', N'spa')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV04', N'giặt đồ')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV05', N'karaoke')
INSERT [dbo].[LoaiDichVu] ([MaLoaiDV], [TenLoaiDV]) VALUES (N'MLDV06', N'trông trẻ')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP01', N'deluxe', N'3', N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP02', N'luxury', N'3', N'2 giường, 1 điều hòa, 1tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP03', N'superio', N'2', N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [SoNguoi], [GhiChu]) VALUES (N'MLP04', N'suite', N'4', N'2 giường, 1 điều hòa, 1 tivi')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV02', N'1', N'c4ca4238a0b923820dcc509a6f7584', 1, N'Văn Thu Anh', CAST(N'1982-12-21' AS Date), N'0450035805  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV03', N'2', N'c4ca4238a0b923820dcc509a6f7584', 1, N'Phạm Hoài Hương', CAST(N'1982-12-22' AS Date), N'0960375532  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV04', N'3', N'c4ca4238a0b923820dcc509a6f7584', 1, N'Phùng Mỹ Anh', CAST(N'1982-12-23' AS Date), N'0450793868  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV05', N'4', N'c4ca4238a0b923820dcc509a6f7584', 1, N'Chu Thanh Anh', CAST(N'1982-12-24' AS Date), N'0820650522  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV06', N'5', N'c81e728d9d4c2f636f067f89cc1486', 0, N'Ngô Cao Kỳ Lê', CAST(N'1982-12-25' AS Date), N'0920172226  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV07', N'6', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Hoàng Thu Nga', CAST(N'1982-12-26' AS Date), N'0920610346  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV08', N'7', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Trần Khánh Trân', CAST(N'1982-12-27' AS Date), N'0320686497  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV09', N'8', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Hoàng Ngô Diệu Lệ', CAST(N'1982-12-28' AS Date), N'0910978401  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV10', N'9', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Văn Diệu Trang', CAST(N'1982-12-29' AS Date), N'0960382807  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV11', N'12', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Vũ Châu Trân', CAST(N'1982-12-30' AS Date), N'0980032157  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV12', N'13', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Chu Bình Lê', CAST(N'1982-12-31' AS Date), N'0910904579  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV13', N'14', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Đinh Bình Hạnh', CAST(N'1983-01-01' AS Date), N'0980725291  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV14', N'11', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Hoàng Mỹ Nhân', CAST(N'1983-01-02' AS Date), N'0360869541  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV17', N'17', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Đàm Thương Mai', CAST(N'1983-01-05' AS Date), N'0360070222  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV18', N'18', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Ngô Khánh Nhung', CAST(N'1983-01-06' AS Date), N'0820302730  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV19', N'19', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Ngô Hoàng Mỹ Nhân', CAST(N'1983-01-07' AS Date), N'0920411337  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV21', N'21', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Cao Thị Tư', CAST(N'1983-01-09' AS Date), N'0920393917  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV22', N'22', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Cao Hải Nguyệt', CAST(N'1983-01-10' AS Date), N'0360183219  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV23', N'23', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Hồ Hoàng Dung', CAST(N'1983-01-11' AS Date), N'0820700016  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV24', N'24', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Phạm Khánh Trang', CAST(N'1983-01-12' AS Date), N'0980880648  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV28', N'29', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Tăng Hồng Hoa', CAST(N'1983-01-16' AS Date), N'0450952025  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV29', N'28', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Quách Mỹ Anh', CAST(N'1983-01-17' AS Date), N'0450828455  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV30', N'30', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Hồ Hồng Bích', CAST(N'1983-01-18' AS Date), N'0910752424  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV31', N'31', N'c4ca4238a0b923820dcc509a6f7584', 0, N'Lò A Vừ', CAST(N'2020-05-09' AS Date), N'0356545298  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'MNV32', NULL, NULL, NULL, N'Nguyễn Văn Tét', CAST(N'2000-05-18' AS Date), N'0354534448  ')
INSERT [dbo].[NhanVien] ([MaNV], [TenTk], [MatKhau], [Quyen], [HoTen], [NgaySinh], [SDT]) VALUES (N'nvNghi', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP02', N'', N'MKH02', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP03', N'', N'MKH03', N'MNV03')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP04', N'', N'MKH04', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP05', N'', N'MKH05', N'MNV05')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP06', N'', N'MKH06', N'MNV06')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP07', N'', N'MKH07', N'MNV07')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP08', N'', N'MKH08', N'MNV08')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP09', N'', N'MKH09', N'MNV09')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP10', N'', N'MKH10', N'MNV10')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP11', N'', N'MKH11', N'MNV11')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP12', N'', N'MKH12', N'MNV12')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP13', N'', N'MKH13', N'MNV13')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP14', N'', N'MKH14', N'MNV14')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP17', N'', N'MKH17', N'MNV17')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP18', N'', N'MKH18', N'MNV18')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP19', N'', N'MKH19', N'MNV19')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP21', N'', N'MKH21', N'MNV21')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP22', N'', N'MKH22', N'MNV22')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP23', N'', N'MKH23', N'MNV23')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP24', N'', N'MKH24', N'MNV24')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP26', N'', N'MKH26', N'nvNghi')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP28', N'', N'MKH28', N'MNV28')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP29', N'', N'MKH29', N'MNV29')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP30', N'', N'MKH30', N'MNV03')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP31', N'', N'MKH31', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP32', N'', N'MKH32', N'MNV05')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP33', N'', N'MKH33', N'MNV06')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP34', N'', N'MKH34', N'MNV07')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP35', N'', N'MKH35', N'MNV08')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP36', N'', N'MKH36', N'MNV09')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP37', N'', N'MKH37', N'MNV10')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP38', N'', N'MKH38', N'MNV11')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP39', N'', N'MKH39', N'MNV12')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP41', N'', N'MKH02', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP42', N'', N'MKH03', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP43', N'', N'MKH03', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP44', N'', N'MKH05', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP45', N'', N'MKH05', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP46', N'', N'MKH05', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP47', N'', N'MKH04', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP48', N'', N'MKH05', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP49', N'', N'MKH05', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP50', N'', N'MKH04', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP51', N'', N'MKH30', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP52', N'', N'MKH10', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP53', N'', N'MKH09', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP54', N'', N'MKH06', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP55', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP56', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP57', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP58', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP59', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP60', N'', N'MKH41', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP62', N'', N'MKH42', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP63', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP64', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP65', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP66', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP67', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP68', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP69', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP70', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP71', N'', N'MKH11', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP72', N'', N'MKH02', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP73', N'', N'MKH14', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP74', N'', N'MKH14', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP75', N'', N'MKH01', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP76', N'', N'MKH01', N'MNV02')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP77', N'', N'MKH01', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP78', N'', N'MKH01', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP79', N'', N'MKH01', N'MNV04')
INSERT [dbo].[PhieuThuePhong] ([MaPhieuThuePhong], [GhiChu], [MaKH], [MaNV]) VALUES (N'MPTP80', N'', N'MKH01', N'MNV04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP01', N'101', 0, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP02', N'102', 1, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP03', N'103', 1, N'70 ', 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP04', N'104', 0, N'70 ', 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP05', N'201', 1, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP06', N'202', 1, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP07', N'203', 0, N'20 ', 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP08', N'204', 1, N'20 ', 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP09', N'301', 1, N'70 ', 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP10', N'302', 1, N'45 ', 300000, N'MLP01')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP11', N'303', 1, N'70 ', 800000, N'MLP04')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP12', N'304', 1, N'45 ', 300000, N'MLP01')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP13', N'401', 1, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP14', N'402', 0, N'20 ', 600000, N'MLP03')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP15', N'403', 1, N'100', 400000, N'MLP02')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [TinhTrang], [DienTich], [GiaThue], [MaLoai]) VALUES (N'MP16', N'404', 0, N'20 ', 600000, N'MLP03')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD01', CAST(N'2020-05-27' AS Date), N'1   ', 100000, N'MCTPT55', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD02', CAST(N'2019-08-03' AS Date), N'4   ', 4000000, N'MCTPT02', N'MDV02')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD03', CAST(N'2019-12-07' AS Date), N'4   ', 280000, N'MCTPT03', N'MDV03')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD04', CAST(N'2019-01-04' AS Date), N'5   ', 50000, N'MCTPT04', N'MDV04')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD05', CAST(N'2019-12-06' AS Date), N'2   ', 20000, N'MCTPT05', N'MDV05')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD06', CAST(N'2019-02-12' AS Date), N'2   ', 30000, N'MCTPT06', N'MDV06')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD07', CAST(N'2019-01-11' AS Date), N'5   ', 50000, N'MCTPT07', N'MDV07')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD08', CAST(N'2019-06-08' AS Date), N'4   ', 48000, N'MCTPT08', N'MDV08')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD09', CAST(N'2019-08-09' AS Date), N'6   ', 600000, N'MCTPT09', N'MDV09')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD10', CAST(N'2019-01-03' AS Date), N'5   ', 500000, N'MCTPT10', N'MDV10')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD11', CAST(N'2019-08-01' AS Date), N'4   ', 800000, N'MCTPT11', N'MDV11')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD12', CAST(N'2019-02-13' AS Date), N'2   ', 300000, N'MCTPT12', N'MDV12')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD13', CAST(N'2019-11-05' AS Date), N'4   ', 200000, N'MCTPT13', N'MDV13')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD14', CAST(N'2019-12-09' AS Date), N'8   ', 1600000, N'MCTPT14', N'MDV14')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD17', CAST(N'2019-03-10' AS Date), N'7   ', 1000000, N'MCTPT17', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD18', CAST(N'2019-01-01' AS Date), N'9   ', 1000000, N'MCTPT18', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD19', CAST(N'2019-05-09' AS Date), N'9   ', 1000000, N'MCTPT19', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD21', CAST(N'2019-07-12' AS Date), N'8   ', 1000000, N'MCTPT21', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD22', CAST(N'2019-10-02' AS Date), N'1   ', 1000000, N'MCTPT22', N'MDV02')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD23', CAST(N'2019-09-11' AS Date), N'2   ', 1000000, N'MCTPT23', N'MDV02')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD24', CAST(N'2019-11-03' AS Date), N'1   ', 1000000, N'MCTPT24', N'MDV02')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD26', CAST(N'2019-08-08' AS Date), N'1   ', 1000000, N'MCTPT26', N'MDV04')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD28', CAST(N'2019-01-10' AS Date), N'5   ', 1000000, N'MCTPT28', N'MDV05')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD29', CAST(N'2019-02-11' AS Date), N'4   ', 1000000, N'MCTPT29', N'MDV06')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD30', CAST(N'2019-10-02' AS Date), N'2   ', 1000000, N'MCTPT30', N'MDV07')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD31', CAST(N'2019-01-03' AS Date), N'8   ', 1000000, N'MCTPT31', N'MDV10')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD32', CAST(N'2019-02-02' AS Date), N'1   ', 1000000, N'MCTPT32', N'MDV14')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD34', CAST(N'2019-05-10' AS Date), N'4   ', 1000000, N'MCTPT34', N'MDV11')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD35', CAST(N'2019-09-11' AS Date), N'4   ', 1000000, N'MCTPT35', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD36', CAST(N'2019-02-09' AS Date), N'6   ', 1000000, N'MCTPT36', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD37', CAST(N'2019-02-05' AS Date), N'4   ', 1000000, N'MCTPT37', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD38', CAST(N'2019-02-12' AS Date), N'3   ', 1000000, N'MCTPT38', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD39', CAST(N'2019-01-03' AS Date), N'7   ', 1000000, N'MCTPT39', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD42', CAST(N'2020-05-16' AS Date), N'11  ', 110000, N'MCTPT34', N'MDV07')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD43', CAST(N'2020-05-20' AS Date), N'2   ', 2000000, N'MCTPT36', N'MDV08')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD44', CAST(N'2020-05-20' AS Date), N'1   ', 100000, N'MCTPT39', N'MDV01')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD45', CAST(N'2020-05-20' AS Date), N'2   ', 140000, N'MCTPT39', N'MDV03')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD46', CAST(N'2020-05-20' AS Date), N'1   ', 1000000, N'MCTPT36', N'MDV02')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD47', CAST(N'2020-05-20' AS Date), N'3   ', 30000, N'MCTPT36', N'MDV05')
INSERT [dbo].[SuDungDichVu] ([MaSD], [NgaySD], [SoLuong], [GiaTien], [MaChiTietPhieuThue], [MaDV]) VALUES (N'MSD48', CAST(N'2020-05-20' AS Date), N'1   ', 1000000, N'MCTPT49', N'MDV02')
ALTER TABLE [dbo].[ChiTietPhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhieuThuePhong])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThuePhong])
GO
ALTER TABLE [dbo].[ChiTietPhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([MaLoaiDV])
REFERENCES [dbo].[LoaiDichVu] ([MaLoaiDV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaHTTT])
REFERENCES [dbo].[HinhThucThanhToan] ([MaHTTT])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuThuePhong])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThuePhong])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiPhong] ([MaLoai])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([MaChiTietPhieuThue])
REFERENCES [dbo].[ChiTietPhieuThue] ([MaChiTietPhieuThue])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
/****** Object:  StoredProcedure [dbo].[add_CTPT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[add_CTPT](@mactpt varchar(8), @ngayvao date, @htt bit, @slk tinyint, @maphong varchar(8), @mptp varchar(8))
as
INSERT dbo.ChiTietPhieuThue
        ( MaChiTietPhieuThue ,
          NgayVao ,
          HinhThucThue ,
          SoLuongKhach ,
          MaPhong ,
          MaPhieuThuePhong
        )
VALUES  ( @mactpt , -- MaChiTietPhieuThue - varchar(8)
          @ngayvao, -- NgayVao - date
          @htt , -- HinhThucThue - bit
          @slk , -- SoLuongKhach - tinyint
          @maphong , -- MaPhong - varchar(8)
          @mptp  -- MaPhieuThuePhong - varchar(8)
        )

GO
/****** Object:  StoredProcedure [dbo].[addCus]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addCus](@MAKH VARCHAR(8), @TENKH NVARCHAR(30), @CMND CHAR(12), @DIACHI NVARCHAR(20), @SDT CHAR(12))
	 AS
	 BEGIN
		INSERT INTO KhachHang (MaKH, TenKH, SoCMND, DiaChi, SDT) 
		VALUES (@MAKH, @TENKH, @CMND, @DIACHI, @SDT)
	 END
GO
/****** Object:  StoredProcedure [dbo].[addEmp]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addEmp](@MANV VARCHAR(8), @HOTEN NVARCHAR(30), @NGAYSINH DATE, @SDT CHAR(12))
	 AS
	 BEGIN
		INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, SDT) 
		VALUES (@MANV, @HOTEN, @NGAYSINH, @SDT)
	 END
GO
/****** Object:  StoredProcedure [dbo].[addPhieuThuePhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addPhieuThuePhong](@mptp varchar(8), @ghichu nvarchar(250), @makh varchar(8), @manv varchar(8))
as
INSERT dbo.PhieuThuePhong
        ( MaPhieuThuePhong ,
          GhiChu ,
          MaKH ,
          MaNV
        )
VALUES  ( @mptp, -- MaPhieuThuePhong - varchar(8)
          @ghichu , -- GhiChu - nvarchar(250)
          @makh, -- MaKH - varchar(8)
          @manv  -- MaNV - varchar(8)
        )

GO
/****** Object:  StoredProcedure [dbo].[addRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addRoom](@MAPHONG VARCHAR(8), @TENPHONG NVARCHAR(30), @TINHTRANG TINYINT, @DIENTICH INT, @GIATHUE FLOAT, @MALOAI VARCHAR(8))
	 AS
	 BEGIN
		INSERT INTO Phong(MaPhong, TenPhong, TinhTrang, DienTich, GiaThue, MaLoai) 
		VALUES (@MAPHONG, @TENPHONG, @TINHTRANG, @DIENTICH, @GIATHUE, @MALOAI)
	 END

GO
/****** Object:  StoredProcedure [dbo].[addSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addSer](@MADV VARCHAR(8), @TENDV NVARCHAR(20), @DONGIA FLOAT,@MALOAIDICHVU VARCHAR(8))
	 AS
	 BEGIN
		INSERT INTO DichVu(MaDV, TenDV, DonGia, MaLoaiDV) 
		VALUES (@MADV, @TENDV, @DONGIA, @MALOAIDICHVU)
	 END

GO
/****** Object:  StoredProcedure [dbo].[addServiceRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addServiceRoom](@MASD VARCHAR(8), @NGAYSD DATE, @SOLUONG TINYINT, @GIATIEN FLOAT, @MADV VARCHAR(8), @MACTPT VARCHAR(8))
	 AS
	 BEGIN
		INSERT INTO SuDungDichVu(MaSD, NgaySD, SoLuong, GiaTien, MaDV, MaChiTietPhieuThue)
		VALUES (@MASD, @NGAYSD, @SOLUONG, @GIATIEN, @MADV, @MACTPT)
	 END

GO
/****** Object:  StoredProcedure [dbo].[addTypeRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addTypeRoom](@MALOAIPHONG VARCHAR(8), @TENLOAIPHONG NVARCHAR(30), @SONGUOI TINYINT, @GHICHU NVARCHAR(250))
	 AS
	 BEGIN
		INSERT INTO LoaiPhong(MaLoai, TenLoai, SoNguoi, GhiChu) 
		VALUES (@MALOAIPHONG,@TENLOAIPHONG ,@SONGUOI ,@GHICHU)
	 END

GO
/****** Object:  StoredProcedure [dbo].[addTypeSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addTypeSer](@MALOAIDV VARCHAR(8), @TENLOAIDV NVARCHAR(20))
	 AS
	 BEGIN
		INSERT INTO LoaiDichVu(MaLoaiDV, TenLoaiDV) 
		VALUES (@MALOAIDV, @TENLOAIDV)
	 END

GO
/****** Object:  StoredProcedure [dbo].[changePass]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[changePass](@matkhauhientai varchar(30), @idnv varchar(8))
as
UPDATE dbo.NhanVien 
SET MatKhau= @matkhauhientai
WHERE MaNV= @idnv

GO
/****** Object:  StoredProcedure [dbo].[changeStatusRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[changeStatusRoom](@maphong varchar(8))
as
UPDATE dbo.Phong 
SET dbo.Phong.TinhTrang = 
CASE
WHEN TinhTrang = 0 THEN 1
WHEN TinhTrang = 1 THEN 0
END
WHERE MaPhong = @maphong

GO
/****** Object:  StoredProcedure [dbo].[creatBill]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[creatBill](@maHD VARCHAR(8), @tienphong FLOAT, @tiendv FLOAT, @tongtien FLOAT , @ngaytt DATE, @ghichu NVARCHAR(500), @mptp varchar(8), @mhttt VARCHAR(8))
AS
INSERT dbo.HoaDon(MaHoaDon, TienPhong, TienDV, TongTien, NgayThanhToan, GhiChu, MaPhieuThuePhong, MaHTTT) VALUES
(@maHD, @tienphong, @tiendv, @tongtien, @ngaytt, @ghichu, @mptp, @mhttt)

GO
/****** Object:  StoredProcedure [dbo].[delCTPT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delCTPT](@MaChiTietPhieuThue varchar(8))
AS
BEGIN
  DELETE dbo.ChiTietPhieuThue WHERE @MaChiTietPhieuThue = ChiTietPhieuThue.MaChiTietPhieuThue
END

GO
/****** Object:  StoredProcedure [dbo].[delCus]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delCus](@MAKH VARCHAR(8))
	 AS
	 BEGIN
			 DELETE dbo.SuDungDichVu
			 WHERE dbo.SuDungDichVu.MaChiTietPhieuThue = (SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue
														  FROM dbo.KhachHang 
													      JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaKH = KhachHang.MaKH
														  JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong
														  WHERE dbo.KhachHang.MaKH = @MaKH)
			 DELETE dbo.HoaDon 
			 WHERE dbo.HoaDon.MaPhieuThuePhong = (SELECT dbo.PhieuThuePhong.MaPhieuThuePhong
												  FROM dbo.KhachHang
												  JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaKH = KhachHang.MaKH
												  WHERE dbo.KhachHang.MaKH = @MaKH)
			 DELETE dbo.ChiTietPhieuThue 
			 WHERE dbo.ChiTietPhieuThue.MaPhieuThuePhong = (SELECT dbo.PhieuThuePhong.MaPhieuThuePhong
															FROM dbo.KhachHang
															JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaKH = KhachHang.MaKH
															WHERE dbo.KhachHang.MaKH = @MAKH)

			 DELETE dbo.PhieuThuePhong WHERE @MaKH = dbo.PhieuThuePhong.MaKH
			 DELETE dbo.KhachHang WHERE MaKH=@MaKH
	 END

GO
/****** Object:  StoredProcedure [dbo].[delEmp]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delEmp](@MANV VARCHAR(8))
	 AS
	 BEGIN
			 DELETE dbo.SuDungDichVu
			 WHERE dbo.SuDungDichVu.MaChiTietPhieuThue in (SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue 
															FROM dbo.NhanVien
															JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaNV = NhanVien.MaNV
															JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong WHERE
															dbo.NhanVien.MaNV = @MANV)

			 DELETE dbo.ChiTietPhieuThue 
			 WHERE dbo.ChiTietPhieuThue.MaPhieuThuePhong in (SELECT dbo.PhieuThuePhong.MaPhieuThuePhong
															FROM dbo.NhanVien 
															JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaNV = NhanVien.MaNV WHERE
															dbo.NhanVien.MaNV = @MANV)
			 DELETE dbo.HoaDon WHERE dbo.HoaDon.MaPhieuThuePhong in (SELECT dbo.PhieuThuePhong.MaPhieuThuePhong
																		  FROM dbo.NhanVien
																		  JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaNV = NhanVien.MaNV
																		   WHERE
																		  dbo.NhanVien.MaNV = @MANV )
			 DELETE dbo.PhieuThuePhong WHERE @MANV = dbo.PhieuThuePhong.MaNV
			 DELETE dbo.NhanVien WHERE MaNV=@MANV
	 END

GO
/****** Object:  StoredProcedure [dbo].[delRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delRoom](@MAPHONG VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.Phong
     WHERE MaPhong= @MAPHONG
     END

GO
/****** Object:  StoredProcedure [dbo].[delSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delSer](@MADV VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.DichVu
     WHERE MaDV = @MADV
     END

GO
/****** Object:  StoredProcedure [dbo].[delServiceRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delServiceRoom](@MASD VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.SuDungDichVu
     WHERE MaSD = @MASD
     END

GO
/****** Object:  StoredProcedure [dbo].[delTypeRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delTypeRoom](@MALOAIPHONG VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.LoaiPhong
     WHERE MaLoai= @MALOAIPHONG
     END

GO
/****** Object:  StoredProcedure [dbo].[delTypeSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delTypeSer](@MALOAIDV VARCHAR(8))
     AS
     BEGIN
     DELETE dbo.LoaiDichVu
     WHERE MaLoaiDV = @MALOAIDV
     END

GO
/****** Object:  StoredProcedure [dbo].[DSDichVu]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSDichVu]
	 AS
	 BEGIN
		SELECT * FROM DichVu
	 END

GO
/****** Object:  StoredProcedure [dbo].[DSLoaiDichVu]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSLoaiDichVu]
	 AS
	 BEGIN
		SELECT * FROM LoaiDichVu
	 END

GO
/****** Object:  StoredProcedure [dbo].[DSLoaiPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSLoaiPhong]
	 AS
	 BEGIN
		SELECT * FROM LoaiPhong
	 END

GO
/****** Object:  StoredProcedure [dbo].[DSPhieuSDDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSPhieuSDDV]
	 AS
	 BEGIN
		SELECT * FROM SuDungDichVu
	 END

GO
/****** Object:  StoredProcedure [dbo].[DSPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSPhong]
	 AS
	 BEGIN
		SELECT * FROM Phong
	 END

GO
/****** Object:  StoredProcedure [dbo].[DsSDDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DsSDDV]
AS
BEGIN
	SELECT * FROM SuDungDichVu
end
GO
/****** Object:  StoredProcedure [dbo].[DSTenPhongSDDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSTenPhongSDDV]
	 AS
	 BEGIN
		  SELECT TenPhong
FROM Phong
WHERE Phong.TinhTrang = 1
END

GO
/****** Object:  StoredProcedure [dbo].[getAcc1]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAcc1]
as
SELECT dbo.NhanVien.MaNV, dbo.NhanVien.HoTen, dbo.NhanVien.TenTk, dbo.NhanVien.MatKhau, 
CASE WHEN Quyen=0 THEN N'Lễ Tân' WHEN Quyen=1 THEN N'Quản Lý' 
END AS Quyen
FROM dbo.NhanVien

GO
/****** Object:  StoredProcedure [dbo].[getAll_CTPT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getAll_CTPT]
as
SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue, dbo.ChiTietPhieuThue.NgayVao, 
CASE WHEN dbo.ChiTietPhieuThue.HinhThucThue=0 THEN N'Offline' WHEN dbo.ChiTietPhieuThue.HinhThucThue=1 THEN N'Online' end AS hinhthucthue,
dbo.ChiTietPhieuThue.SoLuongKhach, dbo.ChiTietPhieuThue.MaPhong, dbo.ChiTietPhieuThue.MaPhieuThuePhong
FROM ChiTietPhieuThue

GO
/****** Object:  StoredProcedure [dbo].[getallCus]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getallCus]
AS SELECT * FROM dbo.KhachHang
GO
/****** Object:  StoredProcedure [dbo].[getallEmp]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getallEmp]
AS SELECT dbo.NhanVien.MaNV, dbo.NhanVien.HoTen, NgaySinh, SDT FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[getCTPT_FrIdPT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getCTPT_FrIdPT](@mpt varchar(8))
as
SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa,
CASE WHEN dbo.ChiTietPhieuThue.HinhThucThue=0 THEN N'Offline' WHEN dbo.ChiTietPhieuThue.HinhThucThue=1 THEN N'Online' end AS hinhthucthue,
dbo.ChiTietPhieuThue.SoLuongKhach, dbo.ChiTietPhieuThue.MaPhong, dbo.ChiTietPhieuThue.MaPhieuThuePhong
FROM ChiTietPhieuThue WHERE MaPhieuThuePhong=@mpt

GO
/****** Object:  StoredProcedure [dbo].[getCusFrPhieuThue3]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getCusFrPhieuThue3](@maphieuthue Varchar(30), @MaKH varchar(8) out, @tenkh nvarchar(30) out, @soCMND char(12) out, @diachi nvarchar(20) out, @sdt char(12) out, @tennv nvarchar(30) out)
AS
BEGIN
set @MaKH = (select KhachHang.MaKH from KhachHang join PhieuThuePhong on PhieuThuePhong.MaKH = KhachHang.MaKH where MaPhieuThuePhong = @maphieuthue)
set @tenkh = (select KhachHang.TenKH from KhachHang join PhieuThuePhong on PhieuThuePhong.MaKH = KhachHang.MaKH where MaPhieuThuePhong = @maphieuthue)
set @soCMND = (select KhachHang.SoCMND from KhachHang join PhieuThuePhong on PhieuThuePhong.MaKH = KhachHang.MaKH where MaPhieuThuePhong = @maphieuthue)
set @diachi = (select KhachHang.DiaChi from KhachHang join PhieuThuePhong on PhieuThuePhong.MaKH = KhachHang.MaKH where MaPhieuThuePhong = @maphieuthue)
set @sdt = (select KhachHang.SDT from KhachHang join PhieuThuePhong on PhieuThuePhong.MaKH = KhachHang.MaKH where MaPhieuThuePhong = @maphieuthue)
set @tennv = (select NhanVien.HoTen from NhanVien join PhieuThuePhong on PhieuThuePhong.MaNV = NhanVien.MaNV where MaPhieuThuePhong = @maphieuthue)
end

GO
/****** Object:  StoredProcedure [dbo].[getDoanhThuTienDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getDoanhThuTienDV](@ngayvaochon date, @ngayrachon date)
as
SELECT Phong.TenPhong, dbo.DichVu.TenDV, dbo.SuDungDichVu.NgaySD, dbo.SuDungDichVu.SoLuong, dbo.SuDungDichVu.SoLuong*dbo.DichVu.DonGia AS tiendv
FROM dbo.Phong
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhong = Phong.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
JOIN dbo.SuDungDichVu ON SuDungDichVu.MaChiTietPhieuThue = dbo.ChiTietPhieuThue.MaChiTietPhieuThue
JOIN dbo.DichVu ON dbo.DichVu.MaDV = SuDungDichVu.MaDV 
AND @ngayvaochon < NgaySD AND NgaySD < @ngayrachon

GO
/****** Object:  StoredProcedure [dbo].[getDoanhThuTienPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getDoanhThuTienPhong](@ngayvaochon date, @ngayrachon date)
as
SELECT phong.TenPhong, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa, 
DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa) AS SoNgayO, dbo.Phong.GiaThue*DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa) AS TienPhong
FROM dbo.Phong 
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhong = Phong.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
AND NgayVao > @ngayvaochon AND NgayRa < @ngayrachon

GO
/****** Object:  StoredProcedure [dbo].[getFreeRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getFreeRoom]
as
SELECT dbo.Phong.MaPhong, dbo.Phong.TenPhong, dbo.LoaiPhong.TenLoai, dbo.LoaiPhong.SoNguoi, dbo.Phong.DienTich, dbo.Phong.GiaThue 
FROM dbo.Phong, dbo.LoaiPhong
WHERE dbo.Phong.MaLoai = dbo.LoaiPhong.MaLoai AND dbo.Phong.TinhTrang = 0

GO
/****** Object:  StoredProcedure [dbo].[getHTTT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getHTTT]
as
SELECT  
CASE WHEN TenHTTT = 0 THEN N'Tiền mặt' WHEN TenHTTT = 1 THEN N'Thẻ'
END AS httt
FROM HinhThucThanhToan

GO
/****** Object:  StoredProcedure [dbo].[getIdEmpFrAcc]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIdEmpFrAcc](@tentk varchar(30), @matkhau varchar(30))
as
SELECT dbo.NhanVien.MaNV FROM dbo.NhanVien
WHERE TenTk=@tentk AND MatKhau=@matkhau

GO
/****** Object:  StoredProcedure [dbo].[getIdNV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIdNV](@TenTk varchar(30), @MatKhau varchar(30))
as
SELECT dbo.NhanVien.MaNV FROM dbo.NhanVien
WHERE dbo.NhanVien.TenTk = @TenTk AND  MatKhau = @MatKhau
GO
/****** Object:  StoredProcedure [dbo].[getIdPTFromMaPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getIdPTFromMaPhong](@tenphong nvarchar(20))
as
SELECT MAX(dbo.PhieuThuePhong.MaPhieuThuePhong) AS MPTP 
FROM dbo.PhieuThuePhong
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong
JOIN dbo.Phong ON Phong.MaPhong = ChiTietPhieuThue.MaPhong
WHERE dbo.Phong.TenPhong = @tenphong
GO
/****** Object:  StoredProcedure [dbo].[getlistBill]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getlistBill]
as
SELECT dbo.HoaDon.MaHoaDon, TienPhong, TienDV, TongTien, 
CASE WHEN HinhThucThanhToan.TenHTTT = 0 THEN N'Tiền mặt' WHEN HinhThucThanhToan.TenHTTT = 1 THEN N'Thẻ' END AS HinhThucThanhToan,
NgayThanhToan, GhiChu, MaPhieuThuePhong
FROM dbo.HoaDon, HinhThucThanhToan WHERE dbo.HoaDon.MaHTTT = HinhThucThanhToan.MaHTTT

GO
/****** Object:  StoredProcedure [dbo].[getMaDVtoTenDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getMaDVtoTenDV](@TENDV NVARCHAR(20))
     AS
     BEGIN
SELECT DichVu.MaDV
FROM DichVu
WHERE DichVu.TenDV = @TENDV
     END
GO
/****** Object:  StoredProcedure [dbo].[getPermission]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getPermission](@username varchar(30), @password varchar(30))
as
select NhanVien.Quyen from NhanVien
where NhanVien.TenTk = @username and NhanVien.MatKhau = @password

GO
/****** Object:  StoredProcedure [dbo].[getPhieuThue2]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getPhieuThue2]
as
SELECT dbo.PhieuThuePhong.MaPhieuThuePhong, dbo.KhachHang.MaKH, dbo.KhachHang.TenKH
FROM dbo.PhieuThuePhong, dbo.KhachHang
WHERE dbo.KhachHang.MaKH = dbo.PhieuThuePhong.MaKH

GO
/****** Object:  StoredProcedure [dbo].[GiaTienDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GiaTienDV](@madv varchar(8), @soluong tinyint)
as
select distinct DichVu.DonGia*@soluong as giatien 
from DichVu
where @madv = DichVu.MaDV

GO
/****** Object:  StoredProcedure [dbo].[Phong_Thue]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Phong_Thue] (@MaKH varchar(8))
as
begin
  select Phong.MaPhong, TenPhong, MaLoai, MaChiTietPhieuThue from Phong, ChiTietPhieuThue, PhieuThuePhong
  where Phong.MaPhong = ChiTietPhieuThue.MaPhong
  and ChiTietPhieuThue.MaPhieuThuePhong = PhieuThuePhong.MaPhieuThuePhong
  and PhieuThuePhong.MaKH = @MaKH and phong.TinhTrang = 1
end

GO
/****** Object:  StoredProcedure [dbo].[Search_MaCtpt]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Search_MaCtpt](@MaChiTietPhieuThue varchar(8))
AS
SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa,
CASE WHEN dbo.ChiTietPhieuThue.HinhThucThue=0 THEN N'Offline' WHEN dbo.ChiTietPhieuThue.HinhThucThue=1 THEN N'Online' end AS hinhthucthue,
dbo.ChiTietPhieuThue.SoLuongKhach, dbo.ChiTietPhieuThue.MaPhong, dbo.ChiTietPhieuThue.MaPhieuThuePhong
FROM ChiTietPhieuThue WHERE MaChiTietPhieuThue = @MaChiTietPhieuThue

GO
/****** Object:  StoredProcedure [dbo].[Search_MaPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Search_MaPhong](@MaPhong varchar(8))
AS
SELECT dbo.ChiTietPhieuThue.MaChiTietPhieuThue, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa,
CASE WHEN dbo.ChiTietPhieuThue.HinhThucThue=0 THEN N'Offline' WHEN dbo.ChiTietPhieuThue.HinhThucThue=1 THEN N'Online' end AS hinhthucthue,
dbo.ChiTietPhieuThue.SoLuongKhach, dbo.ChiTietPhieuThue.MaPhong, dbo.ChiTietPhieuThue.MaPhieuThuePhong
FROM ChiTietPhieuThue WHERE MaPhong = @MaPhong

GO
/****** Object:  StoredProcedure [dbo].[tienDvDetail]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[tienDvDetail](@maptp varchar(8))
as
SELECT Phong.TenPhong, dbo.DichVu.TenDV, dbo.SuDungDichVu.NgaySD, dbo.SuDungDichVu.SoLuong, dbo.SuDungDichVu.SoLuong*dbo.DichVu.DonGia AS tiendv
FROM dbo.ChiTietPhieuThue
JOIN dbo.Phong ON Phong.MaPhong = ChiTietPhieuThue.MaPhong
JOIN SuDungDichVu ON SuDungDichVu.MaChiTietPhieuThue = ChiTietPhieuThue.MaChiTietPhieuThue
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
JOIN dbo.DichVu ON DichVu.MaDV = SuDungDichVu.MaDV
WHERE PhieuThuePhong.MaPhieuThuePhong = @maptp
GO
/****** Object:  StoredProcedure [dbo].[tienphongDetail]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[tienphongDetail](@mptp VARCHAR(8))
as
SELECT phong.TenPhong, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa, 
DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa) AS SoNgayO,
dbo.Phong.GiaThue*DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa) AS TienPhong
FROM dbo.ChiTietPhieuThue 
JOIN dbo.Phong ON Phong.MaPhong = ChiTietPhieuThue.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
WHERE PhieuThuePhong.MaPhieuThuePhong = @mptp

GO
/****** Object:  StoredProcedure [dbo].[TKidCTPTofRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKidCTPTofRoom](@TENPHONG NVARCHAR(20))
     AS
     BEGIN
SELECT  max(ChiTietPhieuThue.MaChiTietPhieuThue)
FROM  ChiTietPhieuThue , Phong
WHERE 
ChiTietPhieuThue.MaPhong = Phong.MaPhong
and Phong.TenPhong = @TENPHONG 
     END

GO
/****** Object:  StoredProcedure [dbo].[TKPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKPhong](@TENPHONG VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.Phong
     WHERE TenPhong = @TENPHONG
     END

GO
/****** Object:  StoredProcedure [dbo].[TKService]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKService](@TENDV VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.DichVu
     WHERE TenDV = @TENDV
     END

GO
/****** Object:  StoredProcedure [dbo].[TKtypeRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKtypeRoom](@TENLOAIPHONG VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.LoaiPhong
     WHERE TenLoai = @TENLOAIPHONG
     END

GO
/****** Object:  StoredProcedure [dbo].[TKtypeService]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TKtypeService](@TENLOAIDV VARCHAR(8))
     AS
     BEGIN
     SELECT * FROM dbo.LoaiDichVu
     WHERE TenLoaiDV = @TENLOAIDV
     END

GO
/****** Object:  StoredProcedure [dbo].[update_CTPT]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[update_CTPT](@mactpt varchar(8), @ngayvao date, @htt bit, @slk tinyint, @maphong varchar(8), @mptp varchar(8))
as
UPDATE dbo.ChiTietPhieuThue SET 
          NgayVao = @ngayvao ,
          
          HinhThucThue=@htt ,
          SoLuongKhach=@slk ,
          MaPhong =@maphong,
          MaPhieuThuePhong=@mptp WHERE MaChiTietPhieuThue = @mactpt

GO
/****** Object:  StoredProcedure [dbo].[updateAcc]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateAcc](@MANV VARCHAR(8), @tenTK varchar(30), @matkhau varchar(30), @quyen bit)
AS
BEGIN
	UPDATE NhanVien SET TenTk=@tenTK, MatKhau=@matkhau, Quyen=@quyen
	WHERE MaNV=@MANV;
END

GO
/****** Object:  StoredProcedure [dbo].[updateCus]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateCus](@MAKH VARCHAR(8), @TENKH NVARCHAR(30), @CMND CHAR(12), @DIACHI NVARCHAR(20), @SDT CHAR(12))
	 AS
	 BEGIN
		UPDATE KhachHang SET TenKH=@TENKH, SoCMND=@CMND, DiaChi=@DIACHI, SDT=@SDT 
		WHERE MaKH=@MAKH;
	 END
GO
/****** Object:  StoredProcedure [dbo].[updateEmp]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateEmp](@MANV VARCHAR(8), @HOTEN NVARCHAR(30), @NGAYSINH DATE, @SDT CHAR(12))
	 AS
	 BEGIN
		UPDATE NhanVien SET HoTen=@HOTEN, NgaySinh=@NGAYSINH, SDT=@SDT
		WHERE MaNV=@MANV;
	 END
GO
/****** Object:  StoredProcedure [dbo].[updateNgayRa]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateNgayRa] ( @MaChiTietPhieuThue varchar(8), @NgayRa date )
AS
BEGIN 
  UPDATE ChiTietPhieuThue Set NgayRa = @NgayRa
		WHERE MaChiTietPhieuThue = @MaChiTietPhieuThue
end

GO
/****** Object:  StoredProcedure [dbo].[updateRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateRoom](@MAPHONG VARCHAR(8), @TENPHONG NVARCHAR(30), @TINHTRANG TINYINT, @DIENTICH INT, @GIATHUE FLOAT, @MALOAI VARCHAR(8))
	 AS
	 BEGIN
		UPDATE Phong SET TenPhong=@TENPHONG, TinhTrang= @TINHTRANG, DienTich=@DIENTICH, GiaThue=@GIATHUE, MaLoai =@MALOAI
		WHERE MaPhong= @MAPHONG;
	 END

GO
/****** Object:  StoredProcedure [dbo].[updateSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateSer](@MADV VARCHAR(8), @TENDV NVARCHAR(20), @DONGIA FLOAT,@MALOAIDICHVU VARCHAR(8))
	 AS
	 BEGIN
		UPDATE DichVu SET TenDV=@TENDV, DonGia=@DONGIA, MaLoaiDV=@MALOAIDICHVU
		WHERE MaDV=@MADV;
	 END

GO
/****** Object:  StoredProcedure [dbo].[UpdateServiceRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateServiceRoom](@MASD VARCHAR(8), @NGAYSD DATE, @SOLUONG TINYINT, @GIATIEN FLOAT, @MADV VARCHAR(8), @MACTPT VARCHAR(8))
	 AS
	 BEGIN
		UPDATE SuDungDichVu
		SET SoLuong = @SOLUONG, GiaTien = @GIATIEN
		WHERE MaSD = @MASD
	 END

GO
/****** Object:  StoredProcedure [dbo].[updateTypeRoom]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateTypeRoom](@MALOAIPHONG VARCHAR(8), @TENLOAIPHONG NVARCHAR(30), @SONGUOI TINYINT, @GHICHU NVARCHAR(250))
	 AS
	 BEGIN
		UPDATE LoaiPhong SET TenLoai=@TENLOAIPHONG, SoNguoi= @SONGUOI, GhiChu=@GHICHU
		WHERE MaLoai= @MALOAIPHONG;
	 END

GO
/****** Object:  StoredProcedure [dbo].[updateTypeSer]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateTypeSer](@MALOAIDV VARCHAR(8), @TENLOAIDV NVARCHAR(20))
	 AS
	 BEGIN
		UPDATE LoaiDichVu SET TenLoaiDV=@TENLOAIDV
		WHERE MaLoaiDV=@MALOAIDV;
	 END

GO
/****** Object:  StoredProcedure [dbo].[ViewDoanhThuTheoSoTienNhap]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ViewDoanhThuTheoSoTienNhap](@ngayvaochon date, @ngayrachon DATE, @sotien VARCHAR(50))
as
SELECT Phong.TenPhong, 
SUM(dbo.SuDungDichVu.SoLuong*dbo.DichVu.DonGia + dbo.Phong.GiaThue*DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa)) AS TongTien
FROM dbo.Phong
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhong = Phong.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
JOIN dbo.SuDungDichVu ON SuDungDichVu.MaChiTietPhieuThue = dbo.ChiTietPhieuThue.MaChiTietPhieuThue
JOIN dbo.DichVu ON dbo.DichVu.MaDV = SuDungDichVu.MaDV 
AND NgayVao > @ngayvaochon AND NgayRa < @ngayrachon
GROUP BY Phong.TenPhong
HAVING SUM(dbo.SuDungDichVu.SoLuong*dbo.DichVu.DonGia + dbo.Phong.GiaThue*DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa)) > @sotien

GO
/****** Object:  StoredProcedure [dbo].[ViewTienDV]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ViewTienDV](@ngayvaochon date, @ngayrachon date)
as
SELECT Phong.TenPhong, SUM(dbo.SuDungDichVu.SoLuong*dbo.DichVu.DonGia) AS TongTienDV
FROM dbo.Phong
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhong = Phong.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
JOIN dbo.SuDungDichVu ON SuDungDichVu.MaChiTietPhieuThue = dbo.ChiTietPhieuThue.MaChiTietPhieuThue
JOIN dbo.DichVu ON dbo.DichVu.MaDV = SuDungDichVu.MaDV 
AND @ngayvaochon < NgaySD AND NgaySD < @ngayrachon
GROUP BY Phong.TenPhong

GO
/****** Object:  StoredProcedure [dbo].[ViewTienPhong]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ViewTienPhong](@ngayvaochon date, @ngayrachon date)
as
SELECT phong.TenPhong, SUM(dbo.Phong.GiaThue*DATEDIFF(DAY, dbo.ChiTietPhieuThue.NgayVao, dbo.ChiTietPhieuThue.NgayRa)) AS TongTienPhong
FROM dbo.Phong 
JOIN dbo.ChiTietPhieuThue ON ChiTietPhieuThue.MaPhong = Phong.MaPhong
JOIN dbo.PhieuThuePhong ON PhieuThuePhong.MaPhieuThuePhong = ChiTietPhieuThue.MaPhieuThuePhong
AND NgayVao > @ngayvaochon AND NgayRa < @ngayrachon
GROUP BY TenPhong
ORDER BY TenPhong 

GO
/****** Object:  StoredProcedure [dbo].[wellCome]    Script Date: 5/27/2020 8:34:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[wellCome](@TenTk varchar(30), @MatKhau varchar(30))
as
SELECT dbo.NhanVien.HoTen FROM dbo.NhanVien 
WHERE dbo.NhanVien.TenTk = @TenTk AND MatKhau = @MatKhau

GO
