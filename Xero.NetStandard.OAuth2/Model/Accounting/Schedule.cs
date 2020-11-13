/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.4.4
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Schedule
    /// </summary>
    [DataContract]
    public partial class Schedule :  IEquatable<Schedule>, IValidatableObject
    {
        /// <summary>
        /// One of the following - WEEKLY or MONTHLY
        /// </summary>
        /// <value>One of the following - WEEKLY or MONTHLY</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 1,

            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 2

        }

        /// <summary>
        /// One of the following - WEEKLY or MONTHLY
        /// </summary>
        /// <value>One of the following - WEEKLY or MONTHLY</value>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// the payment terms
        /// </summary>
        /// <value>the payment terms</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DueDateTypeEnum
        {
            /// <summary>
            /// Enum DAYSAFTERBILLDATE for value: DAYSAFTERBILLDATE
            /// </summary>
            [EnumMember(Value = "DAYSAFTERBILLDATE")]
            DAYSAFTERBILLDATE = 1,

            /// <summary>
            /// Enum DAYSAFTERBILLMONTH for value: DAYSAFTERBILLMONTH
            /// </summary>
            [EnumMember(Value = "DAYSAFTERBILLMONTH")]
            DAYSAFTERBILLMONTH = 2,

            /// <summary>
            /// Enum DAYSAFTERINVOICEDATE for value: DAYSAFTERINVOICEDATE
            /// </summary>
            [EnumMember(Value = "DAYSAFTERINVOICEDATE")]
            DAYSAFTERINVOICEDATE = 3,

            /// <summary>
            /// Enum DAYSAFTERINVOICEMONTH for value: DAYSAFTERINVOICEMONTH
            /// </summary>
            [EnumMember(Value = "DAYSAFTERINVOICEMONTH")]
            DAYSAFTERINVOICEMONTH = 4,

            /// <summary>
            /// Enum OFCURRENTMONTH for value: OFCURRENTMONTH
            /// </summary>
            [EnumMember(Value = "OFCURRENTMONTH")]
            OFCURRENTMONTH = 5,

            /// <summary>
            /// Enum OFFOLLOWINGMONTH for value: OFFOLLOWINGMONTH
            /// </summary>
            [EnumMember(Value = "OFFOLLOWINGMONTH")]
            OFFOLLOWINGMONTH = 6

        }

        /// <summary>
        /// the payment terms
        /// </summary>
        /// <value>the payment terms</value>
        [DataMember(Name="DueDateType", EmitDefaultValue=false)]
        public DueDateTypeEnum DueDateType { get; set; }
        
        /// <summary>
        /// Integer used with the unit e.g. 1 (every 1 week), 2 (every 2 months)
        /// </summary>
        /// <value>Integer used with the unit e.g. 1 (every 1 week), 2 (every 2 months)</value>
        [DataMember(Name="Period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Integer used with due date type e.g 20 (of following month), 31 (of current month)
        /// </summary>
        /// <value>Integer used with due date type e.g 20 (of following month), 31 (of current month)</value>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public int? DueDate { get; set; }

        /// <summary>
        /// Date the first invoice of the current version of the repeating schedule was generated (changes when repeating invoice is edited)
        /// </summary>
        /// <value>Date the first invoice of the current version of the repeating schedule was generated (changes when repeating invoice is edited)</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The calendar date of the next invoice in the schedule to be generated
        /// </summary>
        /// <value>The calendar date of the next invoice in the schedule to be generated</value>
        [DataMember(Name="NextScheduledDate", EmitDefaultValue=false)]
        public DateTime? NextScheduledDate { get; set; }

        /// <summary>
        /// Invoice end date – only returned if the template has an end date set
        /// </summary>
        /// <value>Invoice end date – only returned if the template has an end date set</value>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DueDateType: ").Append(DueDateType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  NextScheduledDate: ").Append(NextScheduledDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="input">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    this.DueDate.Equals(input.DueDate)
                ) && 
                (
                    this.DueDateType == input.DueDateType ||
                    this.DueDateType.Equals(input.DueDateType)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.NextScheduledDate == input.NextScheduledDate ||
                    (this.NextScheduledDate != null &&
                    this.NextScheduledDate.Equals(input.NextScheduledDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                hashCode = hashCode * 59 + this.DueDateType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.NextScheduledDate != null)
                    hashCode = hashCode * 59 + this.NextScheduledDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
