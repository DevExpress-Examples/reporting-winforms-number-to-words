# Reporting for WinForms - Number to Words Conversion in a Report


In this example, the calculated field's [GetValue](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.CalculatedField.GetValue) event is handled to convert numbers to words. Generally, you can handle the [BeforePrint](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.BeforePrint) or [PrintOnPage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.PrintOnPage) event handler) events.

A number is translated to a word by retrieving a word from a custom number-word dictionary.

If you're an owner of the [Universal](https://www.devexpress.com/subscriptions/universal.xml) or [Office File API subscription](https://www.devexpress.com/products/net/office-file-api/), you can use our built-in [NumberInWords](https://documentation.devexpress.com/#DocumentServer/clsDevExpressDocsTextNumberInWordstopic) class to convert numbers to words.
  
## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))

## Documentation

- [Use Calculated Fields](https://docs.devexpress.com/XtraReports/4801/detailed-guide-to-devexpress-reporting/shape-report-data/use-calculated-fields)
- [NumberInWords Class](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Docs.Text.NumberInWords)
- [Custom Functions](https://docs.devexpress.com/XtraReports/403888/detailed-guide-to-devexpress-reporting/use-expressions/custom-functions)

## More Examples

- [Aggregate Functions in Calculated Fields - Usage Example](https://github.com/DevExpress-Examples/reporting-aggregated-function-calculated-field)
- [Reporting for WinForms - Implement a Custom Function for Use in a Query Expression](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-custom-function-in-a-query-expression-t352441)