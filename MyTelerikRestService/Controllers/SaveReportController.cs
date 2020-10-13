using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Processing;
using Telerik.Reporting.Services;
using Telerik.Reporting.Services.WebApi;
using System.Web.Mvc;

namespace MyTelerikRestService.Controllers
{
    public class SaveReportController: Controller
    {

        [System.Web.Http.HttpPost]
        public void SaveReport()
        {
            try
            {
                SmartCampusDBEntities db = new SmartCampusDBEntities();
                var list = db.Admission_Applicant_LeadSource.ToList();
                Telerik.Reporting.Report report = new Telerik.Reporting.Report();
                report.DataSource = list;
                //report.DocumentName = "file.pdf";
                report.Visible = true;
                string fileName = HttpContext.Server.MapPath("~/");
                fileName = Path.Combine(fileName, "Uploads");
                fileName = Path.Combine(fileName, "file.pdf");
                //fileName = Path.Combine(fileName, "file.pdf");
                ReportProcessor reportProcessor = new ReportProcessor();
                Telerik.Reporting.InstanceReportSource instanceReportSource = new Telerik.Reporting.InstanceReportSource();
                instanceReportSource.ReportDocument = report;
                RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
                }
            }
            catch(Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}