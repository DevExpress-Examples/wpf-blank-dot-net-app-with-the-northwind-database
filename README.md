<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/272688157/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T900034)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Blank .NET 6 App with the Northwind Database

In this example, the blank sample project (.NET 6) is connected to the **Northwind** database. You can find this database at the following path: [/CS(VB)/WPFBlankDotNETAppWithNorthwindDatabase/Data/Northwind.mdf](./CS/WPFBlankDotNETAppWithNorthwindDatabase/Data/Northwind.mdf).

Database structure:

![image](https://user-images.githubusercontent.com/65009440/206457391-85e331c6-9dfd-4e6b-b3c3-c509d2778ac2.png)

You can use this example to create DevExpress projects and explore our features.

This project includes the [DevExpress ThemedWindow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindow) as a root element. Refer to the following topic for more information about custom-designed themes: [WPF Application Themes](https://docs.devexpress.com/WPF/7406/common-concepts/themes).

## Implementation Details

The steps below demonstrate how to create this sample application:

1. Create a new project:
   ![image](https://user-images.githubusercontent.com/65009440/206438431-356d95e0-443b-4730-93de-9f66f9d63757.png)
2. Select the DevExpress v22.2 WPF App Template Gallery:
   ![image](https://user-images.githubusercontent.com/65009440/209149534-d966bdfd-8eec-45b0-a7df-755b2a17ffa8.png)
3. Specify the Project name and click **Create**:
   ![image](https://user-images.githubusercontent.com/65009440/206441123-5eaed497-8823-46e0-ba91-a14d3d325aad.png)
4. Select the target framework, language, and **Blank MVVM Application** template and click **Create Project**:
   ![image](https://github.com/DevExpress-Examples/wpf-blank-dot-net-app-with-the-northwind-database/assets/65009440/6255e9c5-2891-41a6-9138-9417faebbd57)
5. Add the `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.Tools` NuGet packages to the project:
   ![image](https://user-images.githubusercontent.com/65009440/206443012-62684ab0-2cf8-4d0e-a03d-74442bdc0212.png)
6. Open the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell) and run the following command. This command generates code for a DbContext and entity types for a database. The `C:\Data\Northwind.mdf` string is the path to your local database:

   `Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\Northwind.mdf;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context NorthwindEntities -Tables "Categories","Customers","CustomerDemographics","Employees","Orders","Order Details","Products","Region","Shippers","Suppliers","Territories"`

## Documentation

* [Scaffold-DbContext](https://learn.microsoft.com/en-us/ef/core/cli/powershell#scaffold-dbcontext)
* [.NET documentation](https://learn.microsoft.com/en-us/dotnet/fundamentals/)
* [DevExpress WPF Controls](https://docs.devexpress.com/WPF/7875/wpf-controls)
* [Getting Started with the DevExpress Data Grid](https://docs.devexpress.com/WPF/5863/controls-and-libraries/data-grid/getting-started)

## More Examples

* [WPF Data Grid - Getting Started (.NET)](https://github.com/DevExpress-Examples/wpf-data-grid-getting-started-net-core)
