﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Forms.Core;
using EPiServer.Forms.Core.Models;
using EPiServer.ServiceLocation;
using System.Web;
using EPiServer.Forms.Implementation;

namespace EPiServer.Forms.Demo.Implementation
{
    /// <summary>
    /// Add more information to the redirection url when navigating to "Thank you page" after submitting Form.
    /// </summary>
    [ServiceConfiguration(typeof(IAppendExtraInfoToRedirection))]
    public class AppendInfoToRedirection : DefaultAppendExtraInfoToRedirection
    {
        public override IDictionary<string, object> GetExtraInfo(FormIdentity formIden, Submission submission)
        {
            var info = base.GetExtraInfo(formIden, submission);            
            info.Add("DemoParam", "demo value");
            info.Add("FormSubmissionId", submission.Id);
            return info;
        }
    }
}