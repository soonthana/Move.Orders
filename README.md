# Move Orders 

## Objectives

Move.Orders คือ Order service ของโครงการ Move พัฒนาด้วย .NET 6.0
Created project on WSL
- On Windows 11 Pro can open and run project correctly.
- On Windows 11 Pro with reopen in Container can open but can't build.
- On Mac OS can open and run project correctly.
- On Mac OS with reopen in Container can open and run project correctly.

## Source code structures

- **Move.Orders.Core** project
    > Class library สำหรับ entities, interfaces ของ Order
- **Move.Orders.Application** project
    > Class library สำหรับ business logic ของ Order เช่น การสร้าง, ลบคำสั่งซื้อ
- **Move.Orders.Infrastructure** project
    > Class library สำหรับ infrastructure ของ Order เช่น repositories, messages, databases
- **Move.Orders.Api** project
    > Web Api ของ Order