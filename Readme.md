<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599105/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T225539)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-number-to-words&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-number-to-words&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
