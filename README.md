<div align="center">

**English** | [ไทย](README.th.md)

# Mini Project OOP — Hotel Booking System

A Windows desktop app for managing hotel rooms, customers and bookings.
Built with C# WinForms and a Microsoft Access database, with a small hand-written repository layer on top of OleDb.

![C#](https://img.shields.io/badge/C%23-WinForms-512BD4)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-5C2D91)
![Database](https://img.shields.io/badge/Database-MS%20Access-A4373A)

</div>

---

## Features

| Page | What it does |
|------|--------------|
| **Dashboard** | Summary cards (total / available / occupied / maintenance rooms), the 10 most recent bookings, and a colour-coded tile for every room. Has a shortcut to create a new booking. |
| **New booking** | Look up an existing customer by phone, ID card, name or e-mail (or type a new one), check room availability for a date range and room type, pick a room, and see the nightly price and total. Re-checks for conflicts right before saving, so a room cannot be double-booked. |
| **Booking list** | Filter by status, check-in/out date range and keyword (customer name, phone or room number). Check in, check out or cancel a booking, with confirmation. Status cells are colour-coded. |
| **Rooms** | Add, edit and delete room types (price, capacity, description) and rooms (number, type, status). A type or room that is still in use cannot be deleted. `Esc` or clicking empty space returns to "add" mode. |
| **Customers** | Add, edit and delete customers, with instant search (debounced) over name, phone, ID card and e-mail. A customer with booking history cannot be deleted. |

Room status is recalculated from today's active bookings every time the dashboard opens and after every booking status change (rooms under maintenance are left alone).

## Tech stack

- **Language / UI:** C# 7.3, Windows Forms
- **Runtime:** .NET Framework 4.8
- **Database:** Microsoft Access (`.accdb`) through `System.Data.OleDb` and the ACE OLEDB 12.0 provider
- **Data access:** a lightweight generic `Repository<T>` with attribute-based mapping (`[TableName]`, `[ColumnName]`), a fluent `Filter` (all values are parameters, so no SQL injection), and `include`-style loading of related rows

## Project structure

```
Mini_Project_OOP/
├── Program.cs                  Application entry point
├── Constants/
│   ├── AppTheme.cs             Colours, fonts and status badge colours
│   └── StatusNames.cs          Room / booking status names used in the database
├── Forms/
│   ├── FormMain.cs             Shell: sidebar navigation + page host
│   ├── FormLogin.cs            Login screen
│   ├── DataForm.cs             Base class: busy state, error handling, standard dialogs
│   ├── ucDashboard.cs          Dashboard page
│   ├── ucBooking.cs            New booking page
│   ├── ucBookingList.cs        Booking list page
│   ├── ucRooms.cs              Room types and rooms page
│   └── ucCustomers.cs          Customers page
├── Helper/
│   ├── TextUtils.cs            Phone/ID normalising, e-mail validation, search helpers
│   └── GridExtensions.cs       DataGridView double-buffering
├── Model/
│   ├── Models.cs               Entities (Customer, Room, RoomType, Booking, ...)
│   ├── AppUser.cs              Logged-in user
│   ├── EntityMap.cs            Mapping attributes + cached reflection metadata
│   ├── Filter.cs               Fluent WHERE / ORDER BY / TOP builder
│   ├── IRepository.cs          Repository contract
│   └── Repository.cs           Generic OleDb repository
├── Services/
│   ├── DatabaseService.cs      OleDb connection / command wrapper
│   ├── AppData.cs              One repository per table
│   ├── AppDb.cs                Database path for the login screen
│   ├── CurrentUser.cs          Current signed-in user
│   ├── StatusText.cs           Status-name matching (Thai / English)
│   └── RoomStatusSync.cs       Recalculates room status from bookings
└── Mini_Project_Database.accdb Access database
```

## Database

| Table | Columns |
|-------|---------|
| `tbl_Customers` | `customer_id`, `full_name`, `phone_number`, `national_id`, `email` |
| `tbl_RoomTypes` | `room_type_id`, `name_type`, `price_per_night`, `capacity`, `desciption` *(sic)* |
| `tbl_RoomStatus` | `room_status_id`, `status` — `Available`, `Occupied`, `Maintenance` |
| `tbl_Rooms` | `room_id`, `room_number`, `room_type_id`, `room_status_id` |
| `tbl_BookingStatus` | `booking_status_id`, `status` — `Confirmed`, `CheckedIn`, `CheckedOut`, `Cancelled` |
| `tbl_Bookings` | `booking_id`, `customer_id`, `room_id`, `checkin_date`, `checkout_date`, `total_price`, `booking_status_id`, `Created_at` |
| `tbl_Users` | `user_id`, `User_name`, `PassWord`, `full_name`, `user_role` |

## Getting started

**Requirements**

- Windows with Visual Studio 2017 or newer (.NET desktop development workload)
- .NET Framework 4.8
- [Microsoft Access Database Engine](https://www.microsoft.com/en-us/download/details.aspx?id=54920) (ACE OLEDB 12.0). Its bitness must match the build: **64-bit** for the Debug configuration (x64), and the same bitness as the process for Release (AnyCPU).

**Run**

1. Open `Mini_Project_OOP.csproj` in Visual Studio.
2. Build and run (`F5`).

The app looks for `Mini_Project_Database.accdb` two folders above the executable (the project folder when running from `bin\Debug`).

## Notes

- `Program.cs` currently opens the main window directly. `FormLogin` is implemented, so to require sign-in start the app with `Application.Run(new FormLogin())`. Note that the login screen looks for the database next to the executable, while the main window looks two folders up.
- Passwords in `tbl_Users` are compared as plain text. Hash them before using this beyond a coursework project.
