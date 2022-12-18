<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655287/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T324548)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Data.cs) (VB: [Data.vb](./VB/Data.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to: Validate Data in PropertyGridControl


<p>The DXPropertyGrid supports several ways to check if the value entered by a user is correct.<br><br>First, this functionality can be implemented at the View level by handling the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_ValidateCelltopic">ValidateCell</a> event. This event is raised when a user has modified a cell value and is trying to save changes (either by pressing the Enter key or switching to another property grid cell).<br>Here is a code snippet demonstrating how to handle this event.</p>
<br>


```cs
void OnPropertyGridControlValidateCell(object sender, DevExpress.Xpf.PropertyGrid.ValidateCellEventArgs e) {
	if (e.NewValue == null || string.IsNullOrEmpty(e.NewValue.ToString()))
		e.ValidationException = new System.Exception("A cell cannot be empty");
}
```


<p> </p>
<p>Another way is to implement validation at the data source level using <a href="https://documentation.devexpress.com/#WPF/CustomDocument16863">Data Annotation Attributes</a> (assigning attributes using the <a href="https://community.devexpress.com/blogs/wpf/archive/2014/03/31/devexpress-mvvm-framework-using-dataannotation-attributes-and-devexpress-fluent-api.aspx">DevExpress FluentAPI</a> is also supported) or by implementing the <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.idataerrorinfo%28v=vs.110%29.aspx">IDataErrorInfo</a> interface.</p>

<br/>


