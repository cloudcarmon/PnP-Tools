﻿using SharePoint.Scanning.Framework;
using SharePointPnP.Modernization.Framework.Entities;
using System;
using System.Collections.Generic;

namespace SharePoint.Modernization.Scanner.Results
{
    public class PublishingPageScanResult: Scan
    {
        /// <summary>
        /// Web relative Url
        /// </summary>
        public string WebRelativeUrl { get; set; }

        /// <summary>
        /// page relative Url
        /// </summary>
        public string PageRelativeUrl { get; set; }

        /// <summary>
        /// Name of the scanned page
        /// </summary>
        public string PageName { get; set; }

        // Page modification information
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Page layout used for this page
        /// </summary>
        public string PageLayout { get; set; }
        /// <summary>
        /// Page layout file used for this page
        /// </summary>
        public string PageLayoutFile { get; set; }

        /// <summary>
        /// Page audiences: global
        /// </summary>
        public List<string> GlobalAudiences { get; set; }
        
        /// <summary>
        /// Page audiences: security and distribution groups
        /// </summary>
        public List<string> SecurityGroupAudiences { get; set; }

        /// <summary>
        /// Page audiences: sharepoint groups
        /// </summary>
        public List<string> SharePointGroupAudiences { get; set; }

        /// <summary>
        /// Content type associated with this page
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Id of the content type associated with this page
        /// </summary>
        public string ContentTypeId { get; set; }

        // Page web part information
        public List<WebPartEntity> WebParts { get; set; }

        public static string FormatList(List<string> list)
        {
            return FormatList(list, ",");
        }

        public static string FormatList(List<string> list, string delim)
        {
            string formattedList = "";
            if (list == null || list.Count == 0)
            {
                return "";
            }

            foreach (var item in list)
            {
                formattedList = formattedList + (!string.IsNullOrEmpty(formattedList) ? $"{delim}{item}" : $"{item}");
            }

            return formattedList;
        }
    }
}
