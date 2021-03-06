
USE [BCGM_2015]
GO
/****** Object:  StoredProcedure [dbo].[GenRoleFunction]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:upjd
-- Create date:20140803
-- Description:	创建默认权限
-- =============================================
CREATE PROCEDURE [dbo].[GenRoleFunction]
	@rCode nvarchar(30)
AS
BEGIN
	INSERT INTO RoleFunction
	(
		rCode,
		fCode
	)
	SELECT @rCode,cFunction 
	FROM BFunction  WHERE cFunction NOT IN (SELECT fCode FROM  RoleFunction  WHERE rCode=@rCode)
	
END




GO
/****** Object:  Table [dbo].[BFunction]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BFunction](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[cFunction] [nvarchar](50) NULL,
	[cModule] [nvarchar](50) NULL,
	[bMenu] [bit] NULL CONSTRAINT [DF_BFunction_bMenu]  DEFAULT ((1)),
	[cClass] [nvarchar](255) NULL,
 CONSTRAINT [PK_DT_Function] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BRole]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cCode] [nvarchar](30) NOT NULL,
	[cName] [nvarchar](50) NOT NULL,
	[dAddDate] [datetime] NULL CONSTRAINT [DF_BRole_dAddDate]  DEFAULT (getdate()),
	[bEnable] [bit] NULL,
 CONSTRAINT [PK_BRole] PRIMARY KEY CLUSTERED 
(
	[cCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BUser]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uCode] [nvarchar](30) NOT NULL,
	[uName] [nvarchar](30) NULL,
	[uPassword] [nvarchar](120) NULL,
	[uRole] [nvarchar](30) NULL,
	[uDepartment] [nvarchar](20) NULL,
	[uAddtime] [datetime] NULL CONSTRAINT [DF_BUser_uAddtime]  DEFAULT (getdate()),
	[bEnable] [bit] NULL CONSTRAINT [DF_BUser_bEnable]  DEFAULT ((1)),
	[bOperator] [bit] NULL CONSTRAINT [DF_BUser_bOperator]  DEFAULT ((0)),
 CONSTRAINT [PK_BUser_1] PRIMARY KEY CLUSTERED 
(
	[uCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ColumnSeting]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColumnSeting](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[cFormID] [nvarchar](50) NULL,
	[cFormName] [nvarchar](50) NULL,
	[cKey] [nvarchar](50) NULL,
	[cCaption] [nvarchar](50) NOT NULL,
	[iVisualPosition] [int] NULL,
	[bHide] [bit] NULL,
	[iWidth] [int] NULL,
 CONSTRAINT [PK_ColumnSeting] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cDepCode] [nvarchar](20) NOT NULL,
	[cDepName] [nvarchar](255) NOT NULL,
	[cDepPerson] [nvarchar](20) NULL,
	[dAddDate] [datetime] NULL CONSTRAINT [DF_Department_dAddDate]  DEFAULT (getdate()),
	[bEnable] [bit] NULL CONSTRAINT [DF_Department_isEnable]  DEFAULT ((1)),
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[cDepCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoleFunction]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleFunction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rCode] [nvarchar](30) NULL,
	[fCode] [nvarchar](50) NULL,
	[bRight] [bit] NULL CONSTRAINT [DF_RoleFunction_bRight]  DEFAULT ((0)),
 CONSTRAINT [PK_RoleFunction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_BUserRole]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_BUserRole]
AS
SELECT   dbo.BRole.cCode AS rCode, dbo.BRole.cName AS rName, dbo.BUser.uCode AS cCode, dbo.BUser.uName AS cName, 
                dbo.BUser.uPassword AS cPwd, dbo.BUser.uDepartment, dbo.BUser.bOperator
FROM      dbo.BRole INNER JOIN
                dbo.BUser ON dbo.BRole.cCode = dbo.BUser.uRole



GO
/****** Object:  View [dbo].[View_RoleAndUser]    Script Date: 2016/2/12 13:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_RoleAndUser]
AS
SELECT   id, cCode, cName
FROM      BRole
union all 
SELECT   id, uCode, uName
FROM      BUser


GO
SET IDENTITY_INSERT [dbo].[BFunction] ON 

INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (9, N'用户管理', N'维护中心', 1, N'BCGM.BaseUser')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (10, N'角色权限管理', N'维护中心', 1, N'BCGM.BaseRoleFunction')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (20, N'表格标题维护', N'维护中心', 1, N'BCGM.BaseColumnManager')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (27, N'条码标签打印', N'条形码管理', 1, N'BCGM.BarCodePrint')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (28, N'条码标签打印记录表', N'条形码管理', 1, N'BCGM.BarCodePrintRecord')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (29, N'产品档案管理', N'条形码管理', 1, N'BCGM.BarCodeInventory')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (30, N'产品入库扫描', N'产品入库管理', 1, N'BCGM.StoreScan')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (31, N'入库扫描记录表', N'产品入库管理', 1, N'BCGM.StoreScanRecord')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (32, N'出库拣货单', N'产品出库管理', 1, N'BCGM.DeliveryOrder')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (33, N'产品出库扫描', N'产品出库管理', 1, N'BCGM.DeliveryScan')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (34, N'产品出库扫描记录表', N'产品出库管理', 1, N'BCGM.DeliveryScanRecord')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (35, N'库存盘点单', N'库存管理', 1, N'BCGM.CheckOrder')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (36, N'盘点扫描', N'库存管理', 1, N'BCGM.CheckScan')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (37, N'盘点扫描记录表', N'库存管理', 1, N'BCGM.CheckScanRecord')
INSERT [dbo].[BFunction] ([ID], [cFunction], [cModule], [bMenu], [cClass]) VALUES (38, N'产品现存量查询', N'库存管理', 1, N'BCGM.CurrentStock')
SET IDENTITY_INSERT [dbo].[BFunction] OFF
SET IDENTITY_INSERT [dbo].[BRole] ON 

INSERT [dbo].[BRole] ([id], [cCode], [cName], [dAddDate], [bEnable]) VALUES (1, N'01', N'管理员', CAST(N'2014-07-05 10:22:30.960' AS DateTime), 1)
INSERT [dbo].[BRole] ([id], [cCode], [cName], [dAddDate], [bEnable]) VALUES (2, N'02', N'测试', CAST(N'2014-11-07 14:14:19.070' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[BRole] OFF
SET IDENTITY_INSERT [dbo].[BUser] ON 

INSERT [dbo].[BUser] ([id], [uCode], [uName], [uPassword], [uRole], [uDepartment], [uAddtime], [bEnable], [bOperator]) VALUES (1, N'001', N'Demo', N'a994daa0c4a76b6a4ef640d41777ec0a', N'01', N'001', CAST(N'2015-10-25 19:57:03.717' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[BUser] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([id], [cDepCode], [cDepName], [cDepPerson], [dAddDate], [bEnable]) VALUES (1, N'001', N'冷冻管理部', NULL, NULL, 1)
INSERT [dbo].[Department] ([id], [cDepCode], [cDepName], [cDepPerson], [dAddDate], [bEnable]) VALUES (2, N'002', N'ddd', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[RoleFunction] ON 

INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (1, N'01', N'用户管理', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (2, N'01', N'角色权限管理', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (3, N'01', N'表格标题维护', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (4, N'01', N'条码标签打印', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (5, N'01', N'条码标签打印记录表', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (6, N'01', N'产品档案管理', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (7, N'01', N'产品入库扫描', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (8, N'01', N'入库扫描记录表', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (9, N'01', N'出库拣货单', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (10, N'01', N'产品出库扫描', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (11, N'01', N'产品出库扫描记录表', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (12, N'01', N'库存盘点单', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (13, N'01', N'盘点扫描', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (14, N'01', N'盘点扫描记录表', 1)
INSERT [dbo].[RoleFunction] ([id], [rCode], [fCode], [bRight]) VALUES (15, N'01', N'产品现存量查询', 1)
SET IDENTITY_INSERT [dbo].[RoleFunction] OFF
ALTER TABLE [dbo].[BUser]  WITH CHECK ADD  CONSTRAINT [FK_BUser_uDepartment] FOREIGN KEY([uDepartment])
REFERENCES [dbo].[Department] ([cDepCode])
GO
ALTER TABLE [dbo].[BUser] CHECK CONSTRAINT [FK_BUser_uDepartment]
GO
ALTER TABLE [dbo].[BUser]  WITH CHECK ADD  CONSTRAINT [FK_BUser_uRole] FOREIGN KEY([uRole])
REFERENCES [dbo].[BRole] ([cCode])
GO
ALTER TABLE [dbo].[BUser] CHECK CONSTRAINT [FK_BUser_uRole]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[31] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BRole"
            Begin Extent = 
               Top = 14
               Left = 354
               Bottom = 153
               Right = 503
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "BUser"
            Begin Extent = 
               Top = 14
               Left = 50
               Bottom = 208
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BUserRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BUserRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RoleAndUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RoleAndUser'
GO
USE [master]
GO
ALTER DATABASE [BCGM_2015] SET  READ_WRITE 
GO
