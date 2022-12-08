<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/272688157/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T900034)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Blank .NET Core App with the Northwind Database


In this example, the blank sample project (.NET Core 3.1) is connected to the **Northwind** database. You can find this database at the following path: [/CS(VB)/WPFBlankDotNETCoreAppWithNorthwindDatabase/Data/Northwind.mdf](./CS/WPFBlankDotNETCoreAppWithNorthwindDatabase/Data/Northwind.mdf).

Database structure:

![](/images/DatabaseStructure.png)

You can use this example to create DevExpress projects and explore our features.

This project includes the [DevExpress ThemedWindow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindow) as a root element. Refer to the [Themes](https://docs.devexpress.com/WPF/7406/common-concepts/themes) topic for more information about custom-designed themes.

To create a project and connect it to a database:

1. Create a new project:

    ![](/images/WPF_DotNETCoreProject.png)

2. Select the DevExpress v20.1 WPF Blank App (.NET Core): 

    ![](/images/WPF_DotNETCoreTemplate.png)

3. Specify the Project name and click **Create**:

    ![](/images/WPF_DotNETCoreNamePath.png)

4. Add the `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.Tools` NuGet packages to the project:

    ![](/images/WPF_DotNETCoreNuGetPackages.png)

5. Open the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell) and run the following command. This command generates code for a DbContext and entity types for a database:
 
    Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\Northwind.mdf;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context NorthwindEntities -Tables "Categories","Customers","CustomerDemographics","Employees","Orders","Order Details","Products","Region","Shippers","Suppliers","Territories"

Refer to the [https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell#scaffold-dbcontext](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell#scaffold-dbcontext) topic for more information on how to use the **Scaffold-DbContext** command.

Refer to the [https://docs.microsoft.com/en-us/dotnet/core/](https://docs.microsoft.com/en-us/dotnet/core/) topic for more information on how to work with .NET Core.
