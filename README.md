# Coffee-shop

Katicas là phần mềm quản lý quán cà phê được phát triển bằng C# theo mô hình ứng dụng desktop .NET Windows Forms. Dự án tập trung vào việc số hóa các nghiệp vụ vận hành hằng ngày, hỗ trợ nhân viên thao tác nhanh, giảm sai sót và giúp chủ quán theo dõi hoạt động kinh doanh dễ hơn.

Ứng dụng được tổ chức theo kiến trúc 3 lớp, có nhiều màn hình và module riêng cho từng nghiệp vụ. Trong repository này có cả phiên bản dùng SQL Server và phiên bản dùng MongoDB, kèm theo một bản gốc ban đầu để tham khảo và phát triển tiếp.

## Chức năng chính

- Quản lý bán hàng: lập hóa đơn, thanh toán và theo dõi đơn hàng.
- Quản lý thực đơn và kho: quản lý món, nhập - xuất - tồn nguyên liệu, đặt hàng nhà cung cấp.
- Quản lý nhân sự: lưu thông tin nhân viên và phân quyền theo chức vụ.
- Thống kê và báo cáo: theo dõi doanh thu, tình hình kinh doanh và sản phẩm bán chạy.
- Quản trị dữ liệu: phiên bản SQL Server có hỗ trợ backup, restore và mã hóa dữ liệu.

## Cây dự án

```text
/
├── Doc and ppt/                    # Tài liệu, slide thuyết trình
├── mongodb version/
│   └── CafeKaticas/                # Phiên bản dùng MongoDB
│       ├── Control/
│       ├── Form/
│       ├── File/
│       ├── Product_Directory/
│       ├── User_Directory/
│       ├── Resources/
│       └── App.config, Program.cs, Database.cs, ...
├── sql server management tool/
│   └── HQTCSDL/                    # Phiên bản SQL Server, có backup/restore/encode
│       ├── Backup.cs
│       ├── Restore.cs
│       ├── Encrypt.cs
│       ├── Filegroups.cs
│       ├── Security.cs
│       └── Login.cs, App.config, Program.cs, ...
├── original version/
│   └── CafeKaticas/                # Bản gốc / nền tảng ban đầu
│       ├── Control/
│       ├── Form/
│       ├── File/
│       ├── Product_Directory/
│       ├── User_Directory/
│       └── App.config, Program.cs, ...
└── README.md
```

## Tổng quan

Mục tiêu của dự án là xây dựng một hệ thống quản lý quán cà phê dễ dùng, dễ mở rộng và phù hợp với nhu cầu vận hành thực tế. Tùy theo phiên bản, hệ thống có thể được triển khai với SQL Server hoặc MongoDB để phục vụ các hướng phát triển khác nhau.
