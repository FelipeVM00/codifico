SELECT companyname CompanyName,
       sum(SalesOrders.freight) TotalFreight,
       sum(PRICE) TotalCostShipped,
       sum(cantidad) TotalItemsShipped
FROM Sales.Shippers SalesShippers
INNER JOIN Sales.Orders SalesOrders ON SalesShippers.shipperid= SalesOrders.shipperid
LEFT JOIN
  (SELECT orderid,
          SUM(UNITPRICE* qty) PRICE,
          Sum(qty) cantidad
   FROM Sales.OrderDetails
   GROUP BY ORDERID) AS SalesOrderDetails ON SalesOrderDetails.orderid = SalesOrders.orderid
GROUP BY companyname
ORDER BY CompanyName