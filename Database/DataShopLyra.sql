USE [ShopLyra]
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([ID], [Name], [Alias], [Phone], [Email], [Image], [Logo]) VALUES (2, N'Thời trang', NULL, N'0123456789', N'dahidjj@bfhioa.com', N' ', N' ')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] ON 

INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (1, N'Áo khoác', NULL, 0, NULL, N'imgAoKhoac.svg', N'LogoAoKhoac.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (2, N'Áo len', NULL, 1, NULL, N'imgAoLen.svg', N'LogoAoLen.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (3, N'Áo phông', NULL, 2, NULL, N'imgAoPhong.svg', N'LogoAoPhong.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (4, N'Áo sơ mi', NULL, 3, NULL, N'imgAoSoMi.svg', N'LogoAoSoMi.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (5, N'Chân váy', NULL, 4, NULL, N'imgChanVay.svg', N'LogoChanVay.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (6, N'Giày', NULL, 5, NULL, N'imgGiay.svg', N'LogoGiay.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (7, N'PhuKien', NULL, 6, NULL, N'imgPhuKien', N'LogoPhuKien.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (8, N'Quần', NULL, 7, NULL, N'imgQuan.svg', N'LogoQuan.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (9, N'Túi', NULL, 8, NULL, N'imgTui.svg', N'LogoTui.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
INSERT [dbo].[ProductCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [SeoTitle], [Image], [Logo], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (10, N'Váy', NULL, 9, NULL, N'imgVay.svg', N'LogoVay.svg', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[PostCategories] ON 

INSERT [dbo].[PostCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (1, N'About Lyra', NULL, 1, CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 0)
INSERT [dbo].[PostCategories] ([ID], [Name], [MetaTitle], [DisplayOrder], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome]) VALUES (2, N'Tuyển dụng', NULL, 0, CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[PostCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([ID], [Name], [MetaTitle], [Description], [Images], [Location], [DisplayOrder], [Content], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome], [HotPost], [Remove]) VALUES (3, N'lyra tìm kiếm đối tác nhượng quyền', NULL, N'💙 LYRA TÌM KIẾM ĐỐI TÁC NHƯỢNG QUYỀN TOÀN QUỐC 💙', N' ', NULL, 0, N'💙 LYRA TÌM KIẾM ĐỐI TÁC NHƯỢNG QUYỀN TOÀN QUỐC 💙', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1, 1, 0)
INSERT [dbo].[Post] ([ID], [Name], [MetaTitle], [Description], [Images], [Location], [DisplayOrder], [Content], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome], [HotPost], [Remove]) VALUES (5, N'TUYỂN DỤNG SALE ONLINE LEADER', NULL, N'TUYỂN DỤNG SALE ONLINE LEADER', N' ', NULL, 1, N'TUYỂN DỤNG SALE ONLINE LEADER', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1, 1, 0)
INSERT [dbo].[Post] ([ID], [Name], [MetaTitle], [Description], [Images], [Location], [DisplayOrder], [Content], [CreateDate], [CreateBy], [Modifiledate], [ModifileBy], [Active], [ShowOnHome], [HotPost], [Remove]) VALUES (6, N'HƯỚNG DẪN MUA HÀNG', NULL, N'LYRASHOP hướng dẫn khách hàng các hình thức thanh toán sản phẩm', N' ', NULL, 2, N'LYRASHOP hướng dẫn khách hàng các hình thức thanh toán sản phẩm', CAST(N'2020-07-30' AS Date), NULL, CAST(N'2020-07-30' AS Date), NULL, 1, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
INSERT [dbo].[TagPost] ([CategoryID], [PostID], [Active], [TagName]) VALUES (1, 3, 1, N'About Lyra')
INSERT [dbo].[TagPost] ([CategoryID], [PostID], [Active], [TagName]) VALUES (1, 5, 1, NULL)
INSERT [dbo].[TagPost] ([CategoryID], [PostID], [Active], [TagName]) VALUES (2, 3, 1, N'Tuyển dụng')
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (1, N'#1D86E3', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (2, N'#1D59E3', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (3, N'#0CB41E', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (4, N'#DDE839', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (5, N'#E8C039', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (6, N'#D32719', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (7, N'#BA19D3', 1, 0)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (8, N'Xanh', 1, 3)
INSERT [dbo].[Colors] ([ID], [Color], [Active], [DisplayOrder]) VALUES (9, N'tím', 0, 3)
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
SET IDENTITY_INSERT [dbo].[Sizes] ON 

INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (1, N'M', 1, 1)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (2, N'S', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (3, N'L', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (4, N'XL', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (5, N'XXL', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (6, N'28', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (7, N'29', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (8, N'30', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (10, N'32', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (11, N'33', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (12, N'34', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (13, N'35', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (14, N'36', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (15, N'37', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (16, N'38', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (17, N'39', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (18, N'40', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (19, N'41', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (20, N'42', 1, 2)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (21, N'43', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (22, N'44', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (23, N'45', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (24, N'27', 1, 0)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (32, N'XXXL', 0, 13)
INSERT [dbo].[Sizes] ([ID], [Size], [Active], [DisplayOrder]) VALUES (35, N'XXXL', 1, 3)
SET IDENTITY_INSERT [dbo].[Sizes] OFF
GO
