select O_ID from orderdetail 
select * from products where P_ID = 6
select * from products where List_ID = 1
SELECT TOP (1000) [P_ID]
      ,[P_Name]
      ,[Price]
      ,[P_Desc]
      ,[P_Image]
      ,[List_ID]
  FROM [IspanPersonalProject_POS].[dbo].[products]
select * from orderdetail 

insert into¡@orderdetail values 

INSERT INTO orderdetail (P_ID, Quantity, TotalPrice, Sugar, Ice, Espresso)
VALUES (11,22,33,44,55,1);

INSERT INTO orderdetail (P_ID, Quantity, TotalPrice, Sugar, Ice, Espresso)
VALUES (@pid, @Quantity, @TotalPrice, @Sugar, @Ice, @Espresso);

INSERT INTO orderdetail (Quantity, TotalPrice, Sugar, Ice, Espresso)
values (11,100,40,40,1)
SELECT o.O_ID, p.P_ID
FROM orderdetail AS o
INNER JOIN products AS p ON o.P_ID = p.P_ID
INNER JOIN orders AS ord ON o.O_ID = ord.O_ID
WHERE ord.O_ID = SCOPE_IDENTITY();

select * from products where List_ID = 4