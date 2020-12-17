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
    /// Benefit
    /// </summary>
    [DataContract]
    public partial class Benefit :  IEquatable<Benefit>, IValidatableObject
    {
        /// <summary>
        /// Superannuations Category type
        /// </summary>
        /// <value>Superannuations Category type</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum KiwiSaver for value: KiwiSaver
            /// </summary>
            [EnumMember(Value = "KiwiSaver")]
            KiwiSaver = 1,

            /// <summary>
            /// Enum ComplyingFund for value: ComplyingFund
            /// </summary>
            [EnumMember(Value = "ComplyingFund")]
            ComplyingFund = 2,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 3

        }

        /// <summary>
        /// Superannuations Category type
        /// </summary>
        /// <value>Superannuations Category type</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Calculation Type of the superannuation either FixedAmount or PercentageOfTaxableEarnings
        /// </summary>
        /// <value>Calculation Type of the superannuation either FixedAmount or PercentageOfTaxableEarnings</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum CalculationTypeNZEnum
        {
            /// <summary>
            /// Enum FixedAmount for value: FixedAmount
            /// </summary>
            [EnumMember(Value = "FixedAmount")]
            FixedAmount = 1,

            /// <summary>
            /// Enum PercentageOfTaxableEarnings for value: PercentageOfTaxableEarnings
            /// </summary>
            [EnumMember(Value = "PercentageOfTaxableEarnings")]
            PercentageOfTaxableEarnings = 2

        }

        /// <summary>
        /// Calculation Type of the superannuation either FixedAmount or PercentageOfTaxableEarnings
        /// </summary>
        /// <value>Calculation Type of the superannuation either FixedAmount or PercentageOfTaxableEarnings</value>
        [DataMember(Name="calculationTypeNZ", EmitDefaultValue=false)]
        public CalculationTypeNZEnum CalculationTypeNZ { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Benefit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Benefit() 
        { 
        }
        
        /// <summary>
        /// The Xero identifier for superannuation
        /// </summary>
        /// <value>The Xero identifier for superannuation</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Name of the superannuations
        /// </summary>
        /// <value>Name of the superannuations</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Xero identifier for Liability Account
        /// </summary>
        /// <value>Xero identifier for Liability Account</value>
        [DataMember(Name="liabilityAccountId", EmitDefaultValue=false)]
        public Guid? LiabilityAccountId { get; set; }

        /// <summary>
        /// Xero identifier for Expense Account
        /// </summary>
        /// <value>Xero identifier for Expense Account</value>
        [DataMember(Name="expenseAccountId", EmitDefaultValue=false)]
        public Guid? ExpenseAccountId { get; set; }

        /// <summary>
        /// Standard amount of the superannuation
        /// </summary>
        /// <value>Standard amount of the superannuation</value>
        [DataMember(Name="standardAmount", EmitDefaultValue=false)]
        public decimal? StandardAmount { get; set; }

        /// <summary>
        /// Percentage of Taxable Earnings of the superannuation
        /// </summary>
        /// <value>Percentage of Taxable Earnings of the superannuation</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Company Maximum amount of the superannuation
        /// </summary>
        /// <value>Company Maximum amount of the superannuation</value>
        [DataMember(Name="companyMax", EmitDefaultValue=false)]
        public decimal? CompanyMax { get; set; }

        /// <summary>
        /// Identifier of a record is active or not.
        /// </summary>
        /// <value>Identifier of a record is active or not.</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Benefit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  LiabilityAccountId: ").Append(LiabilityAccountId).Append("\n");
            sb.Append("  ExpenseAccountId: ").Append(ExpenseAccountId).Append("\n");
            sb.Append("  CalculationTypeNZ: ").Append(CalculationTypeNZ).Append("\n");
            sb.Append("  StandardAmount: ").Append(StandardAmount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  CompanyMax: ").Append(CompanyMax).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
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
            return this.Equals(input as Benefit);
        }

        /// <summary>
        /// Returns true if Benefit instances are equal
        /// </summary>
        /// <param name="input">Instance of Benefit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Benefit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.LiabilityAccountId == input.LiabilityAccountId ||
                    (this.LiabilityAccountId != null &&
                    this.LiabilityAccountId.Equals(input.LiabilityAccountId))
                ) && 
                (
                    this.ExpenseAccountId == input.ExpenseAccountId ||
                    (this.ExpenseAccountId != null &&
                    this.ExpenseAccountId.Equals(input.ExpenseAccountId))
                ) && 
                (
                    this.CalculationTypeNZ == input.CalculationTypeNZ ||
                    this.CalculationTypeNZ.Equals(input.CalculationTypeNZ)
                ) && 
                (
                    this.StandardAmount == input.StandardAmount ||
                    this.StandardAmount.Equals(input.StandardAmount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.CompanyMax == input.CompanyMax ||
                    this.CompanyMax.Equals(input.CompanyMax)
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    this.CurrentRecord.Equals(input.CurrentRecord)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.LiabilityAccountId != null)
                    hashCode = hashCode * 59 + this.LiabilityAccountId.GetHashCode();
                if (this.ExpenseAccountId != null)
                    hashCode = hashCode * 59 + this.ExpenseAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationTypeNZ.GetHashCode();
                hashCode = hashCode * 59 + this.StandardAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyMax.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
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
