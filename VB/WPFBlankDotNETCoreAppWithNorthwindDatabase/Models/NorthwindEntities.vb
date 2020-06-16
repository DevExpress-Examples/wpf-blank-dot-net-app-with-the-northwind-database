Imports System
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata
Imports WPFBlankDotNETCoreAppWithNorthwindDatabase.Data

Namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Models
	Partial Public Class NorthwindEntities
		Inherits DbContext

		Public Sub New()
		End Sub

		Public Sub New(ByVal options As DbContextOptions(Of NorthwindEntities))
			MyBase.New(options)
		End Sub

		Public Overridable Property Categories() As DbSet(Of Category)
		Public Overridable Property CustomerDemographics() As DbSet(Of CustomerDemographic)
		Public Overridable Property Customers() As DbSet(Of Customer)
		Public Overridable Property Employees() As DbSet(Of Employee)
		Public Overridable Property OrderDetails() As DbSet(Of OrderDetail)
		Public Overridable Property Orders() As DbSet(Of Order)
		Public Overridable Property Products() As DbSet(Of Product)
		Public Overridable Property Region() As DbSet(Of Region)
		Public Overridable Property Shippers() As DbSet(Of Shipper)
		Public Overridable Property Suppliers() As DbSet(Of Supplier)
		Public Overridable Property Territories() As DbSet(Of Territory)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
			If Not optionsBuilder.IsConfigured Then
				Dim databasepath = DataDirectoryHelper.GetFile("northwind.mdf", "Data")
				optionsBuilder.UseSqlServer("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & databasepath &";Integrated Security=True")
			End If
		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
			modelBuilder.Entity(Of Category)(Sub(entity)
				entity.HasKey(Function(e) e.CategoryId)

				entity.HasIndex(Function(e) e.CategoryName).HasName("CategoryName")

				entity.Property(Function(e) e.CategoryId).HasColumnName("CategoryID")

				entity.Property(Function(e) e.CategoryName).IsRequired().HasMaxLength(15)

				entity.Property(Function(e) e.Description).HasColumnType("ntext")

				entity.Property(Function(e) e.Picture).HasColumnType("image")
			End Sub)

			modelBuilder.Entity(Of CustomerDemographic)(Sub(entity)
				entity.HasKey(Function(e) e.CustomerTypeId).IsClustered(False)

				entity.Property(Function(e) e.CustomerTypeId).HasColumnName("CustomerTypeID").HasMaxLength(10).IsFixedLength()

				entity.Property(Function(e) e.CustomerDesc).HasColumnType("ntext")
			End Sub)

			modelBuilder.Entity(Of Customer)(Sub(entity)
				entity.HasKey(Function(e) e.CustomerId)

				entity.HasIndex(Function(e) e.City).HasName("City")

				entity.HasIndex(Function(e) e.CompanyName).HasName("CompanyName")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.HasIndex(Function(e) e.Region).HasName("Region")

				entity.Property(Function(e) e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength()

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.CompanyName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.ContactName).HasMaxLength(30)

				entity.Property(Function(e) e.ContactTitle).HasMaxLength(30)

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Fax).HasMaxLength(24)

				entity.Property(Function(e) e.Phone).HasMaxLength(24)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)
			End Sub)

			modelBuilder.Entity(Of Employee)(Sub(entity)
				entity.HasKey(Function(e) e.EmployeeId)

				entity.HasIndex(Function(e) e.LastName).HasName("LastName")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.HasIndex(Function(e) e.ReportsTo).HasName("iReportsTo_Employees")

				entity.Property(Function(e) e.EmployeeId).HasColumnName("EmployeeID")

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.BirthDate).HasColumnType("datetime")

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Extension).HasMaxLength(4)

				entity.Property(Function(e) e.FirstName).IsRequired().HasMaxLength(10)

				entity.Property(Function(e) e.HireDate).HasColumnType("datetime")

				entity.Property(Function(e) e.HomePhone).HasMaxLength(24)

				entity.Property(Function(e) e.LastName).IsRequired().HasMaxLength(20)

				entity.Property(Function(e) e.Notes).HasColumnType("ntext")

				entity.Property(Function(e) e.Photo).HasColumnType("image")

				entity.Property(Function(e) e.PhotoPath).HasMaxLength(255)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)

				entity.Property(Function(e) e.Title).HasMaxLength(30)

				entity.Property(Function(e) e.TitleOfCourtesy).HasMaxLength(25)

				entity.HasOne(Function(d) d.ReportsToNavigation).WithMany(Function(p) p.InverseReportsToNavigation).HasForeignKey(Function(d) d.ReportsTo).HasConstraintName("FK_Employees_Employees")
			End Sub)

			modelBuilder.Entity(Of OrderDetail)(Sub(entity)
				entity.HasKey(Function(e) New With {
					Key e.OrderId,
					Key e.ProductId
				}).HasName("PK_Order_Details")

				entity.ToTable("Order Details")

				entity.HasIndex(Function(e) e.OrderId).HasName("OrdersOrder_Details")

				entity.HasIndex(Function(e) e.ProductId).HasName("ProductsOrder_Details")

				entity.Property(Function(e) e.OrderId).HasColumnName("OrderID")

				entity.Property(Function(e) e.ProductId).HasColumnName("ProductID")

				entity.Property(Function(e) e.Quantity).HasDefaultValueSql("((1))")

				entity.Property(Function(e) e.UnitPrice).HasColumnType("money")

				entity.HasOne(Function(d) d.Order).WithMany(Function(p) p.OrderDetails).HasForeignKey(Function(d) d.OrderId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Order_Details_Orders")

				entity.HasOne(Function(d) d.Product).WithMany(Function(p) p.OrderDetails).HasForeignKey(Function(d) d.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Order_Details_Products")
			End Sub)

			modelBuilder.Entity(Of Order)(Sub(entity)
				entity.HasKey(Function(e) e.OrderId)

				entity.HasIndex(Function(e) e.CustomerId).HasName("CustomersOrders")

				entity.HasIndex(Function(e) e.EmployeeId).HasName("EmployeesOrders")

				entity.HasIndex(Function(e) e.OrderDate).HasName("OrderDate")

				entity.HasIndex(Function(e) e.ShipPostalCode).HasName("ShipPostalCode")

				entity.HasIndex(Function(e) e.ShipVia).HasName("ShippersOrders")

				entity.HasIndex(Function(e) e.ShippedDate).HasName("ShippedDate")

				entity.Property(Function(e) e.OrderId).HasColumnName("OrderID")

				entity.Property(Function(e) e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength()

				entity.Property(Function(e) e.EmployeeId).HasColumnName("EmployeeID")

				entity.Property(Function(e) e.Freight).HasColumnType("money").HasDefaultValueSql("((0))")

				entity.Property(Function(e) e.OrderDate).HasColumnType("datetime")

				entity.Property(Function(e) e.RequiredDate).HasColumnType("datetime")

				entity.Property(Function(e) e.ShipAddress).HasMaxLength(60)

				entity.Property(Function(e) e.ShipCity).HasMaxLength(15)

				entity.Property(Function(e) e.ShipCountry).HasMaxLength(15)

				entity.Property(Function(e) e.ShipName).HasMaxLength(40)

				entity.Property(Function(e) e.ShipPostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.ShipRegion).HasMaxLength(15)

				entity.Property(Function(e) e.ShippedDate).HasColumnType("datetime")

				entity.HasOne(Function(d) d.Customer).WithMany(Function(p) p.Orders).HasForeignKey(Function(d) d.CustomerId).HasConstraintName("FK_Orders_Customers")

				entity.HasOne(Function(d) d.Employee).WithMany(Function(p) p.Orders).HasForeignKey(Function(d) d.EmployeeId).HasConstraintName("FK_Orders_Employees")

				entity.HasOne(Function(d) d.ShipViaNavigation).WithMany(Function(p) p.Orders).HasForeignKey(Function(d) d.ShipVia).HasConstraintName("FK_Orders_Shippers")
			End Sub)

			modelBuilder.Entity(Of Product)(Sub(entity)
				entity.HasKey(Function(e) e.ProductId)

				entity.HasIndex(Function(e) e.CategoryId).HasName("CategoryID")

				entity.HasIndex(Function(e) e.ProductName).HasName("ProductName")

				entity.HasIndex(Function(e) e.SupplierId).HasName("SuppliersProducts")

				entity.Property(Function(e) e.ProductId).HasColumnName("ProductID")

				entity.Property(Function(e) e.CategoryId).HasColumnName("CategoryID")

				entity.Property(Function(e) e.ProductName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.QuantityPerUnit).HasMaxLength(20)

				entity.Property(Function(e) e.ReorderLevel).HasDefaultValueSql("((0))")

				entity.Property(Function(e) e.SupplierId).HasColumnName("SupplierID")

				entity.Property(Function(e) e.UnitPrice).HasColumnType("money").HasDefaultValueSql("((0))")

				entity.Property(Function(e) e.UnitsInStock).HasDefaultValueSql("((0))")

				entity.Property(Function(e) e.UnitsOnOrder).HasDefaultValueSql("((0))")

				entity.HasOne(Function(d) d.Category).WithMany(Function(p) p.Products).HasForeignKey(Function(d) d.CategoryId).HasConstraintName("FK_Products_Categories")

				entity.HasOne(Function(d) d.Supplier).WithMany(Function(p) p.Products).HasForeignKey(Function(d) d.SupplierId).HasConstraintName("FK_Products_Suppliers")
			End Sub)

			modelBuilder.Entity(Of Region)(Sub(entity)
				entity.HasKey(Function(e) e.RegionId).IsClustered(False)

				entity.Property(Function(e) e.RegionId).HasColumnName("RegionID").ValueGeneratedNever()

				entity.Property(Function(e) e.RegionDescription).IsRequired().HasMaxLength(50).IsFixedLength()
			End Sub)

			modelBuilder.Entity(Of Shipper)(Sub(entity)
				entity.HasKey(Function(e) e.ShipperId)

				entity.Property(Function(e) e.ShipperId).HasColumnName("ShipperID")

				entity.Property(Function(e) e.CompanyName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.Phone).HasMaxLength(24)
			End Sub)

			modelBuilder.Entity(Of Supplier)(Sub(entity)
				entity.HasKey(Function(e) e.SupplierId)

				entity.HasIndex(Function(e) e.CompanyName).HasName("CompanyName")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.Property(Function(e) e.SupplierId).HasColumnName("SupplierID")

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.CompanyName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.ContactName).HasMaxLength(30)

				entity.Property(Function(e) e.ContactTitle).HasMaxLength(30)

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Fax).HasMaxLength(24)

				entity.Property(Function(e) e.HomePage).HasColumnType("ntext")

				entity.Property(Function(e) e.Phone).HasMaxLength(24)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)
			End Sub)

			modelBuilder.Entity(Of Territory)(Sub(entity)
				entity.HasKey(Function(e) e.TerritoryId).IsClustered(False)

				entity.Property(Function(e) e.TerritoryId).HasColumnName("TerritoryID").HasMaxLength(20)

				entity.Property(Function(e) e.RegionId).HasColumnName("RegionID")

				entity.Property(Function(e) e.TerritoryDescription).IsRequired().HasMaxLength(50).IsFixedLength()

				entity.HasOne(Function(d) d.Region).WithMany(Function(p) p.Territories).HasForeignKey(Function(d) d.RegionId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Territories_Region")
			End Sub)

			OnModelCreatingPartial(modelBuilder)
		End Sub

		Partial Private Sub OnModelCreatingPartial(ByVal modelBuilder As ModelBuilder)
		End Sub
	End Class
End Namespace
