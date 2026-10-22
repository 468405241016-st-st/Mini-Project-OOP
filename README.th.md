<div align="center">

[English](README.md) | **ไทย**

# Mini Project OOP — ระบบจองห้องพักโรงแรม

โปรแกรมเดสก์ท็อปสำหรับบริหารห้องพัก ลูกค้า และการจอง
เขียนด้วย C# WinForms ใช้ฐานข้อมูล Microsoft Access และมีชั้น Repository ที่เขียนเองครอบ OleDb อีกที

![C#](https://img.shields.io/badge/C%23-WinForms-512BD4)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-5C2D91)
![Database](https://img.shields.io/badge/Database-MS%20Access-A4373A)

</div>

---

## ฟีเจอร์

| หน้า | ทำอะไรได้ |
|------|-----------|
| **Dashboard** | การ์ดสรุป (ห้องทั้งหมด / ว่าง / มีผู้เข้าพัก / ซ่อมบำรุง), การจองล่าสุด 10 รายการ และกล่องสีของทุกห้องตามสถานะ มีปุ่มลัดไปสร้างการจองใหม่ |
| **จองห้องพัก** | ค้นหาลูกค้าเดิมด้วยเบอร์โทร เลขบัตร ชื่อ หรืออีเมล (หรือกรอกลูกค้าใหม่) ตรวจห้องว่างตามช่วงวันที่และประเภทห้อง เลือกห้อง แล้วดูราคาต่อคืนและราคารวม ก่อนบันทึกจะตรวจการจองซ้อนอีกรอบ จึงจองห้องซ้ำไม่ได้ |
| **รายการจอง** | กรองตามสถานะ ช่วงวันที่เช็คอิน/เช็คเอาท์ และคำค้น (ชื่อลูกค้า เบอร์โทร หรือเลขห้อง) เช็คอิน เช็คเอาท์ หรือยกเลิกการจองได้พร้อมถามยืนยัน ช่องสถานะแสดงเป็นสีตามสถานะ |
| **ห้องพัก** | เพิ่ม/แก้ไข/ลบประเภทห้อง (ราคา ความจุ รายละเอียด) และห้องพัก (เลขห้อง ประเภท สถานะ) ประเภทหรือห้องที่ยังถูกใช้งานอยู่จะลบไม่ได้ กด `Esc` หรือคลิกพื้นที่ว่างเพื่อกลับไปโหมดเพิ่ม |
| **ลูกค้า** | เพิ่ม/แก้ไข/ลบลูกค้า ค้นหาทันที (หน่วงเวลาเล็กน้อย) จากชื่อ เบอร์โทร เลขบัตร และอีเมล ลูกค้าที่มีประวัติการจองจะลบไม่ได้ |

สถานะห้องจะถูกคำนวณใหม่จากการจองที่ยัง active ของวันนี้ ทุกครั้งที่เปิด Dashboard และหลังเปลี่ยนสถานะการจองทุกครั้ง (ห้องที่ซ่อมบำรุงอยู่จะไม่ถูกแตะ)

## เทคโนโลยีที่ใช้

- **ภาษา / UI:** C# 7.3, Windows Forms
- **Runtime:** .NET Framework 4.8
- **ฐานข้อมูล:** Microsoft Access (`.accdb`) ผ่าน `System.Data.OleDb` และ ACE OLEDB 12.0
- **การเข้าถึงข้อมูล:** `Repository<T>` แบบ generic ที่ map ด้วย attribute (`[TableName]`, `[ColumnName]`), `Filter` แบบ fluent (ทุกค่าส่งเป็น parameter จึงกัน SQL Injection) และการโหลดข้อมูลที่เกี่ยวข้องแบบ include

## โครงสร้างโปรเจกต์

```
Mini_Project_OOP/
├── Program.cs                  จุดเริ่มต้นโปรแกรม
├── Constants/
│   ├── AppTheme.cs             สี ฟอนต์ และสีป้ายสถานะ
│   └── StatusNames.cs          ชื่อสถานะห้อง / การจองที่ใช้ในฐานข้อมูล
├── Forms/
│   ├── FormMain.cs             หน้าต่างหลัก: เมนูด้านข้าง + พื้นที่แสดงหน้า
│   ├── FormLogin.cs            หน้าเข้าสู่ระบบ
│   ├── DataForm.cs             คลาสฐาน: สถานะรอ จัดการ error และ dialog มาตรฐาน
│   ├── ucDashboard.cs          หน้า Dashboard
│   ├── ucBooking.cs            หน้าจองห้องพัก
│   ├── ucBookingList.cs        หน้ารายการจอง
│   ├── ucRooms.cs              หน้าประเภทห้องและห้องพัก
│   └── ucCustomers.cs          หน้าลูกค้า
├── Helper/
│   ├── TextUtils.cs            จัดรูปเบอร์/เลขบัตร ตรวจอีเมล ตัวช่วยค้นหา
│   └── GridExtensions.cs       เปิด double buffer ให้ DataGridView
├── Model/
│   ├── Models.cs               Entity (Customer, Room, RoomType, Booking, ...)
│   ├── AppUser.cs              ผู้ใช้ที่เข้าสู่ระบบ
│   ├── EntityMap.cs            attribute สำหรับ mapping + cache ผล reflection
│   ├── Filter.cs               ตัวสร้าง WHERE / ORDER BY / TOP แบบ fluent
│   ├── IRepository.cs          สัญญาของ Repository
│   └── Repository.cs           Repository กลางที่ใช้ OleDb
├── Services/
│   ├── DatabaseService.cs      ตัวครอบการเชื่อมต่อ / command ของ OleDb
│   ├── AppData.cs              Repository ของแต่ละตาราง
│   ├── AppDb.cs                พาธฐานข้อมูลสำหรับหน้าเข้าสู่ระบบ
│   ├── CurrentUser.cs          ผู้ใช้ที่กำลังล็อกอิน
│   ├── StatusText.cs           จับคู่ชื่อสถานะ (ไทย / อังกฤษ)
│   └── RoomStatusSync.cs       คำนวณสถานะห้องใหม่จากการจอง
└── Mini_Project_Database.accdb ฐานข้อมูล Access
```

## ฐานข้อมูล

| ตาราง | คอลัมน์ |
|-------|---------|
| `tbl_Customers` | `customer_id`, `full_name`, `phone_number`, `national_id`, `email` |
| `tbl_RoomTypes` | `room_type_id`, `name_type`, `price_per_night`, `capacity`, `desciption` *(สะกดแบบนี้ในฐานข้อมูล)* |
| `tbl_RoomStatus` | `room_status_id`, `status` — `Available`, `Occupied`, `Maintenance` |
| `tbl_Rooms` | `room_id`, `room_number`, `room_type_id`, `room_status_id` |
| `tbl_BookingStatus` | `booking_status_id`, `status` — `Confirmed`, `CheckedIn`, `CheckedOut`, `Cancelled` |
| `tbl_Bookings` | `booking_id`, `customer_id`, `room_id`, `checkin_date`, `checkout_date`, `total_price`, `booking_status_id`, `Created_at` |
| `tbl_Users` | `user_id`, `User_name`, `PassWord`, `full_name`, `user_role` |

## เริ่มต้นใช้งาน

**สิ่งที่ต้องมี**

- Windows และ Visual Studio 2017 ขึ้นไป (workload .NET desktop development)
- .NET Framework 4.8
- [Microsoft Access Database Engine](https://www.microsoft.com/en-us/download/details.aspx?id=54920) (ACE OLEDB 12.0) โดยบิต (32/64) ต้องตรงกับที่ build: configuration Debug ใช้ **64 บิต** (x64) ส่วน Release (AnyCPU) ต้องตรงกับบิตของโปรเซส

**วิธีรัน**

1. เปิดไฟล์ `Mini_Project_OOP.csproj` ด้วย Visual Studio
2. Build แล้วรัน (`F5`)

โปรแกรมจะหาไฟล์ `Mini_Project_Database.accdb` ที่สูงกว่าโฟลเดอร์ของไฟล์ .exe ขึ้นไปสองชั้น (คือโฟลเดอร์โปรเจกต์ เมื่อรันจาก `bin\Debug`)

## หมายเหตุ

- ตอนนี้ `Program.cs` เปิดหน้าต่างหลักตรงๆ ส่วน `FormLogin` เขียนไว้แล้ว ถ้าต้องการให้ล็อกอินก่อนให้เปลี่ยนเป็น `Application.Run(new FormLogin())` โดยหน้าล็อกอินหาฐานข้อมูลข้างๆ ไฟล์ .exe แต่หน้าต่างหลักหาที่สูงขึ้นไปสองชั้น
- รหัสผ่านใน `tbl_Users` เทียบแบบข้อความธรรมดา ควรเข้ารหัส (hash) ก่อนนำไปใช้นอกเหนือจากงานเรียน
