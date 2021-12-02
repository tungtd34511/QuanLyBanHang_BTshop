use QuanLyNuocHoa_BTSHOP
go
insert into XUATXU
values	('Versace',N'Ý',2012,'2015-03-15'),
		('Versace',N'Ý',2013,'2016-03-15'),
		('Versace',N'Ý',2014,'2017-03-15'),
		('Versace',N'Ý',2015,'2018-03-15'),
		('Versace',N'Ý',2016,'2019-03-15')
go
insert into BANGGIA
values	(250000,360000,0),
		(260000,460000,0),
		(270000,560000,0),
		(280000,660000,0),
		(290000,760000,0)
go
insert into MOTASANPHAM
values	(50,'Man EDT','C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\Images\anh1.jpg',N'Thơm mát dịu nhẹ',1),
		(60,' EPT','C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\Images\nuoc-hoa-afnan-supremacy-silver-edp-100ml-60c9ad129a3ed-16062021144938.jpg',N'Thơm mát dịu nhẹ',0),
		(70,' ELT','C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\Images\nuoc-hoa-nu-versace-crystal-noir-eau-de-toilette-5ml-5c6399614b1b7-13022019111321.png',N'Thơm mát dịu nhẹ',0),
		(80,'KDT','C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\Images\nuoc-hoa-versace-bright-crystal-thom-mat-diu-ngot-100ml-5ceb8a6775ec1-27052019135743.jpg',N'Thơm mát dịu nhẹ',1),
		(90,'ZDT','C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\Images\nuoc-hoa-versace-pour-homme-100ml-5cebb1492f218-27052019164337.jpg',N'Thơm mát dịu nhẹ',1)
go
select * from MOTASANPHAM
insert into SANPHAM
values  ('Eros',200,1,'',1,1,9),
		('Eros',300,1,'',1,2,10),
		('Eros',400,1,'',2,1,11),
		('Eros',500,1,'',2,3,12),
		('Eros',600,1,'',1,2,13)
go
insert into KHACHHANG
values  (N'Tạ Duy Tùng','0976909518','tungtdph16451@fpt.edu.vn',N'Hà nội',1),
		(N'Bùi Văn Tiến','0976909518','tungtdph16451@fpt.edu.vn',N'Hà nội',1),
		(N'Trịnh Xuân Sơn','0976909518','tungtdph16451@fpt.edu.vn',N'Hà nội',1),
		(N'Tạ Duy Tùng2','0976909518','tungtdph16451@fpt.edu.vn',N'Hà nội',1),
		(N'Hoàng Minh Đức','0976909518','tungtdph16451@fpt.edu.vn',N'Hà nội',1)
go
select * from KHACHHANG
Delete  from SANPHAM
Where Id = 13
