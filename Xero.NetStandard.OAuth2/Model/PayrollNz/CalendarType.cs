/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// Calendar type of the pay run
    /// </summary>
    /// <value>Calendar type of the pay run</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum CalendarType
    {
        /// <summary>
        /// Enum Weekly for value: Weekly
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly = 1,

        /// <summary>
        /// Enum Fortnightly for value: Fortnightly
        /// </summary>
        [EnumMember(Value = "Fortnightly")]
        Fortnightly = 2,

        /// <summary>
        /// Enum FourWeekly for value: FourWeekly
        /// </summary>
        [EnumMember(Value = "FourWeekly")]
        FourWeekly = 3,

        /// <summary>
        /// Enum Monthly for value: Monthly
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly = 4,

        /// <summary>
        /// Enum Annual for value: Annual
        /// </summary>
        [EnumMember(Value = "Annual")]
        Annual = 5,

        /// <summary>
        /// Enum Quarterly for value: Quarterly
        /// </summary>
        [EnumMember(Value = "Quarterly")]
        Quarterly = 6,

        /// <summary>
        /// Enum TwiceMonthly for value: TwiceMonthly
        /// </summary>
        [EnumMember(Value = "TwiceMonthly")]
        TwiceMonthly = 7

    }

}
