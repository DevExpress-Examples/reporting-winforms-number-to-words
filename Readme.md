<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
<!-- default file list end -->
# How to convert numeric price into word representation using the XtraReports Suite


In this example, we handle a calculated field's [GetValue](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CalculatedField.GetValue?v=20.2) event (in a generic case, you can do that in a report control's [BeforePrint](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.BeforePrint?v=20.2) or [PrintOnPage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.PrintOnPage) event handler) and convert numbers to words from code by associating a number with a word taken from a custom word array.

If you're an owner of the [Universal](https://www.devexpress.com/subscriptions/universal.xml) or [Office File API subscription](https://www.devexpress.com/products/net/office-file-api/), you can use our built-in [NumberInWords](https://documentation.devexpress.com/#DocumentServer/clsDevExpressDocsTextNumberInWordstopic) class to convert numbers to words.
  


