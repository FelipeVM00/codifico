SELECT SalesCustomers.companyname CompanyName,
       MAX(SalesOrders.orderdate) LastOrderDate,
       dateadd(DAY, DATEDIFF(DAY, MIN(SalesOrders.orderdate), MAX(SalesOrders.orderdate)) / COUNT(*), MAX(SalesOrders.orderdate)) NextPredictedOrder
FROM Sales.Orders SalesOrders
INNER JOIN Sales.Customers SalesCustomers ON SalesOrders.custid = SalesCustomers.custid
GROUP BY SalesCustomers.companyname;