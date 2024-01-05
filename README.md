# Move Orders 

## Objectives

Move.Orders คือ Order service ของโครงการ Move พัฒนาด้วย .NET 6.0

## Source code structures

- **Move.Orders.Core** project
    > Class library สำหรับ entities, interfaces ของ Order
- **Move.Orders.Application** project
    > Class library สำหรับ business logic ของ Order เช่น การสร้าง, ลบคำสั่งซื้อ
- **Move.Orders.Infrastructure** project
    > Class library สำหรับ infrastructure ของ Order เช่น repositories, messages, databases
- **Move.Orders.Api** project
    > Web Api ของ Order